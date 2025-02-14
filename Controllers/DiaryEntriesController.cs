using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDiary_API.Data;
using WebDiary_API.Models;

namespace WebDiary_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiaryEntriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DiaryEntriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DiaryEntry_cs>>> GetDiaryEntries()
        {
            return await _context.DiaryEntry_Cs.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DiaryEntry_cs>> GetDiaryEntry(int id)
        {
            var diaryEntry = await _context.DiaryEntry_Cs.FindAsync(id);
            if(diaryEntry == null)
            {
                return NotFound();
            }
            return diaryEntry;
        }

        [HttpPost]
        public async Task<ActionResult<DiaryEntry_cs>> PostDiaryEntry(DiaryEntry_cs diaryEntry)
        {
            diaryEntry.Id = 0;
            _context.DiaryEntry_Cs.Add(diaryEntry);
            await _context.SaveChangesAsync();
            // Agora você deve estar se perguntando: por que nos preocuparíamos com esse URL de recurso?

//            Bem, o fato é que ele fornece uma orientação clara ao cliente sobre como acessar o novo recurso que

//acabou de ser criado e adere aos princípios e às práticas recomendadas do RESTful.

//E, além disso, facilita ações de acompanhamento e interações adicionais com esse recurso.

//Além disso, ele oferece suporte às APIs orientadas por hipermídia, tornando a API mais autodescritiva e mais fácil de usar programaticamente.
            var resourceUrl = Url.Action(nameof(GetDiaryEntry), new {id=diaryEntry.Id});
            return Created(resourceUrl, diaryEntry);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> PutDiaryEntry(int id, [FromBody] DiaryEntry_cs diaryEntry)
        {
            if(id != diaryEntry.Id)
            {
                return BadRequest();
            }

            _context.Entry(diaryEntry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            } catch (DbUpdateConcurrencyException)
            {
                if (!DiaryEntryExists(id))
                {
                    return NotFound();
                } else
                {
                    throw;
                }
            }

            return NoContent();
            {

            }

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiaryEntry(int id)
        {
            var diaryEntry = await _context.DiaryEntry_Cs.FindAsync(id);
            if (diaryEntry == null)
            {
                return NotFound();
            }
            _context.DiaryEntry_Cs.Remove(diaryEntry);
            await _context.SaveChangesAsync();

            return NoContent();

        }
        
        private bool DiaryEntryExists(int id)
        {
            return _context.DiaryEntry_Cs.Any(e => e.Id == id);
        }

    }
}
