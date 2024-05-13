using System.ComponentModel.DataAnnotations;

namespace DanceTimeApp.Models;

public class Comment
{
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// Пользователь, который оставил коммент
    /// </summary>
    public string UserNickname { get; set; } = null!;
    public User User { get; set; } = null!;
    /// <summary>
    /// Тренер, про которого написан отзыв
    /// </summary>
    public string TrainerName { get; set; } = null!;
    public Trainer Trainer { get; set; } = null!;
    /// <summary>
    /// Отзыв
    /// </summary>
    public string Description { get; set; } = null!;
}