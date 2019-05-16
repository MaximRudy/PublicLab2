using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Core
    {
        public List<String> LibraryObejects { get; private set; }
        public List<LibraryObjectAnnotation> LibraryObjectAnnotations{get; private set;}
        public Core()
        {
            LibraryObjectAnnotations = new List<LibraryObjectAnnotation>();
            LibraryObejects = new List<String>
            {
                nameof(Worker),
                nameof(Visitor),
                nameof(Library),
                nameof(Book),
                nameof(Magazine)
            };
        }
    }
}
