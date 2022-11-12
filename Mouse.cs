using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    public class Mouse : Animal
    {
        private int Weight;

        // Constructeur par défaut (Sans paramètre).
        // Appelle au Mouse(int)
        public Mouse()
            : this(100)
        {
        }
        // Ce constructeur a 1 paramètre.
        // Non précisé :base
        // Ce constructeur est basé (base) sur le constructeur par défaut de la classe mère.
        public Mouse(int Weight)
        {
            this.Weight = Weight;
        }
        // Ce constructeur a 2 paramètres.
        public Mouse(String name, int Weight)
            : base(name)
        {
            this.Weight = Weight;
        }
        public int GetWeight()
        {
            return Weight;
        }
        public void SetWeight(int Weight)
        {
            this.Weight = Weight;
        }
    }
}