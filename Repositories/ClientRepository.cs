namespace BlazorDomainObjectEditor.Repositories;

public interface IClientRepository
{
    Client? GetClientById(string id);
}

public class ClientRepository : IClientRepository
{
    private readonly List<Client> _clients = new();
    public ClientRepository()
    {
        var client = new Client("tomasz","Tomasz");
        client.AddLabel(new Label("Blazor"));
        client.AddLabel(new Label("Dotnet8"));

        _clients.Add(client);
        
        var client2 = new Client("agata", "Agata");
        client2.AddLabel(new Label("c#"));
        client2.AddLabel(new Label("Microsoft"));
        
        _clients.Add(client2);
    }

    public Client? GetClientById(string id)
    {
        return _clients.FirstOrDefault(x => x.Id == id);
    }
}