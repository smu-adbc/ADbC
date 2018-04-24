using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADbC.Models
{
    public partial class ModuleBaseModelDataContext : System.Data.Linq.DataContext
    {
        public Module module;
        public List<ModuleIntroSection> introSections;
        public List<ModuleIntroContent> introContents;
        public List<ModuleUsageSection> usageSections;
        public List<ModuleUsageContent> usageContents;

        public void GenerateBaseElements(string moduleName)
        {
            ObjectTrackingEnabled = false;
            
            module = SelectModuleByName(moduleName).ToList().First();
            introSections = SelectModuleIntroSectionsByModuleID(module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
            introContents = SelectModuleIntroContentByModuleID(module.ModuleID).OrderBy(x => x.ContentOrder).ToList();
            usageSections = SelectModuleUsageSectionsByModuleID(module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
            usageContents = SelectModuleUsageContentByModuleID(module.ModuleID).OrderBy(x => x.ContentOrder).ToList();
        }
    }
}