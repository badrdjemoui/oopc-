using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    public class Cat : Animal
    {
        public int Age;
        public int Height;
        // Ceci est un Constructeur ayant 3 paramètres de la classe Cat.
        // Utilisant :base(name) pour appeler le Constructeur de la classe mère : Animal(string).
        // Les champs de la super- classe seront affectés des valeurs.
        // Puis ces champs de cette classes seront affectés des valeurs.
        public Cat(string name, int Age, int Height): base(name)
        {
            this.Age = Age;
            this.Height = Height;
            Console.WriteLine("- Cat(string,int,int)");
        }
        // Ce constructeur appelle le constructeur par défaut (qui n'a pas de paramètre) de super-classe.
        public Cat(int Age, int Height)
            : base()
        {
            this.Age = Age;
            this.Height = Height;
            Console.WriteLine("- Cat(int,int)");
        }
        public void Say()
        {
            Console.WriteLine("Meo");
        }
        // Remplacez la méthode Move() de super-classe (Animal).
        // Re-écrivez cette méthode,
        // pour décrire avec précision le comportement du chat.
        public override void Move()
        {
            Console.WriteLine("Cat Move ...");
        }
    }
}