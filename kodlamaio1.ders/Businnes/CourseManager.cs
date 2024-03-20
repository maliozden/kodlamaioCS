using kodlamaio1.ders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlamaio1.ders.Businnes;

public class CourseManager
{
    Course[] courses=new Course[2];
    public CourseManager()
    {
        Course course1 = new Course();

        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = "asp.net 8";
        course1.Price = 0;

        Course course2 = new Course();

        course2.Id = 2;
        course2.Name = "Java";
        course2.Description = "Java 17";
        course2.Price = 10;


        courses[0] = course1;
        courses[1] = course2;



    }

    public Course[] GetAll()
    {
        return courses; 
    }
}
