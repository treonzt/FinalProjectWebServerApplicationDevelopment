using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace FinalProject_TreonZT.Models;
public class Game
{

    public int? GameId { get; set; }
    public string Against { get; set; }
    public string? Position { get; set; }
    public int? HomeScore { get; set; }
    public int? AwayScore { get; set; }
    public string? Outcome { get; set; }
    public int? Goals { get; set; }
    public int? Assists { get; set; }
}
    
