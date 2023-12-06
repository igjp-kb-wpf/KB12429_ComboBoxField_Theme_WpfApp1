using KB12429_WpfApp1.Infrastructure;

namespace KB12429_WpfApp1.Model;
internal class Person : ObservableObject
{
    private String _name = String.Empty;
    public String Name
    {
        get { return _name; }
        set { _name = value; OnPropertyChanged(); }
    }

    private String _prefectureCode = String.Empty;
    public String PrefectureCode
    {
        get { return _prefectureCode; }
        set { _prefectureCode = value; OnPropertyChanged(); }
    }

    private String _description = String.Empty;
    public String Description
    {
        get { return _description; }
        set { _description = value; OnPropertyChanged(); }
    }

    public Person()
    {
    }
}
