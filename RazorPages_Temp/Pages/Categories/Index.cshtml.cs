using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_Temp.Data;

namespace RazorPages_Temp.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly AplicationDbcontext _dbcontext;
        public IndexModel( AplicationDbcontext dbcontext)
        {
            this._dbcontext = dbcontext;
        }

       public List<Model.Category> categories { get; set; }
        public void OnGet()
        {
            categories=_dbcontext.Categories.ToList();
        }
    }
}
