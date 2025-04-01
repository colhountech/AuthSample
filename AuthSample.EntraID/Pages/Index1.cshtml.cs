using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AuthSample.EntraID.Pages;

[Authorize (Policy = Roles.HQUsers)]
public class IndexModel1 : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel1(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // For debugging: check user claims
        var claims = User.Claims.Select(c => new { c.Type, c.Value }).ToList();
        // You can set a breakpoint here to inspect claims
    }
}
