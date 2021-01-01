using System;
using System.Collections.Generic;
using System.Linq;
using NoteCRUD.Models;

namespace NoteCRUD.Data
{
    public static class DbInitializer
    {
        public static void Initialize(NoteContext context)
        {
            context.Database.EnsureCreated();

            if (context.Notes.Any())
            {
                return;
            }

            var notes = new List<NoteItemModel>();
            Guid listId = new Guid();

            notes.Add(
                new NoteItemModel()
                {
                    Id = new Guid(),
                    Title = "This is note #1",
                    Desc = "Note #1 is about a vaction",
                    TimeStamp = DateTime.Now,
                    ListId = listId
                }
            );

            notes.Add(
                new NoteItemModel()
                {
                    Id = new Guid(),
                    Title = "This is note #2",
                    Desc = "Note #2 is about a business idea",
                    TimeStamp = DateTime.Now,
                    ListId = listId
                }
            );

            notes.Add(
                new NoteItemModel()
                {
                    Id = new Guid(),
                    Title = "This is note #3",
                    Desc = "Note #3 is about school work",
                    TimeStamp = DateTime.Now,
                    ListId = listId
                }
            );

            context.Notes.AddRange(notes);
            context.SaveChanges();
        }
    }
}