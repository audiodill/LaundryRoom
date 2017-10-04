using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryRoom.Classes
{
    public class Darks : LaundryItem
    {
        public Darks(string itemName, string itemColor, string itemMaterial) : base(itemName, itemColor, itemMaterial)
        {

        }
        public override string ClothingDone()
        {
            throw new NotImplementedException();
        }
    }
}
