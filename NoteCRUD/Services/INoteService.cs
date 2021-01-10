using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NoteCRUD.Models;

namespace NoteCRUD.Services
{
    public interface INoteService
    {
        Task<NoteModel> GetNote(Guid id);
        Task<List<NoteModel>> GetNotes(Guid listId);
        Task<int> GetNoteTotal(Guid listId);
    }
}