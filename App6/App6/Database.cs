using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App6
{
    public class Database
    {
        private List<Cat> cats = new List<Cat>();
        private int autoincrement = 3;

        public Database()
        {
            Cat cat = new Cat
            {
                Id = 1,
                Name = "Рыжик",
                Breed = "Рыжий",
                //ShelterId = 1
            };
            Cat cat2 = new Cat
            {
                Id = 2,
                Name = "Барсик",
                Breed = "Сиамский",
                //ShelterId = 2
            };
            Cat cat3 = new Cat
            {
                Id = 3,
                Name = "Черныш",
                Breed = "Бродяжка",
                //ShelterId = 1
            };
            cats.Add(cat);
            cats.Add(cat2);
            cats.Add(cat3);

        }
        public Task<List<Cat>> GetCats()
        {
            return Task.FromResult(cats);
        }
        public Task<Cat> GetCat(int id)
        {
            return Task.FromResult(cats.Find(cat => cat.Id == id));
        }
        public Task AddCat(Cat cat)
        {
            cat.Id = ++autoincrement;
            cats.Add(cat);
            return Task.CompletedTask;
        }
        public async Task EditCat(Cat cat)
        {
            Cat oldCat = await GetCat(cat.Id);
            oldCat = cat;
        }
        public Task DeleteCat(Cat cat)
        {
            
            cats.Remove(cat);
            return Task.CompletedTask;
        }
        public Task<List<Cat>> GetCatsByShelter(int id)
        {
            List<Cat> catShelter = new List<Cat>();
            foreach (var cat in cats)
                if (cat.ShelterId == id)
                catShelter.Add(cat);
            return Task.FromResult(catShelter);
        } 
    }
}
