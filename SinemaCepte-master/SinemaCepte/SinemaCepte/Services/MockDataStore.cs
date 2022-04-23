using SinemaCepte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinemaCepte.Services
{
    public class MockDataStore : IDataStore<Bilet>
    {
        readonly List<Bilet> items;

        public MockDataStore()
        {
            items = new List<Bilet>()
            {
                new Bilet { MovieTitle = "Bad Boys For LIfe", Image = "BadBoys.jpg", ShowingDate = DateTime.Now.AddDays(15), Seats = new int[] { 61, 62, 63 } },
                new Bilet { MovieTitle = "The Old Guard", Image = "OldGuard.jpg", ShowingDate = DateTime.Now.AddDays(22), Seats = new int[] { 111, 112 } },
                new Bilet { MovieTitle = "Tenet", Image = "Tenet.jpg", ShowingDate = DateTime.Now.AddDays(25), Seats = new int[] { 12, 25, 35 } },
                new Bilet { MovieTitle = "No Time To Die", Image = "TimeToDie.jpg", ShowingDate = DateTime.Now.AddDays(20), Seats = new int[] { 99 } }
            };
        }

        public async Task<bool> AddItemAsync(Bilet item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Bilet item)
        {
            var oldItem = items.Where((Bilet arg) => arg.MovieTitle == item.MovieTitle).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Bilet arg) => arg.MovieTitle == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Bilet> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.MovieTitle == id));
        }

        public async Task<IEnumerable<Bilet>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}