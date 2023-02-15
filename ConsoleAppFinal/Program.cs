// See https://aka.ms/new-console-template for more information
using System.Data.Entity;

public class student
{ 
    public int StudentId { get; set; }
    public string StudentName { get; set; }    
    public DateTime? DateOfBirth { get; set; }
}
public class Grade
{
    public int GradeId { get; set; }

}

namespace EF6Console
{
    public class SchoolContext:DbContext
    {
        public SchoolContext(): base()
        {

        }
        public DbSet<student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
namespace EF6Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stub = new student() { StudentName = "Becky" };

                ctx.Students.Add(stub);
                ctx.SaveChanges();
            }
        }
    }
}


