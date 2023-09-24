using start_project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.Repositories
{
    public interface IFormService
    {
        IEnumerable<ApplicationForm> GetForms();
        bool AddForm(ApplicationForm form);
        bool UpdateForm(ApplicationForm form);
        ApplicationForm GetForm(string ID);


    }
}
