using SchoolManagement.DAL.Models;

public interface IStudentRepository : GenericRepository<Student>
{
    Task<Student> GetStudentByPhone(string phone);
}
