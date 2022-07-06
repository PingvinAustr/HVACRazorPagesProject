using System;
using System.Collections.Generic;

namespace RazorPagesApp
{
    public partial class Themostat
    {
        public Themostat()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? ThermoName { get; set; }
        public string? Img { get; set; }
        public int? Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
