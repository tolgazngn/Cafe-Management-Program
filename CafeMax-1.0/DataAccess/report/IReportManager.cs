using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.DataAccess.report
{
    internal interface IReportManager
    {
        ZReport GetZRaport(DateTime firstTime, DateTime lastTime);
    }
}
