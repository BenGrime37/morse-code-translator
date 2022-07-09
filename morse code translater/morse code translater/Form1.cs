using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace morse_code_translater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Translate_Click(object sender, EventArgs e)
        {
            if (messageBox.Text == "" && morseCodeBox.Text == "")//nothing been entered
            {
                MessageBox.Show("Must enter the morse code OR a Message");
            }
            else if (messageBox.Text != "" && morseCodeBox.Text == "")//text was entered
            {
                string messageText = messageBox.Text;

                lengthLabel.Text = messageText.Length.ToString();

                for (int i = 0; i < messageText.Length; i++)
                {

                    if (messageText[i] == Char.Parse("A") || messageText[i] == Char.Parse("a"))
                    {
                        morseCodeBox.AppendText(".-");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("B") || messageText[i] == Char.Parse("b"))
                    {
                        morseCodeBox.AppendText("-...");
                        morseCodeBox.AppendText(" ");
                    }

                    else if (messageText[i] == Char.Parse("C") || messageText[i] == Char.Parse("c"))
                    {
                        morseCodeBox.AppendText("-.-.");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("D") || messageText[i] == Char.Parse("d"))
                    {
                        morseCodeBox.AppendText("-..");
                        morseCodeBox.AppendText(" ");
                    }

                    else if (messageText[i] == Char.Parse("E") || messageText[i] == Char.Parse("e"))
                    {
                        morseCodeBox.AppendText(".");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("F") || messageText[i] == Char.Parse("f"))
                    {
                        morseCodeBox.AppendText("..-.");
                        morseCodeBox.AppendText(" ");
                    }

                    else if (messageText[i] == Char.Parse("G") || messageText[i] == Char.Parse("g"))
                    {
                        morseCodeBox.AppendText("--.");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("H") || messageText[i] == Char.Parse("h"))
                    {
                        morseCodeBox.AppendText("....");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("I") || messageText[i] == Char.Parse("i"))
                    {
                        morseCodeBox.AppendText("..");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("J") || messageText[i] == Char.Parse("j"))
                    {
                        morseCodeBox.AppendText(".---");
                        morseCodeBox.AppendText(" ");
                    }

                    else if (messageText[i] == Char.Parse("K") || messageText[i] == Char.Parse("k"))
                    {
                        morseCodeBox.AppendText("-.-");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("L") || messageText[i] == Char.Parse("l"))
                    {
                        morseCodeBox.AppendText(".-..");
                        morseCodeBox.AppendText(" ");
                    }

                    else if (messageText[i] == Char.Parse("M") || messageText[i] == Char.Parse("m"))
                    {
                        morseCodeBox.AppendText("--");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("N") || messageText[i] == Char.Parse("n"))
                    {
                        morseCodeBox.AppendText("-.");
                        morseCodeBox.AppendText(" ");
                    }

                    else if (messageText[i] == Char.Parse("O") || messageText[i] == Char.Parse("o"))
                    {
                        morseCodeBox.AppendText("---");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("P") || messageText[i] == Char.Parse("p"))
                    {
                        morseCodeBox.AppendText(".--.");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("Q") || messageText[i] == Char.Parse("q"))
                    {
                        morseCodeBox.AppendText("--.-");
                        morseCodeBox.AppendText(" ");
                    }

                    else if (messageText[i] == Char.Parse("R") || messageText[i] == Char.Parse("r"))
                    {
                        morseCodeBox.AppendText(".-.");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("S") || messageText[i] == Char.Parse("s"))
                    {
                        morseCodeBox.AppendText("...");
                        morseCodeBox.AppendText(" ");
                    }

                    else if (messageText[i] == Char.Parse("T") || messageText[i] == Char.Parse("t"))
                    {
                        morseCodeBox.AppendText("-");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("U") || messageText[i] == Char.Parse("u"))
                    {
                        morseCodeBox.AppendText("..-");
                        morseCodeBox.AppendText(" ");
                    }

                    else if (messageText[i] == Char.Parse("V") || messageText[i] == Char.Parse("v"))
                    {
                        morseCodeBox.AppendText("...-");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("W") || messageText[i] == Char.Parse("w"))
                    {
                        morseCodeBox.AppendText(".--");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("X") || messageText[i] == Char.Parse("x"))
                    {
                        morseCodeBox.AppendText("-..-");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse("Y") || messageText[i] == Char.Parse("y"))
                    {
                        morseCodeBox.AppendText("-.--");
                        morseCodeBox.AppendText(" ");
                    }

                    else if (messageText[i] == Char.Parse("Z") || messageText[i] == Char.Parse("z"))
                    {
                        morseCodeBox.AppendText("--..");
                        morseCodeBox.AppendText(" ");
                    }
                    else if (messageText[i] == Char.Parse(" ") || messageText[i] == Char.Parse(" "))
                    {
                        morseCodeBox.AppendText(" ");
                        morseCodeBox.AppendText(" ");
                    }
                }

                MessageBox.Show("COMPLETED!");
            }
            else if (messageBox.Text == "" && morseCodeBox.Text != "")//morse code to text
            {
                string morseCodeText = morseCodeBox.Text;
                

                int countSpaces = morseCodeBox.Text.Count(Char.IsWhiteSpace); 


                string[] code = morseCodeText.Split(" ");

                for (int j = 0; j < countSpaces + 1; j++)
                {
                    if (code[j] == ".-")
                    {
                        messageBox.AppendText("A");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "-...")
                    {
                        messageBox.AppendText("B");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "-.-.")
                    {
                        messageBox.AppendText("C");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "-..")
                    {
                        messageBox.AppendText("D");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == ".")
                    {
                        messageBox.AppendText("E");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "..-.")
                    {
                        messageBox.AppendText("F");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "--.")
                    {
                        messageBox.AppendText("G");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "....")
                    {
                        messageBox.AppendText("H");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "..")
                    {
                        messageBox.AppendText("I");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == ".---")
                    {
                        messageBox.AppendText("J");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "-.-")
                    {
                        messageBox.AppendText("K");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == ".-..")
                    {
                        messageBox.AppendText("L");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "--")
                    {
                        messageBox.AppendText("M");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "-.")
                    {
                        messageBox.AppendText("N");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "---")
                    {
                        messageBox.AppendText("O");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == ".--.")
                    {
                        messageBox.AppendText("P");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "--.-")
                    {
                        messageBox.AppendText("Q");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == ".-.")
                    {
                        messageBox.AppendText("R");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "...")
                    {
                        messageBox.AppendText("S");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "-")
                    {
                        messageBox.AppendText("T");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "..-")
                    {
                        messageBox.AppendText("U");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "...-")
                    {
                        messageBox.AppendText("V");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == ".--")
                    {
                        messageBox.AppendText("W");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "-..-")
                    {
                        messageBox.AppendText("X");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "-.--")
                    {
                        messageBox.AppendText("Y");
                        messageBox.AppendText(" ");
                    }
                    else if (code[j] == "--..")
                    {
                        messageBox.AppendText("Z");
                        messageBox.AppendText(" ");
                    }

                }
                MessageBox.Show("COMPLETED!");
            }
        }

    }
}
