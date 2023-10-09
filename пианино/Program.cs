using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в программу Пианино!");
        Console.WriteLine("Для игры на пианино, используйте белый клавиши  (Z, X, C, V, B, N, M) и черные клавиши (A, S, D, F, G)");
        Console.WriteLine("Для переключения октавы, используйте клавиши F1, F2 и F3.");
        Console.WriteLine("Для выхода из программы, нажмите Escape.\n "+
        "Включена первая октава");

        int[] pervayaOctava = new int[] { 261, 293, 329, 349, 392, 440, 493, 277, 311, 349, 415, 466 };
        int[] vtorayaOctava = new int[] { 523, 587, 659, 698, 783, 880, 987, 554, 622, 698, 830, 932 };
        int[] trtiaOctava = new int[] { 1046, 1175, 1319, 1397, 1568, 1760, 19751109, 1245, 1397, 1661, 1865 };

        int thisOctava = 1; 
        int[] ThisOctavaNjti = pervayaOctava;

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Программа завершена.");
                break;
            }
            else if (keyInfo.Key == ConsoleKey.F1)
            {
                ThisOctavaNjti = pervayaOctava;
                Console.WriteLine("Октава переключена на первую.");
            }
            else if (keyInfo.Key == ConsoleKey.F2)
            {
                ThisOctavaNjti = vtorayaOctava;
                Console.WriteLine("Октава переключена на вторую.");
            }
            else if (keyInfo.Key == ConsoleKey.F3)
            {
                ThisOctavaNjti = trtiaOctava;
                Console.WriteLine("Октава переключена на третью.");
            }
            else
            {
                int nota = Array.IndexOf(dostupnieklavishi, keyInfo.Key);
                if (nota >= 0)
                {
                    int chastota = ThisOctavaNjti[nota];
                    Console.Beep(chastota, 100); 
                }
                else
                {
                    Console.WriteLine("Нажата неизвестная клавиша.");
                }
            }
        }
    }

    static ConsoleKey[] dostupnieklavishi = new ConsoleKey[]
    {
        ConsoleKey.Z, 
        ConsoleKey.X,
        ConsoleKey.C, 
        ConsoleKey.V, 
        ConsoleKey.B, 
        ConsoleKey.N, 
        ConsoleKey.M, 
        ConsoleKey.A, 
        ConsoleKey.S, 
        ConsoleKey.D, 
        ConsoleKey.F, 
        ConsoleKey.G
    };
}