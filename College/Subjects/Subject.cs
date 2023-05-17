namespace College.Subjects;

public class Subject {
    private float _score;

    public float Score {
        get {return _score;} 
        set {
            _score = Math.Clamp(value, 0, 100);
        }
    }
}