using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStrafer.Models
{
   
        public class SearchResult
        {
            public int start { get; set; }
            public int num_found { get; set; }
            public List<Book> books { get; set; }
        }

        public class Book
        {
            public int cover_i { get; set; }
            public bool has_fulltext { get; set; }
            public int edition_count { get; set; }
            public string title { get; set; }
            public string[] author_name { get; set; }
            public int first_publish_year { get; set; }
            public string key { get; set; }
            public string[] ia { get; set; }
            public string[] author_key { get; set; }
            public bool public_scan_b { get; set; }
        }
    
}
