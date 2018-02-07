using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADbC.Models
{
    public class ERNotationModel
    {
        public int currentRelation;
        public int currentNotation;

        List<ERNotationObject> ERList;

        public ERNotationModel(int selRelation, int selNotation)
        {
            currentRelation = selRelation;
            currentNotation = selNotation;

            ERList = new List<ERNotationObject>
            {
                new ERNotationObject(1,1),
                new ERNotationObject(1,2),
                new ERNotationObject(2,1),
                new ERNotationObject(2,2)
            };
        }

        public string CurrentToString
        {
            get
            {
                ERNotationObject current = ERList.Find(x => x.RelationID == currentRelation && x.NotationID == currentNotation);
                return current.Output;
            }            
        }
    }

    public class ERNotationObject
    {
        public int RelationID;
        public int NotationID;
        public string Output;

        public ERNotationObject(int rel, int not)
        {
            RelationID = rel;
            NotationID = not;
            Output = $"Relation: {RelationID} -- Notation: {NotationID}";
        }
    }
}