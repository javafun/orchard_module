using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Webshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orchard.Webshop.Handlers
{
    public class ProductPartHandler : ContentHandler
    {
        public ProductPartHandler(IRepository<ProductPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
