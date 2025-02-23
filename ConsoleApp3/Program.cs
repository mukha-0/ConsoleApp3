int yigindi(int x)
{
    if (100 > x || x > 999)
    {
        int yuz = x / 100;
        int on = x % 100 / 10;
        int bir = x % 100 % 10 / 1;
        return yuz + on + bir;
    }
}

Console.WriteLine("Son: ");
string input = Console.ReadLine();
var natija = int.Parse(input);
Console.WriteLine(yigindi(natija));
