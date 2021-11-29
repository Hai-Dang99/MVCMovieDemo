using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVCMovie.Models
{
    public class PersonGenreViewModel
    {
        public List<Person> Persons { get; set; }
        public SelectList Genres { get; set; }
        public string PersonGenre { get; set; }
        public string SearchString { get; set; }
    }
}