using System;
using System.Collections.Generic;

namespace RazorPagesApp
{
    public partial class SystemTonnage
    {
        public SystemTonnage()
        {
            Orders = new HashSet<Order>();
            SystemPackages = new HashSet<SystemPackage>();
        }

        public int Id { get; set; }
        public string? SystemTonnageName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<SystemPackage> SystemPackages { get; set; }
    }
}
