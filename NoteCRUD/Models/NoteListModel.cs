namespace NoteCRUD.Models
{
    public class NoteListModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int TotalItems { get; set; }
        public List<NoteItemModel> Items { get; set; }
    }
}