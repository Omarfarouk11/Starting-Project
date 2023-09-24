using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.models
{
    public class Question
    {
        public string text { get; set; }
        public Questiontype Questiontype { get; set; }
        public string? QType { get; set; }
    }
}
