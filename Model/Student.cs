using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.API.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string college { get; set; }
    }
}
