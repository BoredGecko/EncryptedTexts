using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTextEncryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            keyReset();
        }
        public static string Alphabet =
       "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!#№$%&()*+,-./:;<=>?@[]^_`{|}~АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя ¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º»¼½¾¿" +
       "ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿĀāĂăĄąĆćĈĉĊċČčĎďĐđĒēĔĕĖėĘęĚěĜĝĞğĠġĢģĤĥĦħĨĩĪīĬĭĮįİıĲĳĴĵĶķĸĹĺĻļĽľĿŀŁłŃńŅņŇňŉŊŋŌōŎŏŐőŒœŔŕŖŗŘřŚśŜŝŞşŠšŢţŤťŦŧŨũŪūŬŭŮůŰűŲųŴŵŶŷŸŹźŻż" +
       "Žžſ‴‖‗―‒‐•❶❷❸❹❺❻❼❽❾❿⓫⓬⓭⓮⓯⓰⓱⓲⓳⓴⓿₠₡₢₣₤₥₦₧₨₩₪₫€₭₮₯₰₱₲₳₴₵₸₹₺₻₼₽₾₿Ѳᴁᴂᴆᴚᴔ⁞…⠁⠂⠃⠄⠅⠆⠇⠈⠉⠊⠋⠌⠍⠎⠏⠐⠑⠒⠓⠔⠕⠖⠗⠘⠙⠚⠛⠜⠝⠞⠟⠠⠡⠢⠣⠤⠥⠦⠧⠨⠩⠪⠫⠬⠭⠮⠯⠰⠱⠲⠳⠴⠵⠶⠷⠸⠹⠺⠻⠼⠽⠾⠿⡀⡁⡂⡃⡄⡅⡆⡇⡈⡉⡊⡋⡌⡍⡎⡏⡐⡑⡒⡓⡔⡕⡖⡗⡘⡙⡚⡛⡜⡝⡞⡟⡠⡡⡢⡣⡤⡥⡦⡧⡨⡩" +
       "⡪⡫⡬⡭⡮⡯⡰⡱⡲⡳⡴⡵⡶⡷⡸⡹⡺⡻⡼⡽⡾⡿⢀⢁⢂⢃⢄⢅⢆⢇⢈⢉⢊⢋⢌⢍⢎⢏⢐⢑⢒⢓⢔⢕⢖⢗⢘⢙⢚⢛⢜⢝⢞⢟⢠⢡⢢⢣⢤⢥⢦⢧⢨⢩⢪⢫⢬⢭⢮⢯⢰⢱⢲⢳⢴⢵⢶⢷⢸⢹⢺⢻⢼⢽⢾⢿⣀⣁⣂⣃⣄⣅⣆⣇⣈⣉⣊⣋⣌⣍⣎⣏⣐⣑⣒⣓⣔⣕⣖⣗⣘⣙⣚⣛⣜⣝⣞⣟⣠⣡⣢⣣⣤⣥⣦⣧⣨⣩⣪⣫⣬⣭⣮⣯⣰⣱⣲⣳⣴⣵⣶⣷⣸⣹⣺⣻⣼⣽⣾⣿ᐍᐎᐏᐐᐑᐒᐓᐔᐕᐖᐗᐘᐙᐚᐛᐜᐝᐞᐟᐠᐡᐢᐣᐤᐥᐦᐧᐨᐩᐪᐫᐬᐭᐮᐯ" +
       "ᐰᐱᐲᐳᐴᐵᐶᐷᐸᐹᐺᐻᐼᐽᐾᐿᑀᑁᑂᑃᑄᑅᑆᑇᑈᑉᑊᑋᑌᑍᑎᑏᑐᑑᑒᑓᑔᑕᑖᑗᑘᑙᑚᑛᑜᑝᑞᑟᑠᑡᑢᑣᑤᑥᑦᑧᑨᑩᑪᒃᒄᒅᒆᒇᒈᒉᒊᒋᒌᒍᒎᒏᒐᒑᒒᒔᒖᒗᒘᒙᒚᒛᒜᒝᒞᒟᒠᒡᒢᒣᒤᒥᒦᒧᒨᒩᒪᒫᒬᒭᒮᒯᒰᒱᒲᒳᒴᒵᒶᒷᒸᒹᒺᓀᓁᓂᓃᓄᓅᓆᓇᓈᓉᓊᓋᓌᓍᓎᓏᓐᓑᓒᓓᓔᓕᓖᓗᓘᓙᓚᓛᓜᓝᓞᓟᓠᓡᓢᓣᓤᓥᓦᓧᓨ" +
       "ᓩᓶᓷᓸᓹᓺᓻᓼᓽᓾᓿᔀᔁᔂᔃᔄᔅᔆᔇᔐᔑᔒᔓᔔᔕᔖᔗᔘᔙᔚᔛᔜᔟᔠᔡᔢᔣᔤ—ᔦᔧᔨᔩᔪᔫᔬᔭᔮᔯᔰᔱᔲᔳᔴᔵᔶᔷᔸᔹᔺᔻᔼᔽᔾᕒᕓᕔᕕᕖᕗᕘᕙᕚᕛᕜᕝᕞᕟᕠᕡᕢᕣᕤᕥᕦᕧᕨᕩᕪᕀᕁᕴᕵᕶᕷᕸᕹᕺᕻᕼᕽᕾᕿᖀᖁᖂᖃᖄᖅ ᚁᚂᚃᚄᚅᚆᚇᚈᚉᚊᚋᚌᚍᚎᚏᚐᚑᚒᚓᚔ\\\n";
        public static int Key; //Ключ шифрования
        public static Random Generator = new Random();
        private void convertText_Click(object sender, EventArgs e)
        {
            String Message = ""; //Текст
            progressCrypting.Value = progressCrypting.Minimum;
            progressCrypting.Maximum = textFirst.Text.Length;
            if (modeEncrypt.Checked)
            {
                if (keyModeRand.Checked)
                {
                    Key = Generator.Next(0, 999999999);
                    keyValue.Text = "Ключ: " + Key.ToString();
                }
                //Генерация псевдослучайной последовательности
                Generator = new Random(Key);
                //Удлинение ключа в двоичной системе счисления
                string longKey = "";
                for (int i = 0; i <= (textFirst.TextLength * 10) / Convert.ToString(Key, 2).Length; i++) 
                    longKey += Convert.ToString(Key, 2);
                longKey = longKey.Substring(0, textFirst.TextLength * 10);
                int index = 0;

                for (int i = 0; i < textFirst.TextLength; i++)
                {
                    char[] symbol = Convert.ToString((Alphabet.IndexOf(textFirst.Text[i]) + Generator.Next(0, Alphabet.Length)) % Alphabet.Length, 2).PadLeft(10, '0').ToCharArray();
                    //Операция "Исключающее или"
                    for (int j = 0; j < symbol.Length; ++j, ++index)
                        if (symbol[j] == longKey[index])
                            symbol[j] = '0';
                        else
                            symbol[j] = '1';
                    Message += Alphabet[Convert.ToInt32(new string(symbol), 2)%Alphabet.Length];
                    ++progressCrypting.Value;
                }
            }
            else if (modeDecrypt.Checked)
            {
                //Генерация псевдослучайной последовательности
                Generator = new Random(Key);
                //Удлинение ключа в двоичной системе счисления
                string longKey = "";
                for (int i = 0; i <= (textFirst.TextLength * 10) / Convert.ToString(Key, 2).Length; i++)
                    longKey += Convert.ToString(Key, 2);
                longKey = longKey.Substring(0, textFirst.TextLength * 10);
                int index = 0;
                for (int i = 0; i < textFirst.TextLength; i++)
                {
                    char[] symbol = Convert.ToString((Alphabet.IndexOf(textFirst.Text[i]) - Generator.Next(0, Alphabet.Length) + Alphabet.Length) % Alphabet.Length, 2).PadLeft(10, '0').ToCharArray();
                    //Операция "Исключающее или"
                    for (int j = 0; j < symbol.Length; ++j, ++index)
                        if (symbol[j] == longKey[index])
                            symbol[j] = '0';
                        else
                            symbol[j] = '1';
                    Message += Alphabet[Convert.ToInt32(new string(symbol), 2) % Alphabet.Length];
                    ++progressCrypting.Value;
                }
            }
            textSecond.Text = Message;
        }

        private void keyModeInput_CheckedChanged(object sender, EventArgs e)
        {
            if (keyModeInput.Checked)
            {
                groupKey.Enabled = true;
                keyReset();
            }              
        }

        private void modeEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            keyReset();
            if (modeEncrypt.Checked)
            {
                convertText.Text = "Зашифровать";
                keyModeRand.Enabled = true;
                keyModeInput.Enabled = true;
                modeClipboardKeyOnly.Enabled = true;
                modeClipboardTextAndKey.Enabled = true;
                keyModeRand.Visible = true;
                keyModeInput.Visible = true;
                groupKey.Location = new Point(8, 53);
                keyValue.Location = new Point(13, 112);
                groupKeyMode.Size = new Size(215, 135);
                groupClipboard.Location = new Point(7, 223);
                if (keyModeInput.Checked)
                    groupKey.Enabled = true;
                else 
                    groupKey.Enabled = false;
            }            
        }

        private void keyInput_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(keyInput.Text))
            {
                Key = Convert.ToInt32(keyInput.Text);
                keyInput.Text = Key.ToString();
                keyValue.Text = "Ключ: " + Key.ToString();
            }
            else
            {
                keyInput.Text = "0";
            }
        }

        private void keyInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void keyModeRand_CheckedChanged(object sender, EventArgs e)
        {
            if (keyModeRand.Checked)
            {
                keyReset();
                groupKey.Enabled = false;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (modeClipboardTextOnly.Checked)
                if(textSecond.TextLength!=0)
                    Clipboard.SetText(textSecond.Text);
            if (modeClipboardKeyOnly.Checked)
                Clipboard.SetText(Key.ToString());
            if (modeClipboardTextAndKey.Checked)
                if (textSecond.TextLength != 0)
                    Clipboard.SetText(textSecond.Text + '\n' + "Ключ: " + Key.ToString());

        }

        private void modeDecrypt_CheckedChanged(object sender, EventArgs e)
        {

            if (modeDecrypt.Checked)
            {
                convertText.Text = "Расшифровать";
                keyModeRand.Enabled = false;
                keyModeInput.Enabled = false;
                keyModeRand.Visible = false;
                keyModeInput.Visible = false;
                groupKey.Location = new Point(8, 21);
                keyValue.Location = new Point(13, 80);
                groupKeyMode.Size = new Size(215, 104);
                groupKey.Enabled = true;
                modeClipboardKeyOnly.Enabled = false;
                modeClipboardTextAndKey.Enabled = false;
                modeClipboardTextOnly.Checked = true;
                groupClipboard.Location = new Point(7, 191);
            }
        }

        public void keyReset()
        {
            Key = 0;
            keyInput.Text = Key.ToString();
            keyValue.Text = "Ключ: " + Key.ToString();
            textFirst.Clear();
            textSecond.Clear();
            progressCrypting.Value = 0;
        }

    }
}
