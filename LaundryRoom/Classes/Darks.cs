﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryRoom.Classes
{
    public class Darks : LaundryItem
    {
        public Darks(string clothingColor, string clothingMaterial) : base(clothingColor, clothingMaterial)
        {

        }
        public override string ClothingDone()
        {
            throw new NotImplementedException();
        }
    }
}