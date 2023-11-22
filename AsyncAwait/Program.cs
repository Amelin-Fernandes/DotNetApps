
await SimpleTask(); //will execute independently

File.WriteAllText(@"SomeFile.txt", "blah blah blah"); //the file class autocloses the file; internally uses stream of data packets
string contents = await ReadFile();
Console.WriteLine(contents);

async Task SimpleTask()
{
    Console.WriteLine("Starting of the task");
    await Task.Delay(2000);  //force a delay
    Console.WriteLine("Task Complete");
}

async Task<string> ReadFile()
{
    using (StreamReader r = new StreamReader(@"SomeFile.txt"))
    {
        return await r.ReadToEndAsync();
    }
}