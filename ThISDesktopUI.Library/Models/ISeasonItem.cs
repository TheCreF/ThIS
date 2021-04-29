namespace ThISDesktopUI.Library.Models
{
    public interface ISeasonItem
    {
        int ID { get; set; }
        int OrderNumb { get; set; }
        string SeaasonFullName { get; set; }
        string SeasonShortName { get; set; }
    }
}