using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    public abstract class Animal
    {
        // Ceci est le champ Name (Nom).
        // par exemple Chat Tom, Souri Jerry.
        public string Name;

        // Le constructeur par défaut.
        public Animal()
        {
            Console.WriteLine("- Animal()");
        }
        public Animal(string Name)
        {
            // Affectuez la valeur au champ Name.
            this.Name = Name;
            Console.WriteLine("- Animal(string)");
        }
        // Move(): Animaux se  déplacent.
        // virtual: Permet la sous- classe de remplacer (override) cette méthode.
        public virtual void Move()
        {
            Console.WriteLine("Animal Move");
        }
        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }
    }
}