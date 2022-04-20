namespace HamsterWarsWASM.Shared.Entities.DTO;

public class NewHamsterDTO
{
    public int HamsterId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string FavFood { get; set; } = string.Empty;
    public string Loves { get; set; } = string.Empty;
    public string ImgName { get; set; } = string.Empty;
}
