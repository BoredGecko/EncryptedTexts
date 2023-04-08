using System.Security.Cryptography;
using System.Text;
namespace TextEncryptor
{
    internal class Program
    {
        //Алфавит
        public static string Alphabet =
        "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!#№$%&()*+,-./:;<=>?@[]^_`{|}~АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +
            "абвгдеёжзийклмнопрстуфхцчшщъыьэюя ¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷ø" +
            "ùúûüýþÿĀāĂăĄąĆćĈĉĊċČčĎďĐđĒēĔĕĖėĘęĚěĜĝĞğĠġĢģĤĥĦħĨĩĪīĬĭĮįİıĲĳĴĵĶķĸĹĺĻļĽľĿŀŁłŃńŅņŇňŉŊŋŌōŎŏŐőŒœŔŕŖŗŘřŚśŜŝŞşŠšŢţŤťŦŧŨũŪūŬŭŮůŰű" +
            "ŲųŴŵŶŷŸŹźŻżŽžſ‴‖‗―‒‐•❶❷❸❹❺❻❼❽❾❿⓫⓬⓭⓮⓯⓰⓱⓲⓳⓴⓿₠₡₢₣₤₥₦₧₨₩₪₫€₭₮₯₰₱₲₳₴₵₸₹₺₻₼₽₾₿Ѳᴁᴂᴆᴚᴔ⁞…⠁⠂⠃⠄⠅⠆⠇⠈⠉⠊⠋⠌⠍⠎⠏⠐⠑⠒⠓⠔⠕⠖⠗⠘⠙⠚" +
            "⠛⠜⠝⠞⠟⠠⠡⠢⠣⠤⠥⠦⠧⠨⠩⠪⠫⠬⠭⠮⠯⠰⠱⠲⠳⠴⠵⠶⠷⠸⠹⠺⠻⠼⠽⠾⠿⡀⡁⡂⡃⡄⡅⡆⡇⡈⡉⡊⡋⡌⡍⡎⡏⡐⡑⡒⡓⡔⡕⡖⡗⡘⡙⡚⡛⡜⡝⡞⡟⡠⡡⡢⡣⡤⡥⡦⡧⡨⡩⡪⡫⡬⡭⡮⡯⡰⡱⡲⡳⡴⡵⡶⡷⡸⡹⡺⡻⡼⡽⡾⡿⢀⢁⢂⢃⢄⢅⢆⢇⢈⢉⢊⢋⢌⢍⢎⢏⢐⢑⢒⢓" +
            "⢔⢕⢖⢗⢘⢙⢚⢛⢜⢝⢞⢟⢠⢡⢢⢣⢤⢥⢦⢧⢨⢩⢪⢫⢬⢭⢮⢯⢰⢱⢲⢳⢴⢵⢶⢷⢸⢹⢺⢻⢼⢽⢾⢿⣀⣁⣂⣃⣄⣅⣆⣇⣈⣉⣊⣋⣌⣍⣎⣏⣐⣑⣒⣓⣔⣕⣖⣗⣘⣙⣚⣛⣜⣝⣞⣟⣠⣡⣢⣣⣤⣥⣦⣧⣨⣩⣪⣫⣬⣭⣮⣯⣰⣱⣲⣳⣴⣵⣶⣷⣸⣹⣺⣻⣼⣽⣾⣿ᐍᐎᐏᐐᐑᐒᐓᐔᐕᐖ" +
            "ᐗᐘᐙᐚᐛᐜᐝᐞᐟᐠᐡᐢᐣᐤᐥᐦᐧᐨᐩᐪᐫᐬᐭᐮᐯᐰᐱᐲᐳᐴᐵᐶᐷᐸᐹᐺᐻᐼᐽᐾᐿᑀᑁᑂᑃᑄᑅᑆᑇᑈᑉᑊᑋᑌᑍᑎᑏᑐᑑᑒᑓᑔᑕᑖᑗᑘᑙᑚᑛᑜᑝᑞᑟᑠᑡᑢᑣᑤᑥᑦᑧᑨᑩᑪᒃᒄᒅᒆᒇᒈᒉᒊᒋᒌᒍᒎᒏᒐᒑᒒᒓᒔ" +
            "ᒕᒖᒗᒘᒙᒚᒛᒜᒝᒞᒟᒠᒡᒢᒣᒤᒥᒦᒧᒨᒩᒪᒫᒬᒭᒮᒯᒰᒱᒲᒳᒴᒵᒶᒷᒸᒹᒺᓀᓁᓂᓃᓄᓅᓆᓇᓈᓉᓊᓋᓌᓍᓎᓏᓐᓑᓒᓓᓔᓕᓖᓗᓘᓙᓚᓛᓜᓝᓞᓟᓠᓡᓢᓣᓤᓥᓦᓧᓨᓩᓶᓷᓸᓹᓺᓻᓼᓽᓾᓿᔀᔁᔂᔃᔄᔅᔆᔇᔐᔑᔒᔓᔔᔕ" +
            "ᔖᔗᔘᔙᔚᔛᔜᔟᔠᔡᔢᔣᔤᔥᔦᔧᔨᔩᔪᔫᔬᔭᔮᔯᔰᔱᔲᔳᔴᔵᔶᔷᔸᔹᔺᔻᔼᔽᔾᕒᕓᕔᕕᕖᕗᕘᕙᕚᕛᕜᕝᕞᕟᕠᕡᕢᕣᕤᕥᕦᕧᕨᕩᕪᕀᕁᕴᕵᕶᕷᕸᕹᕺᕻᕼᕽᕾᕿᖀᖁᖂᖃᖄᖅ ᚁᚂᚃᚄᚅᚆᚇᚈᚉᚊᚋᚌᚍᚎᚏᚐᚑᚒᚓᚔ";

        public static string Command; //Команды
        public static string text; //Текст
        public static int KEY; //Ключ шифрования
        public static string hexkey;

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Random Generating = new();
            Input();
            while (Command != "EXIT")
            {
                string command = Command;
                switch (command)
                {
                    default:
                        Error();
                        break;

                    case "ENCRYPT":
                        Phrases("iutxt");
                        text = Console.ReadLine();
                        KEY = Generating.Next();
                        int[] number = new int[text.Length];
                        Random random = new(KEY);
                        for (int i = 0; i < text.Length; i++)
                            number[i] = (Alphabet.IndexOf(text[i]) + random.Next(1, Alphabet.Length)) % Alphabet.Length;
                        Phrases("oetxt");                       
                        string s = "";
                        for (int i = 0; i < number.Length; ++i)
                            s += Convert.ToString(number[i], 2).PadLeft(10, '0');
                        string longKey = "";
                        for (int i = 0; i <= (s.Length) / Convert.ToString(KEY, 2).Length; i++)
                            longKey += Convert.ToString(KEY, 2);
                        longKey = longKey.Substring(0, s.Length);
                        string ss = "";
                        for (int i = 0; i < s.Length; i++)
                            if (s[i] == '0' && longKey[i] == '1' || s[i] == '1' && longKey[i] == '0')
                                ss += '1';
                            else
                                ss += '0';
                        for (int i = 0; i < ss.Length; i += 10)
                            Out(Alphabet[Convert.ToInt32(ss.Substring(i, 10), 2)]);
                        Phrases("okey");
                        break;

                    case "DECRYPT":
                        Phrases("ietxt");
                        Program.text = Console.ReadLine();
                        Phrases("ikey");
                        try
                        {
                            KEY = Convert.ToInt32(Console.ReadLine());
                            random = new(KEY);
                            number = new int[text.Length];
                            for (int i = 0; i < text.Length; i++)
                                number[i] = Alphabet.IndexOf(text[i]);

                            s = "";
                            for (int i = 0; i < number.Length; ++i)
                                s += Convert.ToString(number[i], 2).PadLeft(10, '0');
                            longKey = "";
                            for (int i = 0; i <= (s.Length * 10) / Convert.ToString(KEY, 2).Length; i++)
                                longKey += Convert.ToString(KEY, 2);
                            longKey = longKey.Substring(0, s.Length);
                            ss = "";
                            for (int i = 0; i < s.Length; i++)
                                if (s[i] == '0' && longKey[i] == '1' || s[i] == '1' && longKey[i] == '0')
                                    ss += '1';
                                else
                                    ss += '0';
                            number = new int[ss.Length / 10];
                            for (int i = 0, j = 0; i < ss.Length; i += 10, j++)
                                number[j] = Convert.ToInt32(ss.Substring(i, 10), 2);

                            Phrases("odtxt");
                            for (int i = 0; i < text.Length; i++)
                            {
                                number[i] -= random.Next(1, Alphabet.Length);
                                if (number[i] < 0)
                                    number[i] += Alphabet.Length;
                                Out(Alphabet[number[i]]);
                            }
                            Console.WriteLine();
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("Invalid KEY");
                        }
                        catch (System.OverflowException)
                        {
                            Console.WriteLine("Invalid KEY");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exeption: {0}", e);
                        }
                        break;

                    case "HELP":
                        Help();
                        break;

                    case "CLEAR":
                        ClearConsole();
                        break;

                    case "ERRORTYPE":
                        ErrorType();
                        break;
                }
                Input();
            }
            Environment.Exit(0);
        }

        public static void ErrorType()
        {
            Console.WriteLine("\nВ разработке.\n");
        }

        public static string GenKey()
        {
            RandomNumberGenerator val = RandomNumberGenerator.Create();
            byte[] array = new byte[128];
            val.GetBytes(array);
            string text = BitConverter.ToString(array);
            return text.Replace("-", "");
        }

        public static void Phrases(string code)
        {
            switch (code)
            {
                default:
                    Console.WriteLine("\nPhrase does not exist.");
                    break;
                case "iutxt":
                    Console.WriteLine("\nEnter text:");
                    break;
                case "oetxt":
                    Console.WriteLine("\nEncrypted text:");
                    break;
                case "okey":
                    Console.WriteLine("\n" + KEY + " (Decrypt key)\n");
                    break;
                case "ietxt":
                    Console.WriteLine("Enter text:");
                    break;
                case "ikey":
                    Console.Write("\nEnter decrypt key >> ");
                    break;
                case "odtxt":
                    Console.WriteLine("\nDecrypted text:");
                    break;
            }
        }

        public static void Help()
        {
            Console.WriteLine();
            Console.WriteLine("CLEAR                            ОЧИСТКА КОНСОЛИ");
            Console.WriteLine("DECRYPT                          ДЕШИФРОВАНИЕ");
            Console.WriteLine("ENCRYPT                          ШИФРОВАНИЕ");
            Console.WriteLine("ERRORTYPE                        УЗНАТЬ ЗНАЧЕНИЕ ОШИБКИ");
            Console.WriteLine("EXIT                             ЗАКРЫТЬ ПРИЛОЖЕНИЕ");
            Console.WriteLine();
        }

        public static void ClearConsole()
        {
            Console.Clear();
            Console.Write("\nScreen cleaned sucsessfully.\n");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void Out(char c)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(c);
            Console.ResetColor();
        }

        public static void Error()
        {
            Console.Write("\nInvalid command. Try again.");
            Thread.Sleep(1000);
            Console.Clear();
        }

        public static void Input()
        {
            Console.Write("Input command (type HELP to see all commands) >> ");
            Command = Console.ReadLine().Replace(" ", "").ToUpper();
        }

        public static string XOR(string text)
        {
            string longKey = "";
            for (int i = 0; i <= (Alphabet.Length * 10) / Convert.ToString(KEY, 2).Length; i++)
            {
                longKey += Convert.ToString(KEY, 2);
            }
            longKey = longKey.Substring(0, Alphabet.Length * 10);
            string s = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '0' && longKey[i] == '1' || text[i] == '1' && longKey[i] == '0')
                    s += '1';
                else
                    s += '0';
            }
            return s;
        }
    }
    
}