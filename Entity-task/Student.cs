using System.ComponentModel.DataAnnotations.Schema;


namespace Entity_task
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Course>();
        }
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        public Grade Grade { get; set; }//one-to-many 
        public virtual StudentAddress Address { get; set; }//one-to-one
      
        public virtual ICollection<Course> Courses { get; set; }//many-to-many
    }

    
 
}
