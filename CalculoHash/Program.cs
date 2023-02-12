using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;


var tempo = new Stopwatch();
tempo.Start();

var texto = "Criar uma chave a partir deste texto que inclui a demo do VS Summit";
var hash = ComputeSha256Hash(texto);
tempo.Stop();
Console.WriteLine($"Tempo para criar um hash de '{texto}' = {tempo.ElapsedMilliseconds} ms.");
Console.ReadLine();

static string ComputeSha256Hash(string rawData)
{
    // Create a SHA256   
    using (SHA256 sha256Hash = SHA256.Create())
    {
        // ComputeHash - returns byte array  
        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

        // Convert byte array to a string   
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < bytes.Length; i++)
        {
            builder.Append(bytes[i].ToString("x2"));
        }
        return builder.ToString();
    }
}