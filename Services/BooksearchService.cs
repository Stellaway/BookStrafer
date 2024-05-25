using Cookbook.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Services
{
    public class BooksearchService
    {
        private readonly Uri serverUrl = new Uri("https://openlibrary.org/");

        /// <summary>
        /// gets the search results from the server
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns></returns>
        public async Task<SearchResult> GetSearchResultsAsync(string searchTerm)
        {
            string[] words = searchTerm.Split(' ');
            searchTerm = string.Join("+", words);
            return await GetAsync<SearchResult>(new Uri(serverUrl, "search.json?q=" + searchTerm));
        }

        /// <summary>
        /// gets the book from the server
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<Book> GetBookAsync(string key)
        {
            var uri = new Uri(serverUrl + key + ".json");
            return await GetAsync<Book>(uri);
        }

        /// <summary>
        /// gets the author details from the server
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<Author> GetAuthorAsync(string key)
        {
            var uri = new Uri(serverUrl, key + ".json");
            return await GetAsync<Author>(uri);
        }
        private async Task<T> GetAsync<T>(Uri uri)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                var json = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return default;
                }
                T result = JsonConvert.DeserializeObject<T>(json);
                
                return result;
            }
        }
    }
}
