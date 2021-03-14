# Design Patterns: Null-Object
Well, let's start from the beginning! Sir Tony Hoare is who created the null reference, in 1965. Unitl now, Null checks is completly a requirement when we develop something.

### Normal Situation
It is usually that we very commom we see null checks, like this:
```rb
public void CreateClient(IClient client)
{
    if (client == null) throw new NullReferenceException();
    if (client.Name == null) throw new NullReferenceException();

    // ... do something
}
```

But, what if you could guarantee that the object was never null?

For this, watch below:

### Null Object Pattern
First, we need to define a default object:

```rb
public class NullClient : IClient
{
  public int Id => 0;

  public string Name => "Non-client";

  public int Age => 0;
}
```
Watch that our class inheritance of the *IClient* interface.

When we do it, we just make this verify:

```rb
static void Main(string[] args)
{
    IClient client = new Client();

    var clientService = new ClientService();

    if (client == null)
    	client = new NullClient();

    clientService.CreateClient(client);
}
```

And when we do the create method, we do not need to verify the object and the name, because we guarantee that the object never is null.