using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryRoom.Classes
{
    public abstract class LaundryItem
    {
        private string itemColor;
        private string itemMaterial;
        private string itemName;

        public string ItemName
        {
            get { return ItemName; }
        }
        public string ItemColor
        {
            get { return itemColor; }
        }

        public string ItemMaterial
        {
            get { return itemMaterial; }
        }

        public LaundryItem(string itemName, string itemColor, string itemMaterial)
        {
            this.itemName = itemName;
            this.itemColor = itemColor;
            this.itemMaterial = itemMaterial;
        }

        public abstract string ClothingDone();
    }
}
