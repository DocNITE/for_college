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
    }
     // Main process - physics, movement and some.
    public new static void Process() {
        Scene?.Update();
        Scene?.Render();
    }
}
