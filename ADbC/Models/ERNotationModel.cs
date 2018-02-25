using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADbC.Models
{
    public partial class ERNotationModelDataContext : ModuleBaseModelDataContext
    {
        public List<ERNotation> NotationList;
        public List<ERRelationship> RelationshipList;
    }
}