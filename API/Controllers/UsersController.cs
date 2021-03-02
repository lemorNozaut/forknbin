  
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("Api/[Controller]")]
    public class UsersController : ControllerBase
    {
        
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            
            //var users = await _context.Users.TolistAsync());

            return  await _context.Users.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<AppUser>> GetUser(int Id)
        {
            
            //var users = await _context.Users.FindAsync();
            return await _context.Users.FindAsync();
        }
    }
}