using System;
using System.Collections.Generic;

namespace RazorPagesApp
{
    public partial class SystemType
    {
        public SystemType()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? SystemTypeName { get; set; }
        public string? Img { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
