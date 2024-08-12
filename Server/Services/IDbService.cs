using GrpcGreeter.DTOs;

namespace GrpcGreeter.Services;

public interface IDbService
{
    List<Cash> GetList();
}
