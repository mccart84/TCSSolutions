using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCSSolutions.Models
{
    public class FileKeyword
    {
        public int RecId { get; set; }
        public string Keyword { get; set; }
        public virtual File File { get; set; }
    }
}