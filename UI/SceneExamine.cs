using System;
using Engine;
using Engine.UI;
using College.Persons;
using College.Journals;
using App.UI;
using College.Subjects;

namespace App.UI;

/// <summary>
/// Theory 1: Make exam. students. and other on the list
/// </summary>
public class SceneExamine: IScene {
    private ListView ExList = new ListView(4, 4, 1);

    string[] genNames = new[] {"Jordan", "Gordan", "Milenium", "Petr", "Daniel", "Pivo", "Johnm", "Chel", "CHUVVVAAAAK", "Aman"};
    string[] genSubNames = new[] {"Westwood", "Pivood", "Machinium", "V2", "V1", "Anekdotovich", "hero-hero", "Teodorus", "Mure-Meorw", "Bleh"};

    public void Initialize() {
        Random rnd = new Random();
        // make admins 
        var admin = new Administrator(new DateTime());
        AddInList(admin);
        // make teachers
        for (int i = 0; i < 3; i++) {
            var teach = new Teacher(new DateTime(), genNames[rnd.Next(genNames.Length)], genSubNames[rnd.Next(genSubNames.Length)]);
            AddInList(teach);
        }
        // gen lesson subjects
        List<Subject> sbjcts = new() {
            new AlgebraSubject() {Score = rnd.Next(100)}, 
            new BiologySubject() {Score = rnd.Next(100)},
            new ChimestrySubject() {Score = rnd.Next(100)}, 
            new GeographySubject() {Score = rnd.Next(100)}, 
            new GeomentySubject() {Score = rnd.Next(100)},
            new HistorySubject() {Score = rnd.Next(100)},
            new LiteratureSubject() {Score = rnd.Next(100)}
        };
        // make students
        for (int i = 0; i < 6; i++) {
            var stud = new Student(new DateTime(), genNames[rnd.Next(genNames.Length)], genSubNames[rnd.Next(genSubNames.Length)]);
            stud.Expiriences = sbjcts;
            AddInList(stud);
        }
        // Restire UI
        ExList.SetVisible(true);
        ExList.Restore();
    }
    public void Update() {

    }
    public void Render() {
        ExList.Draw();

        // App info
        Screen.SetText(35, 100, "Скролить - ^, v, >, <");
        Screen.SetText(36, 100, "Выбрать/Подтвердить - Enter");
    }   
    //public void KeyHandle(ConsoleKeyInfo input) {
    //    ExList.KeyPressed(input.Key);
    //}
    public void Dispose() {

    }

    private void AddInList(Studeble man) {
        var btn = new ListButton(0, 0, man.GetType().Name + " | " + man.FirstName + " " + man.SecondName);
        ExList.items.Add(btn);
    }
}