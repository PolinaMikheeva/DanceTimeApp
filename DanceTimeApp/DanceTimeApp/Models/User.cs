using System.ComponentModel.DataAnnotations;

namespace DanceTimeApp.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string Name { get; set; } = null!;
    /// <summary>
    /// Никнейм пользователя
    /// </summary>
    public string Nickname { get; set; } = null!;
    /// <summary>
    /// Роли пользователя
    /// </summary>
    public string Role { get; set; }
    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; } = null!;

    public List<Records> Records { get; set; } = null!;
    public List<Comment> Comments { get; set; } = null!;
}