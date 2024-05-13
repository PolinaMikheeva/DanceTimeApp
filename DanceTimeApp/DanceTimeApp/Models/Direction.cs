using System.ComponentModel.DataAnnotations;

namespace DanceTimeApp.Models;

public class Direction
{
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// Название направления
    /// </summary>
    public string Name { get; set; } = null!;
    
    public List<Trainer> Trainers { get; set; } = null!;
    public List<Schedule> Schedules { get; set; } = null!;
}