﻿ushort n = 1;
byte KEY;
string text = "";
char[] alphabet = new char[90] { '2', '&', 'P', 'b', '*', 'Z', 'a', '8', 'B', 't', ':', 'u', 'v', '(', 'Q', '1', 'i', ')', 'w', 'x', ']', 'D', '№', '6', 'E', 'T', '"', 'j', 'k', 'l', '7', 'G', 'm', 'n', 'I', 'z', '!', '@', '#', '4', '%', '^', 'o', 'p', 'H', '_', '=', 'R', 'S', '?', ',', 'W', 'X', '3', 'J', 'K', 'y', '/', '|', ' ', 'Y', 'C', 'e', 'f', 'g', '9', '{', 'N', 'O', '}', '[', 'L', 'M', 'c', 'q', 'U', 'V', 'd', 'r', '5', 'h', 'A', '.', '$', 's', ';', 'F', '-', '+', '0'};
for (int j = 0; j < n; j++)
{
    Console.Write("Encryptor/Decryptor [e/d]? >> ");
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
                for (int i = 0; i < text.Length; i++)
                {
                    letters[i] = text[i];
                    switch (letters[i])
                    {
                        case '2':
                            number[i] = 0;
                            break;

                        case '&':
                            number[i] = 1;
                            break;

                        case 'P':
                            number[i] = 2;
                            break;

                        case 'b':
                            number[i] = 3;
                            break;

                        case '*':
                            number[i] = 4;
                            break;

                        case 'Z':
                            number[i] = 5;
                            break;

                        case 'a':
                            number[i] = 6;
                            break;
                           
                        case '8':
                            number[i] = 7;
                            break;

                        case 'B':
                            number[i] = 8;
                            break;

                        case 't':
                            number[i] = 9;
                            break;

                        case ':':
                            number[i] = 10;
                            break;

                        case 'u':
                            number[i] = 11;
                            break;

                        case 'v':
                            number[i] = 12;
                            break;

                        case '(':
                            number[i] = 13;
                            break;

                        case 'Q':
                            number[i] = 14;
                            break;

                        case '1':
                            number[i] = 15;
                            break;

                        case 'i':
                            number[i] = 16;
                            break;

                        case ')':
                            number[i] = 17;
                            break;

                        case 'w':
                            number[i] = 18;
                            break;

                        case 'x':
                            number[i] = 19;
                            break;

                        case ']':
                            number[i] = 20;
                            break;

                        case 'D':
                            number[i] = 21;
                            break;

                        case '№':
                            number[i] = 22;
                            break;

                        case '6':
                            number[i] = 23;
                            break;

                        case 'E':
                            number[i] = 24;
                            break;
                       
                        case 'T':
                            number[i] = 25;
                            break;

                        case '"':
                            number[i] = 26;
                            break;

                        case 'j':
                            number[i] = 27;
                            break;

                        case 'k':
                            number[i] = 28;
                            break;

                        case 'l':
                            number[i] = 29;
                            break;

                        case '7':
                            number[i] = 30;
                            break;

                        case 'G':
                            number[i] = 31;
                            break;

                        case 'm':
                            number[i] = 32;
                            break;

                        case 'n':
                            number[i] = 33;
                            break;

                        case 'I':
                            number[i] = 34;
                            break;

                        case 'z':
                            number[i] = 35;
                            break;

                        case '!':
                            number[i] = 36;
                            break;

                        case '@':
                            number[i] = 37;
                            break;
                        
                        case '#':
                            number[i] = 38;
                            break;

                        case '4':
                            number[i] = 39;
                            break;

                        case '%':
                            number[i] = 40;
                            break;

                        case '^':
                            number[i] = 41;
                            break;

                        case 'o':
                            number[i] = 42;
                            break;

                        case 'p':
                            number[i] = 43;
                            break;

                        case 'H':
                            number[i] = 44;
                            break;

                        case '_':
                            number[i] = 45;
                            break;

                        case '=':
                            number[i] = 46;
                            break;

                        case 'R':
                            number[i] = 47;
                            break;

                        case 'S':
                            number[i] = 48;
                            break;

                        case '?':
                            number[i] = 49;
                            break;

                        case ',':
                            number[i] = 50;
                            break;
                        
                        case 'W':
                            number[i] = 51;
                            break;

                        case 'X':
                            number[i] = 52;
                            break;

                        case '3':
                            number[i] = 53;
                            break;

                        case 'J':
                            number[i] = 54;
                            break;

                        case 'K':
                            number[i] = 55;
                            break;

                        case 'y':
                            number[i] = 56;
                            break;

                        case '/':
                            number[i] = 57;
                            break;

                        case '|':
                            number[i] = 58;
                            break;

                        case ' ':
                            number[i] = 59;
                            break;

                        case 'Y':
                            number[i] = 60;
                            break;

                        case 'C':
                            number[i] = 61;
                            break;

                        case 'e':
                            number[i] = 62;
                            break;
                        
                        case 'f':
                            number[i] = 63;
                            break;

                        case 'g':
                            number[i] = 64;
                            break;

                        case '9':
                            number[i] = 65;
                            break;

                        case '{':
                            number[i] = 66;
                            break;

                        case 'N':
                            number[i] = 67;
                            break;

                        case 'O':
                            number[i] = 68;
                            break;

                        case '}':
                            number[i] = 69;
                            break;

                        case '[':
                            number[i] = 70;
                            break;

                        case 'L':
                            number[i] = 71;
                            break;

                        case 'M':
                            number[i] = 72;
                            break;

                        case 'c':
                            number[i] = 73;
                            break;

                        case 'q':
                            number[i] = 74;
                            break;
                            
                        case 'U':
                            number[i] = 75;
                            break;

                        case 'V':
                            number[i] = 76;
                            break;

                        case 'd':
                            number[i] = 77;
                            break;

                        case 'r':
                            number[i] = 78;
                            break;

                        case '5':
                            number[i] = 79;
                            break;
                        case 'h':
                            number[i] = 80;
                            break;
                        case 'A':
                            number[i] = 81;
                            break;
                        case '.':
                            number[i] = 82;
                            break;
                        case '$':
                            number[i] = 83;
                            break;
                        case 's':
                            number[i] = 84;
                            break;
                        case ';':
                            number[i] = 85;
                            break;
                        case 'F':
                            number[i] = 86;
                            break;
                        case '-':
                            number[i] = 87;
                            break;
                        case '+':
                            number[i] = 88;
                            break;
                        case '0':
                            number[i] = 89;
                            break;
                        default:
                            number[i] = 0;
                            break;
                    }
                }
                Random random = new Random();
                KEY = Convert.ToByte(random.Next(1, 90));
                for (int i = 0; i < text.Length; i++)
                {
                    if (number[i] + KEY > 89) number[i] = number[i] + KEY - 90;
                    else number[i] += KEY;
                    letters[i] = alphabet[number[i]];
                }
                Console.WriteLine("\nEncrypted text:");
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(letters[i]);
                }
                Console.Write("\nDecrypt key >> " + KEY + "\n\nPress any key...");
                Console.ReadKey();
            }
            break;

        case "d":
        case "D":
            {
                Console.Clear();
                Console.WriteLine("Enter encrypted text:");
                text = Console.ReadLine();
                Console.Write("\nEnter decrypt key >> ");
                KEY = Convert.ToByte(Console.ReadLine());
                char[] letters = new char[text.Length];
                int[] number = new int[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    letters[i] = text[i];
                    switch (letters[i])
                    {
                        case '2':
                            number[i] = 0;
                            break;

                        case '&':
                            number[i] = 1;
                            break;

                        case 'P':
                            number[i] = 2;
                            break;

                        case 'b':
                            number[i] = 3;
                            break;

                        case '*':
                            number[i] = 4;
                            break;

                        case 'Z':
                            number[i] = 5;
                            break;

                        case 'a':
                            number[i] = 6;
                            break;

                        case '8':
                            number[i] = 7;
                            break;

                        case 'B':
                            number[i] = 8;
                            break;

                        case 't':
                            number[i] = 9;
                            break;

                        case ':':
                            number[i] = 10;
                            break;

                        case 'u':
                            number[i] = 11;
                            break;

                        case 'v':
                            number[i] = 12;
                            break;

                        case '(':
                            number[i] = 13;
                            break;

                        case 'Q':
                            number[i] = 14;
                            break;

                        case '1':
                            number[i] = 15;
                            break;

                        case 'i':
                            number[i] = 16;
                            break;

                        case ')':
                            number[i] = 17;
                            break;

                        case 'w':
                            number[i] = 18;
                            break;

                        case 'x':
                            number[i] = 19;
                            break;

                        case ']':
                            number[i] = 20;
                            break;

                        case 'D':
                            number[i] = 21;
                            break;

                        case '№':
                            number[i] = 22;
                            break;

                        case '6':
                            number[i] = 23;
                            break;

                        case 'E':
                            number[i] = 24;
                            break;

                        case 'T':
                            number[i] = 25;
                            break;

                        case '"':
                            number[i] = 26;
                            break;

                        case 'j':
                            number[i] = 27;
                            break;

                        case 'k':
                            number[i] = 28;
                            break;

                        case 'l':
                            number[i] = 29;
                            break;

                        case '7':
                            number[i] = 30;
                            break;

                        case 'G':
                            number[i] = 31;
                            break;

                        case 'm':
                            number[i] = 32;
                            break;

                        case 'n':
                            number[i] = 33;
                            break;

                        case 'I':
                            number[i] = 34;
                            break;

                        case 'z':
                            number[i] = 35;
                            break;

                        case '!':
                            number[i] = 36;
                            break;

                        case '@':
                            number[i] = 37;
                            break;

                        case '#':
                            number[i] = 38;
                            break;

                        case '4':
                            number[i] = 39;
                            break;

                        case '%':
                            number[i] = 40;
                            break;

                        case '^':
                            number[i] = 41;
                            break;

                        case 'o':
                            number[i] = 42;
                            break;

                        case 'p':
                            number[i] = 43;
                            break;

                        case 'H':
                            number[i] = 44;
                            break;

                        case '_':
                            number[i] = 45;
                            break;

                        case '=':
                            number[i] = 46;
                            break;

                        case 'R':
                            number[i] = 47;
                            break;

                        case 'S':
                            number[i] = 48;
                            break;

                        case '?':
                            number[i] = 49;
                            break;

                        case ',':
                            number[i] = 50;
                            break;

                        case 'W':
                            number[i] = 51;
                            break;

                        case 'X':
                            number[i] = 52;
                            break;

                        case '3':
                            number[i] = 53;
                            break;

                        case 'J':
                            number[i] = 54;
                            break;

                        case 'K':
                            number[i] = 55;
                            break;

                        case 'y':
                            number[i] = 56;
                            break;

                        case '/':
                            number[i] = 57;
                            break;

                        case '|':
                            number[i] = 58;
                            break;

                        case ' ':
                            number[i] = 59;
                            break;

                        case 'Y':
                            number[i] = 60;
                            break;

                        case 'C':
                            number[i] = 61;
                            break;

                        case 'e':
                            number[i] = 62;
                            break;

                        case 'f':
                            number[i] = 63;
                            break;

                        case 'g':
                            number[i] = 64;
                            break;

                        case '9':
                            number[i] = 65;
                            break;

                        case '{':
                            number[i] = 66;
                            break;

                        case 'N':
                            number[i] = 67;
                            break;

                        case 'O':
                            number[i] = 68;
                            break;

                        case '}':
                            number[i] = 69;
                            break;

                        case '[':
                            number[i] = 70;
                            break;

                        case 'L':
                            number[i] = 71;
                            break;

                        case 'M':
                            number[i] = 72;
                            break;

                        case 'c':
                            number[i] = 73;
                            break;

                        case 'q':
                            number[i] = 74;
                            break;

                        case 'U':
                            number[i] = 75;
                            break;

                        case 'V':
                            number[i] = 76;
                            break;

                        case 'd':
                            number[i] = 77;
                            break;

                        case 'r':
                            number[i] = 78;
                            break;

                        case '5':
                            number[i] = 79;
                            break;
                        case 'h':
                            number[i] = 80;
                            break;
                        case 'A':
                            number[i] = 81;
                            break;
                        case '.':
                            number[i] = 82;
                            break;
                        case '$':
                            number[i] = 83;
                            break;
                        case 's':
                            number[i] = 84;
                            break;
                        case ';':
                            number[i] = 85;
                            break;
                        case 'F':
                            number[i] = 86;
                            break;
                        case '-':
                            number[i] = 87;
                            break;
                        case '+':
                            number[i] = 88;
                            break;
                        case '0':
                            number[i] = 89;
                            break;
                        default:
                            number[i] = 0;
                            break;
                    }
                }
                for (int i = 0; i < text.Length; i++)
                {
                    if (number[i] - KEY < 0) number[i] = number[i] - KEY + 90;
                    else number[i] = number[i] - KEY;
                    letters[i] = alphabet[number[i]];                   
                }
                Console.WriteLine("\nDecrypted text:");
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(letters[i]);
                }
                Console.WriteLine("\n\nPress any key...");
                Console.ReadKey();
            }
            break;
         
        default:
            {
                Console.Write("\nIncorrect. Try again.");
                Thread.Sleep(1000);
                Console.Clear();
                n++;
            }
            break;
    }
}