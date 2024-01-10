using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_Tutorial_3.Data;
using WebAPI_Tutorial_3.DTOs;
using WebAPI_Tutorial_3.Models;

namespace WebAPI_Tutorial_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FatController : ControllerBase
    {
        private readonly DataContext _context;

        public FatController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> CreateCharacter(CharacterCreateDto request)
        {
            var newCharacter = new Character
            {
                Name = request.Name
            };

            var backpack = new Backpack
            {
                Description = request.Backpack.Description,
                Character = newCharacter
            };

            newCharacter.Backpack = backpack;

            _context.Characters.Add(newCharacter);
            await _context.SaveChangesAsync();

            return Ok(await _context.Characters.Include(c => c.Backpack).ToListAsync());
        }
    }
}
