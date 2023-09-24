using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.models
{
    public class ApplicationForm
    {
        public string Id { get; set; }
        public string ProgramdetailsID { get; set; }
        public Programdetails Programdetails { get; set; }

        public string? Image { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
        public Profile Profile { get; set; }
        public List<Question>? Question { get; set; }
    }
}
