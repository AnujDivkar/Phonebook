namespace Phonebook.Models;

public class Contact
{
    public Contact()
    {
        Id = 0;
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        Mobile = string.Empty;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
}