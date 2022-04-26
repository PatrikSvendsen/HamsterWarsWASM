﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HamsterWarsWASM.Shared.Entities;

public class HamsterMatch
{
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Hamster))]
    public int HamsterId { get; set; }

    [ForeignKey(nameof(Match))]
    public int MatchId { get; set; }
}