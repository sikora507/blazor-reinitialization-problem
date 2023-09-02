namespace BlazorDomainObjectEditor;

public record Label(string Value);

public class Client
{
    private readonly List<Label> _labels = new();

    public string Id { get; }
    public string Name { get; }
    public IReadOnlyCollection<Label> Labels => _labels.AsReadOnly();

    public Client(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public void AddLabel(Label label)
    {
        _labels.Add(label);
    }
    
    private Client() // ef core
    {
        
    }
}