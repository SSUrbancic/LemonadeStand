using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //MEMBERS (HAS A)
        public double playerMoney = 20;
        public int iceCubeCount;
        public int sugarCount;
        public int cupCount;
        public int lemonCount;
        public Recipe lemonadeRecipe = new Recipe();

        //Constructor
        public Player()
        {
             iceCubeCount = 0;
            sugarCount = 0;
             cupCount = 0;
             lemonCount = 0;
        }
        //METHODS(CAN DO)








    }
}
