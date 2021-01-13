using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoteCRUD.Models;
using NoteCRUD.Services;

namespace NoteCRUD.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _service;

        public NoteController(INoteService service) 
        {
            this._service = service;
        }

        [HttpGet("{id}", Name="GetNote")]
        public async Task<IActionResult> GetNote(Guid id)
        {
            var result = await _service.GetNote(id);
            return Ok(result);
        }

        [HttpGet("list/{listId}")]
        public async Task<IActionResult> GetNotes(Guid listId)
        {
            var result = await _service.GetNotes(listId);
            return Ok(result);
        }
        [HttpGet("total/{listId}")]
        public async Task<IActionResult> GetTotal(Guid listId)
        {
            var result = await _service.GetTotal(listId);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateNote(NoteModel note)
        {
            if (note is null) return BadRequest();
            var result = await _service.CreateNote(note);
            return CreatedAtRoute(nameof(GetNote), new { Id = result.Id }, result);
        }
    }
}