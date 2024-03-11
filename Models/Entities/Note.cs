namespace CRUD_OPERATIONS.Models.Entities
{
    public class Note
    {
        public Guid Id { get; set; } //Unique identify for note
        public string Title { get; set; } //title for note
        public string Description { get; set; } //lonf text for note
        public bool IsVisible { get; set; } //visiblity for note client


    }
}
