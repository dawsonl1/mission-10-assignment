using System.ComponentModel.DataAnnotations;

namespace backend.data;

public class Team
{
    [Key]
    public int TeamID { get; set; }
    public required string TeamName { get; set; }
}