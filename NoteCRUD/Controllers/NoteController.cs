using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoteCRUD.Services;

namespace NoteCRUD.Controllers
{   
    [ApiController]
    [Route("api/note")]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _service;

        public NoteController(INoteService service) 
        {
            this._service = service;
        }

        [HttpGet("{listId}")]
        public async Task<IActionResult> GetNotes(Guid listId)
        {
            var result = await _service.GetNotes(listId);
            return Ok(result);
        }
    }
}