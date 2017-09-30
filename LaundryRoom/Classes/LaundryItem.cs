using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryRoom.Classes
{
    public abstract class LaundryItem
    {
        private string clothingColor;
        private string clothingMaterial;

        public string ClothingColor
        {
            get { return clothingColor; }
        }

        public string ClothingMaterial
        {
            get { return clothingMaterial; }
        }

        public LaundryItem(string clothingColor, string clothingMaterial)
        {
            this.clothingColor = clothingColor;
            this.clothingMaterial = clothingMaterial;
        }

        public abstract string ClothingDone();
    }
}
