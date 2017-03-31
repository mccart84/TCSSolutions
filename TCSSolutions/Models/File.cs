using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCSSolutions.Models
{
    public class File
    {
        public int RecId { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string ContentType { get; set; }
        public string Title { get; set; }
        public int DownloadCount { get; set; }
        public int ViewCount { get; set; }

        public virtual Section Section { get; set; }
        public virtual ICollection<FileKeyword> FileKeywords { get; set; }
    }
}