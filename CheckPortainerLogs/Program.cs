// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string dockeApiEndpoint = string.Empty;
string containerName = string.Empty;
string logsendpoint = $"{dockeApiEndpoint}/cotainers/{containerName}/logs";

async Task<bool> GetHttpResponse()
{
    try
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(dockeApiEndpoint);
        string logs = await response.Content.ReadAsStringAsync();
        Console.WriteLine(logs);
    }
    catch(Exception ex)
    {
        await Console.Out.WriteLineAsync(ex.Message);
    }

    return true;
}