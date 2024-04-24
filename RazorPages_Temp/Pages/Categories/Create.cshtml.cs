using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_Temp.Data;

namespace RazorPages_Temp.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly AplicationDbcontext _dbContext;
        [BindProperty]
        public Model.Category category { get; set; }
        public CreateModel(AplicationDbcontext dbcontext )
        {
            _dbContext = dbcontext;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
