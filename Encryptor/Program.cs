
bool ending = false;
bool SaveToFile = false;
string Language = "en";
string Action;
Random Generating = new();
int KEY = Generating.Next(); //Decrypt key
string text; //Text
             //Coding alphabet
char[] alphabet = new char[256] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '?', '/', ',', '.', ':', ';', '|', '=', '+', '-', '_', '(', ')', '*', '&', '^', '%', '$', '#', '№', '@', '"', '!', '{', '}', '[', ']', ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '‴', '┌', '┐', '│', '─', '┘', '└', '□', '▪', '▫', '◊', '○', '◌', '●', '◦', '‖', '‗', '―', '—', '‒', '‐', '•', '❶', '❷', '❸', '❹', '❺', '❻', '❼', '❽', '❾', '❿', '⓫', '⓬', '⓭', '⓮', '⓯', '⓰', '⓱', '⓲', '⓳', '⓴', '⓿', '§', '¢', '£', '¤', '¥', '¦', '¨', 'ª', '¬', '¯', '°', '²', 'Ϊ', 'Ϋ', 'ü', 'ö', 'ä', 'ß', '₠', '₡', '₢', '₣', '₤', '₥', '₦', '₧', '₨', '₩', '₪', '₫', '€', '₭', '₮', '₯', '₰', '₱', '₲', '₳', '₴', '₵', '₸', '₹', '₺', '₻', '₼', '₽', '₾', '₿', 'Ѳ', 'ᴁ', 'ᴂ', 'ᴆ', 'ᴚ', 'ᴔ', '‼', '⁞', '…' };
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
while (ending == false)
{
    if (Language == "en")
    {
        Console.WriteLine("Actions:");
        Console.WriteLine("1. Encrypting.");
        Console.WriteLine("2. Decrypting.");
        Console.WriteLine("3. Settings.");
        Console.Write("Enter the action number >> ");
    }
    else if (Language == "rus")
    {
        Console.WriteLine("Действия:");
        Console.WriteLine("1. Шифрование.");
        Console.WriteLine("2. Дешифрование.");
        Console.WriteLine("3. Настройки.");
        Console.Write("Введите номер действия >> ");
    }
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
    Action = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
    switch (Action)
    {
        default:
            {
                if (Language == "en") Console.Write("\nIncorrect. Try again.");
                if (Language == "rus") Console.Write("\nНеверно. Попробуйте снова.");
                Thread.Sleep(1000);
                Console.Clear();
            }
            break;

        //Encrypt
        case "1":
            {
                Console.Clear();
                if (Language == "en") Console.WriteLine("Enter unencrypted text:");
                else if (Language == "rus") Console.WriteLine("Введите незашифрованный текст:");
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
                        '‴' => 156,
                        '┌' => 157,
                        '┐' => 158,
                        '│' => 159,
                        '─' => 160,
                        '┘' => 161,
                        '└' => 162,
                        '□' => 163,
                        '▪' => 164,
                        '▫' => 165,
                        '◊' => 166,
                        '○' => 167,
                        '◌' => 168,
                        '●' => 169,
                        '◦' => 170,
                        '‖' => 171,
                        '‗' => 172,
                        '―' => 173,
                        '—' => 174,
                        '‒' => 175,
                        '‐' => 176,
                        '•' => 177,
                        '❶' => 178,
                        '❷' => 179,
                        '❸' => 180,
                        '❹' => 181,
                        '❺' => 182,
                        '❻' => 183,
                        '❼' => 184,
                        '❽' => 185,
                        '❾' => 186,
                        '❿' => 187,
                        '⓫' => 188,
                        '⓬' => 189,
                        '⓭' => 190,
                        '⓮' => 191,
                        '⓯' => 192,
                        '⓰' => 193,
                        '⓱' => 194,
                        '⓲' => 195,
                        '⓳' => 196,
                        '⓴' => 197,
                        '⓿' => 198,
                        '§' => 199,
                        '¢' => 200,
                        '£' => 201,
                        '¤' => 202,
                        '¥' => 203,
                        '¦' => 204,
                        '¨' => 205,
                        'ª' => 206,
                        '¬' => 207,
                        '¯' => 208,
                        '°' => 209,
                        '²' => 210,
                        'Ϊ' => 211,
                        'Ϋ' => 212,
                        'ü' => 213,
                        'ö' => 214,
                        'ä' => 215,
                        'ß' => 216,
                        '₠' => 217,
                        '₡' => 218,
                        '₢' => 219,
                        '₣' => 220,
                        '₤' => 221,
                        '₥' => 222,
                        '₦' => 223,
                        '₧' => 224,
                        '₨' => 225,
                        '₩' => 226,
                        '₪' => 227,
                        '₫' => 228,
                        '€' => 229,
                        '₭' => 230,
                        '₮' => 231,
                        '₯' => 232,
                        '₰' => 233,
                        '₱' => 234,
                        '₲' => 235,
                        '₳' => 236,
                        '₴' => 237,
                        '₵' => 238,
                        '₸' => 239,
                        '₹' => 240,
                        '₺' => 241,
                        '₻' => 242,
                        '₼' => 243,
                        '₽' => 244,
                        '₾' => 245,
                        '₿' => 246,
                        'Ѳ' => 247,
                        'ᴁ' => 248,
                        'ᴂ' => 249,
                        'ᴆ' => 250,
                        'ᴚ' => 251,
                        'ᴔ' => 252,
                        '‼' => 253,
                        '⁞' => 254,
                        '…' => 255,
                        _ => 0,
                    };
                }
                for (int i = 0; i < text.Length; i++)
                {
                    int n = random.Next(1, 256);
                    if (number[i] + n > 255) number[i] = number[i] + n - 256;
                    else number[i] += n;
                    letters[i] = alphabet[number[i]];
                }
                if (Language == "en") Console.WriteLine("\nEncrypted text:");
                else if (Language == "rus") Console.WriteLine("\nЗашифрованный текст:");
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(letters[i]);
                }
                if (Language == "en") Console.Write("\n\nDecrypt key >> " + KEY);
                else if (Language == "rus") Console.WriteLine("\n\nКлюч дешифрования >> " + KEY);

                //Сохранение в файл
                if (SaveToFile == true)
                {
                    try
                    {
                        StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "\\CryptedMessage.txt");
                        //Запись текста
                        sw.WriteLine(letters);
                        //Запись ключа
                        sw.WriteLine(KEY);
                        //Close the file
                        sw.Close();
                    }
                    finally
                    {
                        if (Language == "en") Console.WriteLine("\nSaved to a file " + Directory.GetCurrentDirectory() + "\\CryptedMessage.txt");
                        else if (Language == "rus") Console.WriteLine("\nСохранено в файл " + Directory.GetCurrentDirectory() + "\\CryptedMessage.txt");
                    }
                }

                ending = true;
            }
            break;

        //Decrypt
        case "2":
            {
                Console.Clear();
                if (Language == "en") Console.WriteLine("Enter encrypted text:");
                else if (Language == "rus") Console.WriteLine("Введите зашифрованный текст:");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                text = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                if (Language == "en") Console.Write("\nEnter decrypt key >> ");
                else if (Language == "rus") Console.Write("\n\nВведие ключ дешифрования >> ");
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
                        '‴' => 156,
                        '┌' => 157,
                        '┐' => 158,
                        '│' => 159,
                        '─' => 160,
                        '┘' => 161,
                        '└' => 162,
                        '□' => 163,
                        '▪' => 164,
                        '▫' => 165,
                        '◊' => 166,
                        '○' => 167,
                        '◌' => 168,
                        '●' => 169,
                        '◦' => 170,
                        '‖' => 171,
                        '‗' => 172,
                        '―' => 173,
                        '—' => 174,
                        '‒' => 175,
                        '‐' => 176,
                        '•' => 177,
                        '❶' => 178,
                        '❷' => 179,
                        '❸' => 180,
                        '❹' => 181,
                        '❺' => 182,
                        '❻' => 183,
                        '❼' => 184,
                        '❽' => 185,
                        '❾' => 186,
                        '❿' => 187,
                        '⓫' => 188,
                        '⓬' => 189,
                        '⓭' => 190,
                        '⓮' => 191,
                        '⓯' => 192,
                        '⓰' => 193,
                        '⓱' => 194,
                        '⓲' => 195,
                        '⓳' => 196,
                        '⓴' => 197,
                        '⓿' => 198,
                        '§' => 199,
                        '¢' => 200,
                        '£' => 201,
                        '¤' => 202,
                        '¥' => 203,
                        '¦' => 204,
                        '¨' => 205,
                        'ª' => 206,
                        '¬' => 207,
                        '¯' => 208,
                        '°' => 209,
                        '²' => 210,
                        'Ϊ' => 211,
                        'Ϋ' => 212,
                        'ü' => 213,
                        'ö' => 214,
                        'ä' => 215,
                        'ß' => 216,
                        '₠' => 217,
                        '₡' => 218,
                        '₢' => 219,
                        '₣' => 220,
                        '₤' => 221,
                        '₥' => 222,
                        '₦' => 223,
                        '₧' => 224,
                        '₨' => 225,
                        '₩' => 226,
                        '₪' => 227,
                        '₫' => 228,
                        '€' => 229,
                        '₭' => 230,
                        '₮' => 231,
                        '₯' => 232,
                        '₰' => 233,
                        '₱' => 234,
                        '₲' => 235,
                        '₳' => 236,
                        '₴' => 237,
                        '₵' => 238,
                        '₸' => 239,
                        '₹' => 240,
                        '₺' => 241,
                        '₻' => 242,
                        '₼' => 243,
                        '₽' => 244,
                        '₾' => 245,
                        '₿' => 246,
                        'Ѳ' => 247,
                        'ᴁ' => 248,
                        'ᴂ' => 249,
                        'ᴆ' => 250,
                        'ᴚ' => 251,
                        'ᴔ' => 252,
                        '‼' => 253,
                        '⁞' => 254,
                        '…' => 255,
                        _ => 0,
                    };
                }
                for (int i = 0; i < text.Length; i++)
                {
                    int n = random.Next(1, 256);
                    if (number[i] - n < 0) number[i] = number[i] - n + 256;
                    else number[i] = number[i] - n;
                    letters[i] = alphabet[number[i]];
                }
                if (Language == "en") Console.WriteLine("\nDecrypted text:");
                else if (Language == "rus") Console.WriteLine("\nРасшифрованный текст:");
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(letters[i]);
                }
                ending = true;
            }
            break;

        //Settings
        case "3":
            {
                Console.Clear();
                if (Language == "en")
                {
                    Console.WriteLine("Settings:");
                    Console.WriteLine("1. Interface language - English.");
                    Console.Write("2. Auto - saving to the file - ");
                }
                else if (Language == "rus")
                {
                    Console.WriteLine("Настройки:");
                    Console.WriteLine("1. Язык интерфейса - Русский.");
                    Console.Write("2. Автосохранение в файл - ");
                }
                Console.WriteLine(Convert.ToString(SaveToFile) + ".");
                if (Language == "en")
                {
                    Console.Write("Enter setting number >> ");
                }
                else if (Language == "rus")
                {
                    Console.Write("Введите номер настройки >> ");
                }
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                Action = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                switch (Action)
                {
                    case "1":
                        {
                            if (Language == "en")
                            {
                                Console.Clear();
                                Console.Write("Switch to Russian (Русский)? [YES/NO] >> ");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                                string check = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                                if (check == "YES" || check == "Yes" || check == "yes")
                                {
                                    Console.Clear();
                                    Language = "rus";
                                }
                                else if (check == "NO" || check == "No" || check == "no")
                                {
                                    Language = "en";
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.Write("\nIncorrect. Try again.");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }
                            }
                            else if (Language == "rus")
                            {
                                Console.Clear();
                                Console.Write("Сменить на Английский (English)? [YES/NO] >> ");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                                string check = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                                if (check == "YES" || check == "Yes" || check == "yes")
                                {
                                    Language = "en";
                                    Console.Clear();
                                }
                                else if (check == "NO" || check == "No" || check == "no")
                                {
                                    Language = "rus";
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.Write("\nНеверно. Попробуйте снова.");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }
                            }
                        }
                        break;

                    case "2":
                        {
                            if (Language == "en")
                            {
                                Console.Clear();
                                if (SaveToFile == false)
                                {
                                    Console.Write("Turn on «Auto - saving to the file»? [YES/NO] >> ");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                                    string check = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                                    if (check == "YES" || check == "Yes" || check == "yes")
                                    {
                                        SaveToFile = true;
                                        Console.Clear();
                                    }
                                    else if (check == "NO" || check == "No" || check == "no")
                                    {
                                        SaveToFile = false;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.Write("\nIncorrect. Try again.");
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                                else if (SaveToFile == true)
                                {
                                    Console.Write("Turn off «Auto - saving to a file»? [YES/NO] >> ");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                                    string check = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                                    if (check == "YES" || check == "Yes" || check == "yes")
                                    {
                                        SaveToFile = false;
                                        Console.Clear();
                                    }
                                    else if (check == "NO" || check == "No" || check == "no")
                                    {
                                        SaveToFile = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.Write("\nIncorrect. Try again.");
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                            }
                            else if (Language == "rus")
                            {
                                Console.Clear();
                                if (SaveToFile == false)
                                {
                                    Console.Write("Включить «Автосохранение в файл»? [YES/NO] >> ");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                                    string check = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                                    if (check == "YES" || check == "Yes" || check == "yes")
                                    {
                                        SaveToFile = true;
                                        Console.Clear();
                                    }
                                    else if (check == "NO" || check == "No" || check == "no")
                                    {
                                        SaveToFile = false;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.Write("\nIncorrect. Try again.");
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                                else if (SaveToFile == true)
                                {
                                    Console.Write("Выключить «Автосохранение в файл»? [YES/NO] >> ");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                                    string check = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                                    if (check == "YES" || check == "Yes" || check == "yes")
                                    {
                                        SaveToFile = false;
                                        Language = "rus";
                                    }
                                    else if (check == "NO" || check == "No" || check == "no")
                                    {
                                        SaveToFile = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.Write("\nIncorrect. Try again.");
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                }
                            }
                        }
                        break;

                    default:
                        {
                            if (Language == "en") Console.Write("\nIncorrect. Try again.");
                            if (Language == "rus") Console.Write("\nНеверно. Попробуйте снова.");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        break;
                }
            }
            break;
    }
}

if (Language == "en") Console.WriteLine("\n\n\nPress any key...");
else if (Language == "rus") Console.WriteLine("\n\n\nНажмите любую клавишу...");
Console.ReadKey();
//Console.WriteLine("\n\n\nCopyright© 2022 George Kondratev.\n\n");

for (int i = 5; i > 0; i--)
{
    for (int j = 0; j < 52; j++) Console.Write("\b");
    if (Language == "en") Console.Write("The program will close automatically after {0} sec(s).", i);
    else if (Language == "rus") Console.Write("Программа закроется автоматически через {0} с.", i);
    Thread.Sleep(1000);
}