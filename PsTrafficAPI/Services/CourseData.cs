using PsTrafficAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsTrafficAPI.Services
{

    public class CourseData
    {
        public List<Course> GetAll()
        {
            return new List<Course>(){ new Course { Id="1", Title="Raja" } };
        }

        public Course GetById(int id)
        {
            return new Course { Id = "1", Title = "Raja" };
        }
    }
}
