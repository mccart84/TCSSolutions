using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCSSolutions.Models
{
    public class PageType
    {
        public int RecId { get; set; }
        public string TemplateTitle { get; set; }
        public bool IsActive { get; set; }
        public virtual NavigationItem NavigationItems { get; set; }
        public virtual ICollection<PageContent> PageContents { get; set; }

    }
}