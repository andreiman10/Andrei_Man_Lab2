using Andrei_Man_Lab2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Andrei_Man_Lab2.Pages.BookPages;

public class IndexModel : PageModel
{
    private readonly Andrei_Man_Lab2Context _context;

    public IndexModel(Andrei_Man_Lab2Context context)
    {
        _context = context;
    }

    public IList<Book> Book { get; set; } = default!;

    [BindProperty(SupportsGet = true)]
    public int? SelectedAuthorID { get; set; }

    public SelectList? AuthorsList { get; set; }

    public async Task OnGetAsync()
    {
        AuthorsList = new SelectList(_context.Authors, "ID", "FullName");

        var books = _context.Book
            .Include(b => b.Publisher)
            .Include(b => b.Author)
            .AsQueryable();

        if (SelectedAuthorID.HasValue)
        {
            books = books.Where(b => b.AuthorID == SelectedAuthorID);
        }

        Book = await books.ToListAsync();
    }
}
