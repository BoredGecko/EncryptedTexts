bool ending = false;
Random Generating = new();
int KEY = Generating.Next(); //Ключ шифровки
string text; //Текст
             //Алфавит кодировки
char[] alphabet = new char[156] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '?', '/', ',', '.', ':', ';', '|', '=', '+', '-', '_', '(', ')', '*', '&', '^', '%', '$', '#', '№', '@', '"', '!', '{', '}', '[', ']', ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
while (ending == false)
{
    Console.OutputEncoding = System.Text.Encoding.Unicode;
    Console.Write("Encryptor/Decryptor [e/d]? >> "); //Выбор режима работы
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
    string type = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
    switch (type)
    {
        case "e":
        case "E":
            {
                Console.Clear();
                Console.WriteLine("Enter unencrypted text:");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                text = Convert.ToString(Console.ReadLine());
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
                char[] letters = new char[text.Length];
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
                int[] number = new int[text.Length];
                Random random = new(KEY);
                for (int i = 0; i < text.Length; i++)
                {
                    letters[i] = text[i];
                    number[i] = letters[i] switch
                    {
                        'А' => 0,
                        'Б' => 1,
                        'В' => 2,
                        'Г' => 3,
                        'Д' => 4,
                        'Е' => 5,
                        'Ё' => 6,
                        'Ж' => 7,
                        'З' => 8,
                        'И' => 9,
                        'Й' => 10,
                        'К' => 11,
                        'Л' => 12,
                        'М' => 13,
                        'Н' => 14,
                        'О' => 15,
                        'П' => 16,
                        'Р' => 17,
                        'С' => 18,
                        'Т' => 19,
                        'У' => 20,
                        'Ф' => 21,
                        'Х' => 22,
                        'Ц' => 23,
                        'Ч' => 24,
                        'Ш' => 25,
                        'Щ' => 26,
                        'Ъ' => 27,
                        'Ы' => 28,
                        'Ь' => 29,
                        'Э' => 30,
                        'Ю' => 31,
                        'Я' => 32,
                        'а' => 33,
                        'б' => 34,
                        'в' => 35,
                        'г' => 36,
                        'д' => 37,
                        'е' => 38,
                        'ё' => 39,
                        'ж' => 40,
                        'з' => 41,
                        'и' => 42,
                        'й' => 43,
                        'к' => 44,
                        'л' => 45,
                        'м' => 46,
                        'н' => 47,
                        'о' => 48,
                        'п' => 49,
                        'р' => 50,
                        'с' => 51,
                        'т' => 52,
                        'у' => 53,
                        'ф' => 54,
                        'х' => 55,
                        'ц' => 56,
                        'ч' => 57,
                        'ш' => 58,
                        'щ' => 59,
                        'ъ' => 60,
                        'ы' => 61,
                        'ь' => 62,
                        'э' => 63,
                        'ю' => 64,
                        'я' => 65,
                        'A' => 66,
                        'B' => 67,
                        'C' => 68,
                        'D' => 69,
                        'E' => 70,
                        'F' => 71,
                        'G' => 72,
                        'H' => 73,
                        'I' => 74,
                        'J' => 75,
                        'K' => 76,
                        'L' => 77,
                        'M' => 78,
                        'N' => 79,
                        'O' => 80,
                        'P' => 81,
                        'Q' => 82,
                        'R' => 83,
                        'S' => 84,
                        'T' => 85,
                        'U' => 86,
                        'V' => 87,
                        'W' => 88,
                        'X' => 89,
                        'Y' => 90,
                        'Z' => 91,
                        'a' => 92,
                        'b' => 93,
                        'c' => 94,
                        'd' => 95,
                        'e' => 96,
                        'f' => 97,
                        'g' => 98,
                        'h' => 99,
                        'i' => 100,
                        'j' => 101,
                        'k' => 102,
                        'l' => 103,
                        'm' => 104,
                        'n' => 105,
                        'o' => 106,
                        'p' => 107,
                        'q' => 108,
                        'r' => 109,
                        's' => 110,
                        't' => 111,
                        'u' => 112,
                        'v' => 113,
                        'w' => 114,
                        'x' => 115,
                        'y' => 116,
                        'z' => 117,
                        '?' => 118,
                        '/' => 119,
                        ',' => 120,
                        '.' => 121,
                        ':' => 122,
                        ';' => 123,
                        '|' => 124,
                        '=' => 125,
                        '+' => 126,
                        '-' => 127,
                        '_' => 128,
                        '(' => 129,
                        ')' => 130,
                        '*' => 131,
                        '&' => 132,
                        '^' => 133,
                        '%' => 134,
                        '$' => 135,
                        '#' => 136,
                        '№' => 137,
                        '@' => 138,
                        '"' => 139,
                        '!' => 140,
                        '{' => 141,
                        '}' => 142,
                        '[' => 143,
                        ']' => 144,
                        ' ' => 145,
                        '1' => 146,
                        '2' => 147,
                        '3' => 148,
                        '4' => 149,
                        '5' => 150,
                        '6' => 151,
                        '7' => 152,
                        '8' => 153,
                        '9' => 154,
                        '0' => 155,
                        _ => 0,
                    };
                }
                for (int i = 0; i < text.Length; i++)
                {
                    byte n = Convert.ToByte(random.Next(1, 156));
                    if (number[i] + n > 155) number[i] = number[i] + n - 156;
                    else number[i] += n;
                    letters[i] = alphabet[number[i]];
                }
                Console.WriteLine("\nEncrypted text:");
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(letters[i]);
                }
                Console.Write("\n\nDecrypt key >> " + KEY + "\n\n\nPress any key...");
                Console.ReadKey();
                Console.WriteLine("\n\n\nCopyright 2022 George Kondratev.\n\n");
                for (int k = 5; k > 0; k--)
                {
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\bThe program will close automatically after {0} sec(s).", k);
                    Thread.Sleep(1000);
                }
                ending = true;
            }
            break;

        case "d":
        case "D":
            {
                Console.Clear();
                Console.WriteLine("Enter encrypted text:");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                text = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                Console.Write("\nEnter decrypt key >> ");
                KEY = Convert.ToInt32(Console.ReadLine());
                Random random = new(KEY);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
                char[] letters = new char[text.Length];
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
                int[] number = new int[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    letters[i] = text[i];
                    number[i] = letters[i] switch
                    {
                        'А' => 0,
                        'Б' => 1,
                        'В' => 2,
                        'Г' => 3,
                        'Д' => 4,
                        'Е' => 5,
                        'Ё' => 6,
                        'Ж' => 7,
                        'З' => 8,
                        'И' => 9,
                        'Й' => 10,
                        'К' => 11,
                        'Л' => 12,
                        'М' => 13,
                        'Н' => 14,
                        'О' => 15,
                        'П' => 16,
                        'Р' => 17,
                        'С' => 18,
                        'Т' => 19,
                        'У' => 20,
                        'Ф' => 21,
                        'Х' => 22,
                        'Ц' => 23,
                        'Ч' => 24,
                        'Ш' => 25,
                        'Щ' => 26,
                        'Ъ' => 27,
                        'Ы' => 28,
                        'Ь' => 29,
                        'Э' => 30,
                        'Ю' => 31,
                        'Я' => 32,
                        'а' => 33,
                        'б' => 34,
                        'в' => 35,
                        'г' => 36,
                        'д' => 37,
                        'е' => 38,
                        'ё' => 39,
                        'ж' => 40,
                        'з' => 41,
                        'и' => 42,
                        'й' => 43,
                        'к' => 44,
                        'л' => 45,
                        'м' => 46,
                        'н' => 47,
                        'о' => 48,
                        'п' => 49,
                        'р' => 50,
                        'с' => 51,
                        'т' => 52,
                        'у' => 53,
                        'ф' => 54,
                        'х' => 55,
                        'ц' => 56,
                        'ч' => 57,
                        'ш' => 58,
                        'щ' => 59,
                        'ъ' => 60,
                        'ы' => 61,
                        'ь' => 62,
                        'э' => 63,
                        'ю' => 64,
                        'я' => 65,
                        'A' => 66,
                        'B' => 67,
                        'C' => 68,
                        'D' => 69,
                        'E' => 70,
                        'F' => 71,
                        'G' => 72,
                        'H' => 73,
                        'I' => 74,
                        'J' => 75,
                        'K' => 76,
                        'L' => 77,
                        'M' => 78,
                        'N' => 79,
                        'O' => 80,
                        'P' => 81,
                        'Q' => 82,
                        'R' => 83,
                        'S' => 84,
                        'T' => 85,
                        'U' => 86,
                        'V' => 87,
                        'W' => 88,
                        'X' => 89,
                        'Y' => 90,
                        'Z' => 91,
                        'a' => 92,
                        'b' => 93,
                        'c' => 94,
                        'd' => 95,
                        'e' => 96,
                        'f' => 97,
                        'g' => 98,
                        'h' => 99,
                        'i' => 100,
                        'j' => 101,
                        'k' => 102,
                        'l' => 103,
                        'm' => 104,
                        'n' => 105,
                        'o' => 106,
                        'p' => 107,
                        'q' => 108,
                        'r' => 109,
                        's' => 110,
                        't' => 111,
                        'u' => 112,
                        'v' => 113,
                        'w' => 114,
                        'x' => 115,
                        'y' => 116,
                        'z' => 117,
                        '?' => 118,
                        '/' => 119,
                        ',' => 120,
                        '.' => 121,
                        ':' => 122,
                        ';' => 123,
                        '|' => 124,
                        '=' => 125,
                        '+' => 126,
                        '-' => 127,
                        '_' => 128,
                        '(' => 129,
                        ')' => 130,
                        '*' => 131,
                        '&' => 132,
                        '^' => 133,
                        '%' => 134,
                        '$' => 135,
                        '#' => 136,
                        '№' => 137,
                        '@' => 138,
                        '"' => 139,
                        '!' => 140,
                        '{' => 141,
                        '}' => 142,
                        '[' => 143,
                        ']' => 144,
                        ' ' => 145,
                        '1' => 146,
                        '2' => 147,
                        '3' => 148,
                        '4' => 149,
                        '5' => 150,
                        '6' => 151,
                        '7' => 152,
                        '8' => 153,
                        '9' => 154,
                        '0' => 155,
                        _ => 0,
                    };
                }
                for (int i = 0; i < text.Length; i++)
                {
                    byte n = Convert.ToByte(random.Next(1, 156));
                    if (number[i] - n < 0) number[i] = number[i] - n + 156;
                    else number[i] = number[i] - n;
                    letters[i] = alphabet[number[i]];
                }
                Console.WriteLine("\nDecrypted text:");
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(letters[i]);
                }
                Console.WriteLine("\n\n\nPress any key...");
                Console.ReadKey();
                Console.WriteLine("\n\n\nCopyright 2022 George Kondratev.\n\n");
                for (int k = 5; k > 0; k--)
                {
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\bThe program will close automatically after {0} sec(s).", k);
                    Thread.Sleep(1000);
                }
                ending = true;
            }
            break;

        default:
            {
                Console.Write("\nIncorrect. Try again.");
                Thread.Sleep(1000);
                Console.Clear();
            }
            break;
    }
}