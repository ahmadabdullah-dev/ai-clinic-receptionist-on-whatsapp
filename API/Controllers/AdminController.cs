using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class AdminController : BaseApiController
{
    private readonly IAdminService _adminService;

    public AdminController(IAdminService adminService)
    {
        _adminService = adminService;
    }  
    [HttpGet("is-db-connected")]
    public async Task<ActionResult<bool>> IsDbConnected(CancellationToken ct = default)
    {
        var result = await _adminService.IsDbConnectedAsync(ct);
        return result;
    }

}
