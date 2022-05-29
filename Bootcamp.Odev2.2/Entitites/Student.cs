namespace Bootcamp.Odev2._2.Entitites
{
    public class Student
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public int SchoolID { get; set; }

        public int ClassID { get; set; }

        public List<Lesson> Lessons { get; set; }
    }
}
