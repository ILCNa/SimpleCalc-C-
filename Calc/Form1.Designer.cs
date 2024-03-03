using System.Drawing;

namespace Calc
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelWin = new System.Windows.Forms.Panel();
            this.buttonWinMin = new System.Windows.Forms.Button();
            this.buttonWinChangeSize = new System.Windows.Forms.Button();
            this.labelWinTilte = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelNONE = new System.Windows.Forms.Panel();
            this.panel0 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonRightBracket = new System.Windows.Forms.Button();
            this.buttonLeftBractet = new System.Windows.Forms.Button();
            this.buttonTh = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonNegtive = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonBackSpace = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelWinBody = new System.Windows.Forms.Panel();
            this.panelWin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNONE.SuspendLayout();
            this.panel0.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panelWinBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("霞鹜文楷 GB 屏幕阅读版", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // panelWin
            // 
            this.panelWin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelWin.Controls.Add(this.buttonWinMin);
            this.panelWin.Controls.Add(this.buttonWinChangeSize);
            this.panelWin.Controls.Add(this.labelWinTilte);
            this.panelWin.Controls.Add(this.pictureBox1);
            this.panelWin.Controls.Add(this.buttonClose);
            this.panelWin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWin.Location = new System.Drawing.Point(7, 0);
            this.panelWin.Name = "panelWin";
            this.panelWin.Size = new System.Drawing.Size(731, 42);
            this.panelWin.TabIndex = 24;
            this.panelWin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DoubleClickToScale);
            this.panelWin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WinMouseDown);
            this.panelWin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WinMove);
            this.panelWin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WinMoveOver);
            // 
            // buttonWinMin
            // 
            this.buttonWinMin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonWinMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonWinMin.FlatAppearance.BorderSize = 0;
            this.buttonWinMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWinMin.Font = new System.Drawing.Font("霞鹜文楷 GB 屏幕阅读版", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonWinMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWinMin.Location = new System.Drawing.Point(521, 0);
            this.buttonWinMin.Name = "buttonWinMin";
            this.buttonWinMin.Size = new System.Drawing.Size(70, 42);
            this.buttonWinMin.TabIndex = 4;
            this.buttonWinMin.TabStop = false;
            this.buttonWinMin.Text = "—";
            this.buttonWinMin.UseVisualStyleBackColor = false;
            this.buttonWinMin.Click += new System.EventHandler(this.buttonWinMin_Click);
            // 
            // buttonWinChangeSize
            // 
            this.buttonWinChangeSize.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonWinChangeSize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonWinChangeSize.FlatAppearance.BorderSize = 0;
            this.buttonWinChangeSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWinChangeSize.Font = new System.Drawing.Font("霞鹜文楷 GB 屏幕阅读版", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonWinChangeSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonWinChangeSize.Location = new System.Drawing.Point(591, 0);
            this.buttonWinChangeSize.Name = "buttonWinChangeSize";
            this.buttonWinChangeSize.Size = new System.Drawing.Size(70, 42);
            this.buttonWinChangeSize.TabIndex = 3;
            this.buttonWinChangeSize.TabStop = false;
            this.buttonWinChangeSize.Text = "▢";
            this.buttonWinChangeSize.UseVisualStyleBackColor = false;
            this.buttonWinChangeSize.Click += new System.EventHandler(this.buttonWinChangeSize_Click);
            // 
            // labelWinTilte
            // 
            this.labelWinTilte.AutoSize = true;
            this.labelWinTilte.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelWinTilte.Font = new System.Drawing.Font("霞鹜文楷 GB 屏幕阅读版", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWinTilte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWinTilte.Location = new System.Drawing.Point(44, 0);
            this.labelWinTilte.Margin = new System.Windows.Forms.Padding(0);
            this.labelWinTilte.Name = "labelWinTilte";
            this.labelWinTilte.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.labelWinTilte.Size = new System.Drawing.Size(100, 40);
            this.labelWinTilte.TabIndex = 0;
            this.labelWinTilte.Text = "Calc1.0";
            this.labelWinTilte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWinTilte.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WinMouseDown);
            this.labelWinTilte.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WinMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Calc.Properties.Resources.Sbstnblnd_Plateau_Apps_calc;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(7);
            this.pictureBox1.Size = new System.Drawing.Size(44, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WinMouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WinMove);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("霞鹜文楷", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonClose.Location = new System.Drawing.Point(661, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(70, 42);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "✖";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseTheWindow);
            this.buttonClose.MouseEnter += new System.EventHandler(this.ReadToClose);
            this.buttonClose.MouseLeave += new System.EventHandler(this.ReadToCloseCancel);
            // 
            // panelNONE
            // 
            this.panelNONE.Controls.Add(this.panel0);
            this.panelNONE.Controls.Add(this.panel1);
            this.panelNONE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNONE.Location = new System.Drawing.Point(7, 42);
            this.panelNONE.Name = "panelNONE";
            this.panelNONE.Size = new System.Drawing.Size(731, 701);
            this.panelNONE.TabIndex = 25;
            // 
            // panel0
            // 
            this.panel0.Controls.Add(this.tableLayoutPanel1);
            this.panel0.Controls.Add(this.menuStrip1);
            this.panel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel0.Location = new System.Drawing.Point(0, 0);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(321, 701);
            this.panel0.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Snow;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonPower, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonRightBracket, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonLeftBractet, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonTh, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPoint, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonCE, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonC, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button0, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonMinus, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonMultiply, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlus, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonDivision, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNegtive, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonEqual, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonBackSpace, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 655);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // buttonPower
            // 
            this.buttonPower.AutoSize = true;
            this.buttonPower.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonPower.CausesValidation = false;
            this.buttonPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPower.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonPower.FlatAppearance.BorderSize = 2;
            this.buttonPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPower.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPower.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonPower.Location = new System.Drawing.Point(160, 229);
            this.buttonPower.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(80, 85);
            this.buttonPower.TabIndex = 28;
            this.buttonPower.TabStop = false;
            this.buttonPower.Text = "^";
            this.buttonPower.UseVisualStyleBackColor = false;
            this.buttonPower.Click += new System.EventHandler(this.buttonPower_Click);
            this.buttonPower.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // buttonRightBracket
            // 
            this.buttonRightBracket.AutoSize = true;
            this.buttonRightBracket.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonRightBracket.CausesValidation = false;
            this.buttonRightBracket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRightBracket.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonRightBracket.FlatAppearance.BorderSize = 2;
            this.buttonRightBracket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRightBracket.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRightBracket.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonRightBracket.Location = new System.Drawing.Point(80, 229);
            this.buttonRightBracket.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRightBracket.Name = "buttonRightBracket";
            this.buttonRightBracket.Size = new System.Drawing.Size(80, 85);
            this.buttonRightBracket.TabIndex = 27;
            this.buttonRightBracket.TabStop = false;
            this.buttonRightBracket.Text = ")";
            this.buttonRightBracket.UseVisualStyleBackColor = false;
            this.buttonRightBracket.Click += new System.EventHandler(this.buttonRightBracket_Click);
            this.buttonRightBracket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // buttonLeftBractet
            // 
            this.buttonLeftBractet.AutoSize = true;
            this.buttonLeftBractet.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonLeftBractet.CausesValidation = false;
            this.buttonLeftBractet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLeftBractet.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonLeftBractet.FlatAppearance.BorderSize = 2;
            this.buttonLeftBractet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeftBractet.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLeftBractet.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonLeftBractet.Location = new System.Drawing.Point(0, 229);
            this.buttonLeftBractet.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLeftBractet.Name = "buttonLeftBractet";
            this.buttonLeftBractet.Size = new System.Drawing.Size(80, 85);
            this.buttonLeftBractet.TabIndex = 26;
            this.buttonLeftBractet.TabStop = false;
            this.buttonLeftBractet.Text = "(";
            this.buttonLeftBractet.UseVisualStyleBackColor = false;
            this.buttonLeftBractet.Click += new System.EventHandler(this.buttonLeftBractet_Click);
            this.buttonLeftBractet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // buttonTh
            // 
            this.buttonTh.AutoSize = true;
            this.buttonTh.BackColor = System.Drawing.Color.Lavender;
            this.buttonTh.CausesValidation = false;
            this.buttonTh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTh.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonTh.FlatAppearance.BorderSize = 2;
            this.buttonTh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTh.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonTh.Location = new System.Drawing.Point(160, 144);
            this.buttonTh.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTh.Name = "buttonTh";
            this.buttonTh.Size = new System.Drawing.Size(80, 85);
            this.buttonTh.TabIndex = 25;
            this.buttonTh.TabStop = false;
            this.buttonTh.Text = "%";
            this.buttonTh.UseVisualStyleBackColor = false;
            this.buttonTh.Click += new System.EventHandler(this.buttonTh_Click);
            this.buttonTh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonPoint.CausesValidation = false;
            this.buttonPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPoint.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonPoint.FlatAppearance.BorderSize = 2;
            this.buttonPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoint.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPoint.ForeColor = System.Drawing.Color.SlateGray;
            this.buttonPoint.Location = new System.Drawing.Point(160, 569);
            this.buttonPoint.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(80, 86);
            this.buttonPoint.TabIndex = 24;
            this.buttonPoint.TabStop = false;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            this.buttonPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.Lavender;
            this.buttonCE.CausesValidation = false;
            this.buttonCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCE.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonCE.FlatAppearance.BorderSize = 2;
            this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCE.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCE.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCE.Location = new System.Drawing.Point(80, 144);
            this.buttonCE.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(80, 85);
            this.buttonCE.TabIndex = 22;
            this.buttonCE.TabStop = false;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            this.buttonCE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.Lavender;
            this.buttonC.CausesValidation = false;
            this.buttonC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonC.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonC.FlatAppearance.BorderSize = 2;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonC.ForeColor = System.Drawing.Color.Red;
            this.buttonC.Location = new System.Drawing.Point(0, 144);
            this.buttonC.Margin = new System.Windows.Forms.Padding(0);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(80, 85);
            this.buttonC.TabIndex = 21;
            this.buttonC.TabStop = false;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            this.buttonC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.CausesValidation = false;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(0, 484);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 85);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            this.button4.CausesValidation = false;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button4.Location = new System.Drawing.Point(0, 399);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 85);
            this.button4.TabIndex = 8;
            this.button4.TabStop = false;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.CausesValidation = false;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button2.Location = new System.Drawing.Point(80, 484);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 85);
            this.button2.TabIndex = 6;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.CausesValidation = false;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button3.Location = new System.Drawing.Point(160, 484);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 85);
            this.button3.TabIndex = 7;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AliceBlue;
            this.button5.CausesValidation = false;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button5.Location = new System.Drawing.Point(80, 399);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 85);
            this.button5.TabIndex = 9;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.AliceBlue;
            this.button6.CausesValidation = false;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button6.Location = new System.Drawing.Point(160, 399);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 85);
            this.button6.TabIndex = 10;
            this.button6.TabStop = false;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.AliceBlue;
            this.button7.CausesValidation = false;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button7.Location = new System.Drawing.Point(0, 314);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 85);
            this.button7.TabIndex = 11;
            this.button7.TabStop = false;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.AliceBlue;
            this.button8.CausesValidation = false;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button8.Location = new System.Drawing.Point(80, 314);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 85);
            this.button8.TabIndex = 12;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.AliceBlue;
            this.button9.CausesValidation = false;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button9.Location = new System.Drawing.Point(160, 314);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 85);
            this.button9.TabIndex = 13;
            this.button9.TabStop = false;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.AliceBlue;
            this.button0.CausesValidation = false;
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.button0.FlatAppearance.BorderSize = 2;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button0.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button0.Location = new System.Drawing.Point(80, 569);
            this.button0.Margin = new System.Windows.Forms.Padding(0);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(80, 86);
            this.button0.TabIndex = 14;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            this.button0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.Azure;
            this.buttonMinus.CausesValidation = false;
            this.buttonMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMinus.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.buttonMinus.FlatAppearance.BorderSize = 2;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonMinus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonMinus.Location = new System.Drawing.Point(240, 399);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(81, 85);
            this.buttonMinus.TabIndex = 17;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            this.buttonMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.Azure;
            this.buttonMultiply.CausesValidation = false;
            this.buttonMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.buttonMultiply.FlatAppearance.BorderSize = 2;
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiply.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonMultiply.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonMultiply.Location = new System.Drawing.Point(240, 314);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(81, 85);
            this.buttonMultiply.TabIndex = 18;
            this.buttonMultiply.TabStop = false;
            this.buttonMultiply.Text = "×";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            this.buttonMultiply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.Azure;
            this.buttonPlus.CausesValidation = false;
            this.buttonPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPlus.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.buttonPlus.FlatAppearance.BorderSize = 2;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPlus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonPlus.Location = new System.Drawing.Point(240, 484);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(81, 85);
            this.buttonPlus.TabIndex = 16;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            this.buttonPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.Azure;
            this.buttonDivision.CausesValidation = false;
            this.buttonDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDivision.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.buttonDivision.FlatAppearance.BorderSize = 2;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivision.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDivision.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonDivision.Location = new System.Drawing.Point(240, 229);
            this.buttonDivision.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(81, 85);
            this.buttonDivision.TabIndex = 19;
            this.buttonDivision.TabStop = false;
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            this.buttonDivision.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // buttonNegtive
            // 
            this.buttonNegtive.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonNegtive.CausesValidation = false;
            this.buttonNegtive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNegtive.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonNegtive.FlatAppearance.BorderSize = 2;
            this.buttonNegtive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNegtive.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonNegtive.ForeColor = System.Drawing.Color.SlateGray;
            this.buttonNegtive.Location = new System.Drawing.Point(0, 569);
            this.buttonNegtive.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNegtive.Name = "buttonNegtive";
            this.buttonNegtive.Size = new System.Drawing.Size(80, 86);
            this.buttonNegtive.TabIndex = 1;
            this.buttonNegtive.TabStop = false;
            this.buttonNegtive.Text = "+/-";
            this.buttonNegtive.UseVisualStyleBackColor = false;
            this.buttonNegtive.Click += new System.EventHandler(this.buttonNegtive_Click);
            this.buttonNegtive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEqual.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonEqual.FlatAppearance.BorderSize = 2;
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqual.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEqual.ForeColor = System.Drawing.Color.Black;
            this.buttonEqual.Location = new System.Drawing.Point(240, 569);
            this.buttonEqual.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(81, 86);
            this.buttonEqual.TabIndex = 0;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            this.buttonEqual.Leave += new System.EventHandler(this.FocuedEqual);
            this.buttonEqual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // buttonBackSpace
            // 
            this.buttonBackSpace.AutoSize = true;
            this.buttonBackSpace.BackColor = System.Drawing.Color.Lavender;
            this.buttonBackSpace.CausesValidation = false;
            this.buttonBackSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBackSpace.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonBackSpace.FlatAppearance.BorderSize = 2;
            this.buttonBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackSpace.Font = new System.Drawing.Font("霞鹜文楷", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBackSpace.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonBackSpace.Location = new System.Drawing.Point(240, 144);
            this.buttonBackSpace.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBackSpace.Name = "buttonBackSpace";
            this.buttonBackSpace.Size = new System.Drawing.Size(81, 85);
            this.buttonBackSpace.TabIndex = 23;
            this.buttonBackSpace.TabStop = false;
            this.buttonBackSpace.Text = "←";
            this.buttonBackSpace.UseVisualStyleBackColor = false;
            this.buttonBackSpace.Click += new System.EventHandler(this.buttonBackSpace_Click);
            this.buttonBackSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.richTextBox2, 4);
            this.richTextBox2.DetectUrls = false;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Font = new System.Drawing.Font("霞鹜文楷", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox2.HideSelection = false;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox2.Size = new System.Drawing.Size(321, 144);
            this.richTextBox2.TabIndex = 29;
            this.richTextBox2.TabStop = false;
            this.richTextBox2.Text = "0";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            this.richTextBox2.Enter += new System.EventHandler(this.TextBoxFouce);
            this.richTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input);
            this.richTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterFromWIN);
            this.richTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input);
            this.richTextBox2.Leave += new System.EventHandler(this.TextBoxNoFouce);
            this.richTextBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dealTryCatch);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("霞鹜文楷", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(321, 46);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.languageToolStripMenuItem});
            this.菜单ToolStripMenuItem.Font = new System.Drawing.Font("霞鹜文楷", 14F, System.Drawing.FontStyle.Bold);
            this.菜单ToolStripMenuItem.Image = global::Calc.Properties.Resources.setting;
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(117, 41);
            this.菜单ToolStripMenuItem.Text = "Menu";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("霞鹜文楷", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(213, 36);
            this.toolStripMenuItem4.Text = "Top";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.中文ToolStripMenuItem});
            this.languageToolStripMenuItem.Font = new System.Drawing.Font("霞鹜文楷", 10F, System.Drawing.FontStyle.Bold);
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(213, 36);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(183, 36);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // 中文ToolStripMenuItem
            // 
            this.中文ToolStripMenuItem.Name = "中文ToolStripMenuItem";
            this.中文ToolStripMenuItem.Size = new System.Drawing.Size(183, 36);
            this.中文ToolStripMenuItem.Text = "中文";
            this.中文ToolStripMenuItem.Click += new System.EventHandler(this.中文ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("霞鹜文楷", 14F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem2.Image = global::Calc.Properties.Resources._1;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 41);
            this.toolStripMenuItem2.Text = "Histroy";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(321, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(410, 99999);
            this.panel1.MinimumSize = new System.Drawing.Size(410, 694);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 701);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("霞鹜文楷 GB 屏幕阅读版", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Location = new System.Drawing.Point(0, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(410, 655);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(150, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip2.Font = new System.Drawing.Font("霞鹜文楷", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(3, 2, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(410, 46);
            this.menuStrip2.TabIndex = 22;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("霞鹜文楷", 14F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 41);
            this.toolStripMenuItem1.Text = "Clear";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // panelWinBody
            // 
            this.panelWinBody.BackColor = System.Drawing.Color.LavenderBlush;
            this.panelWinBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelWinBody.Controls.Add(this.panelNONE);
            this.panelWinBody.Controls.Add(this.panelWin);
            this.panelWinBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWinBody.Location = new System.Drawing.Point(0, 0);
            this.panelWinBody.Margin = new System.Windows.Forms.Padding(0);
            this.panelWinBody.Name = "panelWinBody";
            this.panelWinBody.Padding = new System.Windows.Forms.Padding(7, 0, 7, 7);
            this.panelWinBody.Size = new System.Drawing.Size(745, 750);
            this.panelWinBody.TabIndex = 25;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonEqual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 750);
            this.ControlBox = false;
            this.Controls.Add(this.panelWinBody);
            this.Font = new System.Drawing.Font("霞鹜文楷", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(480, 750);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.SizeChanged += new System.EventHandler(this.showRightPart);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterFromWIN);
            this.panelWin.ResumeLayout(false);
            this.panelWin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNONE.ResumeLayout(false);
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panelWinBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelWin;
        private System.Windows.Forms.Button buttonWinMin;
        private System.Windows.Forms.Button buttonWinChangeSize;
        private System.Windows.Forms.Label labelWinTilte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelNONE;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panelWinBody;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button buttonRightBracket;
        private System.Windows.Forms.Button buttonLeftBractet;
        private System.Windows.Forms.Button buttonTh;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonNegtive;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonBackSpace;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中文ToolStripMenuItem;
    }
}

