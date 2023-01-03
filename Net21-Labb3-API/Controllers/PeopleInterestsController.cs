using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net21_Labb3_API.Models;
using Net21_Labb3_API.Data;

namespace Net21_Labb3_API.Controllers
{

   
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleInterestsController : ControllerBase
    {

        private readonly ApiContext _context;

        public PeopleInterestsController(ApiContext context)
        {
            _context = context;
        }

        //Create/Edit
        [HttpPost]
        public JsonResult CreateEdit (Person person)
        {
            if (person.Id == 0)
            {
                _context.People.Add(person);
            }
            else
            {
                var personInDb = _context.People.Find(person.Id);

                if (personInDb==null)
                    return new JsonResult(NotFound());

                personInDb = person;

            }

            _context.SaveChanges();

            return new JsonResult(Ok(person));

        }




        //Get
        //Get All interests connected to a specific person

        [HttpGet]
        public JsonResult Get(int Id)
        {
            var result = _context.Interests.Find(Id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));

        }


    }
}
