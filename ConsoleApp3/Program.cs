void minutsekundqilish(int n)
{
    int hours = n / 3600;
    int minutes = (n % 3600) / 60;

    Console.WriteLine($"{hours} soat {minutes} minut");
}

Console.WriteLine("Son: ");
string? input = Console.ReadLine();
var seconds = int.Parse(input);
minutsekundqilish(seconds);
