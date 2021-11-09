using DC.UI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DC.UI.Pages.Contact
{
    public class EditModel : PageModel
    {
        private readonly DataNames Data;

        public EditModel()
        {
            Data = new DataNames();
        }
        [BindProperty]
        public string Name { get; set; }
        public void OnGet(string name)
        {
            Name = name;
        }

        public IActionResult OnPostSave()
        {
            if (ModelState.IsValid)
            {
                Data.UpdateName(Name);
                return RedirectToPage("/Contact/Contact");
            }
            return Page();
        }
    }
}
