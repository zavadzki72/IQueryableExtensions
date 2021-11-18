using AspNetCore.IQueryable.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TeamAPI.Models.Dtos;

namespace TeamAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {

        private readonly TeamDbContext _dbContext;

        public TeamController(TeamDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var times = await _dbContext.Teams.ToListAsync();
            return times.Any() ? Ok(times) : NotFound();
        }

        [HttpGet]
        [Route("GetWithFilter")]
        public async Task<IActionResult> GetTeamsWithFilter([FromQuery] GetTeamFilterDto getTeamFilterDto)
        {
            var times = await _dbContext.Teams.AsQueryable().Apply(getTeamFilterDto).ToListAsync();
            return times.Any() ? Ok(times) : NotFound();
        }
    }
}
