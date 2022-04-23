using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HamsterWarsWASM.Shared.Entities;

public class Hamster
{
    [Key]
    [Column("HamsterId")]
    public int Id { get; set; }
    [Required(ErrorMessage = "This field is required")]
    [MaxLength(20)]
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    [MaxLength(20)]
    public string FavFood { get; set; } = string.Empty;
    [MaxLength(20)]
    public string Loves { get; set; } = string.Empty;
    public string ImgName { get; set; } = string.Empty;
    public int Wins { get; set; } = 0;
    public int Defeats { get; set; } = 0;
    public int Games { get; set; } = 0;
    public bool Deleted { get; set; } = false;
    [NotMapped]
    public bool IsNew { get; set; } = false;
    [NotMapped]
    public bool Editing { get; set; } = false;
}
