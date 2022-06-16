bool ending = false;
Random Generating = new Random();
int KEY = Generating.Next(); //Ключ шифровки
string text = ""; //Текст
//Алфавит кодировки
char[] alphabet = new char[156] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '?', '/', ',', '.', ':', ';', '|', '=', '+', '-', '_', '(', ')', '*', '&', '^', '%', '$', '#', '№', '@', '"', '!', '{', '}', '[', ']', ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
while (ending == false)
{
    Console.Write("Encryptor/Decryptor [e/d]? >> "); //Выбор режима работы
    string type = Console.ReadLine();
    switch (type)
    {
        case "e":
        case "E":
            {
                Console.Clear();
                Console.WriteLine("Enter unencrypted text:");
                text = Console.ReadLine();
                char[] letters = new char[text.Length];
                int[] number = new int[text.Length];
                Random random = new Random(KEY);
                for (int i = 0; i < text.Length; i++)
                {
                    letters[i] = text[i];
                    switch (letters[i])
                    {
                        default:
                            number[i] = 0;
                            break;

                        case 'А':
                            number[i] = 0;
                            break;

                        case 'Б':
                            number[i] = 1;
                            break;

                        case 'В':
                            number[i] = 2;
                            break;

                        case 'Г':
                            number[i] = 3;
                            break;

                        case 'Д':
                            number[i] = 4;
                            break;

                        case 'Е':
                            number[i] = 5;
                            break;

                        case 'Ё':
                            number[i] = 6;
                            break;

                        case 'Ж':
                            number[i] = 7;
                            break;

                        case 'З':
                            number[i] = 8;
                            break;

                        case 'И':
                            number[i] = 9;
                            break;

                        case 'Й':
                            number[i] = 10;
                            break;

                        case 'К':
                            number[i] = 11;
                            break;

                        case 'Л':
                            number[i] = 12;
                            break;

                        case 'М':
                            number[i] = 13;
                            break;

                        case 'Н':
                            number[i] = 14;
                            break;

                        case 'О':
                            number[i] = 15;
                            break;

                        case 'П':
                            number[i] = 16;
                            break;

                        case 'Р':
                            number[i] = 17;
                            break;

                        case 'С':
                            number[i] = 18;
                            break;

                        case 'Т':
                            number[i] = 19;
                            break;

                        case 'У':
                            number[i] = 20;
                            break;

                        case 'Ф':
                            number[i] = 21;
                            break;

                        case 'Х':
                            number[i] = 22;
                            break;

                        case 'Ц':
                            number[i] = 23;
                            break;

                        case 'Ч':
                            number[i] = 24;
                            break;

                        case 'Ш':
                            number[i] = 25;
                            break;

                        case 'Щ':
                            number[i] = 26;
                            break;

                        case 'Ъ':
                            number[i] = 27;
                            break;

                        case 'Ы':
                            number[i] = 28;
                            break;

                        case 'Ь':
                            number[i] = 29;
                            break;

                        case 'Э':
                            number[i] = 30;
                            break;

                        case 'Ю':
                            number[i] = 31;
                            break;

                        case 'Я':
                            number[i] = 32;
                            break;

                        case 'а':
                            number[i] = 33;
                            break;

                        case 'б':
                            number[i] = 34;
                            break;

                        case 'в':
                            number[i] = 35;
                            break;

                        case 'г':
                            number[i] = 36;
                            break;

                        case 'д':
                            number[i] = 37;
                            break;

                        case 'е':
                            number[i] = 38;
                            break;

                        case 'ё':
                            number[i] = 39;
                            break;

                        case 'ж':
                            number[i] = 40;
                            break;

                        case 'з':
                            number[i] = 41;
                            break;

                        case 'и':
                            number[i] = 42;
                            break;

                        case 'й':
                            number[i] = 43;
                            break;

                        case 'к':
                            number[i] = 44;
                            break;

                        case 'л':
                            number[i] = 45;
                            break;

                        case 'м':
                            number[i] = 46;
                            break;

                        case 'н':
                            number[i] = 47;
                            break;

                        case 'о':
                            number[i] = 48;
                            break;

                        case 'п':
                            number[i] = 49;
                            break;

                        case 'р':
                            number[i] = 50;
                            break;

                        case 'с':
                            number[i] = 51;
                            break;

                        case 'т':
                            number[i] = 52;
                            break;

                        case 'у':
                            number[i] = 53;
                            break;

                        case 'ф':
                            number[i] = 54;
                            break;

                        case 'х':
                            number[i] = 55;
                            break;

                        case 'ц':
                            number[i] = 56;
                            break;

                        case 'ч':
                            number[i] = 57;
                            break;

                        case 'ш':
                            number[i] = 58;
                            break;

                        case 'щ':
                            number[i] = 59;
                            break;

                        case 'ъ':
                            number[i] = 60;
                            break;

                        case 'ы':
                            number[i] = 61;
                            break;

                        case 'ь':
                            number[i] = 62;
                            break;

                        case 'э':
                            number[i] = 63;
                            break;

                        case 'ю':
                            number[i] = 64;
                            break;

                        case 'я':
                            number[i] = 65;
                            break;

                        case 'A':
                            number[i] = 66;
                            break;

                        case 'B':
                            number[i] = 67;
                            break;

                        case 'C':
                            number[i] = 68;
                            break;

                        case 'D':
                            number[i] = 69;
                            break;

                        case 'E':
                            number[i] = 70;
                            break;

                        case 'F':
                            number[i] = 71;
                            break;

                        case 'G':
                            number[i] = 72;
                            break;

                        case 'H':
                            number[i] = 73;
                            break;

                        case 'I':
                            number[i] = 74;
                            break;

                        case 'J':
                            number[i] = 75;
                            break;

                        case 'K':
                            number[i] = 76;
                            break;

                        case 'L':
                            number[i] = 77;
                            break;

                        case 'M':
                            number[i] = 78;
                            break;

                        case 'N':
                            number[i] = 79;
                            break;

                        case 'O':
                            number[i] = 80;
                            break;

                        case 'P':
                            number[i] = 81;
                            break;

                        case 'Q':
                            number[i] = 82;
                            break;

                        case 'R':
                            number[i] = 83;
                            break;

                        case 'S':
                            number[i] = 84;
                            break;

                        case 'T':
                            number[i] = 85;
                            break;

                        case 'U':
                            number[i] = 86;
                            break;

                        case 'V':
                            number[i] = 87;
                            break;

                        case 'W':
                            number[i] = 88;
                            break;

                        case 'X':
                            number[i] = 89;
                            break;

                        case 'Y':
                            number[i] = 90;
                            break;

                        case 'Z':
                            number[i] = 91;
                            break;

                        case 'a':
                            number[i] = 92;
                            break;

                        case 'b':
                            number[i] = 93;
                            break;

                        case 'c':
                            number[i] = 94;
                            break;

                        case 'd':
                            number[i] = 95;
                            break;

                        case 'e':
                            number[i] = 96;
                            break;

                        case 'f':
                            number[i] = 97;
                            break;

                        case 'g':
                            number[i] = 98;
                            break;

                        case 'h':
                            number[i] = 99;
                            break;

                        case 'i':
                            number[i] = 100;
                            break;

                        case 'j':
                            number[i] = 101;
                            break;

                        case 'k':
                            number[i] = 102;
                            break;

                        case 'l':
                            number[i] = 103;
                            break;

                        case 'm':
                            number[i] = 104;
                            break;

                        case 'n':
                            number[i] = 105;
                            break;

                        case 'o':
                            number[i] = 106;
                            break;

                        case 'p':
                            number[i] = 107;
                            break;

                        case 'q':
                            number[i] = 108;
                            break;

                        case 'r':
                            number[i] = 109;
                            break;

                        case 's':
                            number[i] = 110;
                            break;

                        case 't':
                            number[i] = 111;
                            break;

                        case 'u':
                            number[i] = 112;
                            break;

                        case 'v':
                            number[i] = 113;
                            break;

                        case 'w':
                            number[i] = 114;
                            break;

                        case 'x':
                            number[i] = 115;
                            break;

                        case 'y':
                            number[i] = 116;
                            break;

                        case 'z':
                            number[i] = 117;
                            break;

                        case '?':
                            number[i] = 118;
                            break;

                        case '/':
                            number[i] = 119;
                            break;

                        case ',':
                            number[i] = 120;
                            break;

                        case '.':
                            number[i] = 121;
                            break;

                        case ':':
                            number[i] = 122;
                            break;

                        case ';':
                            number[i] = 123;
                            break;

                        case '|':
                            number[i] = 124;
                            break;

                        case '=':
                            number[i] = 125;
                            break;

                        case '+':
                            number[i] = 126;
                            break;

                        case '-':
                            number[i] = 127;
                            break;

                        case '_':
                            number[i] = 128;
                            break;

                        case '(':
                            number[i] = 129;
                            break;

                        case ')':
                            number[i] = 130;
                            break;

                        case '*':
                            number[i] = 131;
                            break;

                        case '&':
                            number[i] = 132;
                            break;

                        case '^':
                            number[i] = 133;
                            break;

                        case '%':
                            number[i] = 134;
                            break;

                        case '$':
                            number[i] = 135;
                            break;

                        case '#':
                            number[i] = 136;
                            break;

                        case '№':
                            number[i] = 137;
                            break;

                        case '@':
                            number[i] = 138;
                            break;

                        case '"':
                            number[i] = 139;
                            break;

                        case '!':
                            number[i] = 140;
                            break;

                        case '{':
                            number[i] = 141;
                            break;

                        case '}':
                            number[i] = 142;
                            break;

                        case '[':
                            number[i] = 143;
                            break;

                        case ']':
                            number[i] = 144;
                            break;

                        case ' ':
                            number[i] = 145;
                            break;

                        case '1':
                            number[i] = 146;
                            break;

                        case '2':
                            number[i] = 147;
                            break;

                        case '3':
                            number[i] = 148;
                            break;

                        case '4':
                            number[i] = 149;
                            break;

                        case '5':
                            number[i] = 150;
                            break;

                        case '6':
                            number[i] = 151;
                            break;

                        case '7':
                            number[i] = 152;
                            break;

                        case '8':
                            number[i] = 153;
                            break;

                        case '9':
                            number[i] = 154;
                            break;

                        case '0':
                            number[i] = 155;
                            break;
                    }
                }            
                for (int i = 0; i < text.Length; i++)
                {
                    byte n = Convert.ToByte(random.Next(1, 156));
                    if (number[i] + n > 156) number[i] = number[i] + n - 156;
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
                text = Console.ReadLine();
                Console.Write("\nEnter decrypt key >> ");
                KEY = Convert.ToInt32(Console.ReadLine());
                Random random = new Random(KEY);
                char[] letters = new char[text.Length];
                int[] number = new int[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    letters[i] = text[i];
                    switch (letters[i])
                    {
                        default:
                            number[i] = 0;
                            break;

                        case 'А':
                            number[i] = 0;
                            break;

                        case 'Б':
                            number[i] = 1;
                            break;

                        case 'В':
                            number[i] = 2;
                            break;

                        case 'Г':
                            number[i] = 3;
                            break;

                        case 'Д':
                            number[i] = 4;
                            break;

                        case 'Е':
                            number[i] = 5;
                            break;

                        case 'Ё':
                            number[i] = 6;
                            break;

                        case 'Ж':
                            number[i] = 7;
                            break;

                        case 'З':
                            number[i] = 8;
                            break;

                        case 'И':
                            number[i] = 9;
                            break;

                        case 'Й':
                            number[i] = 10;
                            break;

                        case 'К':
                            number[i] = 11;
                            break;

                        case 'Л':
                            number[i] = 12;
                            break;

                        case 'М':
                            number[i] = 13;
                            break;

                        case 'Н':
                            number[i] = 14;
                            break;

                        case 'О':
                            number[i] = 15;
                            break;

                        case 'П':
                            number[i] = 16;
                            break;

                        case 'Р':
                            number[i] = 17;
                            break;

                        case 'С':
                            number[i] = 18;
                            break;

                        case 'Т':
                            number[i] = 19;
                            break;

                        case 'У':
                            number[i] = 20;
                            break;

                        case 'Ф':
                            number[i] = 21;
                            break;

                        case 'Х':
                            number[i] = 22;
                            break;

                        case 'Ц':
                            number[i] = 23;
                            break;

                        case 'Ч':
                            number[i] = 24;
                            break;

                        case 'Ш':
                            number[i] = 25;
                            break;

                        case 'Щ':
                            number[i] = 26;
                            break;

                        case 'Ъ':
                            number[i] = 27;
                            break;

                        case 'Ы':
                            number[i] = 28;
                            break;

                        case 'Ь':
                            number[i] = 29;
                            break;

                        case 'Э':
                            number[i] = 30;
                            break;

                        case 'Ю':
                            number[i] = 31;
                            break;

                        case 'Я':
                            number[i] = 32;
                            break;

                        case 'а':
                            number[i] = 33;
                            break;

                        case 'б':
                            number[i] = 34;
                            break;

                        case 'в':
                            number[i] = 35;
                            break;

                        case 'г':
                            number[i] = 36;
                            break;

                        case 'д':
                            number[i] = 37;
                            break;

                        case 'е':
                            number[i] = 38;
                            break;

                        case 'ё':
                            number[i] = 39;
                            break;

                        case 'ж':
                            number[i] = 40;
                            break;

                        case 'з':
                            number[i] = 41;
                            break;

                        case 'и':
                            number[i] = 42;
                            break;

                        case 'й':
                            number[i] = 43;
                            break;

                        case 'к':
                            number[i] = 44;
                            break;

                        case 'л':
                            number[i] = 45;
                            break;

                        case 'м':
                            number[i] = 46;
                            break;

                        case 'н':
                            number[i] = 47;
                            break;

                        case 'о':
                            number[i] = 48;
                            break;

                        case 'п':
                            number[i] = 49;
                            break;

                        case 'р':
                            number[i] = 50;
                            break;

                        case 'с':
                            number[i] = 51;
                            break;

                        case 'т':
                            number[i] = 52;
                            break;

                        case 'у':
                            number[i] = 53;
                            break;

                        case 'ф':
                            number[i] = 54;
                            break;

                        case 'х':
                            number[i] = 55;
                            break;

                        case 'ц':
                            number[i] = 56;
                            break;

                        case 'ч':
                            number[i] = 57;
                            break;

                        case 'ш':
                            number[i] = 58;
                            break;

                        case 'щ':
                            number[i] = 59;
                            break;

                        case 'ъ':
                            number[i] = 60;
                            break;

                        case 'ы':
                            number[i] = 61;
                            break;

                        case 'ь':
                            number[i] = 62;
                            break;

                        case 'э':
                            number[i] = 63;
                            break;

                        case 'ю':
                            number[i] = 64;
                            break;

                        case 'я':
                            number[i] = 65;
                            break;

                        case 'A':
                            number[i] = 66;
                            break;

                        case 'B':
                            number[i] = 67;
                            break;

                        case 'C':
                            number[i] = 68;
                            break;

                        case 'D':
                            number[i] = 69;
                            break;

                        case 'E':
                            number[i] = 70;
                            break;

                        case 'F':
                            number[i] = 71;
                            break;

                        case 'G':
                            number[i] = 72;
                            break;

                        case 'H':
                            number[i] = 73;
                            break;

                        case 'I':
                            number[i] = 74;
                            break;

                        case 'J':
                            number[i] = 75;
                            break;

                        case 'K':
                            number[i] = 76;
                            break;

                        case 'L':
                            number[i] = 77;
                            break;

                        case 'M':
                            number[i] = 78;
                            break;

                        case 'N':
                            number[i] = 79;
                            break;

                        case 'O':
                            number[i] = 80;
                            break;

                        case 'P':
                            number[i] = 81;
                            break;

                        case 'Q':
                            number[i] = 82;
                            break;

                        case 'R':
                            number[i] = 83;
                            break;

                        case 'S':
                            number[i] = 84;
                            break;

                        case 'T':
                            number[i] = 85;
                            break;

                        case 'U':
                            number[i] = 86;
                            break;

                        case 'V':
                            number[i] = 87;
                            break;

                        case 'W':
                            number[i] = 88;
                            break;

                        case 'X':
                            number[i] = 89;
                            break;

                        case 'Y':
                            number[i] = 90;
                            break;

                        case 'Z':
                            number[i] = 91;
                            break;

                        case 'a':
                            number[i] = 92;
                            break;

                        case 'b':
                            number[i] = 93;
                            break;

                        case 'c':
                            number[i] = 94;
                            break;

                        case 'd':
                            number[i] = 95;
                            break;

                        case 'e':
                            number[i] = 96;
                            break;

                        case 'f':
                            number[i] = 97;
                            break;

                        case 'g':
                            number[i] = 98;
                            break;

                        case 'h':
                            number[i] = 99;
                            break;

                        case 'i':
                            number[i] = 100;
                            break;

                        case 'j':
                            number[i] = 101;
                            break;

                        case 'k':
                            number[i] = 102;
                            break;

                        case 'l':
                            number[i] = 103;
                            break;

                        case 'm':
                            number[i] = 104;
                            break;

                        case 'n':
                            number[i] = 105;
                            break;

                        case 'o':
                            number[i] = 106;
                            break;

                        case 'p':
                            number[i] = 107;
                            break;

                        case 'q':
                            number[i] = 108;
                            break;

                        case 'r':
                            number[i] = 109;
                            break;

                        case 's':
                            number[i] = 110;
                            break;

                        case 't':
                            number[i] = 111;
                            break;

                        case 'u':
                            number[i] = 112;
                            break;

                        case 'v':
                            number[i] = 113;
                            break;

                        case 'w':
                            number[i] = 114;
                            break;

                        case 'x':
                            number[i] = 115;
                            break;

                        case 'y':
                            number[i] = 116;
                            break;

                        case 'z':
                            number[i] = 117;
                            break;

                        case '?':
                            number[i] = 118;
                            break;

                        case '/':
                            number[i] = 119;
                            break;

                        case ',':
                            number[i] = 120;
                            break;

                        case '.':
                            number[i] = 121;
                            break;

                        case ':':
                            number[i] = 122;
                            break;

                        case ';':
                            number[i] = 123;
                            break;

                        case '|':
                            number[i] = 124;
                            break;

                        case '=':
                            number[i] = 125;
                            break;

                        case '+':
                            number[i] = 126;
                            break;

                        case '-':
                            number[i] = 127;
                            break;

                        case '_':
                            number[i] = 128;
                            break;

                        case '(':
                            number[i] = 129;
                            break;

                        case ')':
                            number[i] = 130;
                            break;

                        case '*':
                            number[i] = 131;
                            break;

                        case '&':
                            number[i] = 132;
                            break;

                        case '^':
                            number[i] = 133;
                            break;

                        case '%':
                            number[i] = 134;
                            break;

                        case '$':
                            number[i] = 135;
                            break;

                        case '#':
                            number[i] = 136;
                            break;

                        case '№':
                            number[i] = 137;
                            break;

                        case '@':
                            number[i] = 138;
                            break;

                        case '"':
                            number[i] = 139;
                            break;

                        case '!':
                            number[i] = 140;
                            break;

                        case '{':
                            number[i] = 141;
                            break;

                        case '}':
                            number[i] = 142;
                            break;

                        case '[':
                            number[i] = 143;
                            break;

                        case ']':
                            number[i] = 144;
                            break;

                        case ' ':
                            number[i] = 145;
                            break;

                        case '1':
                            number[i] = 146;
                            break;

                        case '2':
                            number[i] = 147;
                            break;

                        case '3':
                            number[i] = 148;
                            break;

                        case '4':
                            number[i] = 149;
                            break;

                        case '5':
                            number[i] = 150;
                            break;

                        case '6':
                            number[i] = 151;
                            break;

                        case '7':
                            number[i] = 152;
                            break;

                        case '8':
                            number[i] = 153;
                            break;

                        case '9':
                            number[i] = 154;
                            break;

                        case '0':
                            number[i] = 155;
                            break;
                    }
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

