namespace QuizletExportReformater
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
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonShowTerm = new System.Windows.Forms.CheckBox();
            this.buttonShowDefination = new System.Windows.Forms.CheckBox();
            this.buttonSort = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TD_Customize = new System.Windows.Forms.RadioButton();
            this.ButtonComma = new System.Windows.Forms.RadioButton();
            this.buttonTab = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rowCustom = new System.Windows.Forms.RadioButton();
            this.buttonSemicolon = new System.Windows.Forms.RadioButton();
            this.buttonNewLine = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sortZA = new System.Windows.Forms.RadioButton();
            this.sortAZ = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exportCustomTB2 = new System.Windows.Forms.TextBox();
            this.exportCustom2 = new System.Windows.Forms.RadioButton();
            this.exportSemiColon = new System.Windows.Forms.RadioButton();
            this.exportNewLine = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.exportCustomTB = new System.Windows.Forms.TextBox();
            this.exportCustom1 = new System.Windows.Forms.RadioButton();
            this.exportComma = new System.Windows.Forms.RadioButton();
            this.exportTab = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAutoSpace = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonSwitchCase = new System.Windows.Forms.CheckBox();
            this.buttonUpperCase = new System.Windows.Forms.RadioButton();
            this.buttonLowerCase = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonGithub = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入";
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(17, 220);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(384, 133);
            this.input.TabIndex = 2;
            this.input.Text = "";
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "分隔符 (在Term和Defination之间)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "输出";
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(438, 220);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(384, 133);
            this.output.TabIndex = 2;
            this.output.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "分隔符 (在两行之间)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "选项";
            // 
            // buttonShowTerm
            // 
            this.buttonShowTerm.AutoSize = true;
            this.buttonShowTerm.Checked = true;
            this.buttonShowTerm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buttonShowTerm.Location = new System.Drawing.Point(445, 387);
            this.buttonShowTerm.Name = "buttonShowTerm";
            this.buttonShowTerm.Size = new System.Drawing.Size(74, 17);
            this.buttonShowTerm.TabIndex = 6;
            this.buttonShowTerm.Text = "显示Term";
            this.buttonShowTerm.UseVisualStyleBackColor = true;
            this.buttonShowTerm.CheckedChanged += new System.EventHandler(this.buttonShowTerm_CheckedChanged);
            // 
            // buttonShowDefination
            // 
            this.buttonShowDefination.AutoSize = true;
            this.buttonShowDefination.Checked = true;
            this.buttonShowDefination.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buttonShowDefination.Location = new System.Drawing.Point(445, 410);
            this.buttonShowDefination.Name = "buttonShowDefination";
            this.buttonShowDefination.Size = new System.Drawing.Size(98, 17);
            this.buttonShowDefination.TabIndex = 6;
            this.buttonShowDefination.Text = "显示Defination";
            this.buttonShowDefination.UseVisualStyleBackColor = true;
            this.buttonShowDefination.CheckedChanged += new System.EventHandler(this.buttonShowDefination_CheckedChanged);
            // 
            // buttonSort
            // 
            this.buttonSort.AutoSize = true;
            this.buttonSort.Location = new System.Drawing.Point(445, 433);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(110, 17);
            this.buttonSort.TabIndex = 6;
            this.buttonSort.Text = "按字母顺序排序";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.CheckedChanged += new System.EventHandler(this.buttonSort_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.TD_Customize);
            this.panel1.Controls.Add(this.ButtonComma);
            this.panel1.Controls.Add(this.buttonTab);
            this.panel1.Location = new System.Drawing.Point(18, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 96);
            this.panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TD_Customize
            // 
            this.TD_Customize.AutoSize = true;
            this.TD_Customize.Location = new System.Drawing.Point(3, 49);
            this.TD_Customize.Name = "TD_Customize";
            this.TD_Customize.Size = new System.Drawing.Size(94, 17);
            this.TD_Customize.TabIndex = 2;
            this.TD_Customize.Text = "自定义 (下面)";
            this.TD_Customize.UseVisualStyleBackColor = true;
            this.TD_Customize.CheckedChanged += new System.EventHandler(this.TD_Customize_CheckedChanged);
            // 
            // ButtonComma
            // 
            this.ButtonComma.AutoSize = true;
            this.ButtonComma.Location = new System.Drawing.Point(3, 26);
            this.ButtonComma.Name = "ButtonComma";
            this.ButtonComma.Size = new System.Drawing.Size(60, 17);
            this.ButtonComma.TabIndex = 1;
            this.ButtonComma.Text = "Comma";
            this.ButtonComma.UseVisualStyleBackColor = true;
            this.ButtonComma.CheckedChanged += new System.EventHandler(this.ButtonComma_CheckedChanged);
            // 
            // buttonTab
            // 
            this.buttonTab.AutoSize = true;
            this.buttonTab.Checked = true;
            this.buttonTab.Location = new System.Drawing.Point(3, 3);
            this.buttonTab.Name = "buttonTab";
            this.buttonTab.Size = new System.Drawing.Size(44, 17);
            this.buttonTab.TabIndex = 0;
            this.buttonTab.TabStop = true;
            this.buttonTab.Text = "Tab";
            this.buttonTab.UseVisualStyleBackColor = true;
            this.buttonTab.CheckedChanged += new System.EventHandler(this.buttonTab_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.rowCustom);
            this.panel2.Controls.Add(this.buttonSemicolon);
            this.panel2.Controls.Add(this.buttonNewLine);
            this.panel2.Location = new System.Drawing.Point(226, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 96);
            this.panel2.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(3, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rowCustom
            // 
            this.rowCustom.AutoSize = true;
            this.rowCustom.Location = new System.Drawing.Point(3, 49);
            this.rowCustom.Name = "rowCustom";
            this.rowCustom.Size = new System.Drawing.Size(94, 17);
            this.rowCustom.TabIndex = 2;
            this.rowCustom.Text = "自定义 (下面)";
            this.rowCustom.UseVisualStyleBackColor = true;
            this.rowCustom.CheckedChanged += new System.EventHandler(this.rowCustom_CheckedChanged);
            // 
            // buttonSemicolon
            // 
            this.buttonSemicolon.AutoSize = true;
            this.buttonSemicolon.Location = new System.Drawing.Point(3, 26);
            this.buttonSemicolon.Name = "buttonSemicolon";
            this.buttonSemicolon.Size = new System.Drawing.Size(74, 17);
            this.buttonSemicolon.TabIndex = 1;
            this.buttonSemicolon.Text = "Semicolon";
            this.buttonSemicolon.UseVisualStyleBackColor = true;
            this.buttonSemicolon.CheckedChanged += new System.EventHandler(this.buttonSemicolon_CheckedChanged);
            // 
            // buttonNewLine
            // 
            this.buttonNewLine.AutoSize = true;
            this.buttonNewLine.Checked = true;
            this.buttonNewLine.Location = new System.Drawing.Point(3, 3);
            this.buttonNewLine.Name = "buttonNewLine";
            this.buttonNewLine.Size = new System.Drawing.Size(70, 17);
            this.buttonNewLine.TabIndex = 0;
            this.buttonNewLine.TabStop = true;
            this.buttonNewLine.Text = "New Line";
            this.buttonNewLine.UseVisualStyleBackColor = true;
            this.buttonNewLine.CheckedChanged += new System.EventHandler(this.buttonNewLine_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sortZA);
            this.panel3.Controls.Add(this.sortAZ);
            this.panel3.Location = new System.Drawing.Point(444, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 25);
            this.panel3.TabIndex = 8;
            // 
            // sortZA
            // 
            this.sortZA.AutoSize = true;
            this.sortZA.Enabled = false;
            this.sortZA.Location = new System.Drawing.Point(72, 0);
            this.sortZA.Name = "sortZA";
            this.sortZA.Size = new System.Drawing.Size(66, 17);
            this.sortZA.TabIndex = 9;
            this.sortZA.Text = "Z-A排序";
            this.sortZA.UseVisualStyleBackColor = true;
            this.sortZA.CheckedChanged += new System.EventHandler(this.sortZA_CheckedChanged);
            // 
            // sortAZ
            // 
            this.sortAZ.AutoSize = true;
            this.sortAZ.Checked = true;
            this.sortAZ.Enabled = false;
            this.sortAZ.Location = new System.Drawing.Point(0, 0);
            this.sortAZ.Name = "sortAZ";
            this.sortAZ.Size = new System.Drawing.Size(66, 17);
            this.sortAZ.TabIndex = 0;
            this.sortAZ.TabStop = true;
            this.sortAZ.Text = "A-Z排序";
            this.sortAZ.UseVisualStyleBackColor = true;
            this.sortAZ.CheckedChanged += new System.EventHandler(this.sortAZ_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 41);
            this.label6.TabIndex = 9;
            this.label6.Text = "输入设置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 41);
            this.label7.TabIndex = 9;
            this.label7.Text = "输出设置";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, -66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(9, 780);
            this.label8.TabIndex = 10;
            this.label8.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n" +
    "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r" +
    "\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.exportCustomTB2);
            this.panel4.Controls.Add(this.exportCustom2);
            this.panel4.Controls.Add(this.exportSemiColon);
            this.panel4.Controls.Add(this.exportNewLine);
            this.panel4.Location = new System.Drawing.Point(646, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 96);
            this.panel4.TabIndex = 13;
            // 
            // exportCustomTB2
            // 
            this.exportCustomTB2.Enabled = false;
            this.exportCustomTB2.Location = new System.Drawing.Point(3, 72);
            this.exportCustomTB2.Name = "exportCustomTB2";
            this.exportCustomTB2.Size = new System.Drawing.Size(164, 20);
            this.exportCustomTB2.TabIndex = 3;
            this.exportCustomTB2.TextChanged += new System.EventHandler(this.exportCustomTB2_TextChanged);
            // 
            // exportCustom2
            // 
            this.exportCustom2.AutoSize = true;
            this.exportCustom2.Location = new System.Drawing.Point(3, 49);
            this.exportCustom2.Name = "exportCustom2";
            this.exportCustom2.Size = new System.Drawing.Size(94, 17);
            this.exportCustom2.TabIndex = 2;
            this.exportCustom2.Text = "自定义 (下面)";
            this.exportCustom2.UseVisualStyleBackColor = true;
            this.exportCustom2.CheckedChanged += new System.EventHandler(this.exportCustom2_CheckedChanged);
            // 
            // exportSemiColon
            // 
            this.exportSemiColon.AutoSize = true;
            this.exportSemiColon.Location = new System.Drawing.Point(3, 26);
            this.exportSemiColon.Name = "exportSemiColon";
            this.exportSemiColon.Size = new System.Drawing.Size(74, 17);
            this.exportSemiColon.TabIndex = 1;
            this.exportSemiColon.Text = "Semicolon";
            this.exportSemiColon.UseVisualStyleBackColor = true;
            this.exportSemiColon.CheckedChanged += new System.EventHandler(this.exportSemiColon_CheckedChanged);
            // 
            // exportNewLine
            // 
            this.exportNewLine.AutoSize = true;
            this.exportNewLine.Checked = true;
            this.exportNewLine.Location = new System.Drawing.Point(3, 3);
            this.exportNewLine.Name = "exportNewLine";
            this.exportNewLine.Size = new System.Drawing.Size(70, 17);
            this.exportNewLine.TabIndex = 0;
            this.exportNewLine.TabStop = true;
            this.exportNewLine.Text = "New Line";
            this.exportNewLine.UseVisualStyleBackColor = true;
            this.exportNewLine.CheckedChanged += new System.EventHandler(this.exportNewLine_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.exportCustomTB);
            this.panel5.Controls.Add(this.exportCustom1);
            this.panel5.Controls.Add(this.exportComma);
            this.panel5.Controls.Add(this.exportTab);
            this.panel5.Location = new System.Drawing.Point(438, 96);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 96);
            this.panel5.TabIndex = 14;
            // 
            // exportCustomTB
            // 
            this.exportCustomTB.Enabled = false;
            this.exportCustomTB.Location = new System.Drawing.Point(3, 72);
            this.exportCustomTB.Name = "exportCustomTB";
            this.exportCustomTB.Size = new System.Drawing.Size(164, 20);
            this.exportCustomTB.TabIndex = 3;
            this.exportCustomTB.TextChanged += new System.EventHandler(this.exportCustomTB_TextChanged);
            // 
            // exportCustom1
            // 
            this.exportCustom1.AutoSize = true;
            this.exportCustom1.Location = new System.Drawing.Point(3, 49);
            this.exportCustom1.Name = "exportCustom1";
            this.exportCustom1.Size = new System.Drawing.Size(94, 17);
            this.exportCustom1.TabIndex = 2;
            this.exportCustom1.Text = "自定义 (下面)";
            this.exportCustom1.UseVisualStyleBackColor = true;
            this.exportCustom1.CheckedChanged += new System.EventHandler(this.exportCustom1_CheckedChanged);
            // 
            // exportComma
            // 
            this.exportComma.AutoSize = true;
            this.exportComma.Location = new System.Drawing.Point(3, 26);
            this.exportComma.Name = "exportComma";
            this.exportComma.Size = new System.Drawing.Size(60, 17);
            this.exportComma.TabIndex = 1;
            this.exportComma.Text = "Comma";
            this.exportComma.UseVisualStyleBackColor = true;
            this.exportComma.CheckedChanged += new System.EventHandler(this.exportComma_CheckedChanged);
            // 
            // exportTab
            // 
            this.exportTab.AutoSize = true;
            this.exportTab.Checked = true;
            this.exportTab.Location = new System.Drawing.Point(3, 3);
            this.exportTab.Name = "exportTab";
            this.exportTab.Size = new System.Drawing.Size(44, 17);
            this.exportTab.TabIndex = 0;
            this.exportTab.TabStop = true;
            this.exportTab.Text = "Tab";
            this.exportTab.UseVisualStyleBackColor = true;
            this.exportTab.CheckedChanged += new System.EventHandler(this.exportTab_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(643, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "分隔符 (在两行之间)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "分隔符 (在Term和Defination之间)";
            // 
            // buttonAutoSpace
            // 
            this.buttonAutoSpace.AutoSize = true;
            this.buttonAutoSpace.Location = new System.Drawing.Point(649, 366);
            this.buttonAutoSpace.Name = "buttonAutoSpace";
            this.buttonAutoSpace.Size = new System.Drawing.Size(179, 17);
            this.buttonAutoSpace.TabIndex = 6;
            this.buttonAutoSpace.Text = "自动补全空格 (空格数量下面)";
            this.buttonAutoSpace.UseVisualStyleBackColor = true;
            this.buttonAutoSpace.CheckedChanged += new System.EventHandler(this.buttonAutoSpace_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(649, 385);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "15";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonLowerCase);
            this.panel6.Controls.Add(this.buttonUpperCase);
            this.panel6.Controls.Add(this.buttonSwitchCase);
            this.panel6.Location = new System.Drawing.Point(643, 412);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 65);
            this.panel6.TabIndex = 16;
            // 
            // buttonSwitchCase
            // 
            this.buttonSwitchCase.AutoSize = true;
            this.buttonSwitchCase.Location = new System.Drawing.Point(6, 0);
            this.buttonSwitchCase.Name = "buttonSwitchCase";
            this.buttonSwitchCase.Size = new System.Drawing.Size(86, 17);
            this.buttonSwitchCase.TabIndex = 0;
            this.buttonSwitchCase.Text = "大小写转换";
            this.buttonSwitchCase.UseVisualStyleBackColor = true;
            this.buttonSwitchCase.CheckedChanged += new System.EventHandler(this.buttonSwitchCase_CheckedChanged);
            // 
            // buttonUpperCase
            // 
            this.buttonUpperCase.AutoSize = true;
            this.buttonUpperCase.Checked = true;
            this.buttonUpperCase.Enabled = false;
            this.buttonUpperCase.Location = new System.Drawing.Point(6, 20);
            this.buttonUpperCase.Name = "buttonUpperCase";
            this.buttonUpperCase.Size = new System.Drawing.Size(61, 17);
            this.buttonUpperCase.TabIndex = 1;
            this.buttonUpperCase.TabStop = true;
            this.buttonUpperCase.Text = "全大写";
            this.buttonUpperCase.UseVisualStyleBackColor = true;
            this.buttonUpperCase.CheckedChanged += new System.EventHandler(this.buttonUpperCase_CheckedChanged);
            // 
            // buttonLowerCase
            // 
            this.buttonLowerCase.AutoSize = true;
            this.buttonLowerCase.Enabled = false;
            this.buttonLowerCase.Location = new System.Drawing.Point(6, 41);
            this.buttonLowerCase.Name = "buttonLowerCase";
            this.buttonLowerCase.Size = new System.Drawing.Size(61, 17);
            this.buttonLowerCase.TabIndex = 2;
            this.buttonLowerCase.Text = "全小写";
            this.buttonLowerCase.UseVisualStyleBackColor = true;
            this.buttonLowerCase.CheckedChanged += new System.EventHandler(this.buttonLowerCase_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(388, 51);
            this.label11.TabIndex = 17;
            this.label11.Text = "说明: 在Quizlet界面上 点标题下面的一个圆的 \"...\" 然后点Export (导出)\r\n在这个程序的\"输入设置\"里设置和导出格式同样的格式\r\n然后把Qu" +
    "izlet网站导出的复制过来, 在输出设置里面设置新的格式即可\r\n";
            // 
            // buttonGithub
            // 
            this.buttonGithub.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGithub.Location = new System.Drawing.Point(53, 447);
            this.buttonGithub.Name = "buttonGithub";
            this.buttonGithub.Size = new System.Drawing.Size(311, 31);
            this.buttonGithub.TabIndex = 18;
            this.buttonGithub.Text = "Github";
            this.buttonGithub.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 493);
            this.Controls.Add(this.buttonGithub);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonShowDefination);
            this.Controls.Add(this.buttonAutoSpace);
            this.Controls.Add(this.buttonShowTerm);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Quizlet 导出格式辅助  By: 小桂Hykilpikonna";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox buttonShowTerm;
        private System.Windows.Forms.CheckBox buttonShowDefination;
        private System.Windows.Forms.CheckBox buttonSort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ButtonComma;
        private System.Windows.Forms.RadioButton buttonTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton TD_Customize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rowCustom;
        private System.Windows.Forms.RadioButton buttonSemicolon;
        private System.Windows.Forms.RadioButton buttonNewLine;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton sortZA;
        private System.Windows.Forms.RadioButton sortAZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox exportCustomTB2;
        private System.Windows.Forms.RadioButton exportCustom2;
        private System.Windows.Forms.RadioButton exportSemiColon;
        private System.Windows.Forms.RadioButton exportNewLine;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox exportCustomTB;
        private System.Windows.Forms.RadioButton exportCustom1;
        private System.Windows.Forms.RadioButton exportComma;
        private System.Windows.Forms.RadioButton exportTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox buttonAutoSpace;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton buttonLowerCase;
        private System.Windows.Forms.RadioButton buttonUpperCase;
        private System.Windows.Forms.CheckBox buttonSwitchCase;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonGithub;
    }
}

