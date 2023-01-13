using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class Klant
    {
        private int id;
        private string name;

        public Klant( int id , string naam) {
            this.Id = id;
            this.Name = naam;
        
        }  

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return $"Klant : {this.Name}  \n";
        }
    }
}
