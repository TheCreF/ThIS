namespace ThISDesktopUI.Library.Models
{
    public interface ISeasonItemModel
    {
        int Id { get; set; }
        int Order { get; set; }
        string SeasonName { get; set; }
        string SeasonShortName { get; set; }
        int? IsCurrent { get; set; }
    }
}