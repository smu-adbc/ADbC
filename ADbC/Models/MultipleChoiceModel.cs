﻿using System;
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
    }
}