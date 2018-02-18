using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADbC.Models
{
    public partial class ERMultipleChoiceModelDataContext : ModuleBaseModelDataContext
    {
        public keysERQuestion Question;
        public List<keysERAnswer> Answers;
    }
}