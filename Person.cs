using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class Person :Animal
    {
        // Le champ name - nom de la personne
        public String Name;

        // Le champ bornYear - l'année de naissance
        public int BornYear;

        // Lieu de naissance
        public String PlaceOfBirth;

        // Ce constructeur a 3 paramètres.
        // L'objectif à initialiser la valeur du champs de Person.
        // Précisez le nom, l'année de naissance et le lieu de naissance.
        public Person(String Name, int BornYear, String PlaceOfBirth)
        {
            this.Name = Name;
            this.BornYear = BornYear;
            this.PlaceOfBirth = PlaceOfBirth;
        }
        // Ce constructeur a 2 paramètres.
        // Le but  d'initialiser 2 champs (nom et année de naissance) de Person.
        // Le lieu de naissance n'est pas initialisé.
        public Person(String Name, int BornYear)
        {
            this.Name = Name;
            this.BornYear = BornYear;
        }

        public new void Move()
        {
            Console.WriteLine("person Move..");
        }
    }
}