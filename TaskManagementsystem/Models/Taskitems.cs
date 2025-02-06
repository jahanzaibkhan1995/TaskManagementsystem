using System;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime? DueDate { get; set; }
    public string Status { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsCompleted { get; internal set; }
}

