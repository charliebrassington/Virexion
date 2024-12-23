using Domain.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CategoryService.PeopleCategoryService
{
    public class PeopleService : IPeopleCategoryService
    {
        public int GetTotalSalary(Person person, Dictionary<string, Job> jobs)
        {
            return Convert.ToInt32(person.JobList.Select(jobId => jobs[jobId].Salary).Sum());
        }
    }
}
