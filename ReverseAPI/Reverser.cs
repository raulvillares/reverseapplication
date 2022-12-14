namespace ReverseApp;

public class Reverser
{
    public string Reverse(string? text)
    {
        return !string.IsNullOrEmpty(text) ? new string(text.Reverse().ToArray()) : string.Empty;
    }
}