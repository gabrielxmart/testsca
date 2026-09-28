using System;
using Newtonsoft.Json;

namespace TestReachability.App;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Iniciando teste de policy gate do Sonatype IQ...");
        ExecuteJsonCall();
    }

    private static void ExecuteJsonCall()
    {
        const string payload = "{\"Name\":\"TestUser\",\"Active\":true}";
        var result = JsonConvert.DeserializeObject<UserData>(payload);
        Console.WriteLine($"Processado: {result?.Name}");
    }
}

public sealed class UserData
{
    public string Name { get; set; } = string.Empty;
    public bool Active { get; set; }
}
