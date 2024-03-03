using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Calc
{
    public partial class Form1 : Form
    {
        private string ERROR = "ERROR";

        private Point point;

        private int sortForHistory;
        private string[] history = new string[100];

        private int temp;
        private bool readyToChangeSize;
        private bool conutinueCalc=false;
        private double result;

        private bool openRight = true;

        private int numOfTh;
        private int numOfCe;

        public Form1()
        {
            InitializeComponent();
            //最大化防止覆盖任务栏
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            this.BackColor = SystemColors.Window;
            ControlBox = false;
            LodingConfig();
            richTextBox2.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox1.ShortcutsEnabled = true;
        }


        private void LodingConfig()
        {
            if (File.Exists("config.txt"))
            {
                if (File.ReadAllText("config.txt") == "english")
                {
                    labelWinTilte.Text = "SimpleCalc1.0";
                    菜单ToolStripMenuItem.Text = "Menu";
                    toolStripMenuItem4.Text = "Top";
                    languageToolStripMenuItem.Text = "Language";
                    toolStripMenuItem2.Text = "History";
                    toolStripMenuItem1.Text = "Clear";
                    ERROR = "ERROR";
                }
                else if (File.ReadAllText("config.txt") == "chinese")
                {
                    labelWinTilte.Text = "简便计算器1.0";
                    菜单ToolStripMenuItem.Text = "菜单";
                    toolStripMenuItem4.Text = "顶置";
                    languageToolStripMenuItem.Text = "语言";
                    toolStripMenuItem2.Text = "历史";
                    toolStripMenuItem1.Text = "清空";
                    ERROR = "输入异常";
                }
            }
            else
            {
                File.WriteAllText("config.txt", "english");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            history = new string[100];
            sortForHistory = 0;
        }

        private void showRightPart(object sender, EventArgs e)
        {
            if (Size.Width >= 770 && openRight)
            {

                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;

            }
            if (Size.Height <= System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height/3*2)
            {
                this.richTextBox2.Font = new System.Drawing.Font("霞鹜文楷", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            }
            else
            {
                this.richTextBox2.Font = new System.Drawing.Font("霞鹜文楷", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            }
        }

        private void DoubleClickToScale(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else { WindowState = FormWindowState.Maximized; }
        }

        private void WinMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + e.X - point.X, Location.Y + e.Y - point.Y);
            }
        }

        private void WinMouseDown(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized) WindowState = FormWindowState.Normal;
            if (e.Button == MouseButtons.Left)
            {
                point = new Point(e.X, e.Y);
            }
        }

        private void WinMoveOver(object sender, MouseEventArgs e)
        {
            point = Point.Empty;
        }

        private void ReadToClose(object sender, EventArgs e)
        {



            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (72 + temp * 20 == 192) { timer.Stop(); return; }
            buttonClose.BackColor = Color.FromArgb(((int)(((byte)(72 + temp * 20)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            temp += 1;

        }

        private void ReadToCloseCancel(object sender, EventArgs e)
        {
            buttonClose.BackColor = System.Drawing.Color.CornflowerBlue;
            timer.Stop();
            temp = 0;
        }

        private void ColorChanging(object sender, EventArgs e)
        {

        }

        private void CloseTheWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { System.Windows.Forms.Application.Exit(); }
        }

        private void buttonWinChangeSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else { WindowState = FormWindowState.Maximized; }
        }

        private void buttonWinMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private bool pos(int x, int y)
        {
            int n = 10;

            if (x <= n || y >= Size.Height - n || x >= Size.Width - n || y <= n)
            {
                return true;
            }
            return false;
        }

        private void ChangeSizeDone(object sender, EventArgs e)
        {
            if (readyToChangeSize)
            {
                this.Width = MousePosition.X - this.Left;
            }
            else
                Cursor = System.Windows.Forms.Cursors.Default;

        }

        private void ReadyTochange(object sender, MouseEventArgs e)
        {

        }



        private void ChangingSize(object sender, MouseEventArgs e)
        {
            int n = 10;
            //Left And Right
            if ((e.X < n || e.X >= Size.Width - n) && (e.Y <= Size.Height - n && e.Y >= n))
            {

                Cursor = Cursors.SizeWE;
                if (e.Button == MouseButtons.Left)
                {
                    readyToChangeSize = true;

                    this.Width = MousePosition.X - this.Left;


                }
            }
            //Bottom AND Top
            else if ((e.Y >= Size.Height - n || e.Y <= n) && (e.X <= Size.Width - n && e.X >= n))
            {
                Cursor = Cursors.SizeNS;
            }
            else if ((e.Y <= n && e.X <= n) || (e.Y >= Size.Height - n && e.X >= Size.Width - n))
                Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            else
            {
                Cursor = Cursors.SizeNESW;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
            if (panel1.Visible == false && openRight)
            {

                panel1.Visible = true;
                toolStripMenuItem2.Checked = true;
                Width = 770;
            }
            else if (openRight)
            {
                toolStripMenuItem2.Checked = true;
                openRight = false;
                panel1.Visible = false;
            }
            else
            {
                toolStripMenuItem2.Checked = false;
                if (Width < 770) Width = 770;
                openRight = true;
                panel1.Visible = true;
            }
        }
        private bool textBoxIsEmpty = true;
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.SelectionAlignment = HorizontalAlignment.Right;
          
            if (richTextBox2.Focused)
            {

                int n = 0;
                string mid = string.Empty;
                for (int i = 0; i < richTextBox2.Text.Length; i++)
                {
                    if (richTextBox2.Text[i] == '*') mid += '×';
                    else if (richTextBox2.Text[i] == '/') mid += '÷';
                    else mid += richTextBox2.Text[i];
                }

                n = richTextBox2.SelectionStart;
                richTextBox2.Text = mid;
                richTextBox2.SelectionStart = n;
                return;
            }
      
            if (textBoxIsEmpty && richTextBox2.Text == "")
            {
                richTextBox2.Text = "0";
            }
            else
            {
                textBoxIsEmpty = true;
            }

        }
        //
        // logic
        //
        private void Input(object sender, KeyEventArgs e)
        {
 
            if (richTextBox2.Focused) return;
         
            switch (e.KeyCode)
            {

                
                //处理退格
                case Keys.Back: buttonBackSpace_Click(sender, e); break;

            }
            //处理^
            if (e.KeyCode == Keys.D6 && e.Shift) { NewMethodNum(); buttonPower_Click(sender, e); conutinueCalc = false; }
        }
        private void EnterFromWIN(object sender, KeyPressEventArgs e)
        {
            if (richTextBox2.Text ==ERROR)
            {
                richTextBox2.Text = "";
                richTextBox2.ForeColor = System.Drawing.Color.Black;
            }
            if (richTextBox2.Focused) return;

            NewMethod();
            switch (e.KeyChar)
            {

                //处理数字
                case '0': NewMethodNum(); button0_Click(button0, e); conutinueCalc = false; break;
                case '1': NewMethodNum(); button1_Click(button1, e); conutinueCalc = false; break;
                case '2': NewMethodNum(); button2_Click(button2, e); conutinueCalc = false; break;
                case '3': NewMethodNum(); button3_Click(button3, e); conutinueCalc = false; break;
                case '4': NewMethodNum(); button4_Click(button4, e); conutinueCalc = false; break;
                case '5': NewMethodNum(); button5_Click(button5, e); conutinueCalc = false; break;
                case '6': NewMethodNum(); button6_Click(button6, e); conutinueCalc = false; break;
                case '7': NewMethodNum(); button7_Click(button7, e); conutinueCalc = false; break;
                case '8': NewMethodNum(); button8_Click(button8, e); conutinueCalc = false; break;
                case '9': NewMethodNum(); button9_Click(button9, e); conutinueCalc = false; break;
                //处理小数点
                case '.':
                    NewMethod();
                    if (richTextBox2.Text[richTextBox2.Text.Length - 1] > '9' || richTextBox2.Text[richTextBox2.Text.Length - 1] < '0')
                        richTextBox2.Text += "0";
                    conutinueCalc = false;
                    buttonPoint_Click(sender, e);

                    break;

                //回车
                case '\r':
                   
                        buttonEqual_Click(buttonEqual, e);
                    
                    break;

                case '(': buttonLeftBractet_Click(sender, e); conutinueCalc = false; break;
                case ')': buttonRightBracket_Click(sender, e); conutinueCalc = false; break;

                case '+': NewMethod(); buttonPlus_Click(sender, e); conutinueCalc = false; break;
                case '-': NewMethod(); buttonMinus_Click(sender, e); conutinueCalc = false; break;
                case '*': NewMethod(); buttonMultiply_Click(sender, e); conutinueCalc = false; break;
                case '/': NewMethod(); buttonDivision_Click(sender, e); conutinueCalc = false; break;

                case '%': NewMethod(); buttonTh_Click(sender, e); conutinueCalc = false; break;
            }

            
        }
        void NewMethod()
        {
            if (conutinueCalc) richTextBox2.Text = result.ToString();
        }
        void NewMethodNum()
        {
            if (conutinueCalc) richTextBox2.Text = string.Empty;
        }
        private void buttonPower_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "^";
        }
        private bool TextBoxInit()
        {
            return richTextBox2.Text == "0";
        }
        private void buttonLeftBractet_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0") { textBoxIsEmpty = false; richTextBox2.Text = ""; }

            richTextBox2.Text += "(";

        }

        private void buttonRightBracket_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += ")";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0") { textBoxIsEmpty = false; richTextBox2.Text = ""; }

            richTextBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0") { textBoxIsEmpty = false; richTextBox2.Text = ""; }

            richTextBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0") { textBoxIsEmpty = false; richTextBox2.Text = ""; }

            richTextBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0") { textBoxIsEmpty = false; richTextBox2.Text = ""; }

            richTextBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0") { textBoxIsEmpty = false; richTextBox2.Text = ""; }

            richTextBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0") { textBoxIsEmpty = false; richTextBox2.Text = ""; }

            richTextBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0") { textBoxIsEmpty = false; richTextBox2.Text = ""; }

            richTextBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0") { textBoxIsEmpty = false; richTextBox2.Text = ""; }

            richTextBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0") { textBoxIsEmpty = false; richTextBox2.Text = ""; }

            richTextBox2.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "0") { textBoxIsEmpty = false; richTextBox2.Text = ""; }

            richTextBox2.Text += "0";
        }

        private void buttonNegtive_Click(object sender, EventArgs e)
        {


            if (richTextBox2.Text[0] == '-' && richTextBox2.Text[1] == '(' && richTextBox2.Text[richTextBox2.TextLength - 1] == ')')
            {
                richTextBox2.Text = richTextBox2.Text.Substring(2, richTextBox2.TextLength - 3);
            }

            else richTextBox2.Text = "-(" + richTextBox2.Text + ")";

        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {

            richTextBox2.Text += ".";

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "+";
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "-";
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "×";

        }
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "÷";

        }
        private void buttonBackSpace_Click(object sender, EventArgs e)
        {

            if (richTextBox2.Text != "")
                richTextBox2.Text = richTextBox2.Text.Remove(richTextBox2.Text.Length - 1);
            else
            {
                richTextBox2.Text = "0";
                return;
            }

        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (conutinueCalc) { richTextBox2.Text = string.Empty; conutinueCalc = false; }
            else
            {
                string str = string.Empty;
                if (richTextBox2.Text[0] == '-')
                    richTextBox2.Text = "0" + richTextBox2.Text;
                for (int i = 0; i < richTextBox2.Text.Length; i++)
                {
                    if (richTextBox2.Text[i] == '%') numOfTh++;
                    if (i > 0 && richTextBox2.Text[i] == '(' && (richTextBox2.Text[i - 1] <= '9' && richTextBox2.Text[i - 1] >= '0' || richTextBox2.Text[i - 1] == ')')) str += '×';
                    if (richTextBox2.Text[i] == '=') continue;
                    else str += richTextBox2.Text[i];
                }
                try
                {
                    Stack<string> post = creatPost(ReadyToCalc(str));
                    result = CalcResult(post) / (Math.Pow(100, numOfTh));
                    richTextBox2.Text = str + "=" + result.ToString();
                    richTextBox2.SelectionStart = richTextBox2.TextLength;
                    sortForHistory++;

                    history[sortForHistory - 1] = str;

                    richTextBox1.Text += sortForHistory + ") ";
                    richTextBox1.Text += richTextBox2.Text + "\n";

                    numOfCe = 0;
                    conutinueCalc = true;
                }
                catch (Exception ex)
                {
                    richTextBox2.ForeColor = System.Drawing.Color.Silver;
                    richTextBox2.Text = ERROR;
                    richTextBox2.SelectionStart = richTextBox2.TextLength;
                    conutinueCalc = false;
                }
                numOfTh = 0;
            }
        }

        /////logic运算逻辑:
        private string ReadyToCalc(string text)
        {
            string mid = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '×') mid += '*';
                else if (text[i] == '÷') mid += '/';
                else mid += text[i];
            }
            return mid;
        }
        private Stack<string> creatPost(string str)
        {
            Stack<string> op = new Stack<string>();
            Stack<string> post = new Stack<string>();
            string number = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+' || str[i] == '-')
                {
                    if (i == 0 || str[i - 1] == '*' || str[i - 1] == '/'
                        || str[i - 1] == '(')
                    {
                        number += str[i];
                        continue;
                    }

                    if (number != string.Empty)
                    {
                        post.Push(number);
                        number = string.Empty;
                    }

                    if (op.Count == 0 || op.Peek() == "(") op.Push(str[i].ToString());
                    else if (str[i - 1] == ')') op.Push(str[i].ToString());
                    else
                    {
                        while (op.Count > 0 && op.Peek() != "(")
                        {
                            post.Push(op.Pop());
                        }
                        op.Push(str[i].ToString());
                    }
                }
                else if (str[i] <= '9' && str[i] >= '0' || str[i] == '.')
                {
                    number += str[i];
                }
                else if (str[i] == '*' || str[i] == '/')
                {
                    if (number != string.Empty)
                    {
                        post.Push(number);
                        number = string.Empty;
                    }
                    //op == null
                    if (op.Count == 0 || op.Peek() == "(") op.Push(str[i].ToString());
                    else if (op.Peek() == "+" || op.Peek() == "-")
                    {
                        op.Push(str[i].ToString());
                    }
                    else
                    {
                        while (op.Count > 0 && op.Peek() != "(")
                        {
                            post.Push(op.Pop());
                        }
                        op.Push(str[i].ToString());
                    }
                }
                else if (str[i] == '^')
                {
                    if (number != string.Empty)
                    {
                        post.Push(number);
                        number = string.Empty;
                    }
                    if (op.Count == 0 || op.Peek() == "(") op.Push(str[i].ToString());
                    else if (op.Peek() == "+" || op.Peek() == "-" || op.Peek() == "*" || op.Peek() == "/")
                    {
                        op.Push(str[i].ToString());
                    }
                    else
                    {
                        while (op.Count > 0 && op.Peek() != "(")
                        {
                            post.Push(op.Pop());
                        }
                        op.Push(str[i].ToString());
                    }
                }
                else if (str[i] == '(')
                {
                    op.Push(str[i].ToString());
                }
                else if (str[i] == ')')
                {
                    if (number != string.Empty) { post.Push(number); number = string.Empty; }
                    while (op.Peek() != "(")
                    {
                        post.Push(op.Pop());
                    }
                    op.Pop();
                }

            }
            if (number != string.Empty) { post.Push(number); }
            while (op.Count > 0)
            {
                post.Push(op.Pop());
            }
            /*string temp=string.Empty;
            
            while(post.Count > 0)
            {
                temp += post.Pop();
            }
            string t=string.Empty;
            for(int i = temp.Length - 1;i >= 0; i--)
            {
               t+= temp[i];
            }
            return t ;*/
            while (post.Count > 0)
            {
                op.Push(post.Pop());
            }

            return op;

        }

        private double CalcResult(Stack<string> post)
        {

            double a;
            double b;
            Stack<double> stack = new Stack<double>();
            while (post.Count > 0)
            {
                if (post.Peek() == "+")
                {
                    b = stack.Pop();
                    a = stack.Pop();
                    stack.Push(a + b);
                }
                else if (post.Peek() == "-")
                {
                    b = stack.Pop();
                    a = stack.Pop();
                    stack.Push(a - b);
                }
                else if (post.Peek() == "*") {
                    b = stack.Pop();
                    a = stack.Pop();

                    stack.Push(a * b);
                }
                else if (post.Peek() == "/")
                {
                    b = stack.Pop();
                    a = stack.Pop();
                    stack.Push(a / b);

                }
                else if (post.Peek() == "^")
                {
                    b = stack.Pop();
                    a = stack.Pop();
                    stack.Push(Math.Pow(a, b));
                }
                else//numbers
                {
                    stack.Push(double.Parse(post.Peek()));
                }
                post.Pop();
            }
            return stack.Pop();
        }

        
        private void buttonCE_Click(object sender, EventArgs e)
        {
            conutinueCalc = false;
            if (richTextBox1.Text != string.Empty && sortForHistory - 1 - numOfCe >= 0)
            {

                richTextBox2.Text =
                history[sortForHistory - 1 - numOfCe];
                numOfCe++;
            }
            else if (sortForHistory - numOfCe == 0) {richTextBox2.Text = string.Empty; numOfCe = 0; }

     

        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = string.Empty;
            conutinueCalc = false;
        }
        private void TextBoxFouce(object sender, EventArgs e)
        {
            if (richTextBox2.Focused && richTextBox2.Text == "0") richTextBox2.Text = string.Empty;
            if (richTextBox2.Text == ERROR)
            {
                richTextBox2.Text = "";
                richTextBox2.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void dealTryCatch(object sender, MouseEventArgs e)
        {
            if (richTextBox2.Text == ERROR)
            {
                richTextBox2.Text = "";
                richTextBox2.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TextBoxNoFouce(object sender, EventArgs e)
        {
            if (richTextBox2.Text == ERROR)
            {
                richTextBox2.Text = "";
                richTextBox2.ForeColor = System.Drawing.Color.Black;
            }
            if (richTextBox2.Text == "") richTextBox2.Text = "0";
        }

        private void buttonTh_Click(object sender, EventArgs e)
        {
            int n=0;
            for (int i = 0; i < richTextBox2.Text.Length; i++)
            {
                if (richTextBox2.Text[i] == '%') n++;
            }
            if (richTextBox2.Text[richTextBox2.Text.Length - 1] == '%'||n==0)
            richTextBox2.Text += "%";
          
        }

        private void FocuedEqual(object sender, EventArgs e)
        {
            if(!richTextBox1.Focused&& !richTextBox2.Focused)
            buttonEqual.Focus();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (!toolStripMenuItem4.Checked)
            {   
                toolStripMenuItem4.Checked = true;
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
                toolStripMenuItem4.Checked = false;
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelWinTilte.Text = "SimpleCalc1.0";
            菜单ToolStripMenuItem.Text = "Menu";
            toolStripMenuItem4.Text = "Top";
            languageToolStripMenuItem.Text = "Language";
            toolStripMenuItem2.Text = "History";
            toolStripMenuItem1.Text = "Clear";
            ERROR = "ERROR";
            File.WriteAllText("config.txt","english");
        }

        private void 中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelWinTilte.Text = "简便计算器1.0";
            菜单ToolStripMenuItem.Text = "菜单";
            toolStripMenuItem4.Text = "顶置";
            languageToolStripMenuItem.Text = "语言";
            toolStripMenuItem2.Text = "历史";
            toolStripMenuItem1.Text = "清空";
            ERROR = "输入异常";
            File.WriteAllText("config.txt", "chinese");
        }
    }
}
