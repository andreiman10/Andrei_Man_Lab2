using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Andrei_Man_Lab2.Models;

namespace Andrei_Man_Lab2.Pages.AuthorsPages;

public class IndexModel : PageModel
{
    private readonly Andrei_Man_Lab2Context _context;

    public IndexModel(Andrei_Man_Lab2Context context)
    {
        _context = context;
    }

    public IList<Authors> Authors { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Authors = await _context.Authors.ToListAsync();
    }
}
