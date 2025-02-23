using ConsoleApp3;

public class Program
{
    static void Main(string[] args)
    {

        string[] arguments = { "Sardor", "Muhammadbek", "Aziz" };
        string[] arguments2 = { "150$", "250$", "350.000$ (For Porsche GT3 RS)" };
        Main2(arguments, arguments2);

    }


    public static void Main2(string[] names, string[] arguments2)
    {
        int res = 0;
        foreach (string name in names)
        {
            Console.WriteLine(name + " " + arguments2[res]);
            res++;
        }
    }
}
