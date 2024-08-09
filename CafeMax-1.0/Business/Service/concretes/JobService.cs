using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.DataAccess.job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.concretes
{
    internal class JobService : IJobService
    {
        public List<Job> GetAll()
        {
            JobManager jobManager = new JobManager();

            return jobManager.GetAll();
        }
    }
}
