using System.ComponentModel.DataAnnotations;

namespace DanceTimeApp.Models;

public class Schedule
{
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// Направление танца
    /// </summary>
    public string DirectionName { get; set; } = null!;
    public Direction Direction { get; set; } = null!;
    /// <summary>
    /// День занятия
    /// </summary>
    public string Day { get; set; } = null!;
    /// <summary>
    /// Время тренировки
    /// </summary>
    public TimeSpan Time { get; set; }
    
    /// <summary>
    /// Тренер, который ведет данное направление
    /// </summary>
    
    public string TrainerName { get; set; } = null!;
    public Trainer Trainer { get; set; } = null!;
}