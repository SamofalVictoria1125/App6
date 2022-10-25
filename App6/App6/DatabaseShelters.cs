using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    public class DatabaseShelters
    {
        private List<Shelters> shelters = new List<Shelters>();
        private int autoincrement = 3;
        public DatabaseShelters()
        {
            Shelters shelter = new Shelters
            {
                Id = 1,
                Adress = "Ул. Пожарная"
            };
            Shelters shelter2 = new Shelters
            {
                Id = 2,
                Adress = "Ул. Прохладная"
            };
            Shelters shelter3 = new Shelters
            {
                Id = 3,
                Adress = "Ул. Пумкина"
            };
            shelters.Add(shelter);
            shelters.Add(shelter2);
            shelters.Add(shelter3);
        }
        public Task<List<Shelters>> GetShelters()
        {
            return Task.FromResult(shelters);
        }
        public Task<Shelters> GetShelters(int id)
        {
            return Task.FromResult(shelters.Find(shelter => shelter.Id == id));
        }
        public Task AddShelters(Shelters shelter)
        {
            shelter.Id = ++autoincrement;
            shelters.Add(shelter);
            return Task.CompletedTask;
        }
        public async Task EditShelters(Shelters shelter)
        {
            Shelters oldShelter = await GetShelters(shelter.Id);
            oldShelter = shelter;
        }
        public Task DeleteShelters(Shelters shelter)
        {

            shelters.Remove(shelter);
            return Task.CompletedTask;
        }

    }
}
