namespace UserDatabase.Core.Models;

public class User : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public ICollection<PhoneNumber> PhoneNumbers { get; set; }
    public ICollection<Address> Addresses { get; set; }
    public User? Spouse { get; set; }
    public bool IsEdited { get; set; } = false;
}