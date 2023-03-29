using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Random Generating = new Random();
            int KEY = Generating.Next();
            string KEYString = "";           
            Console.InputEncoding=Encoding.UTF8;
            Console.OutputEncoding=Encoding.UTF8;
            string Alphabet=
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!#№$%&()*+,-./:;<=>?@[]^_`{|}~"+
            "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя ¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º"+
            "»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿĀāĂăĄąĆćĈĉĊċČčĎďĐđĒēĔĕĖ"+
            "ėĘęĚěĜĝĞğĠġĢģĤĥĦħĨĩĪīĬĭĮįİıĲĳĴĵĶķĸĹĺĻļĽľĿŀŁłŃńŅņŇňŉŊŋŌōŎŏŐőŒœŔŕŖŗŘřŚśŜŝŞşŠšŢţŤťŦŧŨũŪūŬŭŮůŰűŲ"+
            "ųŴŵŶŷŸŹźŻżŽžſ‴‖‗―‒‐•❶❷❸❹❺❻❼❽❾❿⓫⓬⓭⓮⓯⓰⓱⓲⓳⓴⓿₠₡₢₣₤₥₦₧₨₩₪₫€₭₮₯₰₱₲₳₴₵"+
            "₸₹₺₻₼₽₾₿Ѳᴁᴂᴆᴚᴔ⁞…⠁⠂⠃⠄⠅⠆⠇⠈⠉⠊⠋⠌⠍⠎⠏⠐⠑⠒⠓⠔⠕⠖⠗⠘⠙⠚⠛⠜⠝⠞⠟⠠⠡⠢⠣⠤⠥⠦⠧⠨⠩⠪⠫⠬⠭⠮⠯⠰⠱⠲⠳⠴⠵⠶⠷⠸⠹⠺⠻⠼⠽⠾⠿⡀⡁⡂⡃⡄⡅⡆⡇⡈⡉⡊⡋"+
            "⡌⡍⡎⡏⡐⡑⡒⡓⡔⡕⡖⡗⡘⡙⡚⡛⡜⡝⡞⡟⡠⡡⡢⡣⡤⡥⡦⡧⡨⡩⡪⡫⡬⡭⡮⡯⡰⡱⡲⡳⡴⡵⡶⡷⡸⡹⡺⡻⡼⡽⡾⡿⢀⢁⢂⢃⢄⢅⢆⢇⢈⢉⢊⢋⢌⢍⢎⢏⢐⢑⢒⢓⢔⢕⢖⢗⢘⢙⢚⢛⢜⢝⢞⢟⢠⢡⢢⢣⢤⢥⢦⢧"+
            "⢨⢩⢪⢫⢬⢭⢮⢯⢰⢱⢲⢳⢴⢵⢶⢷⢸⢹⢺⢻⢼⢽⢾⢿⣀⣁⣂⣃⣄⣅⣆⣇⣈⣉⣊⣋⣌⣍⣎⣏⣐⣑⣒⣓⣔⣕⣖⣗⣘⣙⣚⣛⣜⣝⣞⣟⣠⣡⣢⣣⣤⣥⣦⣧⣨⣩⣪⣫⣬⣭⣮⣯⣰⣱⣲⣳⣴⣵⣶⣷⣸⣹⣺⣻⣼⣽⣾⣿ᐍᐎᐏ"+
            "ᐐᐑᐒᐓᐔᐕᐖᐗᐘᐙᐚᐛᐜᐝᐞᐟᐠᐡᐢᐣᐤᐥᐦᐧᐨᐩᐪᐫᐬᐭᐮᐯᐰᐱᐲᐳᐴᐵᐶᐷᐸᐹᐺᐻᐼᐽᐾᐿᑀᑁᑂᑃᑄᑅᑆᑇᑈᑉᑊᑋᑌᑍᑎᑏᑐᑑᑒᑓᑔᑕᑖᑗᑘᑙᑚ"+
            "ᑛᑜᑝᑞᑟᑠᑡᑢᑣᑤᑥᑦᑧᑨᑩᑪᒃᒄᒅᒆᒇᒈᒉᒊᒋᒌᒍᒎᒏᒐᒑᒒᒓᒔᒕᒖᒗᒘᒙᒚᒛᒜᒝᒞᒟᒠᒡᒢᒣᒤᒥᒦᒧᒨᒩᒪᒫᒬᒭᒮᒯ"+
            "ᒰᒱᒲᒳᒴᒵᒶᒷᒸᒹᒺᓀᓁᓂᓃᓄᓅᓆᓇᓈᓉᓊᓋᓌᓍᓎᓏᓐᓑᓒᓓᓔᓕᓖᓗᓘᓙᓚᓛᓜᓝᓞᓟᓠᓡᓢᓣᓤᓥᓦᓧᓨᓩᓶᓷᓸᓹᓺᓻᓼᓽᓾᓿᔀᔁᔂᔃᔄᔅᔆᔇᔐᔑᔒᔓ"+
            "ᔔᔕᔖᔗᔘᔙᔚᔛᔜᔟᔠᔡᔢᔣᔤᔥᔦᔧᔨᔩᔪᔫᔬᔭᔮᔯᔰᔱᔲᔳᔴᔵᔶᔷᔸᔹᔺᔻᔼᔽᔾᕒᕓᕔᕕᕖᕗᕘᕙᕚᕛᕜᕝᕞᕟᕠᕡᕢᕣᕤᕥᕦᕧᕨᕩᕪᕀᕁᕴᕵᕶᕷᕸᕹᕺᕻᕼᕽᕾᕿᖀᖁᖂᖃᖄᖅ ᚁᚂᚃᚄᚅᚆᚇᚈᚉᚊᚋᚌᚍᚎᚏᚐᚑᚒᚓᚔ";
            Console.WriteLine(Alphabet[128]);
            for (int i = 0; i <= (Alphabet.Length*10)/Convert.ToString(KEY, 2).Length; i++)
            {
                KEYString += Convert.ToString(KEY, 2);
            }
            KEYString = KEYString.Substring(0, Alphabet.Length*10);
           // Console.WriteLine(KEYString);
            string s = "";
            for (int i = 0;i< Alphabet.Length; i++)
            {
               s+=Convert.ToString(i, 2).PadLeft(10, '0');
            }       
            s = XOR(s, KEYString);
            for (int i = 0; i < s.Length; i+=10)
            {
                Console.Write(Alphabet[Convert.ToInt32(s.Substring(i, 10), 2)]);
            }
            s = XOR(s, KEYString);
            Console.WriteLine();
            for (int i = 0; i < s.Length; i += 10)
            {
                Console.Write(Alphabet[Convert.ToInt32(s.Substring(i, 10), 2)]);
            }
            //Console.WriteLine(XOR(s, KEYString).Length);
            Console.ReadKey();
        }
        static string XOR(string text, string pas)
        {
            string s = "";
            for (int i = 0; i< text.Length; i++)
            {
                if (text[i] == '0' && pas[i] == '1' || text[i] == '1' && pas[i] == '0')
                {
                    s += '1';
                }
                else
                    s += '0';
            }
            return s;
        }
    }
}

/*
 * case "ENCRYPT":
                        Phrases("iutxt");
                        text = Console.ReadLine();
                        KEY = Generating.Next();
                        int[] number = new int[text.Length];
                        Random random = new(KEY);
                        for (int i = 0; i < text.Length; i++)
                            number[i] = Alphabet.IndexOf(text[i]);
                        Phrases("oetxt");
                        text = "";
                        for (int i = 0; i < number.Length; i++)
                        {
                            number[i] += random.Next(1, Alphabet.Length);
                            if (number[i] >= Alphabet.Length) 
                                number[i] %= Alphabet.Length;
                            text += Convert.ToString(number[i], 2).PadLeft(10, '0');
                        }                         
                        text = XOR(text);
                        for (int i = 0; i < text.Length; i += 10)
                        {
                            Console.Write(Alphabet[Convert.ToInt32(text.Substring(i, 10), 2)]);
                        }
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
                            Phrases("odtxt");
                            text = "";
                            for (int i = 0; i < number.Length; i++)
                            {
                                number[i] -= random.Next(1, Alphabet.Length);
                                if (number[i] < 0)
                                    number[i] += Alphabet.Length;
                                text += Convert.ToString(number[i], 2).PadLeft(10, '0');
                            }
                            text = XOR(text);
                            for (int i = 0; i < text.Length; i += 10)
                            {
                                Console.Write(Alphabet[Convert.ToInt32(text.Substring(i, 10), 2)]);
                            }
                            Console.WriteLine();


static string XOR(string text)
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
*/