﻿namespace Bootcamp.Odev2._2.Entitites
{
    public class Lesson
    {
        public int LessonID { get; set; }

        public string LessonName { get; set; }

        public int TeacherID { get; set; }

        public List<Student> Students { get; set; }
    }
}
