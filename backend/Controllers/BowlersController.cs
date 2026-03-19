using backend.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers;

[ApiController]
[Route("api/Bowlers")]
public class BowlersController : ControllerBase
{
    private BowlerDbContext _context;

    public BowlersController(BowlerDbContext context)
    {
        _context = context;
    }

    [HttpGet(Name = "GetBowlers")]
    public ActionResult<IEnumerable<Bowler>> GetBowlers()
    {
        List<Bowler> bowlers = _context.Bowlers.Include(b => b.Team).Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks").ToList();
        return Ok(bowlers);
    }
}