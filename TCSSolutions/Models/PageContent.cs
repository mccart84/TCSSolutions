using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCSSolutions.Models
{
    public class PageContent
    {
        public int RecId { get; set; }
        public string Container { get; set; }
        public string Content { get; set; }

        public virtual PageType PageType { get; set; }

    }
}