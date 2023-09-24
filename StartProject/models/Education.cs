using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.models
{
    public class Education
    {
        public string School { get; set; }
        public string courseName { get; set; }
        public string Degree { get; set; }
        public string Location { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<Question>? question { get; set; }
    }
}
