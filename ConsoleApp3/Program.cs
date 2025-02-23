using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Bankomatga hush kelibsiz !");
        Console.WriteLine();
        Console.Write("Kodni kiriting: ");
        int kod = 9232;
        double kartaBalansi = 15000000;
        int bankomatBalansi = 1000000000;
        int number = 997507128;
        int kod1 = int.Parse(Console.ReadLine());
        Console.Clear();
        if (kod == kod1)
        {
            while (true)
            {
                Console.WriteLine("Bo`limni tanlang");
                Console.WriteLine();
                Console.WriteLine("1. Pul olish");
                Console.WriteLine();
                Console.WriteLine("2. Karta balansi");
                Console.WriteLine();
                Console.WriteLine("3. Telefon raqamga sms xabarnoma ulash");
                Console.WriteLine();
                Console.WriteLine("4. Karta kodini o`zgartirish");
                Console.WriteLine();
                Console.WriteLine("5. Valyuta almashtirish");
                Console.WriteLine();
                Console.WriteLine("6. Chiqish");
                Console.WriteLine();
                Console.Write("Tanlang: ");
                int tanlang = int.Parse(Console.ReadLine());
                Console.Clear();
                if (tanlang == 1)
                {
                    Console.WriteLine("Pul miqdorini kiriting: ");
                    int pul = int.Parse(Console.ReadLine());
                    Console.Clear();

                    kartaBalansi = kartaBalansi - pul;
                    bankomatBalansi = bankomatBalansi - pul;
                    Console.WriteLine("Marxamat pulni olishingiz mumkun");
                    Console.WriteLine("Qoldiq balans: " + kartaBalansi);
                    Console.Clear();
                    Console.WriteLine("Boshqa amal bajarasizmi ?    1-Ha.  2-Yoq ");
                    int amal = int.Parse(Console.ReadLine());
                    if (amal == 1)
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (amal == 2)
                    {
                        Console.WriteLine("Xizmatdan foydalanish uchun rahmat !");
                        break;
                    }
                }
                else if (tanlang == 2)
                {
                    Console.WriteLine($"Balans: {kartaBalansi}");
                    Console.WriteLine("Boshqa amal bajarasizmi ?    1-Ha.  2-Yoq ");
                    int amal = int.Parse(Console.ReadLine());
                    if (amal == 1)
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (amal == 2)
                    {
                        Console.WriteLine("Xizmatdan foydalanish uchun rahmat !");
                        break;
                    }

                }
                else if (tanlang == 3)
                {
                    Console.Write("Yangi telefon raqamini kiriting: +998");
                    int raqam = int.Parse(Console.ReadLine());
                    number = raqam;
                    Console.WriteLine($"{number} ga Sms xabarnoma ulandi");
                    Console.WriteLine("Boshqa amal bajarasizmi ?    1-Ha.  2-Yoq ");
                    int amal = int.Parse(Console.ReadLine());
                    if (amal == 1)
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (amal == 2)
                    {
                        Console.WriteLine("Xizmatdan foydalanish uchun rahmat !");
                        break;
                    }

                }
                else if (tanlang == 4)
                {
                    Console.WriteLine("Yangi parol kiriting: ");
                    int kod2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    kod = kod2;
                    Console.WriteLine("Karta kodini o`zgartirish muvaffaqiyatli amalga oshirildi");
                    Console.WriteLine();
                    Console.WriteLine("Boshqa amal bajarasizmi ?   1-Ha.  2-Yoq ");
                    int amal = int.Parse(Console.ReadLine());
                    if (amal == 1)
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (amal == 2)
                    {
                        Console.WriteLine("Xizmatdan foydalanish uchun rahmat !");
                        break;
                    }
                }
                else if (tanlang == 5)
                {
                    Console.WriteLine("1. $ -> SUM");
                    Console.WriteLine("2. SUM -> $");
                    int valyuta = int.Parse(Console.ReadLine());
                    if (valyuta == 1)
                    {
                        Console.WriteLine("$ miqdorini kiriting: ");
                        double dollar = double.Parse(Console.ReadLine());
                        double sum = dollar * 12950;
                        Console.WriteLine($"Marxamat pulingnizni olishingiz mumkin ( {sum} )");
                        Console.WriteLine();
                        Console.WriteLine("Boshqa amal bajarasizmi ?   1-Ha.  2-Yoq ");
                        int amal = int.Parse(Console.ReadLine());
                        if (amal == 1)
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanish uchun rahmat !");
                            break;
                        }
                    }
                    else if (valyuta == 2)
                    {
                        Console.WriteLine("SUM miqdorini kiriting: ");
                        double sum = double.Parse(Console.ReadLine());
                        double dollar = sum / 12950;
                        Console.WriteLine($"Marxamat pulingnizni olishingiz mumkin ( {dollar} $)");
                        Console.WriteLine();
                        Console.WriteLine("Boshqa amal bajarasizmi ?   1-Ha.  2-Yoq ");
                        int amal = int.Parse(Console.ReadLine());
                        if (amal == 1)
                        {
                            Console.Clear();
                            continue;
                        }
                        else if (amal == 2)
                        {
                            Console.WriteLine("Xizmatdan foydalanish uchun rahmat !");
                            break;
                        }
                    }
                }
                else if (tanlang == 6)
                {
                    Console.WriteLine("Xizmatdan foydalanish uchun rahmat !");
                    break;
                }

            }
        }
        else if (kod != kod1)
        {
            Console.WriteLine("Kod noto`g`ri kiritildi");
            Console.WriteLine();
            Console.WriteLine("Qaytadan urinib ko`ring");
            Console.WriteLine();
            Console.WriteLine();

        }

    }
}
