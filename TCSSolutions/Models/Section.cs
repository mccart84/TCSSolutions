using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCSSolutions.Models
{
    public class Section
    {
        public int RecId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsSystem { get; set; }

        public virtual ICollection<NavigationItem> NavigationItems { get; set; }
        public virtual ICollection<File> Files { get; set; }
    }
}