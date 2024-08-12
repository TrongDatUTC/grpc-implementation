using GrpcGreeter.DTOs;
using GrpcGreeter.Services;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace GrpcGreeter.Controller;

[Route("api/v1/[controller]")]
public class CashController: ControllerBase
{
    private readonly IDbService _dbService;

    public CashController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet]
    public List<Cash> GetCash()
    {
        var listCash = _dbService.GetList();
        return (listCash);
    }
}
