using College.Persons;

namespace College.Journals;

public partial class Journal {
    public static List<T> GetHumans<T>() {
        var list = new List<T>();
        foreach (var item in _list)
        {
            if(item.GetType() == typeof(T))
                list.Add((T)Convert.ChangeType(item, typeof(T))); //list.Add((T)item);
        }
        return list;
    }
}