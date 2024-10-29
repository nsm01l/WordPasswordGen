namespace WordPasswordGen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtWordA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWordB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnClearWordA = new System.Windows.Forms.Button();
            this.btnClearWordB = new System.Windows.Forms.Button();
            this.btnImportWordA = new System.Windows.Forms.Button();
            this.btnImportWordB = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grPattern = new System.Windows.Forms.GroupBox();
            this.btnClearPatterns = new System.Windows.Forms.Button();
            this.btnNewLine = new System.Windows.Forms.Button();
            this.btnInvWordC = new System.Windows.Forms.Button();
            this.btnInvWordB = new System.Windows.Forms.Button();
            this.btnInvWordA = new System.Windows.Forms.Button();
            this.btnNumSym = new System.Windows.Forms.Button();
            this.btnSymbol = new System.Windows.Forms.Button();
            this.btnNum = new System.Windows.Forms.Button();
            this.btnUWordC = new System.Windows.Forms.Button();
            this.btnCWordC = new System.Windows.Forms.Button();
            this.btnLWordC = new System.Windows.Forms.Button();
            this.btnUWordB = new System.Windows.Forms.Button();
            this.btnCWordB = new System.Windows.Forms.Button();
            this.btnLWordB = new System.Windows.Forms.Button();
            this.btnUWordA = new System.Windows.Forms.Button();
            this.btnCWordA = new System.Windows.Forms.Button();
            this.btnLWordA = new System.Windows.Forms.Button();
            this.txtPatterns = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWordMin = new System.Windows.Forms.TextBox();
            this.txtWordMax = new System.Windows.Forms.TextBox();
            this.passRange = new System.Windows.Forms.GroupBox();
            this.wordsTab = new System.Windows.Forms.TabControl();
            this.tabWordsA = new System.Windows.Forms.TabPage();
            this.tabWordsB = new System.Windows.Forms.TabPage();
            this.tabWordsC = new System.Windows.Forms.TabPage();
            this.txtWordC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearWordC = new System.Windows.Forms.Button();
            this.btnImportWordC = new System.Windows.Forms.Button();
            this.btnLowAZ = new System.Windows.Forms.Button();
            this.btnUpAZ = new System.Windows.Forms.Button();
            this.btnFullAZ = new System.Windows.Forms.Button();
            this.grPattern.SuspendLayout();
            this.passRange.SuspendLayout();
            this.wordsTab.SuspendLayout();
            this.tabWordsA.SuspendLayout();
            this.tabWordsB.SuspendLayout();
            this.tabWordsC.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWordA
            // 
            this.txtWordA.Location = new System.Drawing.Point(7, 21);
            this.txtWordA.Multiline = true;
            this.txtWordA.Name = "txtWordA";
            this.txtWordA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWordA.Size = new System.Drawing.Size(179, 194);
            this.txtWordA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "WordsA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "WordsB";
            // 
            // txtWordB
            // 
            this.txtWordB.Location = new System.Drawing.Point(7, 21);
            this.txtWordB.Multiline = true;
            this.txtWordB.Name = "txtWordB";
            this.txtWordB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWordB.Size = new System.Drawing.Size(179, 194);
            this.txtWordB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Num:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(349, 14);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(80, 19);
            this.txtNum.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(562, 46);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassword.Size = new System.Drawing.Size(275, 258);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.DoubleClick += new System.EventHandler(this.txtPassword_DoubleClick);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(646, 7);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(98, 33);
            this.btnGen.TabIndex = 10;
            this.btnGen.Text = "Gen";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnClearWordA
            // 
            this.btnClearWordA.Location = new System.Drawing.Point(107, 226);
            this.btnClearWordA.Name = "btnClearWordA";
            this.btnClearWordA.Size = new System.Drawing.Size(27, 20);
            this.btnClearWordA.TabIndex = 3;
            this.btnClearWordA.Text = "C";
            this.btnClearWordA.UseVisualStyleBackColor = true;
            this.btnClearWordA.Click += new System.EventHandler(this.btnClearWordA_Click);
            // 
            // btnClearWordB
            // 
            this.btnClearWordB.Location = new System.Drawing.Point(107, 226);
            this.btnClearWordB.Name = "btnClearWordB";
            this.btnClearWordB.Size = new System.Drawing.Size(27, 20);
            this.btnClearWordB.TabIndex = 7;
            this.btnClearWordB.Text = "C";
            this.btnClearWordB.UseVisualStyleBackColor = true;
            this.btnClearWordB.Click += new System.EventHandler(this.btnClearWordB_Click);
            // 
            // btnImportWordA
            // 
            this.btnImportWordA.Location = new System.Drawing.Point(11, 225);
            this.btnImportWordA.Name = "btnImportWordA";
            this.btnImportWordA.Size = new System.Drawing.Size(75, 21);
            this.btnImportWordA.TabIndex = 2;
            this.btnImportWordA.Text = "Import";
            this.btnImportWordA.UseVisualStyleBackColor = true;
            this.btnImportWordA.Click += new System.EventHandler(this.btnImportWordA_Click);
            // 
            // btnImportWordB
            // 
            this.btnImportWordB.Location = new System.Drawing.Point(11, 225);
            this.btnImportWordB.Name = "btnImportWordB";
            this.btnImportWordB.Size = new System.Drawing.Size(75, 21);
            this.btnImportWordB.TabIndex = 6;
            this.btnImportWordB.Text = "Import";
            this.btnImportWordB.UseVisualStyleBackColor = true;
            this.btnImportWordB.Click += new System.EventHandler(this.btnImportWordB_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text|*.txt|All files|*.*";
            // 
            // grPattern
            // 
            this.grPattern.Controls.Add(this.btnFullAZ);
            this.grPattern.Controls.Add(this.btnUpAZ);
            this.grPattern.Controls.Add(this.btnLowAZ);
            this.grPattern.Controls.Add(this.btnClearPatterns);
            this.grPattern.Controls.Add(this.btnNewLine);
            this.grPattern.Controls.Add(this.btnInvWordC);
            this.grPattern.Controls.Add(this.btnInvWordB);
            this.grPattern.Controls.Add(this.btnInvWordA);
            this.grPattern.Controls.Add(this.btnNumSym);
            this.grPattern.Controls.Add(this.btnSymbol);
            this.grPattern.Controls.Add(this.btnNum);
            this.grPattern.Controls.Add(this.btnUWordC);
            this.grPattern.Controls.Add(this.btnCWordC);
            this.grPattern.Controls.Add(this.btnLWordC);
            this.grPattern.Controls.Add(this.btnUWordB);
            this.grPattern.Controls.Add(this.btnCWordB);
            this.grPattern.Controls.Add(this.btnLWordB);
            this.grPattern.Controls.Add(this.btnUWordA);
            this.grPattern.Controls.Add(this.btnCWordA);
            this.grPattern.Controls.Add(this.btnLWordA);
            this.grPattern.Controls.Add(this.txtPatterns);
            this.grPattern.Location = new System.Drawing.Point(218, 43);
            this.grPattern.Name = "grPattern";
            this.grPattern.Size = new System.Drawing.Size(332, 265);
            this.grPattern.TabIndex = 12;
            this.grPattern.TabStop = false;
            this.grPattern.Text = "Pattern";
            // 
            // btnClearPatterns
            // 
            this.btnClearPatterns.Location = new System.Drawing.Point(269, 134);
            this.btnClearPatterns.Name = "btnClearPatterns";
            this.btnClearPatterns.Size = new System.Drawing.Size(33, 23);
            this.btnClearPatterns.TabIndex = 17;
            this.btnClearPatterns.Text = "C";
            this.btnClearPatterns.UseVisualStyleBackColor = true;
            this.btnClearPatterns.Click += new System.EventHandler(this.btnClearPatterns_Click);
            // 
            // btnNewLine
            // 
            this.btnNewLine.Location = new System.Drawing.Point(269, 105);
            this.btnNewLine.Name = "btnNewLine";
            this.btnNewLine.Size = new System.Drawing.Size(33, 23);
            this.btnNewLine.TabIndex = 16;
            this.btnNewLine.Text = "\\n";
            this.btnNewLine.UseVisualStyleBackColor = true;
            this.btnNewLine.Click += new System.EventHandler(this.btnNewLine_Click);
            // 
            // btnInvWordC
            // 
            this.btnInvWordC.Location = new System.Drawing.Point(249, 76);
            this.btnInvWordC.Name = "btnInvWordC";
            this.btnInvWordC.Size = new System.Drawing.Size(75, 23);
            this.btnInvWordC.TabIndex = 15;
            this.btnInvWordC.Text = "wordC";
            this.btnInvWordC.UseVisualStyleBackColor = true;
            this.btnInvWordC.Click += new System.EventHandler(this.btnInvWordC_Click);
            // 
            // btnInvWordB
            // 
            this.btnInvWordB.Location = new System.Drawing.Point(249, 47);
            this.btnInvWordB.Name = "btnInvWordB";
            this.btnInvWordB.Size = new System.Drawing.Size(75, 23);
            this.btnInvWordB.TabIndex = 14;
            this.btnInvWordB.Text = "wordB";
            this.btnInvWordB.UseVisualStyleBackColor = true;
            this.btnInvWordB.Click += new System.EventHandler(this.btnInvWordB_Click);
            // 
            // btnInvWordA
            // 
            this.btnInvWordA.Location = new System.Drawing.Point(249, 18);
            this.btnInvWordA.Name = "btnInvWordA";
            this.btnInvWordA.Size = new System.Drawing.Size(75, 23);
            this.btnInvWordA.TabIndex = 13;
            this.btnInvWordA.Text = "wordA";
            this.btnInvWordA.UseVisualStyleBackColor = true;
            this.btnInvWordA.Click += new System.EventHandler(this.btnInvWordA_Click);
            // 
            // btnNumSym
            // 
            this.btnNumSym.Location = new System.Drawing.Point(168, 105);
            this.btnNumSym.Name = "btnNumSym";
            this.btnNumSym.Size = new System.Drawing.Size(75, 23);
            this.btnNumSym.TabIndex = 12;
            this.btnNumSym.Text = "#sym";
            this.btnNumSym.UseVisualStyleBackColor = true;
            this.btnNumSym.Click += new System.EventHandler(this.btnNumSym_Click);
            // 
            // btnSymbol
            // 
            this.btnSymbol.Location = new System.Drawing.Point(87, 105);
            this.btnSymbol.Name = "btnSymbol";
            this.btnSymbol.Size = new System.Drawing.Size(75, 23);
            this.btnSymbol.TabIndex = 11;
            this.btnSymbol.Text = "sym";
            this.btnSymbol.UseVisualStyleBackColor = true;
            this.btnSymbol.Click += new System.EventHandler(this.btnSymbol_Click);
            // 
            // btnNum
            // 
            this.btnNum.Location = new System.Drawing.Point(6, 105);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(75, 23);
            this.btnNum.TabIndex = 10;
            this.btnNum.Text = "#";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnUWordC
            // 
            this.btnUWordC.Location = new System.Drawing.Point(168, 76);
            this.btnUWordC.Name = "btnUWordC";
            this.btnUWordC.Size = new System.Drawing.Size(75, 23);
            this.btnUWordC.TabIndex = 9;
            this.btnUWordC.Text = "WORDC";
            this.btnUWordC.UseVisualStyleBackColor = true;
            this.btnUWordC.Click += new System.EventHandler(this.btnUWordC_Click);
            // 
            // btnCWordC
            // 
            this.btnCWordC.Location = new System.Drawing.Point(87, 76);
            this.btnCWordC.Name = "btnCWordC";
            this.btnCWordC.Size = new System.Drawing.Size(75, 23);
            this.btnCWordC.TabIndex = 8;
            this.btnCWordC.Text = "Wordc";
            this.btnCWordC.UseVisualStyleBackColor = true;
            this.btnCWordC.Click += new System.EventHandler(this.btnCWordC_Click);
            // 
            // btnLWordC
            // 
            this.btnLWordC.Location = new System.Drawing.Point(6, 76);
            this.btnLWordC.Name = "btnLWordC";
            this.btnLWordC.Size = new System.Drawing.Size(75, 23);
            this.btnLWordC.TabIndex = 7;
            this.btnLWordC.Text = "wordc";
            this.btnLWordC.UseVisualStyleBackColor = true;
            this.btnLWordC.Click += new System.EventHandler(this.btnLWordC_Click);
            // 
            // btnUWordB
            // 
            this.btnUWordB.Location = new System.Drawing.Point(168, 47);
            this.btnUWordB.Name = "btnUWordB";
            this.btnUWordB.Size = new System.Drawing.Size(75, 23);
            this.btnUWordB.TabIndex = 6;
            this.btnUWordB.Text = "WORDB";
            this.btnUWordB.UseVisualStyleBackColor = true;
            this.btnUWordB.Click += new System.EventHandler(this.btnUWordB_Click);
            // 
            // btnCWordB
            // 
            this.btnCWordB.Location = new System.Drawing.Point(87, 47);
            this.btnCWordB.Name = "btnCWordB";
            this.btnCWordB.Size = new System.Drawing.Size(75, 23);
            this.btnCWordB.TabIndex = 5;
            this.btnCWordB.Text = "Wordb";
            this.btnCWordB.UseVisualStyleBackColor = true;
            this.btnCWordB.Click += new System.EventHandler(this.btnCWordB_Click);
            // 
            // btnLWordB
            // 
            this.btnLWordB.Location = new System.Drawing.Point(6, 47);
            this.btnLWordB.Name = "btnLWordB";
            this.btnLWordB.Size = new System.Drawing.Size(75, 23);
            this.btnLWordB.TabIndex = 4;
            this.btnLWordB.Text = "wordb";
            this.btnLWordB.UseVisualStyleBackColor = true;
            this.btnLWordB.Click += new System.EventHandler(this.btnLWordB_Click);
            // 
            // btnUWordA
            // 
            this.btnUWordA.Location = new System.Drawing.Point(168, 18);
            this.btnUWordA.Name = "btnUWordA";
            this.btnUWordA.Size = new System.Drawing.Size(75, 23);
            this.btnUWordA.TabIndex = 3;
            this.btnUWordA.Text = "WORDA";
            this.btnUWordA.UseVisualStyleBackColor = true;
            this.btnUWordA.Click += new System.EventHandler(this.btnUWordA_Click);
            // 
            // btnCWordA
            // 
            this.btnCWordA.Location = new System.Drawing.Point(87, 18);
            this.btnCWordA.Name = "btnCWordA";
            this.btnCWordA.Size = new System.Drawing.Size(75, 23);
            this.btnCWordA.TabIndex = 2;
            this.btnCWordA.Text = "Worda";
            this.btnCWordA.UseVisualStyleBackColor = true;
            this.btnCWordA.Click += new System.EventHandler(this.btnCWordA_Click);
            // 
            // btnLWordA
            // 
            this.btnLWordA.Location = new System.Drawing.Point(6, 18);
            this.btnLWordA.Name = "btnLWordA";
            this.btnLWordA.Size = new System.Drawing.Size(75, 23);
            this.btnLWordA.TabIndex = 1;
            this.btnLWordA.Text = "worda";
            this.btnLWordA.UseVisualStyleBackColor = true;
            this.btnLWordA.Click += new System.EventHandler(this.btnLWordA_Click);
            // 
            // txtPatterns
            // 
            this.txtPatterns.Location = new System.Drawing.Point(6, 164);
            this.txtPatterns.Multiline = true;
            this.txtPatterns.Name = "txtPatterns";
            this.txtPatterns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPatterns.Size = new System.Drawing.Size(320, 93);
            this.txtPatterns.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = ">= pass <= ";
            // 
            // txtWordMin
            // 
            this.txtWordMin.Location = new System.Drawing.Point(15, 10);
            this.txtWordMin.Name = "txtWordMin";
            this.txtWordMin.Size = new System.Drawing.Size(33, 19);
            this.txtWordMin.TabIndex = 16;
            this.txtWordMin.Text = "16";
            // 
            // txtWordMax
            // 
            this.txtWordMax.Location = new System.Drawing.Point(123, 10);
            this.txtWordMax.Name = "txtWordMax";
            this.txtWordMax.Size = new System.Drawing.Size(33, 19);
            this.txtWordMax.TabIndex = 17;
            // 
            // passRange
            // 
            this.passRange.Controls.Add(this.txtWordMax);
            this.passRange.Controls.Add(this.txtWordMin);
            this.passRange.Controls.Add(this.label5);
            this.passRange.Location = new System.Drawing.Point(458, 5);
            this.passRange.Name = "passRange";
            this.passRange.Size = new System.Drawing.Size(162, 35);
            this.passRange.TabIndex = 18;
            this.passRange.TabStop = false;
            // 
            // wordsTab
            // 
            this.wordsTab.Controls.Add(this.tabWordsA);
            this.wordsTab.Controls.Add(this.tabWordsB);
            this.wordsTab.Controls.Add(this.tabWordsC);
            this.wordsTab.Location = new System.Drawing.Point(12, 7);
            this.wordsTab.Name = "wordsTab";
            this.wordsTab.SelectedIndex = 0;
            this.wordsTab.Size = new System.Drawing.Size(200, 301);
            this.wordsTab.TabIndex = 19;
            // 
            // tabWordsA
            // 
            this.tabWordsA.Controls.Add(this.txtWordA);
            this.tabWordsA.Controls.Add(this.label1);
            this.tabWordsA.Controls.Add(this.btnClearWordA);
            this.tabWordsA.Controls.Add(this.btnImportWordA);
            this.tabWordsA.Location = new System.Drawing.Point(4, 22);
            this.tabWordsA.Name = "tabWordsA";
            this.tabWordsA.Padding = new System.Windows.Forms.Padding(3);
            this.tabWordsA.Size = new System.Drawing.Size(192, 275);
            this.tabWordsA.TabIndex = 0;
            this.tabWordsA.Text = "WordsA";
            this.tabWordsA.UseVisualStyleBackColor = true;
            // 
            // tabWordsB
            // 
            this.tabWordsB.Controls.Add(this.txtWordB);
            this.tabWordsB.Controls.Add(this.label2);
            this.tabWordsB.Controls.Add(this.btnClearWordB);
            this.tabWordsB.Controls.Add(this.btnImportWordB);
            this.tabWordsB.Location = new System.Drawing.Point(4, 22);
            this.tabWordsB.Name = "tabWordsB";
            this.tabWordsB.Padding = new System.Windows.Forms.Padding(3);
            this.tabWordsB.Size = new System.Drawing.Size(192, 253);
            this.tabWordsB.TabIndex = 1;
            this.tabWordsB.Text = "WordsB";
            this.tabWordsB.UseVisualStyleBackColor = true;
            // 
            // tabWordsC
            // 
            this.tabWordsC.Controls.Add(this.txtWordC);
            this.tabWordsC.Controls.Add(this.label4);
            this.tabWordsC.Controls.Add(this.btnClearWordC);
            this.tabWordsC.Controls.Add(this.btnImportWordC);
            this.tabWordsC.Location = new System.Drawing.Point(4, 22);
            this.tabWordsC.Name = "tabWordsC";
            this.tabWordsC.Padding = new System.Windows.Forms.Padding(3);
            this.tabWordsC.Size = new System.Drawing.Size(192, 253);
            this.tabWordsC.TabIndex = 2;
            this.tabWordsC.Text = "WordsC";
            this.tabWordsC.UseVisualStyleBackColor = true;
            // 
            // txtWordC
            // 
            this.txtWordC.Location = new System.Drawing.Point(7, 21);
            this.txtWordC.Multiline = true;
            this.txtWordC.Name = "txtWordC";
            this.txtWordC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWordC.Size = new System.Drawing.Size(179, 194);
            this.txtWordC.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "WordsC";
            // 
            // btnClearWordC
            // 
            this.btnClearWordC.Location = new System.Drawing.Point(107, 226);
            this.btnClearWordC.Name = "btnClearWordC";
            this.btnClearWordC.Size = new System.Drawing.Size(27, 20);
            this.btnClearWordC.TabIndex = 11;
            this.btnClearWordC.Text = "C";
            this.btnClearWordC.UseVisualStyleBackColor = true;
            this.btnClearWordC.Click += new System.EventHandler(this.btnClearWordC_Click);
            // 
            // btnImportWordC
            // 
            this.btnImportWordC.Location = new System.Drawing.Point(11, 225);
            this.btnImportWordC.Name = "btnImportWordC";
            this.btnImportWordC.Size = new System.Drawing.Size(75, 21);
            this.btnImportWordC.TabIndex = 10;
            this.btnImportWordC.Text = "Import";
            this.btnImportWordC.UseVisualStyleBackColor = true;
            this.btnImportWordC.Click += new System.EventHandler(this.btnImportWordC_Click);
            // 
            // btnLowAZ
            // 
            this.btnLowAZ.Location = new System.Drawing.Point(6, 135);
            this.btnLowAZ.Name = "btnLowAZ";
            this.btnLowAZ.Size = new System.Drawing.Size(75, 23);
            this.btnLowAZ.TabIndex = 18;
            this.btnLowAZ.Text = "a-z";
            this.btnLowAZ.UseVisualStyleBackColor = true;
            this.btnLowAZ.Click += new System.EventHandler(this.btnLowAZ_Click);
            // 
            // btnUpAZ
            // 
            this.btnUpAZ.Location = new System.Drawing.Point(87, 134);
            this.btnUpAZ.Name = "btnUpAZ";
            this.btnUpAZ.Size = new System.Drawing.Size(75, 23);
            this.btnUpAZ.TabIndex = 19;
            this.btnUpAZ.Text = "A-Z";
            this.btnUpAZ.UseVisualStyleBackColor = true;
            this.btnUpAZ.Click += new System.EventHandler(this.btnUpAZ_Click);
            // 
            // btnFullAZ
            // 
            this.btnFullAZ.Location = new System.Drawing.Point(168, 134);
            this.btnFullAZ.Name = "btnFullAZ";
            this.btnFullAZ.Size = new System.Drawing.Size(75, 23);
            this.btnFullAZ.TabIndex = 20;
            this.btnFullAZ.Text = "a-Z";
            this.btnFullAZ.UseVisualStyleBackColor = true;
            this.btnFullAZ.Click += new System.EventHandler(this.btnFullAZ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 312);
            this.Controls.Add(this.wordsTab);
            this.Controls.Add(this.passRange);
            this.Controls.Add(this.grPattern);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "WordPasswordGen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grPattern.ResumeLayout(false);
            this.grPattern.PerformLayout();
            this.passRange.ResumeLayout(false);
            this.passRange.PerformLayout();
            this.wordsTab.ResumeLayout(false);
            this.tabWordsA.ResumeLayout(false);
            this.tabWordsA.PerformLayout();
            this.tabWordsB.ResumeLayout(false);
            this.tabWordsB.PerformLayout();
            this.tabWordsC.ResumeLayout(false);
            this.tabWordsC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWordA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWordB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnClearWordA;
        private System.Windows.Forms.Button btnClearWordB;
        private System.Windows.Forms.Button btnImportWordA;
        private System.Windows.Forms.Button btnImportWordB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox grPattern;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWordMin;
        private System.Windows.Forms.TextBox txtWordMax;
        private System.Windows.Forms.GroupBox passRange;
        private System.Windows.Forms.TabControl wordsTab;
        private System.Windows.Forms.TabPage tabWordsA;
        private System.Windows.Forms.TabPage tabWordsB;
        private System.Windows.Forms.TabPage tabWordsC;
        private System.Windows.Forms.TextBox txtWordC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearWordC;
        private System.Windows.Forms.Button btnImportWordC;
        private System.Windows.Forms.Button btnUWordA;
        private System.Windows.Forms.Button btnCWordA;
        private System.Windows.Forms.Button btnLWordA;
        private System.Windows.Forms.TextBox txtPatterns;
        private System.Windows.Forms.Button btnInvWordC;
        private System.Windows.Forms.Button btnInvWordB;
        private System.Windows.Forms.Button btnInvWordA;
        private System.Windows.Forms.Button btnNumSym;
        private System.Windows.Forms.Button btnSymbol;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button btnUWordC;
        private System.Windows.Forms.Button btnCWordC;
        private System.Windows.Forms.Button btnLWordC;
        private System.Windows.Forms.Button btnUWordB;
        private System.Windows.Forms.Button btnCWordB;
        private System.Windows.Forms.Button btnLWordB;
        private System.Windows.Forms.Button btnClearPatterns;
        private System.Windows.Forms.Button btnNewLine;
        private System.Windows.Forms.Button btnFullAZ;
        private System.Windows.Forms.Button btnUpAZ;
        private System.Windows.Forms.Button btnLowAZ;
    }
}

