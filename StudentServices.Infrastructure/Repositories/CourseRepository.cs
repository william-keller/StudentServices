using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentServices.Domain.Entities;
using StudentServices.Domain.Interfaces.Repositories;

namespace StudentServices.Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        
        public Task<List<Student>> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
