using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetPlayground.Pages;

public class IndexModel : PageModel
{
    public DateTime ServerTime { get; private set; }
    public void OnGet() => ServerTime = DateTime.UtcNow;
}
