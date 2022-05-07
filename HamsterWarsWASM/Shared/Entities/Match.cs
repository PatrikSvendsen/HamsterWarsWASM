using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HamsterWarsWASM.Shared.Entities;

/// <summary>
/// Class for modelen Match
/// </summary>
public class Match
{
    [Key]
    [Column("MatchId")]
    public int Id { get; set; }
    public int WinnerId { get; set; }
    public int LoserId { get; set; }
    public bool Deleted { get; set; } = false;

    public ICollection<Hamster>? Hamsters { get; set; } 
}
