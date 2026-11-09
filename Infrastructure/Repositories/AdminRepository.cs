namespace Infrastructure.Repositories;

public class AdminRepository : IAdminRepository
{
    private readonly ApplicationDbContext _dbContext;
    public AdminRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> IsDbConnectedAsync(CancellationToken ct = default)
    {
        return await _dbContext.Database.CanConnectAsync(ct);
    }
}
