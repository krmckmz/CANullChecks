string? info = null;
SayHi(info);

void SayHi(string message)
{
    //C# 9
    //if (message is null)
    //    throw new ArgumentNullException(nameof(message));

    //C# 10
    ArgumentNullException.ThrowIfNull(message);

    Console.WriteLine(value: $"Hello {message}");
}