using start_project.ApplicationDbContext;
using start_project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.Repositories
{
    
    public class FormService : IFormService
    {
        private readonly Applicationdbcontext _dbcontext;
        public FormService(Applicationdbcontext applicationdbcontext)
        {
            _dbcontext = applicationdbcontext;

        }
        public bool AddForm(ApplicationForm form)
        {
            if(form==null)
            {
                return false;
            }
            else
            {
                _dbcontext.Forms.Add(form);
                _dbcontext.SaveChanges();
                return true;
            }
        }
        public IEnumerable<ApplicationForm> GetForms()
        {
           return _dbcontext.Forms.ToList(); 
        }
        public bool UpdateForm(ApplicationForm form)
        {
            if (form == null)
            {
                return false;
            }
            else
            {
                _dbcontext.Forms.Update(form);
                _dbcontext.SaveChanges();
                return true;
            }


        }
        public ApplicationForm GetForm(string ID)
        {
            var form = _dbcontext.Forms.FirstOrDefault(c=>c.Id==ID);
            if (form == null)
            {
                throw new Exception("Not Found ....");
            }
            else
            {
                return form;
            }
       

        }


    }
}
