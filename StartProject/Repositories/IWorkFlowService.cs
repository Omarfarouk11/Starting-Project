using start_project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.Repositories
{
    public interface IWorkFlowService
    {
        bool Update(WorkFlow workFlow);
        bool Add(WorkFlow workFlow);
        IEnumerable<WorkFlow> GetAllWorkFlow(); 
        WorkFlow GetWorkFlow(string ID);
    }
}
