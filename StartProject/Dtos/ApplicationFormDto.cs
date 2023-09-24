using Microsoft.AspNetCore.Http;
using start_project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.Dtos
{
    public class ApplicationFormDto
    {
    
        public string? Image { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
        public Profile Profile { get; set; }
        public List<Question>? Question { get; set; }
    }
}
