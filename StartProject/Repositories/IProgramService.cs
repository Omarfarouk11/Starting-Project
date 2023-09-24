using start_project.Dtos;
using start_project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.Repositories
{
    public interface IProgramService
    {
        IEnumerable<Programdetails> GetAllDetails();
        bool AddProgramDetails(Programdetails programDetails);
        bool UpdateProgramDetails(Programdetails programDetails);
        Programdetails GetProgramDetails(string ID);
    }
   
}
