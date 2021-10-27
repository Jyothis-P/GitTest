using GitTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GitTest.Controllers
{
    public class EmpsController : ApiController
    {
        // GET: api/Emps
        public IEnumerable<Emp> Get()
        {
            return new Emp[] { 
                new Emp {Eid = 1, Ename = "Amal", Edes = "Manager", Edoj = new DateTime()},
                new Emp {Eid = 2, Ename = "Kamal", Edes = "Manager", Edoj = new DateTime()},
                new Emp {Eid = 3, Ename = "Jamal", Edes = "Manager", Edoj = new DateTime()}
            };
        }

        // GET: api/Emps/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Emps
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Emps/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Emps/5
        public void Delete(int id)
        {
        }
    }
}
