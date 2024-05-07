using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyWebApplication.Models;


namespace MyWebApplication.Pages.Pets
{
    public class IndexModel : PageModel
    {
        private FakePetRepository repo;

        public List<Pet> Pets { get; private set; }
        public IndexModel()
        {
            repo = FakePetRepository.Instance;
        }
        public void OnGet()
        {
            Pets = (List<Pet>)repo.GetAllPets();
        }
    }
}