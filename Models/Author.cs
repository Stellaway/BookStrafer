using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Models
{


    public class Author
    {
        public string personal_name { get; set; }
        public string[] source_records { get; set; }
        public string[] alternate_names { get; set; }
        public Bio bio { get; set; }
        public AuthorType type { get; set; }
        public string death_date { get; set; }
        public Remote_Ids remote_ids { get; set; }
        public string name { get; set; }
        public Link[] links { get; set; }
        public int[] photos { get; set; }
        public string birth_date { get; set; }
        public string key { get; set; }
        public int latest_revision { get; set; }
        public int revision { get; set; }
        public AuthorCreated created { get; set; }
        public Author_Last_Modified last_modified { get; set; }
    }

    public class Bio
    {
        public string type { get; set; }
        public string value { get; set; }
    }

    public class AuthorType
    {
        public string key { get; set; }
    }

    public class Remote_Ids
    {
        public string viaf { get; set; }
        public string wikidata { get; set; }
        public string isni { get; set; }
    }

    public class AuthorCreated
    {
        public string type { get; set; }
        public DateTime value { get; set; }
    }

    public class Author_Last_Modified
    {
        public string type { get; set; }
        public DateTime value { get; set; }
    }

    public class Link
    {
        public string url { get; set; }
        public Type2 type { get; set; }
        public string title { get; set; }
    }

    public class Type2
    {
        public string key { get; set; }
    }


}
