using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    class Library
    {
        string Name { get; set; }
        List<Worker> Workers { get; set; }
        List<Visitor> Visitors { get; set; }
        Assortment Assortment { get; set; }
    }
}
