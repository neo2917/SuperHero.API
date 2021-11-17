using SuperHero.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.API.Repository
{
    public class StudentRepository
    {

        public static List<Student> Students()
        {

            return new List<Student>()
            {
                new Student{Id= 1, name ="First", college = "Dorset"},
                new Student{Id= 2, name ="Second", college = "Trinity"},
                new Student{Id= 3, name ="Third", college = "UCD"}


            };
        }
    }
}
