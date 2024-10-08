namespace Day_1_mvc.Models
{
    public class StudentBL
    {
        private List<Student> students;
        public StudentBL()
        {
            students = new List<Student>()
            {
                new Student { Id = 1 , Name = "Fawzy Fathi" , ImageUrl = "boy.png"},
                new Student { Id = 2 , Name = "Mohamed Fathi" , ImageUrl = "boy.png"},
                new Student { Id = 3 , Name = "Naglaa Fathi" , ImageUrl = "woman.png"},
                new Student { Id = 4 , Name = "Eman Fathi" , ImageUrl = "woman.png"}
            }; 
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public Student GetStudentById (int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }


    }
}
