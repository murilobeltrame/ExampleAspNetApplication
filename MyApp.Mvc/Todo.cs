public class Todo {
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool Finished { get; set; } = false;
    public DateTime? DueDate { get; set; }
}