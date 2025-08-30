
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Reflection;

namespace Ass_EFC01
{
    internal class Program
    {
        static void Main()
        {
            // Create a class diagram for iti schema then make a mapping for this schema(code first).
            // Notes: -

            // 1.Don’t make relations between tables(create tables only).

            // 2.Use all ways of mapping(create a table using convention and another using fluent APIS and so on...). 
            /*

            Ass_EFC01_Project 
            1. Program.cs
            2. AssEFC01Context.cs
            3. Entities /
            Student.cs(Convention)
            Department.cs(Convention)
            Course.cs(Convention)
            Instructor.cs(DataAnnotations)
            Topic.cs(DataAnnotations)
            Stud_Course.cs(Fluent API)
            Course_Inst.cs(Fluent API)
            4. Configurations
            Stud_CourseConfiguration.cs
            Course_InstConfiguration.cs
     
            */



        }
    }
}