using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet;

public abstract class Drank : IBedrag

{
    private Dranks naam;
    private decimal prijs;
    public Drank(Dranks naam, decimal prijs) {
        this.Naam = naam;
        this.Prijs = prijs;

    }

    public Dranks Naam { get => naam; set => naam = value; }
    public decimal Prijs { get => prijs; set => prijs = value; }

    public abstract decimal BerekenBedrag();

    public abstract override string ToString();

    
}

