using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TCSSolutions.Models;

namespace TCSSolutions.DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("ApplicationContext")
        {
            
        }

        public DbSet<File> Files { get; set; }
        public DbSet<FileKeyword> FileKeywords { get; set; }
        public DbSet<NavigationItem> NavigationItems { get; set; }
        public DbSet<PageContent> PageContents { get; set; }
        public DbSet<PageType> PageTypes { get; set; }
        public DbSet<Section> Sections { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}