using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.Dtos
{
    public class ProgramDetailsDto
    {
        public string Title { get; set; }
        public string? summary { get; set; }
        public string description { get; set; }
        public List<skills> skills { get; set; }
        public string? benefits { get; set; }
        public string? criteria { get; set; }
        public ProgramTypes types { get; set; }
        public  Qualification? qualifications { get; set; }
        public DateTime? Open { get; set; }
        public DateTime? Close { get; set; }
        public int? Duration { get; set; }
        public string Location { get; set; }
        public int maxnumber { get; set; }

        
    }
}
