using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.DataAccess.job
{
    interface IJob
    {
        bool AddJob(string job);
        bool DeleteJob(string job);
        List<Job> GetAll();

    }
}
