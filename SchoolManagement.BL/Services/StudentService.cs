using Project_Api_BLL.Service;
using SchoolMangementDAL.Entities;
using SchoolMangementDAL.StudentRepository;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<IEnumerable<Student>> GetAllStudents()
    {
        return await _studentRepository.GetAll();
    }

    public async Task<Student> GetStudentById(int id)
    {
        return await _studentRepository.GetById(id);
    }

    public async Task<Student> GetStudentByPhone(string phone)
    {
        return await _studentRepository.GetStudentByPhone(phone);
    }

    public async Task AddStudent(Student student)
    {
        await _studentRepository.Add(student);
    }

    public async Task UpdateStudent(Student student)
    {
        await _studentRepository.Update(student);
    }

    public async Task DeleteStudent(int id)
    {
        await _studentRepository.Delete(id);
    }

    public Task GetCoursesByStudentId(int studentId)
    {
        throw new NotImplementedException();
    }
}

