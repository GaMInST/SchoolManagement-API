using Microsoft.EntityFrameworkCore;
using SchoolMangementDAL.DbContexts;
using SchoolMangementDAL.Entities;
using SchoolMangementDAL.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMangementDAL.StudentRepository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context) { }

        public async Task<Student> GetStudentByPhone(string phone)
        {
            return await _context.Students
                                 .Include(s => s.Courses) 
                                 .FirstOrDefaultAsync(s => s.Phone == phone);
        }
    }


}
