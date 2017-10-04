using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryRoom.Classes
{
    public class Colors : LaundryItem
    {
        public Colors(string itemName, string itemColor, string itemMaterial) : base(itemName, itemColor, itemMaterial)
        {

        }

        public override string ClothingDone()
        {
            return "Your colors have been washed";
        }
    }
}
