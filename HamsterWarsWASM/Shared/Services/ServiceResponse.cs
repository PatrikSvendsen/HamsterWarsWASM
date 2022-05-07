namespace HamsterWarsWASM.Shared.Service;

/// <summary>
/// Denna model är mest gjord för att förenkla felmeddelanden på hemsidan, undvika massa error kod etc.
/// </summary>
/// <typeparam name="T">T är class</typeparam>
public class ServiceResponse<T>
{
    public T? Data { get; set; }
    public bool Success { get; set; } = true;
    public string Message { get; set; } = string.Empty;
}
