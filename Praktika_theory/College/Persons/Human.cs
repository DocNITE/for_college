using System.Runtime;

namespace College.Persons;

public enum ESex {
    Trans = 0, // NonBinary
    Male = 1,
    Female = 2
}

/// <summary>
/// Base human instance
/// </summary>
public class Human {
    public string FirstName {get; set;}
    public string SecondName {get; set;}
    public ESex Sex {get; set;}
    public DateTime Birthday {get; set;}

    public Human(DateTime Birthday,
                string FirstName = "Georgio", 
                string SecondName = "Stashkov", 
                ESex Sex = ESex.Trans) {
        this.FirstName = FirstName;
        this.SecondName = SecondName;
        this.Sex = Sex;
        this.Birthday = Birthday;
    }

    public bool IsCanWork() {
        return true;
    }
}