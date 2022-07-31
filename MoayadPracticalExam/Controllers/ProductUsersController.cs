using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoayadPracticalExam.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MoayadPracticalExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductUsersController : ControllerBase
    {


        public static List<ApplicationUsers> AppUsers = new List<ApplicationUsers>()
        {
            new ApplicationUsers() { Id = 1, Name = "Moayad", PassWord="12345", Type =1 },
             new ApplicationUsers() { Id = 2, Name = "Mohand", PassWord="123456", Type =2 },
              new ApplicationUsers() { Id = 3, Name = "Mohammed", PassWord="1234567", Type =1 },



        };



        [HttpGet]

        public IActionResult Getall()
        {
            return Ok(AppUsers);
        }


        [HttpGet("{Id}")]


        public IActionResult GetById(int Id)
        {
            var curUser = AppUsers.Where(x => x.Id == Id).SingleOrDefault();

            if (curUser == null)
            {
                return NotFound(new { ErrorCode = 501, Message = "Invalid User ID" });

            }

            return Ok(curUser);
        }

        [HttpPost]

        public IActionResult addUser (int Id, ApplicationUsers NewUser)
        {
            if (string.IsNullOrEmpty(NewUser.Name))
            {

                return BadRequest(new { ErrorCode = 502, Message = "empty Name" });
            }

            

            AppUsers.Add(NewUser);
            return NoContent();

        }


        [HttpDelete("{Id}")]

        public IActionResult DeleteUser(int Id)
        {
            var curUser = AppUsers.Where(x => x.Id == Id).SingleOrDefault();

            if (curUser == null)
            {
                return NotFound(new { ErrorCode = 501, Message = "No user ID" });

            }

            AppUsers.Remove(curUser);
            return NoContent();





        }
    }
}
