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
        Task<int> GetTotal(Guid listId);
        Task<NoteModel> CreateNote(NoteModel note);
    }
}