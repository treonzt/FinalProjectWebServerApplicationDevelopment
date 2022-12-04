using Microsoft.EntityFrameworkCore;
namespace FinalProject_TreonZT.Models
{
    public class GameContext : DbContext
    {
  

        public GameContext(DbContextOptions<GameContext> options)
    : base(options) => ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;


        public DbSet<Game> Games { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().HasData(
                   new Game
                   {
                       GameId = 1,
                       
                       Position = "Center",
                       Against = "Chaos Delta",
                       HomeScore = 2,
                       AwayScore = 3,
                       Outcome = "Loss",
                       Goals = 1,
                       Assists = 0
                   },
                  new Game
                  {
                      GameId = 2,
                      
            Against = "Brewmasters",
                      Position = "Center",
                      HomeScore = 2,
                      AwayScore = 4,
                      Outcome = "Loss",
                      Goals = 0,
                      Assists = 0
                  }


                   ); 

               }
    }
}