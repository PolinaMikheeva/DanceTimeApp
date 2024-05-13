using System.ComponentModel.DataAnnotations;

namespace DanceTimeApp.Models;

public class Records
{
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// Никнейм пользователя, который записан на тренировку
    /// </summary>
    public string UserNickname { get; set; } = null!;
    public User User { get; set; } = null!;
    /// <summary>
    /// Название занятия
    /// </summary>
    public string ScheduleName { get; set; } = null!;
    public Schedule Schedule { get; set; } = null!;
}