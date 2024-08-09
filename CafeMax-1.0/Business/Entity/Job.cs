using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Entity
{
    class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Job() { Title = ""; }
    }
}
