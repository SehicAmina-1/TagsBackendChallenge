using Amina.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Amina.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TagController(ApplicationDbContext context) : ControllerBase
{
    private readonly ApplicationDbContext _context = context;
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Tag>>> GetTags()
    {
        var tags = await _context.Tags.ToListAsync();
        return Ok(tags);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Tag>> GetAsync(int id)
    {
        var tag = await _context.Tags.FirstOrDefaultAsync(e => e.Id == id);
        if (tag == null)
        {
            return NotFound();
        }
        return tag;
    } 
}