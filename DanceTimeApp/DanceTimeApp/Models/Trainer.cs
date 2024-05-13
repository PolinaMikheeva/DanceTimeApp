using System.ComponentModel.DataAnnotations;

namespace DanceTimeApp.Models;

public class Trainer
{
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// Имя тренера
    /// </summary>
    public string Name { get; set; } = null!;
    /// <summary>
    /// Направление, которое ведет тренер
    /// </summary>
    //public string Direction { get; set; } = null!;
    public string DirectionName { get; set; } = null!;
    public Direction Direction { get; set; } = null!;
    /// <summary>
    /// Опыт работы
    /// </summary>
    public int Experience { get; set; }
    
    public List<Comment> Comments { get; set; } = null!;
    public List<Schedule> Schedules { get; set; } = null!;
}