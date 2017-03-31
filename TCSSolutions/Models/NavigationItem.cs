﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCSSolutions.Models
{
    public class NavigationItem
    {
        public int RecId { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string DisplayText { get; set; }
        public bool IsActive { get; set; }
        public int SortOrder { get; set; }
        public int ParentId { get; set; }
        public string Description { get; set; }
        public bool IsSystem { get; set; }
        public bool IsSubPage { get; set; }

        public virtual ICollection<Section> Sections { get; set; }
        public virtual ICollection<PageType> PageTypes { get; set; }
    }
}