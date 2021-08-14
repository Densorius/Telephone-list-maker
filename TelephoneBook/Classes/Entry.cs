using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneBookApp.Classes
{
    public class Entry
    {
        public string Name { get; set; }
        public string TelephoneNumber { get; set; }
        public string Adress { get; set; }

        public Entry(string name, string telephoneNumber, string adress)
        {
            Name            = name;
            TelephoneNumber = telephoneNumber;
            Adress          = adress;
        }
    }
}
