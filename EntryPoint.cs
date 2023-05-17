using System;
using Engine;
using College.Persons;
using College.Journals;
using App.UI;

namespace App;

/// <summary>
/// Application entry point
/// </summary>
public partial class Controller {
    public static IScene? Scene;
        
    public new static void Initialize() {
        Scene = new SceneExamine();
        Scene.Initialize(); // Why not?

        // test
        /*
        var hum1 = new Student(new DateTime(2000, 01, 01), "d", "a", ESex.Male);
        var hum2 = new Student(new DateTime(1999, 01, 01), "s", "g", ESex.Male);
        // make teacher
        var teach = new Teacher(new DateTime(1843, 01, 01), "Geniout", "Danimed", ESex.Trans);
        // make admin
        var admin = new Administrator(new DateTime(2000, 01, 01), "j", "j", ESex.Male);
        admin.AddWorker(hum1);
        // so, next - we put info about all students from journal
        var _list = Journal.GetHumans<Student>();
        foreach (var item in _list) {
            Console.Write(item.Role + " ");
            Console.WriteLine(item.FirstName + " " + item.SecondName);
        }
        // small print
        Console.WriteLine();
        Console.WriteLine(Journal.GetHumans<Teacher>()[0].Role);
        // mention if programm ended
        Console.WriteLine("Work i sdon!  Rly");
        Console.ReadKey();
        */

        //TODO: Сделать возможность копирования из Human для Studeable обьектов
    }
     // Main game process - physics, movement and some.
    public new static void Update() {
        Scene?.Update();
    }
     // Main renderer method for drawing screen buffer
    public new static void Render() {
        Scene?.Render();
    }
     // Input listeneer
    public new static void KeyHandle(ConsoleKeyInfo input) {
        Scene?.KeyHandle(input);
        
        if (input.Key == ConsoleKey.Escape) {
            LifeStage = LifeStage.Exit;
        }
    }
}
