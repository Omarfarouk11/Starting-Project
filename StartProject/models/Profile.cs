using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.models
{
    public class Profile
    {
        public string resume { get; set; }
        public Experince experince { get; set; }    
        public Education education { get; set; }
        public List<Question>? question { get; set; }
    }
}
