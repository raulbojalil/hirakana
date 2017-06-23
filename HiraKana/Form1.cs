using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HiraKana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        IKeyboardMouseEvents globalHook;
        Timer timer;
        Timer canShowTimer;
        bool hiragana = true;
        bool katakana = true;
        string currentCharacter = string.Empty;
        int[] intervals = { 30000, 60000, 300000, 600000 };
        int selectedInterval = 0;
        bool canShow = true;
        bool showPending = false;
        Random rand = new Random();

        private Dictionary<string, string> characters = new Dictionary<string, string>
        {
            //HIRAGANA

            { "あ", "a" },
            { "か", "ka" },
            { "さ", "sa" },
            { "た", "ta" },
            { "な", "na" },
            { "は", "ha" },
            { "ま", "ma" },
            { "や", "ya" },
            { "ら", "ra" },
            { "わ", "wa" },

            { "が", "ga" },
            { "ざ", "za" },
            { "だ", "da" },

            { "ば", "ba" },
            { "ぱ", "pa" },

            { "い", "i" },
            { "き", "ki" },
            { "し", "shi" },
            { "ち", "chi" },
            { "に", "ni" },
            { "ひ", "hi" },
            { "み", "mi" },

            { "り", "ri" },

            { "ぎ", "gi" },
            { "じ", "ji" },
            { "ぢ", "ji" },
            { "び", "bi" },
            { "ぴ", "pi" },

            { "う", "u" },
            { "く", "ku" },
            { "す", "su" },
            { "つ", "tsu" },
            { "ぬ", "nu" },
            { "ふ", "fu" },
            { "む", "mu" },
            { "ゆ", "yu" },
            { "る", "ru" },

            { "ぐ", "gu" },
            { "ず", "zu" },
            { "づ", "zu" },
            { "ぶ", "bu" },
            { "ぷ", "pu" },

            { "え", "e" },
            { "け", "ke" },
            { "せ", "se" },
            { "て", "te" },
            { "ね", "ne" },
            { "へ", "he" },
            { "め", "me" },

            { "れ", "re" },

            { "げ", "ge" },
            { "ぜ", "ze" },
            { "で", "de" },
            { "べ", "be" },
            { "ぺ", "pe" },

            { "お", "o" },
            { "こ", "ko" },
            { "そ", "so" },
            { "と", "to" },
            { "の", "no" },
            { "ほ", "ho" },
            { "も", "mo" },
            { "よ", "yo" },
            { "ろ", "ro" },
            { "を", "wo" },
            { "ん", "n" },
            { "ご", "go" },
            { "ぞ", "zo" },
            { "ど", "do" },
            { "ぼ", "bo" },
            { "ぽ", "po" },

            //KATAKANA

            { "ア", "a" },
            { "カ", "ka" },
            { "サ", "sa" },
            { "タ", "ta" },
            { "ナ", "na" },
            { "ハ", "ha" },
            { "マ", "ma" },
            { "ヤ", "ya" },
            { "ラ", "ra" },
            { "ワ", "wa" },

            { "ガ", "ga" },
            { "ザ", "za" },
            { "ダ", "da" },
            { "バ", "ba" },
            { "パ", "pa" },

            { "イ","i" },
            { "キ","ki" },
            { "シ","shi" },
            { "チ","chi" },
            { "ニ","ni" },
            { "ヒ","hi" },
            { "ミ","mi" },

            { "リ","ri" },

            { "ギ","gi" },
            { "ジ","ji" },
            { "ヂ","ji" },
            { "ビ","bi" },
            { "ピ","pi" },

            { "ウ","u" },
            { "ク","ku" },
            { "ス","su" },
            { "ツ","tsu" },
            { "ヌ","nu" },
            { "フ","fu" },
            { "ム","mu" },
            { "ユ","yu" },
            { "ル","ru" },

            { "グ","gu" },
            { "ズ","zu" },
            { "ヅ","zu" },
            { "ブ","bu" },
            { "プ","pu" },

            { "エ","e" },
            { "ケ","ke" },
            { "セ","se" },
            { "テ","te" },
            { "ネ","ne" },
            { "ヘ","he" },
            { "メ","me" },

            { "レ","re" },

            { "ゲ","ge" },
            { "ゼ","ze" },
            { "デ","de" },
            { "ベ","be" },
            { "ペ","pe" },

            { "オ","o" },
            { "コ","ko" },
            { "ソ","so" },
            { "ト","to" },
            { "ノ","no" },
            { "ホ","ho" },
            { "モ","mo" },
            { "ヨ","yo" },
            { "ロ","ro" },
            { "ヲ","wo" },
            { "ン","n" },
            { "ゴ","go" },
            { "ゾ","zo" },
            { "ド","do" },
            { "ボ","bo" },
            { "ポ","po" }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            katakanaToolStripMenuItem.Checked = katakana;
            hiraganaToolStripMenuItem.Checked = hiragana;

            selectedInterval = intervals[0];

            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = "こんにちは!";
            notifyIcon.BalloonTipText = "I will be showing you a Japanese question picked at random from time to time for you to answer!. Right click on this icon to show the options menu.";
            notifyIcon.ShowBalloonTip(500);

            WindowState = FormWindowState.Minimized;

            timer = new Timer();
            timer.Tick += (obj, ev) => ShowNextCharacter();
            timer.Start();
            timer.Interval = selectedInterval;

            canShowTimer = new Timer();
            canShowTimer.Interval = 1000;
            canShowTimer.Tick += (obj, ev) =>
            {
                canShow = true;
                if (showPending)
                    ShowNextCharacter();

                canShowTimer.Stop();
            };

            SubscribeMouseKeyboardHooks();

        }

        private void SubscribeMouseKeyboardHooks()
        {
            globalHook = Hook.GlobalEvents();
            globalHook.KeyDown += GlobalKeyboardHook;
            globalHook.MouseMove += GlobalMouseHook;
        }

        private void UnsubscribeMouseKeyboardHooks()
        {
            globalHook.KeyDown -= GlobalKeyboardHook;
            globalHook.MouseMove -= GlobalMouseHook;
            globalHook.Dispose();
        }

        private void GlobalKeyboardHook(object sender, KeyEventArgs e)
        {
            ResetCanShowTimer();
        }

        private void GlobalMouseHook(object sender, MouseEventArgs e)
        {
            ResetCanShowTimer();
        }

        private void ResetCanShowTimer()
        {
            canShow = false;
            canShowTimer.Stop();
            canShowTimer.Start();
        }

        private void GetRandomCharacter()
        {
            currentCharacter = hiragana & katakana ? characters.Keys.ElementAt(rand.Next(characters.Keys.Count)) : 
                (hiragana ? characters.Keys.ElementAt(rand.Next(71)) : characters.Keys.ElementAt(rand.Next(71, characters.Keys.Count)));
            label1.Text = currentCharacter;
            toolTip1.SetToolTip(label1, characters[currentCharacter]);
        }

        private void ShowNextCharacter()
        {
            showPending = false;
            if (canShow)
            {
                WindowState = FormWindowState.Normal;
                Show();
                GetRandomCharacter();
                int x = Screen.PrimaryScreen.WorkingArea.Width - Width;
                int y = Screen.PrimaryScreen.WorkingArea.Height - Height;
                Location = new Point(x, y);
                TopMost = true;
                textBox1.Focus();
                timer.Stop();
            }
            else
                showPending = true;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
                if (textBox1.Text.ToLower() == characters[currentCharacter].ToLower())
                {
                    textBox1.BackColor = Color.White;
                    textBox1.ForeColor = Color.Black;
                    Hide();
                    timer.Start();
                }
                else
                {
                    textBox1.BackColor = Color.Red;
                    textBox1.ForeColor = Color.White;
                }

                textBox1.Text = "";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hiraganaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hiragana = !katakana ? hiragana : !hiragana;
            hiraganaToolStripMenuItem.Checked = hiragana;
        }

        private void katakanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            katakana = !hiragana ? katakana : !katakana;
            katakanaToolStripMenuItem.Checked = katakana;
        }

        private void secToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTimerInterval(Convert.ToInt32((sender as ToolStripMenuItem).Tag));
        }

        private void SetTimerInterval(int intervalIndex)
        {
            selectedInterval = intervals[intervalIndex];
            foreach (ToolStripMenuItem menuItem in timeIntervalToolStripMenuItem.DropDownItems)
            {
                menuItem.Checked = false;
            }
            (timeIntervalToolStripMenuItem.DropDownItems[intervalIndex] as ToolStripMenuItem).Checked = true;

            timer.Stop();
            timer.Interval = selectedInterval;
            timer.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UnsubscribeMouseKeyboardHooks();
        }
    }
}
