using System.Runtime;
using College.Journals;

namespace College.Persons;

/// <summary>
/// Boss, or more important role
/// </summary>
public class Administrator: Studeble {
    public float Expirience {get; set;}

    public Administrator(DateTime Birthday,
                string FirstName = "Max", 
                string SecondName = "Leather", 
                ESex Sex = ESex.Trans) : 
                base(Birthday, FirstName, SecondName, Sex, ERoles.Administrator) {
        // TODO:
    }

    // Add worker on job
    public void AddWorker(Human hum) {
        Journal.Add(hum);
    }
    // Remove worker from job
    public void RemoveWorker(Human hum) {
        Journal.Remove(hum);
    }
    public void RemoveWorker(string FirstName, string SecondName) {
        Journal.Remove(FirstName, SecondName);
    }
}