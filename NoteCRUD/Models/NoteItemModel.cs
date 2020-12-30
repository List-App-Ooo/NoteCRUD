namespace NoteCRUD.Models
{
    public class NoteItemModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public DateTime TimeStamp { get; set; }
        public Guid NoteListId { get; set; }
    }
}