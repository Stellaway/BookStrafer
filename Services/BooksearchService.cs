using BookStrafer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookStrafer.Services
{
    public class BooksearchService
    {
        private readonly Uri serverUrl = new Uri("https://bmecookbook.azurewebsites.net");

        public async Task<SearchResult> GetSearchResultsAsync(string searchTerm)
        {
            string[] words = searchTerm.Split(' ');
            searchTerm = string.Join("+", words);

            return await GetAsync<SearchResult>(new Uri(serverUrl, "search.json?q=" + searchTerm));
        }
        private async Task<T> GetAsync<T>(Uri uri)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                var json = await response.Content.ReadAsStringAsync();
                T result = JsonConvert.DeserializeObject<T>(json);
                return result;
            }
        }
    }
}
