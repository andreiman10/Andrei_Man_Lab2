using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Andrei_Man_Lab2.Models;

namespace Andrei_Man_Lab2.Pages.AuthorsPages;

public class DetailsModel : PageModel
{
    private readonly Andrei_Man_Lab2Context _context;
    public DetailsModel(Andrei_Man_Lab2Context context)
    {
        _context = context;
    }

    public Authors Authors { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var authors = await _context.Authors.FirstOrDefaultAsync(m => m.ID == id);
        if (authors is null)
        {
            return NotFound();
        }
        else
        {
            Authors = authors;
        }

        return Page();
    }
}
