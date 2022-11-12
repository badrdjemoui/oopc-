using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Cat object from Cat(string,int,int)");
            // Créez un objet Cat via un constructeur avec 3 paramètres.
            // Le champ Name de la classe Animal sera affecté la valeur "Tom".
            // Le champ Age của Cat sera affecté la valeur 3
            // Le champ Height của Cat sera affecté la valeur 20.
            Cat tom1 = new Cat("Tom", 3, 20);
            Console.WriteLine("------");
            Console.WriteLine("Name = {0}", tom1.Name);
            Console.WriteLine("Age = {0}", tom1.Age);
            Console.WriteLine("Height = {0}", tom1.Height);

            Console.WriteLine("------");

            // Appelez la méthode héritée de la classe Animal.
            tom1.Sleep();

            // Appelez la méthode Say() (de la classe Cat)
            tom1.Say();

            Console.ReadLine();


            // Créez un objet Animal.
            // Animal est une classe abstraite,
            // Donc vous ne pouvez pas créer l'objet via le Constructeur de Animal.
            Animal tom = new Cat("Tom", 3, 20); 
            Console.WriteLine("Animal Sleep:");

            // Appelez la méthode Sleep() de Animal
            tom.Sleep();

            // Utilisez l'opérateur 'is' pour vérifier si
            // un objet est le type d'un objet.
            bool isMouse = tom is Mouse;// false 
            Console.WriteLine("Tom is mouse? " + isMouse);

            bool isCat = tom is Cat; // true
            Console.WriteLine("Tom is cat? " + isCat);

            bool isAnimal = tom is Animal; // true
            Console.WriteLine("Tom is animal? " + isAnimal); 
            Console.ReadLine();

            


            // Vous déclarez un objet Animal.
            // Mais créez- le en utilisant le Constructeur de la classe Duck.
            Animal donald = new Duck("Donald");

            // Appelez la méthode Sleep() (Définie dans la classe Animal).
            donald.Sleep();

            // - Move() est la méthode définie dans la classe Animal.
            // - Move() est "réécrit" avec le mot-clé 'new' dans la classe Duck.
            //   ('new' Move() n'est qu'utilisée aux objets déclarés étant comme Duck ou sous-classe de Duck).
            // 'donald' est déclaré comme 'Animal', non 'Duck'.
            donald.Move(); // ==> Animal Move.  
            tom.Move();
            Mouse m = new Mouse();
            m.Move();
            Person p = new Person("badr",1982);
           p.Move();
            Console.ReadLine();
        }
    }
}