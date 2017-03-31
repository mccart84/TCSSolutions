using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCSSolutions.Models;

namespace TCSSolutions.DAL
{
    public class ApplicationInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            var sections = new List<Section>
            {
                new Section {Name = "Main Navigation", IsActive = true, IsSystem = true},
                new Section {Name = "Trafficking", IsActive = true, IsSystem = true},
                new Section {Name = "Cyber Security", IsActive = true, IsSystem = true},
                new Section {Name = "Admin", IsActive = true, IsSystem = true}
            };

            sections.ForEach(s => context.Sections.Add(s));
            context.SaveChanges();

            var pageTypes = new List<PageType>
            {
                new PageType { TemplateTitle = "Group Page", IsActive = true},
                new PageType { TemplateTitle = "Resource View", IsActive = true}
            };

            pageTypes.ForEach(pt => context.PageTypes.Add(pt));
            context.SaveChanges();

            var navigationItems = new List<NavigationItem>
            {
                new NavigationItem { Controller = "Home", Action = "Index", DisplayText = "Home", Description = "Home page for the application", IsActive = true, IsSystem = true, SortOrder = 1, ParentId = null, IsSubPage = false, FkSection = 1},
                new NavigationItem { Controller = "Trafficking", Action = "Index", DisplayText = "Trafficking", Description = "Home page for the trafficking section", IsActive = true, IsSystem = true, SortOrder = 2, ParentId = null, FkSection = 1},
                new NavigationItem { Controller = "CyberSecurity", Action = "Index", DisplayText = "Cyber Security", Description = "Home page for the cyber security section", IsActive = true, IsSystem = true, SortOrder = 3, ParentId = null, FkSection = 1},
                new NavigationItem { Controller = "Home", Action = "About", DisplayText = "About", Description = "An information page that describes what the application is for", IsActive = true, IsSystem = true, SortOrder = 4, ParentId = null, FkSection = 1},
                new NavigationItem { Controller = "Home", Action = "Contact", DisplayText = "Contact", Description = "A page for contacting various government agencies for information", IsActive = false, IsSystem = true, SortOrder = 5, ParentId = null, FkSection = 1},
                new NavigationItem { Controller = "CustomPages", Action = "CustomPage", DisplayText = "Adult", Description = "The Adults sub page of the Trafficking Section", IsActive = true, IsSystem = false, SortOrder = 1, ParentId = 2, FkSection = 2, IsSubPage = true, FkPageType = 1},
                new NavigationItem { Controller = "CustomPages", Action = "CustomPage", DisplayText = "Teen", Description = "The Teen sub page of the Trafficking Section", IsActive = true, IsSystem = false, SortOrder = 2, ParentId = 2, FkSection = 2, IsSubPage = true, FkPageType = 1},
                new NavigationItem { Controller = "CustomPages", Action = "CustomPage", DisplayText = "Youth", Description = "The Youth sub page of the Trafficking Section", IsActive = true, IsSystem = false, SortOrder = 3, ParentId = 2, FkSection = 2, IsSubPage = true, FkPageType = 1},
                new NavigationItem { Controller = "CustomPages", Action = "CustomPage", DisplayText = "Teacher", Description = "The Teachers sub page of the Trafficking Section", IsActive = true, IsSystem = false, SortOrder = 4, ParentId = 2, FkSection = 2, IsSubPage = true, FkPageType = 1},
                new NavigationItem { Controller = "CustomPages", Action = "CustomPage", DisplayText = "Statistics", Description = "The Statistics sub page of the Trafficking Section", IsActive = true, IsSystem = false, SortOrder = 5, ParentId = 2, FkSection = 2, IsSubPage = true, FkPageType = 1},
                new NavigationItem { Controller = "CustomPages", Action = "CustomPage", DisplayText = "Resources", Description = "The Resources page of the Trafficking Section that displays files", IsActive = true, IsSystem = false, SortOrder = 6, ParentId = 2, FkSection = 6, IsSubPage = true, FkPageType = 2},
                new NavigationItem { Controller = "CustomPages", Action = "CustomPage", DisplayText = "Adult", Description = "", IsActive = true, IsSystem = false, SortOrder = 1, ParentId = 2, FkSection = 3, IsSubPage = true, FkPageType = 1},
                new NavigationItem { Controller = "CustomPages", Action = "CustomPage", DisplayText = "Teen", Description = "The Teen sub page of the Cyber Security Section", IsActive = true, IsSystem = false, SortOrder = 2, ParentId = 2, FkSection = 3, IsSubPage = true, FkPageType = 1},
                new NavigationItem { Controller = "CustomPages", Action = "CustomPage", DisplayText = "Youth", Description = "The Youth sub page of the Cyber Security Section", IsActive = true, IsSystem = false, SortOrder = 3, ParentId = 2, FkSection = 3, IsSubPage = true, FkPageType = 1},
                new NavigationItem { Controller = "CustomPages", Action = "CustomPage", DisplayText = "Teacher", Description = "The Teachers sub page of the Cyber Security Section", IsActive = true, IsSystem = false, SortOrder = 4, ParentId = 2, FkSection = 3, IsSubPage = true, FkPageType = 1},
                new NavigationItem { Controller = "CustomPages", Action = "CustomPage", DisplayText = "Law Enforcement", Description = "The Law Enforcement sub page of the Cyber Security Section", IsActive = true, IsSystem = false, SortOrder = 5, ParentId = 2, FkSection = 3, IsSubPage = true, FkPageType = 1},
                new NavigationItem { Controller = "CustomPages", Action = "CustomPage", DisplayText = "Statistics", Description = "The Statistics sub page of the Cyber Security Section", IsActive = true, IsSystem = false, SortOrder = 6, ParentId = 2, FkSection = 3, IsSubPage = true, FkPageType = 1},
                new NavigationItem { Controller = "CustomPages", Action = "CustomPage", DisplayText = "Resources", Description = "The Resources page of the Cyber Security Section that displays files", IsActive = true, IsSystem = false, SortOrder = 7, ParentId = 2, FkSection = 3, IsSubPage = true, FkPageType = 2},
            };

            navigationItems.ForEach(n => context.NavigationItems.Add(n));
            context.SaveChanges();
        }
    }
}