using Microsoft.EntityFrameworkCore;
using start_project.ApplicationDbContext;
using start_project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace start_project.Repositories
{
    public class WorkFlowService : IWorkFlowService
    {
        private readonly Applicationdbcontext _dbcontext;
        public WorkFlowService(Applicationdbcontext applicationdbcontext)
        {
            _dbcontext = applicationdbcontext;

        }

        public bool Add(WorkFlow workFlow)
        {
            if (workFlow == null)
            {
                return false;
            }
            else
            {
                _dbcontext.workFlows.Add(workFlow);
                _dbcontext.SaveChanges();
                return true;
            }
        }

        public IEnumerable<WorkFlow> GetAllWorkFlow()
        {
            return _dbcontext.workFlows.ToList();

        }

        public WorkFlow GetWorkFlow(string ID)
        {
            var workflow= _dbcontext.workFlows.FirstOrDefault(c => c.Id == ID);
            if(workflow==null)
            {
                throw new Exception("Not Found ...");
            }
            else
            {
                return workflow;
            }
        }

        public bool Update(WorkFlow workFlow)
        {
           
            if(workFlow == null)
            {
                return false;
            }
            else
            {
                _dbcontext.workFlows.Update(workFlow);
                _dbcontext.SaveChanges();
                return true;
            }
        }


    }
}
