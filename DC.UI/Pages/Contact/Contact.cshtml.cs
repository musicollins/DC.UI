using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DC.UI.Data;
using DC.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DC.UI.Pages.Contact
{
    public class ContactModel : PageModel
    {
        public ContactModel()
        {
            Data = new DataNames();
        }

        private readonly DataNames Data;
        public List<User> Customer{ get; set; }
        [BindProperty]
        public string Name{ get; set; }
        public void OnGet()
        {
            Customer = Data.GetAll().ToList();
        }

        public IActionResult OnPostEdit()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("/Contact/Edit", "Contact", new { name = Name });
            }
            return Page();
        }
    }
}
