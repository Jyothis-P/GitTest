using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using GitTest.Models;
using Microsoft.Data.OData;

namespace GitTest.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using GitTest.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Emp>("Emps1");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class Emps1Controller : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/Emps1
        public IHttpActionResult GetEmps1(ODataQueryOptions<Emp> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            Emp[] emps = new Emp[] {
                new Emp {Eid = 1, Ename = "Amal", Edes = "Manager", Edoj = new DateTime()},
                new Emp {Eid = 2, Ename = "Kamal", Edes = "Manager", Edoj = new DateTime()},
                new Emp {Eid = 3, Ename = "Jamal", Edes = "Manager", Edoj = new DateTime()}
            };
            return Ok<IEnumerable<Emp>>(emps);
            //return StatusCode(HttpStatusCode.NotImplemented);
        }

        // GET: odata/Emps1(5)
        public IHttpActionResult GetEmp([FromODataUri] int key, ODataQueryOptions<Emp> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<Emp>(emp);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/Emps1(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Emp> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(emp);

            // TODO: Save the patched entity.

            // return Updated(emp);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/Emps1
        public IHttpActionResult Post(Emp emp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(emp);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/Emps1(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Emp> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(emp);

            // TODO: Save the patched entity.

            // return Updated(emp);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/Emps1(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}
