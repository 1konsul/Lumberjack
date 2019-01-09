using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumberjack
{
    enum Flapjacks
    {
        Crispy,
        Soggy,
        Browned,
        Banana
    }

    class Lumberjack
    {
        public string  Name { get; private set; }
        public Stack<Flapjacks> meal;

        public Lumberjack(string name)
        {
            Name = name;
        }

        public void CreateMeal(Flapjacks flapjack)
        {
            meal.Push(flapjack);
        }

        public string EatFlapjacks()
        {
            string eaten = "";
            foreach (Flapjacks flapjack in meal)
            {
                eaten += Name + " ate a " + flapjack.ToString() + " flapjack."+"\n";
                meal.Pop();
            }
            return eaten;
        }
    }
}
