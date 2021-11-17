using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHero.API.Model;
using SuperHero.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//https://exceptionnotfound.net/ef-core-inmemory-asp-net-core-store-database/

namespace SuperHero.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {


        [HttpGet]
        public List<Student> Get()
        {
            return StudentRepository.Students();
        }


        [HttpGet]
        [Route("{id:int}")]
        public Student GetStudent(int id)
        {
            return StudentRepository.Students().Where(x=>x.Id == id).FirstOrDefault();
        }


        [HttpPost]
        public List<Student> Post([FromBody] Student student)
        {


            List<Student> students = StudentRepository.Students();

            students.Add(student);
            return students;
        }



    }
}
