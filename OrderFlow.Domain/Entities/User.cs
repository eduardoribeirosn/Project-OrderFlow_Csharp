namespace OrderFlow.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public User() { }

    public User(string name, string email)
    {
        this.Id = Guid.NewGuid();
        this.Name = name;
        this.Email = email;
        this.CreatedAt = DateTime.UtcNow;
    }
}