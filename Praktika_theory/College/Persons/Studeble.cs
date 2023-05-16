using System.Runtime;
using College.Journals;

namespace College.Persons;

public enum ERoles {
    Loh = 0, // Default
    Student = 1,
    Teacher = 2,
    Administrator = 16
}

/// <summary>
/// Layer implementation, for automatic insert workers into journal and some shi
/// </summary>
public class Studeble: Human {
    public ERoles Role {get; set;}
    public Studeble(DateTime Birthday,
                string FirstName, 
                string SecondName, 
                ESex Sex,
                ERoles Role) : 
                base(Birthday, FirstName, SecondName, Sex) {
        // Markup out human with role
        this.Role = Role;
        // Add worker into journal
        Journal.Add(this);
    }
}