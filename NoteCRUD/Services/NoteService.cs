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

        public Task<NoteModel> GetNote(Guid id)
        {
            return _repo.GetNoteItem(id);
        }

        public Task<List<NoteModel>> GetNotes(Guid listId)
        {
            return _repo.GetNoteItems(listId);
        }

        public async Task<int> GetTotal(Guid listId)
        {
            return await _repo.GetTotal(listId);
        }
        
        public async Task<NoteModel> CreateNote(NoteModel note)
        {
            var newNote = new NoteModel {
                Id = Guid.NewGuid(),
                Title = note.Title,
                Desc = note.Desc,
                IsComplete = note.IsComplete,
                TimeStamp = DateTime.Now,
                ListId = note.ListId
            };

            return await _NoteRepo.CreateNote(newNote);
        }
    }
}