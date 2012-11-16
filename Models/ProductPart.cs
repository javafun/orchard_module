﻿using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orchard.Webshop.Models
{
    public class ProductPart : ContentPart<ProductPartRecord>
    {
        public decimal UnitPrice
        {
            get { return Record.UnitPrice; }
            set { Record.UnitPrice = value; }
        }

        public string Sku
        {
            get { return Record.Sku; }
            set { Record.Sku = value; }
        }
    }
}
