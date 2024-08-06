using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PatikaWeek4FirstClassPractice
{
    // Creating the class and setting properties
    public class Person
    {       
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Statue { get; set; }

        public int BirthYear { get; set; }

     
        // Method to print informations
        public void Introduce()
        {
            Console.WriteLine($"Merhaba benim adım {Name} soyadım {Surname} doğum tarihim {BirthYear} yılı ve bu kurumda statüm {Statue}dir.");
        }
        
    }
}
