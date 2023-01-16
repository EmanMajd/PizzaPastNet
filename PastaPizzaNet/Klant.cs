using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class Klant
    {
        public int id;
        public string name;

        public Klant() :this(0 , "Onbekende Klant"){ }
        public Klant(int id , string naam) {
            this.Id = id;
            this.Name = naam;
        }  

        public int Id { get => id; set => id = value; }
        public string Name
        {
            get => name;
            set => name = value;
              
            
        }
        public override string ToString()
        {
            if(this.Name == "")
                return $"Klant : Onbekende Klant  \n";
            return $"Klant : {this.Name}  \n";
        }
    }
}
