namespace MyWebApplication.Models
{
    public class FakePetRepository
    {
        private List<Pet> pets { get; }
        private static FakePetRepository _instance;

        public FakePetRepository() 
        {
            pets = new List<Pet>();

            pets.Add(new Pet()
            {
                Id = 1,
                Name = "Cheddar",
                Age = 3.5,
                Species = "Dog",
                ImageName = "cheddar.jpg"

            });

            pets.Add(new Pet()
            {
                Id = 2,
                Name = "Soya",
                Age = 11,
                Species = "Dog",
                ImageName = "soya.jpg"
            });

            pets.Add(new Pet()
            {
                Id = 3,
                Name = "Sløjfe",
                Age = 16,
                Species = "Cat",
                ImageName = "sløjfe.jpg"
            });

            pets.Add(new Pet()
            {
                Id = 4,
                Name = "Malaya",
                Age = 3,
                Species = "Dog",
                ImageName = "malaya.jpg"
            });

            pets.Add(new Pet()
            {
                Id = 5,
                Name = "Yrsa",
                Age = 1,
                Species = "Cow",
                ImageName = "yrsa.jpg"
            });

        }

        public static FakePetRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FakePetRepository();
                }
                return _instance;
            }
        }

        public IEnumerable<Pet> GetAllPets()
        {
            return pets.ToList();
        }

        public void AddPet(Pet pet)
        {
            List<int> petId = new List<int>();

            foreach (Pet p in pets)
            {
                petId.Add(p.Id);
            }
            if (petId.Count != 0)
            {
                int start = petId.Max();
                pet.Id = start + 1;
            }
            else
            {
                pet.Id = 1;
            }
            pets.Add(pet);
        }

        
    }

    
}
