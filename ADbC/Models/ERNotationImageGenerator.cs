using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADbC.Models
{
    public class ERNotationImageGenerator
    {
        public string notation;
        public string relation;

        public ERNotationImageGenerator(string not, string rel)
        {
            notation = not;
            relation = rel;
        }

        public string GenerateImageURL()
        {
            return $@"/Content/Images/ERNotation/{notation}/{relation}.png";
        }
    }
}