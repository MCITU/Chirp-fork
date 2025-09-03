List<string> cheeps = new() { "Hello, BDSA students!", "Welcome to the course!", "I hope you had a good summer.", "Cheeping cheeps on Chirp :)" };

foreach (var cheep in cheeps)
{
    Console.WriteLine(cheep);
    Thread.Sleep(1000);
}
