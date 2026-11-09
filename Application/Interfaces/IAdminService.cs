namespace Application.Interfaces;

public interface IAdminService
{
    Task<bool> IsDbConnectedAsync(CancellationToken ct);
}
