using Microsoft.EntityFrameworkCore;

namespace DanceTimeApp.Models;

public class AppDbContext : DbContext
{
    public DbSet<Trainer> Trainers { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Schedule> Schedules { get; set; } = null!;
    public DbSet<Records> Records { get; set; } = null!;
    public DbSet<Comment> Comments { get; set; } = null!;
    public DbSet<Direction> Directions { get; set; } = null!;

    public AppDbContext()
    {
        
    }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        //Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasAlternateKey(u => u.Nickname);
        modelBuilder.Entity<Records>()
            .HasOne(p => p.User)
            .WithMany(t => t.Records)
            .HasForeignKey(p => p.UserNickname)
            .HasPrincipalKey(t => t.Nickname);
        modelBuilder.Entity<Comment>()
            .HasOne(p => p.User)
            .WithMany(t => t.Comments)
            .HasForeignKey(p => p.UserNickname)
            .HasPrincipalKey(t => t.Nickname);
        modelBuilder.Entity<Comment>()
            .HasOne(p => p.Trainer)
            .WithMany(t => t.Comments)
            .HasForeignKey(p => p.TrainerName)
            .HasPrincipalKey(t => t.Name);
        modelBuilder.Entity<Schedule>()
            .HasOne(p => p.Trainer)
            .WithMany(t => t.Schedules)
            .HasForeignKey(p => p.TrainerName)
            .HasPrincipalKey(t => t.Name)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Schedule>()
            .HasOne(p => p.Direction)
            .WithMany(t => t.Schedules)
            .HasForeignKey(p => p.DirectionName)
            .HasPrincipalKey(t => t.Name)
            .OnDelete(DeleteBehavior.Restrict);;
        modelBuilder.Entity<Trainer>()
            .HasOne(p => p.Direction)
            .WithMany(t => t.Trainers)
            .HasForeignKey(p => p.DirectionName)
            .HasPrincipalKey(t => t.Name);
    }
}