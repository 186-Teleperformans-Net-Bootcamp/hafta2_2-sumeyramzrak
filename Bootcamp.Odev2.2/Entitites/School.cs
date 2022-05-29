namespace Bootcamp.Odev2._2.Entitites
{
    public class School
    {
        public int SchoolID { get; set; }

        public string SchoolName { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<Student> Students { get; set; }
    }
}
