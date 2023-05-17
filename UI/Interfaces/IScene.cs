namespace App.UI;

/// <summary>
/// Base UI Scene-screen interface
/// </summary>
public interface IScene {
    public virtual void Initialize() {}
    public virtual void Update() {}
    public virtual void Render() {}
    public virtual void KeyHandle(ConsoleKeyInfo input) {}
    public virtual void Dispose() {}
}