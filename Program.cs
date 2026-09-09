using System;
using Newtonsoft.Json;

namespace TestReachability.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iniciando execucao do teste de Reachability...");
            ExecuteVulnerableCall();
        }

        public static void ExecuteVulnerableCall()
        {
            var payload = "{\"Name\":\"TestUser\",\"Active\":true}";
            var result = JsonConvert.DeserializeObject<UserData>(payload);
            Console.WriteLine($"Processado: {result?.Name}");
        }
    }

    public class UserData
    {
        public string Name { get; set; } = string.Empty;
        public bool Active { get; set; }
    }
}
