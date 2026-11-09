namespace Application.Services;

public class AdminService : IAdminService
{
    private readonly IAdminRepository _adminRepository;

    public AdminService(IAdminRepository adminRepository)
    {
        _adminRepository = adminRepository;
    }
    public async Task<bool> IsDbConnectedAsync(CancellationToken ct = default)
    {
        return await _adminRepository.IsDbConnectedAsync(ct);
    }
}
