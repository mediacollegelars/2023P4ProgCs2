using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        int health = 100;
        int energy = 100;
        string naam = "Strijder";



    }

    internal void TakeDamage(int damage)
    {
          health -= damage
    }

    internal void DepleteEnergy(int Energy)
    {
          Energycost -= Energy    
    }
}


