﻿using SchoolManagement.DAL.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public ICollection<Course> Courses { get; set; }
}
