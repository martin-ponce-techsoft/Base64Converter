using Spectre.Console;

while (true)
{
    var fruit = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("What's your [green]favorite fruit[/]?")
        .PageSize(5)
        .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
        .AddChoices(new[] {
            "Apple", "Apricot", "Avocado",
            "Banana", "Blackcurrant", "Blueberry",
            "Cherry", "Cloudberry", "Cocunut", "wola", "hola", "hello", "hej", "hallå",
        }));
    Console.WriteLine("Enter a string to encode in Base64:");
    var value = Console.ReadLine();
    if (!string.IsNullOrEmpty(value))
    {
        var bytes = System.Text.Encoding.UTF8.GetBytes(value);
        var base64 = Convert.ToBase64String(bytes);
        Console.WriteLine($"Base64 encoded: {base64}");
    }
    else
    {
        Console.WriteLine("No input provided.");
    }
    Console.WriteLine();
}