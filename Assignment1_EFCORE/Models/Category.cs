using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_EFCORE.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }
    }
}
