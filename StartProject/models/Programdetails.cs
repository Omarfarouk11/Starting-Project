using Cosmonaut.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.models
{
    public class Programdetails
    {
        
        public string Id { get; set; }
        public string Title { get; set; }
        public string? summary { get; set; }
        public string description { get; set; }
        public List<string> skills { get; set; }
        public string? benefits { get; set;}
        public string? criteria { get; set; }
        public string types { get; set; }
        public string? qualifications { get; set; } 
        public DateTime? Open { get; set; }
        public DateTime? Close { get; set; } 
        public int? Duration { get; set; }
        public string Location { get; set; }
        public int maxnumber { get; set; }
        public ICollection<ApplicationForm> forms { get; set; }
        public ICollection<WorkFlow> workFlows { get; set; }

    }
}
