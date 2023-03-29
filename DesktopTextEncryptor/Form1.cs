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
       "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!#№$%&()*+,-./:;<=>?@[]^_`{|}~АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +
           "абвгдеёжзийклмнопрстуфхцчшщъыьэюя ¡¢£¤¥¦§¨©ª«¬­®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷ø" +
           "ùúûüýþÿĀāĂăĄąĆćĈĉĊċČčĎďĐđĒēĔĕĖėĘęĚěĜĝĞğĠġĢģĤĥĦħĨĩĪīĬĭĮįİıĲĳĴĵĶķĸĹĺĻļĽľĿŀŁłŃńŅņŇňŉŊŋŌōŎŏŐőŒœŔŕŖŗŘřŚśŜŝŞşŠšŢţŤťŦŧŨũŪūŬŭŮůŰű" +
           "ŲųŴŵŶŷŸŹźŻżŽžſ‴‖‗―‒‐•❶❷❸❹❺❻❼❽❾❿⓫⓬⓭⓮⓯⓰⓱⓲⓳⓴⓿₠₡₢₣₤₥₦₧₨₩₪₫€₭₮₯₰₱₲₳₴₵₸₹₺₻₼₽₾₿Ѳᴁᴂᴆᴚᴔ⁞…⠁⠂⠃⠄⠅⠆⠇⠈⠉⠊⠋⠌⠍⠎⠏⠐⠑⠒⠓⠔⠕⠖⠗⠘⠙⠚" +
           "⠛⠜⠝⠞⠟⠠⠡⠢⠣⠤⠥⠦⠧⠨⠩⠪⠫⠬⠭⠮⠯⠰⠱⠲⠳⠴⠵⠶⠷⠸⠹⠺⠻⠼⠽⠾⠿⡀⡁⡂⡃⡄⡅⡆⡇⡈⡉⡊⡋⡌⡍⡎⡏⡐⡑⡒⡓⡔⡕⡖⡗⡘⡙⡚⡛⡜⡝⡞⡟⡠⡡⡢⡣⡤⡥⡦⡧⡨⡩⡪⡫⡬⡭⡮⡯⡰⡱⡲⡳⡴⡵⡶⡷⡸⡹⡺⡻⡼⡽⡾⡿⢀⢁⢂⢃⢄⢅⢆⢇⢈⢉⢊⢋⢌⢍⢎⢏⢐⢑⢒⢓" +
           "⢔⢕⢖⢗⢘⢙⢚⢛⢜⢝⢞⢟⢠⢡⢢⢣⢤⢥⢦⢧⢨⢩⢪⢫⢬⢭⢮⢯⢰⢱⢲⢳⢴⢵⢶⢷⢸⢹⢺⢻⢼⢽⢾⢿⣀⣁⣂⣃⣄⣅⣆⣇⣈⣉⣊⣋⣌⣍⣎⣏⣐⣑⣒⣓⣔⣕⣖⣗⣘⣙⣚⣛⣜⣝⣞⣟⣠⣡⣢⣣⣤⣥⣦⣧⣨⣩⣪⣫⣬⣭⣮⣯⣰⣱⣲⣳⣴⣵⣶⣷⣸⣹⣺⣻⣼⣽⣾⣿ᐍᐎᐏᐐᐑᐒᐓᐔᐕᐖ" +
           "ᐗᐘᐙᐚᐛᐜᐝᐞᐟᐠᐡᐢᐣᐤᐥᐦᐧᐨᐩᐪᐫᐬᐭᐮᐯᐰᐱᐲᐳᐴᐵᐶᐷᐸᐹᐺᐻᐼᐽᐾᐿᑀᑁᑂᑃᑄᑅᑆᑇᑈᑉᑊᑋᑌᑍᑎᑏᑐᑑᑒᑓᑔᑕᑖᑗᑘᑙᑚᑛᑜᑝᑞᑟᑠᑡᑢᑣᑤᑥᑦᑧᑨᑩᑪᒃᒄᒅᒆᒇᒈᒉᒊᒋᒌᒍᒎᒏᒐᒑᒒᒓᒔ" +
           "ᒕᒖᒗᒘᒙᒚᒛᒜᒝᒞᒟᒠᒡᒢᒣᒤᒥᒦᒧᒨᒩᒪᒫᒬᒭᒮᒯᒰᒱᒲᒳᒴᒵᒶᒷᒸᒹᒺᓀᓁᓂᓃᓄᓅᓆᓇᓈᓉᓊᓋᓌᓍᓎᓏᓐᓑᓒᓓᓔᓕᓖᓗᓘᓙᓚᓛᓜᓝᓞᓟᓠᓡᓢᓣᓤᓥᓦᓧᓨᓩᓶᓷᓸᓹᓺᓻᓼᓽᓾᓿᔀᔁᔂᔃᔄᔅᔆᔇᔐᔑᔒᔓᔔᔕ" +
           "ᔖᔗᔘᔙᔚᔛᔜᔟᔠᔡᔢᔣᔤᔥᔦᔧᔨᔩᔪᔫᔬᔭᔮᔯᔰᔱᔲᔳᔴᔵᔶᔷᔸᔹᔺᔻᔼᔽᔾᕒᕓᕔᕕᕖᕗᕘᕙᕚᕛᕜᕝᕞᕟᕠᕡᕢᕣᕤᕥᕦᕧᕨᕩᕪᕀᕁᕴᕵᕶᕷᕸᕹᕺᕻᕼᕽᕾᕿᖀᖁᖂᖃᖄᖅ ᚁᚂᚃᚄᚅᚆᚇᚈᚉᚊᚋᚌᚍᚎᚏᚐᚑᚒᚓᚔ\\\n";
        public static string Message; //Текст
        public static int Key = 0; //Ключ шифрования
        public static Random Generator = new Random();
        private void convertText_Click(object sender, EventArgs e)
        {
            String tmpMessage = "";
            progressCrypting.Value = progressCrypting.Minimum;
            progressCrypting.Maximum = textFirst.Text.Length;
            if (modeEncrypt.Checked)
            {
                if (keyModeInput.Checked)
                {
                    Random shift = new Random(Key);
                    for (int i = 0; i < textFirst.TextLength; i++)
                    {
                        tmpMessage += Alphabet.ElementAt((Alphabet.IndexOf(textFirst.Text[i]) + shift.Next(0, Alphabet.Length)) % Alphabet.Length);
                        ++progressCrypting.Value;
                    }
                }
                else if (keyModeRand.Checked)
                {
                    Key = Generator.Next(0, 999999999);
                    keyValue.Text = "Ключ: " + Key.ToString();
                    Random shift = new Random(Key);
                    for (int i = 0; i < textFirst.TextLength; i++)
                    {
                        tmpMessage += Alphabet.ElementAt((Alphabet.IndexOf(textFirst.Text[i]) + shift.Next(0, Alphabet.Length)) % Alphabet.Length);
                        ++progressCrypting.Value;
                    }
                }
            }
            else if (modeDecrypt.Checked)
            {
                Random shift = new Random(Key);
                for (int i = 0; i < textFirst.TextLength; i++)
                {
                    int index = Alphabet.IndexOf(textFirst.Text[i]) - shift.Next(0, Alphabet.Length);
                    if (index < 0)
                        index += Alphabet.Length;
                    tmpMessage += Alphabet.ElementAt(index);
                    ++progressCrypting.Value;
                }

            }
            textSecond.Text = tmpMessage;
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
                groupKey.Location = new Point(8, 60);
                keyValue.Location = new Point(13, 119);
                groupKeyMode.Size = new Size(215, 143);
                groupClipboard.Location = new Point(7, 230);
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
                keyValue.Text = "Ключ: " + Key.ToString();
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
                Clipboard.SetText(textSecond.Text);
            if (modeClipboardKeyOnly.Checked)
                Clipboard.SetText(Key.ToString());
            if (modeClipboardTextAndKey.Checked)
                Clipboard.SetText(textSecond.Text + '\n' + "Ключ: " + Key.ToString());

        }

        private void textFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
 
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
        }
    }
}
