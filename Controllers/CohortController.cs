using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHero.API.Model;
using SuperHero.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CohortController : ControllerBase
    {

        [HttpGet]
        public Cohort Get()
        {

            Cohort cohort = new(1, "Programming", StudentRepository.Students());
            return cohort;
        }

    }
}
