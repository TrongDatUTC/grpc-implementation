
using Grpc.Core;
using Grpc.Net.Client;
using GrpcCashClient;
using GrpcGreeterClient.DTOs;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;

var httpHandler = new HttpClientHandler();
httpHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://10.26.2.221:7064", new GrpcChannelOptions { HttpHandler = httpHandler });
// Gọi CashService
var cashClient = new CashService.CashServiceClient(channel);
var cashRequest = new CashRequest { PageNumber = 1, PageSize = 10 };
var swRpc = new Stopwatch();
swRpc.Start();
using (var cashCall = cashClient.GetCashData(cashRequest))
{
    var listCashRpc = new List<CashData>();
    await foreach (var data in cashCall.ResponseStream.ReadAllAsync())
    {
        listCashRpc.Add(data);
    }
    swRpc.Stop();
    TimeSpan timeTaken = swRpc.Elapsed;


};

var swApi = new Stopwatch();
using (var httpClient = new HttpClient(httpHandler))
{
    swApi.Start();
    var req = new HttpRequestMessage(HttpMethod.Get, "https://10.26.2.221:7064/api/v1/Cash") { Version = new Version(2, 0) };
    var response = await httpClient.SendAsync(req).ConfigureAwait(false);
    var responseString = response.Content.ReadAsStringAsync().Result;
    var listCash = JsonSerializer.Deserialize<List<Cash>>(responseString);
    var listCashApi = new List<Cash>();
    foreach (var cash in listCash)
    {
        listCashApi.Add(cash);
    }
    swApi.Stop();
}

Console.WriteLine($"Api time taken: {swApi.Elapsed.ToString(@"m\:ss\.fff")} " +
    $"Rpc time taken: {swRpc.Elapsed.ToString(@"m\:ss\.fff")}");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();