using SchoolMangementDAL.Entities;
using SchoolMangementDAL.GenericRepository;
using SchoolMangementDAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementDAL.StudentRepository
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<Student> GetStudentByPhone(string phone);
    }
}
