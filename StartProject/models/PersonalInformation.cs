using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.models
{
    public class PersonalInformation
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string nationality { get; set; }
        public string currentresidence { get; set; }
        public int IDnumber { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public List<Question>? Question { get; set; }


    }
}
