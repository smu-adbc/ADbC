using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADbC.Models
{
    public partial class ModuleBaseModelDataContext : System.Data.Linq.DataContext
    {
        public Module module;
        public List<ModuleIntroSection> sections;
        public List<ModuleIntroContent> contents;
    }
}