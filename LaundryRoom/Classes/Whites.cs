using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryRoom.Classes
{
    public class Whites : LaundryItem
    {
        public Whites(string clothingColor, string clothingMaterial) : base(clothingColor, clothingMaterial)
        {

        }
        public override string ClothingDone()
        {
            return "Your whites have been washed!";
        }
    }
}
