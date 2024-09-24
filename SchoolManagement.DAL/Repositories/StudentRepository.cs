public class StudentRepository : GenericRepository<Student>, IStudentRepository
{
    public StudentRepository(SchoolDbContext context) : base(context) { }

    public async Task<Student> GetStudentByPhone(string phone)
    {
        return await _context.Students.Include(s => s.Courses)
            .FirstOrDefaultAsync(s => s.Phone == phone);
    }
}
