using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

       
        public Category Category { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost() {

            await _context.AddAsync(Category);

            await _context.SaveChangesAsync();


            return RedirectToPage("Index");



        }
    }
}
