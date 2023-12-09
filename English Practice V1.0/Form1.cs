using Microsoft.VisualBasic.ApplicationServices;
using System.Text;

namespace English_Practice_V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("wordlist.wl"))
            {
                File.Create("wordlist.wl");
            }
            importWords();
            giveNewWord();
        }

        private void kELÝMEEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordForm wordForm = new wordForm();
            wordForm.ShowDialog();
            if (wordForm.isWordAdded)
            {
                importWords();
                giveNewWord();
            }
        }

        public static List<string> wordList = new List<string>();

        void importWords()
        {
            wordList.Clear();
            if (File.Exists("wordlist.wl"))
            {
                StreamReader sk = new StreamReader("wordlist.wl", Encoding.GetEncoding("utf-8"));
                while (true)
                {
                    var read = sk.ReadLine(); if (string.IsNullOrEmpty(read))
                    {
                        break;
                    }
                    string word = read.ToString();
                    wordList.Add(word);
                }
                sk.Close();
                sk.Dispose();
            }
        }

        string word = "word";
        string answer = "answer";
        static Random Random = new Random();

        int answerIndex = -1;
        void giveNewWord()
        {
            if (wordList.Count < 5)
            {
                button1.Enabled=false;
                return;
            }

            string temp = label1.Text;

            while (true)
            {
                radioButton1.Text = "a";
                radioButton2.Text = "b";
                radioButton3.Text = "c";
                radioButton4.Text = "d";

                radioButton1.Checked=true;
                string line = wordList[Random.Next(wordList.Count)];
                word = line.Split(" -*- ")[0];
                answer = line.Split(" -*- ")[1];

                label1.Text = word;

                int randomNumber = Random.Next(1, 5);

                RadioButton[] radioButtons = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 };
                answerIndex = randomNumber - 1;
                radioButtons[answerIndex].Text = answer;
                for (int i = 0; i < radioButtons.Length; i++)
                {
                    if (i != answerIndex)
                    {
                        radioButtons[i].Text = giveFakeAnswer();
                    }
                }
                if (temp != label1.Text) break;
            }
            button1.Enabled = true;
        }




        string giveFakeAnswer()
        {
        again:
            while (true)
            {
                string fakeLine = wordList[Random.Next(wordList.Count)];
                string fakeWord = fakeLine.Split(" -*- ")[0];
                string fakeAnswer = fakeLine.Split(" -*- ")[1];
                if (fakeWord != label1.Text)
                {
                    RadioButton[] radioButtons = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 };
                    foreach (RadioButton radioButton in radioButtons)
                    {
                        if (radioButton.Text == fakeAnswer)
                        {
                            goto again;
                        }
                    }
                    return fakeAnswer;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "CHECK")
            {
                RadioButton[] radioButtons = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 };
                bool check = false;
                foreach (RadioButton radioButton in radioButtons)
                {
                    if (radioButton.Checked) check = true;
                }
                if (!check)
                {
                    MessageBox.Show("Please check an answer!", "English Practice V1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (radioButtons[answerIndex].Checked)
                {
                    radioButtons[answerIndex].ForeColor = Color.Green;
                }
                else
                {
                    foreach (RadioButton radioButton in radioButtons)
                        if (radioButton.Checked) radioButton.ForeColor = Color.Red;

                    radioButtons[answerIndex].ForeColor = Color.Green;

                }
                button1.Text = "NEW WORD";
            }

            else if (button1.Text == "NEW WORD")
            {
                RadioButton[] radioButtons = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 };
                foreach (RadioButton radioButton in radioButtons) { radioButton.ForeColor = Color.FromArgb(250, 250, 250); }
                button1.Text = "CHECK";
                giveNewWord();
            }
        }

        private void removeWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeForm removeForm = new removeForm();
            removeForm.isDeleted=false;
            removeForm.ShowDialog();
            if (removeForm.isDeleted)
            {
                importWords();
                giveNewWord();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}