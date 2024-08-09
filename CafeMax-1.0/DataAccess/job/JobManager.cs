using CafeMax.Business.Entity;
using CafeMax.DataAccess.database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.DataAccess.job
{
    class JobManager : IJob
    {
        public IDatabase database;

        public JobManager() { database = new MsSqlDatabase(); }

        public bool AddJob(string job)
        {
            throw new NotImplementedException();
        }

        public bool DeleteJob(string job)
        {
            throw new NotImplementedException();
        }

        public List<Job> GetAll()
        {
            List<Job> jobs = new List<Job>();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query = "Select * From job";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Job job = new Job();

                        job.Id = (int)reader["id"];
                        job.Title = (string)reader["job"];

                        jobs.Add(job);
                    }
                }

            }

            return jobs;
        }

        
    }
}
