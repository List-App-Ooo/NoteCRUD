using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNotes(Guid id)
        {
            var result = await _service.GetNotes(id);
            return Ok(result);
        }
    }
}