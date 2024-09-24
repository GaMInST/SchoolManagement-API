public class StudentDetailsVm
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public List<CourseVm> Courses { get; set; }
}
