using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.data;

public class Bowler
{
    [Key]
    public int BowlerID { get; set; }
    public required string BowlerFirstName { get; set; }
    public string? BowlerMiddleInit { get; set; }
    public required string BowlerLastName { get; set; }
    public required string BowlerAddress { get; set; }
    public required string BowlerCity { get; set; }
    public required string BowlerState { get; set; }
    public required int BowlerZip { get; set; }
    public required string BowlerPhoneNumber { get; set; }
    
    public required int TeamID { get; set; }
    
    [ForeignKey("TeamID")]
    public Team? Team { get; set; }
}