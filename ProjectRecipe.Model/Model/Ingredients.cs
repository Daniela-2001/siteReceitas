﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectRecipe.Model
{
    public class Ingredients : BaseDomain
    {
        public string Description { get; set; }
        public string Quantity { get; set; }
        public int IdRecipe { get; set; }


    }
}
