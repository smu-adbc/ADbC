using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADbC.Models
{
    public partial class MultipleChoiceModelDataContext : ModuleBaseModelDataContext
    {
        public List<MCQuestion> MenuQuestions;

        public MCQuestion Question;        
        public List<MCAnswer> Answers;

        //using 'new' because hiding inherited
        new public void GenerateBaseElements(string moduleName)
        {
            //using inherited to avoid duplication
            base.GenerateBaseElements(moduleName);

            MenuQuestions = SelectMCQuestionsByModuleName(moduleName).OrderBy(x => x.MCQuestionID).ToList();
        }
    }
}