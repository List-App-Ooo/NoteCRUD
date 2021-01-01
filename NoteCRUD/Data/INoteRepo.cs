using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NoteCRUD.Models;

namespace NoteCRUD.Data
{
    public interface INoteRepo
    {
        Task<List<NoteItemModel>> GetNoteItems(Guid listId);
        Task<int> GetTotal(Guid listId);
    }
}