using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectOp.Context;
using ProjectOp.DTO;
using ProjectOp.Entities;

namespace ProjectOp.Controllers
{
    [Route("api/member")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly AppDbContext _db;
        public MemberController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet("byId")]
        public async Task<ActionResult> GetMember(int id)
        {
            if (ModelState.IsValid)
            {
                List<Achievement> achive = await _db.achievements.Where(x => x.UserId == id).ToListAsync();
                Console.WriteLine(achive);
                var user = await _db.users.FirstOrDefaultAsync(x => x.UserID == id);
                if (user == null)
                {
                    return NotFound();
                }
                UserDTO u = new UserDTO();
                List<AchievementDTO> achievementDTOs = new List<AchievementDTO>();
                for (var i = 0; i < achive.Count(); i++)
                {
                    AchievementDTO dTO = new AchievementDTO();
                    dTO.achieve = achive[i].achieve;
                    achievementDTOs.Add(dTO);
                }
                u.achievements = new List<AchievementDTO>(achievementDTOs);
                u.department = user.department;
                u.name = user.name;
                u.id = user.UserID;
                u.nationality = user.nationality;
                u.quote = user.quote;
                u.image1 = user.image1;
                u.image2 = user.image2;
                return Ok(u);
            }

            return BadRequest("error");
        }

        [HttpGet]
        public async Task<ActionResult> GetMembers()
        {
            if (ModelState.IsValid)
            {
                var users = await _db.users.Select(x => new UsersDTO(
                    x.UserID, x.name, x.nationality, x.quote, x.department, x.image1, x.image2
                    )).ToListAsync<UsersDTO>();
                if (users == null)
                {
                    return NotFound();
                }
                return Ok(users);
            }

            return BadRequest("error");
        }


    }
}