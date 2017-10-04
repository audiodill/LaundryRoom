using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryRoom.Classes
{
    public class LaundryPile
    {
        private string currentPile;
        Dictionary<string, Stack<LaundryItem>> whites = new Dictionary<string, Stack<LaundryItem>>();
        Dictionary<string, Stack<LaundryItem>> colors = new Dictionary<string, Stack<LaundryItem>>();
        Dictionary<string, Stack<LaundryItem>> darks = new Dictionary<string, Stack<LaundryItem>>();
        public LaundryPile()
        {

        }

        public string CurrentPile
        {
            get{ return this.currentPile; }
        }
        public LaundryItem ClothingWashed()
        {
            return null;
        }
    }
}
