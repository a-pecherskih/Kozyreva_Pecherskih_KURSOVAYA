﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOshopService.BindingModels
{
    public class PartBindingModel
    {
        public int Id { get; set; }

        public string PartName { get; set; }
        public int PartPrice { get; set; }
    }
}
