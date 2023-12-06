using KB12429_WpfApp1.Infrastructure;

namespace KB12429_WpfApp1.Model;
internal class Prefecture : ObservableObject
{
    private String _prefectureCode = String.Empty;
    public String PrefectureCode
    {
        get { return _prefectureCode; }
        set { _prefectureCode = value; OnPropertyChanged(); }
    }

    private String _prefectureName = String.Empty;
    public String PrefectureName
    {
        get { return _prefectureName; }
        set { _prefectureName = value; OnPropertyChanged(); }
    }

    public Prefecture()
    {
    }
}
