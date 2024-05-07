using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebApplication.Models;

namespace MyWebApplication.Pages.Pets
{
    public class AddPetsModel : PageModel
    {
        private FakePetRepository repo;

        [BindProperty]
        public Pet Pet { get; set; }

        public AddPetsModel() 
        {
            repo = FakePetRepository.Instance;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost() 
        {
            repo.AddPet(Pet);
            return RedirectToPage("Index");
        }
    }
}
