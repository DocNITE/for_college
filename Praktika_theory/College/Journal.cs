using College.Persons;

namespace College.Journals;

public partial class Journal {
    private readonly static List<Human> _list = new();

    public static void Add(Human hum) {
        if (_list.Contains(hum))
            return;

        _list.Add(hum);
    }
    public static void Remove(Human hum) {
        if (!_list.Contains(hum))
            return;

        _list.Remove(hum);
    }
    public static void Remove(string fname, string sname) {
        for(int i = 0; i < _list.Count; i++) {
            if (_list[i].FirstName == fname && _list[i].SecondName == sname) {
                _list.RemoveAt(i);
                break;
            }
        }
    }
}