using Microsoft.EntityFrameworkCore;
using start_project.ApplicationDbContext;
using start_project.Dtos;
using start_project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.Repositories
{
    public class ProgramSerivce : IProgramService
    {
        private readonly Applicationdbcontext _Dbcontext;
        public ProgramSerivce( Applicationdbcontext applicationdbcontext)
        {
            _Dbcontext = applicationdbcontext;

        }

        public bool AddProgramDetails(Programdetails programDetails)
        {
            if(programDetails == null)
            {
                return false;
            }
            else
            {
                _Dbcontext.Programdetails.Add(programDetails);
                _Dbcontext.SaveChanges();
                return true;
            }
            
        }

        public IEnumerable<Programdetails> GetAllDetails()
        {
            return _Dbcontext.Programdetails.ToList();
        }

        public Programdetails GetProgramDetails(string ID)
        {
            var program= _Dbcontext.Programdetails.FirstOrDefault(c => c.Id == ID);
            if(program == null)
            {
                
                    throw new Exception("Not Found ....");
                
            }
            else
            {
                return program;
            }
            
        }

        public bool UpdateProgramDetails(Programdetails programDetails)
        {
           
            if(programDetails==null)
            {
                return false;

            }
            else
            {
                _Dbcontext.Programdetails.Update(programDetails);
                _Dbcontext.SaveChanges();
                return true;
            }
               
            
     
        }
    }
}
















