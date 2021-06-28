using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NoteCRUD.Models;

namespace NoteCRUD.Data
{
    public interface INoteRepo
    {
        Task<NoteModel> GetNoteItem(Guid id);
        Task<List<NoteModel>> GetNoteItems(Guid listId);
        Task<int> GetTotal(Guid listId);
        Task<NoteModel> CreateNote(NoteModel note);
        void DeleteNote(Guid id);
    }
}