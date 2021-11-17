using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.API.Model
{
    public class Cohort
    {
        public int Id { get; set; }
        public string Subject { get; set; }

        public List<Student> Students { get; set; }

        public Cohort(int _id, string _subject, List<Student> _students)
        {
            Id = _id;
            Subject = _subject;
            Students = _students;
        }
    }
}
