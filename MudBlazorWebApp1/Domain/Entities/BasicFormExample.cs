namespace MudBlazorWebApp1.Domain.Entities;

public class BasicFormExample
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public string Title { get; set; }
    public string AuthorUrl { get; set; } = string.Empty;
}
