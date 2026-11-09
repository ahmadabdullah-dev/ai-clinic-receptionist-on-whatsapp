namespace Infrastructure.Interfaces;

public interface IAdminRepository
{
    Task<bool> IsDbConnectedAsync(CancellationToken ct = default);
}
