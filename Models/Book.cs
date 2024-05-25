using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Models
{


    public class Book
    {
        public string description { get; set; }
        public string title { get; set; }
        public int[] covers { get; set; }
        public First_Sentence first_sentence { get; set; }
        public string[] subject_places { get; set; }
        public string first_publish_date { get; set; }
        public string key { get; set; }
        public BookAuthor[] authors { get; set; }
        public Excerpt[] excerpts { get; set; }
        public string[] subjects { get; set; }
        public Type type { get; set; }
        public string[] subject_times { get; set; }
        public int latest_revision { get; set; }
        public int revision { get; set; }
        public Created created { get; set; }
        public Last_Modified last_modified { get; set; }
    }

    public class First_Sentence
    {
        public string type { get; set; }
        public string value { get; set; }
    }

    public class Type
    {
        public string key { get; set; }
    }

    public class Created
    {
        public string type { get; set; }
        public DateTime value { get; set; }
    }

    public class Last_Modified
    {
        public string type { get; set; }
        public DateTime value { get; set; }
    }

    public class BookAuthor
    {
        public Author1 author { get; set; }
        public Type1 type { get; set; }
    }

    public class Author1
    {
        public string key { get; set; }
    }

    public class Type1
    {
        public string key { get; set; }
    }

    public class Excerpt
    {
        public string excerpt { get; set; }
    }


}
