namespace LibraryManagementSystem.Application.Models;

public abstract class Base
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } =  DateTime.Now;
}