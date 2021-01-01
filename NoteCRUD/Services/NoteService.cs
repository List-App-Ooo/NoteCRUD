using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NoteCRUD.Data;
using NoteCRUD.Models;

namespace NoteCRUD.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepo _repo;

        public NoteService(INoteRepo repo)
        {
            this._repo = repo;
        }

        public Task<List<NoteItemModel>> GetNotes(Guid listId)
        {
            return _repo.GetNoteItems(listId);
        }

        public async Task<int> GetNoteTotal(Guid listId)
        {
            return await _repo.GetTotal(listId);
        }
    }
}