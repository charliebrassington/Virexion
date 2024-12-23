using Domain.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CategoryService.PeopleCategoryService
{
    public interface IPeopleCategoryService
    {
        public int GetTotalSalary(Person person, Dictionary<string, Job> jobs);
    }
}
