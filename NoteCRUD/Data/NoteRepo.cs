using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NoteCRUD.Models;

namespace NoteCRUD.Data
{
    public class NoteRepo : INoteRepo
    {
        private readonly NoteContext _context;

        public NoteRepo(NoteContext context)
        {
            this._context = context;
        }

        public async Task<NoteModel> GetNoteItem(Guid id)
        {
            return await _context.Notes.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<List<NoteModel>> GetNoteItems(Guid listId)
        {
            var query = _context.Notes.Where(m => m.ListId == listId).OrderBy(d => d.TimeStamp);
            return await query.ToListAsync<NoteModel>();
        }

        public async Task<int> GetTotal(Guid listId)
        {
            return await _context.Notes.CountAsync(m => m.ListId == listId);
        }
    }
}