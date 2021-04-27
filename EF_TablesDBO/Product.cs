using System;
using System.Collections.Generic;
using System.Text;
using EF_TablesDBO;

namespace EF_TablesDBO
{
    public class Product
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Describe { get; set; }

    }
}
