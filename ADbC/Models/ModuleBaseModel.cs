﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADbC.Models
{
    public partial class ModuleBaseModelDataContext : System.Data.Linq.DataContext
    {
        public keysModule module;
        public List<keysModuleIntroSection> sections;
        public List<keysModuleIntroContent> contents;
    }
}