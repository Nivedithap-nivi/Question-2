using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    public class BabyDressUtility 
    {
        public void AddDressToCart(BabyDress dress)
        {
            Program.DressesCart.Add(dress);
        }
        public bool RemoveDressFromCart(string Brand)
        {
            foreach (var dress in Program.DressesCart)
            {
                if (dress.Brand == Brand)
                {
                    Program.DressesCart.Remove(dress);
                    return true;
                }
                
            
            }
            return false;

        }

    }
}
