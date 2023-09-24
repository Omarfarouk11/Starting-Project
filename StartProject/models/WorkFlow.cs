using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.models
{
    public class WorkFlow
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Stagetype Stagetype { get; set; }
        public string ProgramdetailsID { get; set; }
        public Programdetails Programdetails { get; set; }
    }
}
