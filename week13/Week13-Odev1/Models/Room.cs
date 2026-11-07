namespace Week13_Odev1.Models;

public class Room
{
    public int Id { get; set; }

    public string RoomNumber { get; set; } = string.Empty;

    public int Floor { get; set; }

    public bool IsAvailable { get; set; }

    public string ImageUrl { get; set; } = string.Empty;

    public int RoomTypeId { get; set; }

    public RoomType RoomType { get; set; } = null!;
}