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

        public async Task<List<NoteItemModel>> GetNoteItems(Guid listId)
        {
            var query = _context.Notes.Where(m => m.ListId == listId).OrderBy(d => d.TimeStamp);
            return await query.ToListAsync<NoteItemModel>();
        }

        public Task<int> GetTotal(Guid postId)
        {
            throw new NotImplementedException();
        }
    }
}