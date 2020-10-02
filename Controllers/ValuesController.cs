using PetAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get(string name)
        {
            petEntities1 db = new petEntities1();

            Pet other = (from p in db.Pets
                         where p.pet_name.Contains(name)
                         select p).FirstOrDefault();

            return new string[] { name, other.pet_name };
        }

        /*
        // GET api/values/5
        public object Get(int id)
        {
            petEntities db = new petEntities();

            Pet pet = db.Pets.FirstOrDefault();

            return pet.pet_name;
        }

        // GET api/values/0BA79BF2-1A5E-4BD8-A35D-E21C43DB9198
        public object Get(Guid id)
        {
            petEntities db = new petEntities();

            Pet pet = db.Pets.FirstOrDefault(x => x.pet_id == id);

            return pet.pet_name;
        }
         */

        // GET api/values/5
        public object Get(Guid id)
        {
            petEntities1 db = new petEntities1();

            Pet pet = db.Pets.FirstOrDefault(x => x.pet_id == id);

            return pet.pet_name;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
