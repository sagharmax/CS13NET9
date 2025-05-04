HttpClient client = new();
HttpResponseMessage response = await client.GetAsync("https://www.microsoft.com/");
Console.WriteLine($"Microsoft's homepage has {response.Content.Headers.ContentLength} bytes.");
