using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizletExportReformater
{
    public partial class Form1 : Form
    {
        private ImportProperties importProperties = new ImportProperties();
        private ExportProperties exportProperties = new ExportProperties();
        public Form1()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            QuizletList list = convertToQuizletList(splitTwo(input.Text, importProperties.TermAndDefinationSeparator, importProperties.RowSeparator));
            output.Text = QuizletListToString(list, exportProperties);
        }

        private void debug(String s)
        {
            if (this.enableDebug) Debug.instance.log(s);
        }

        private String QuizletListToString(QuizletList quizletList, ExportProperties exportProperties)
        {
            if (!(exportProperties.ShowTerm) && !(exportProperties.ShowDefination)) return "ERROR - Show Term 和 Show Defination 全被取消了! 那样的话什么都不会输出!";
            if (exportProperties.Sort)
            {
                quizletList.Terms.Sort();
                quizletList.Definations.Sort();
                if (!(exportProperties.SortAz))
                {
                    quizletList.Terms = reverse(quizletList.Terms);
                    quizletList.Definations = reverse(quizletList.Definations);
                }
            }
            String output = "";
            for (int i = 0; i < quizletList.Terms.Count; i++)
            {
                if (exportProperties.ShowTerm)
                    output += quizletList.Terms[i];
                if (exportProperties.ShowTerm && exportProperties.ShowDefination)
                {
                    if (!exportProperties.AutoSpace) output += exportProperties.TermAndDefinationSeparator;
                    else output += exportProperties.Spaces - quizletList.Terms[i].Length < 1 ? " " : spaceGen(i != 0 ? exportProperties.Spaces - quizletList.Terms[i].Length : (exportProperties.Spaces - quizletList.Terms[i].Length) * 2 + 1);
                }
                    
                if (exportProperties.ShowDefination)
                    output += quizletList.Definations[i];
                output += exportProperties.RowSeparator;
            }
            if (exportProperties.ChangeCase)
            {
                if (exportProperties.AllUpperCase) output = output.ToUpper();
                else output = output.ToLower();
            }
            return output;
        }

        public String spaceGen(int count)
        {
            String output = "";
            for (int i = 0; i < count; i++) output += " ";
            return output;
        }

        public List<String> reverse(List<String> input)
        {
            List<String> output = new List<String>();
            for (int i = 0; i < input.Count; i++)
            {
                output.Add(input[input.Count - i - 1]);
            }
            return output;
        }

        public List<String> splitTwo(String rawInput, String splitOne, String splitTwo)
        {
            try
            {
                List<String> firstSplit = split(rawInput, splitOne);
                List<String> output = new List<String>();
                output.Add(firstSplit[0]);
                for (int i = 1; i < firstSplit.Count - 1; i++)
                {
                    List<String> tempList = split(firstSplit[i], splitTwo);
                    foreach (String str in tempList) output.Add(str);
                }
                output.Add(firstSplit[firstSplit.Count - 1]);
                return output;
            }
            catch (Exception ignored)
            {
                List<String> temp = new List<string>();
                temp.Add("ERROR");
                return temp;
            }
        }

        private QuizletList convertToQuizletList(List<String> input)
        {
            List<String> list1 = new List<String>(), list2 = new List<String>();
            for (int i = 0; i < input.Count; i += 1)
            {
                if (IsOdd(i))
                {
                    //奇数
                    list1.Add(input[i]);
                }
                else
                {
                    //偶数
                    list2.Add(input[i]);
                }
            }
            return new QuizletList(list2, list1);
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        public List<String> split(String input, String split)
        {
            List<String> output = new List<String>();
            if (input == null || input == "" || !(input.Contains(split))) return output;
            Char[] charArray = input.ToCharArray();
            String tempString = "";
            for (int i = 0; i < charArray.Length; i++)
            {
                Boolean needToSplit = true;
                for (int j = 0; j < split.Length; j++)
                {
                    if (charArray.Length <= i + j || charArray[i + j] != split[j])
                    {
                        needToSplit = false;
                        break;
                    }
                }

                if (i >= charArray.Length) break;

                if (needToSplit)
                {
                    i += split.Length - 1;
                    
                    output.Add(tempString);
                    tempString = "";
                }
                else
                {
                    tempString += charArray[i];
                }
            }
            output.Add(tempString);
            return output;
        }

        public String listToString(List<String> list)
        {
            String output = "";
            foreach (String each in list) output += each;
            return output;
        }

        public String listToStringDebug(List<String> list)
        {
            String output = "[";
            foreach (String each in list) output += each + ", ";
            return output + "]";
        }

        private void buttonTab_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonTab.Checked == true)
            {
                importProperties.TermAndDefinationSeparator = "\t";
                importProperties.CustomTermAndDefinationSeparator = false;
                refresh();
            }
        }

        private void ButtonComma_CheckedChanged(object sender, EventArgs e)
        {
            if (ButtonComma.Checked == true)
            {
                importProperties.TermAndDefinationSeparator = ",";
                importProperties.CustomTermAndDefinationSeparator = false;
                refresh();
            }
        }

        private void TD_Customize_CheckedChanged(object sender, EventArgs e)
        {
            if (TD_Customize.Checked == true)
            {
                textBox1.Enabled = true;
                importProperties.TermAndDefinationSeparator = textBox1.Text;
                importProperties.CustomTermAndDefinationSeparator = true;
                refresh();
            }
            else
            {
                importProperties.CustomTermAndDefinationSeparator = false;
                textBox1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (importProperties.CustomTermAndDefinationSeparator)
            {
                importProperties.TermAndDefinationSeparator = textBox1.Text;
                refresh();
            }
        }

        private void buttonNewLine_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonNewLine.Checked == true)
            {
                importProperties.RowSeparator = "\n";
                importProperties.CustomRowSeparator = false;
                refresh();
            }
        }

        private void buttonSemicolon_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonSemicolon.Checked == true)
            {
                importProperties.RowSeparator = ";";
                importProperties.CustomRowSeparator = false;
                refresh();
            }
        }

        private void rowCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rowCustom.Checked == true)
            {
                textBox2.Enabled = true;
                importProperties.RowSeparator = textBox2.Text;
                importProperties.CustomRowSeparator = true;
                refresh();
            }
            else
            {
                importProperties.CustomRowSeparator = false;
                textBox2.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (importProperties.CustomRowSeparator)
            {
                importProperties.RowSeparator = textBox2.Text;
                refresh();
            }
        }

        private void buttonShowTerm_CheckedChanged(object sender, EventArgs e)
        {
            exportProperties.ShowTerm = buttonShowTerm.Checked;
            refresh();
        }

        private void buttonShowDefination_CheckedChanged(object sender, EventArgs e)
        {
            exportProperties.ShowDefination = buttonShowDefination.Checked;
            refresh();
        }

        private void buttonSort_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonSort.Checked)
            {
                exportProperties.Sort = true;
                sortAZ.Enabled = true;
                sortZA.Enabled = true;
                refresh();
            }
            else
            {
                exportProperties.Sort = false;
                sortAZ.Enabled = false;
                sortZA.Enabled = false;
                refresh();
            }
        }

        private void sortAZ_CheckedChanged(object sender, EventArgs e)
        {
            if (sortAZ.Checked)
            {
                exportProperties.SortAz = true;
                refresh();
            }
        }

        private void sortZA_CheckedChanged(object sender, EventArgs e)
        {
            if (sortZA.Checked)
            {
                exportProperties.SortAz = false;
                refresh();
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void exportTab_CheckedChanged(object sender, EventArgs e)
        {
            if (exportTab.Checked == true)
            {
                exportProperties.TermAndDefinationSeparator = "\t";
                exportProperties.CustomTermAndDefinationSeparator = false;
                refresh();
            }
        }

        private void exportComma_CheckedChanged(object sender, EventArgs e)
        {
            if (exportComma.Checked == true)
            {
                exportProperties.TermAndDefinationSeparator = ",";
                exportProperties.CustomTermAndDefinationSeparator = false;
                refresh();
            }
        }

        private void exportCustom1_CheckedChanged(object sender, EventArgs e)
        {
            if (exportCustom1.Checked == true)
            {
                exportCustomTB.Enabled = true;
                exportProperties.TermAndDefinationSeparator = exportCustomTB.Text;
                exportProperties.CustomTermAndDefinationSeparator = true;
                refresh();
            }
            else
            {
                exportProperties.CustomTermAndDefinationSeparator = false;
                exportCustomTB.Enabled = false;
            }
        }

        private void exportNewLine_CheckedChanged(object sender, EventArgs e)
        {
            if (exportNewLine.Checked == true)
            {
                exportProperties.RowSeparator = "\n";
                exportProperties.CustomRowSeparator = false;
                refresh();
            }
        }

        private void exportSemiColon_CheckedChanged(object sender, EventArgs e)
        {
            if (exportSemiColon.Checked == true)
            {
                exportProperties.RowSeparator = ";";
                exportProperties.CustomRowSeparator = false;
                refresh();
            }
        }

        private void exportCustom2_CheckedChanged(object sender, EventArgs e)
        {
            if (exportCustom2.Checked == true)
            {
                exportCustomTB2.Enabled = true;
                exportProperties.RowSeparator = exportCustomTB2.Text;
                exportProperties.CustomRowSeparator = true;
                refresh();
            }
            else
            {
                exportProperties.CustomRowSeparator = false;
                exportCustomTB2.Enabled = false;
            }
        }

        private void exportCustomTB_TextChanged(object sender, EventArgs e)
        {
            if (exportProperties.CustomTermAndDefinationSeparator)
            {
                exportProperties.TermAndDefinationSeparator = exportCustomTB.Text;
                refresh();
            }
        }

        private void exportCustomTB2_TextChanged(object sender, EventArgs e)
        {
            if (exportProperties.CustomRowSeparator)
            {
                exportProperties.RowSeparator = exportCustomTB2.Text;
                refresh();
            }
        }

        private Boolean enableDebug = false;
        private Debug debugVar;

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            enableDebug = !enableDebug;
            if (enableDebug)
            {
                debugVar = new Debug();
                debugVar.Visible = true;
            }
            else
            {
                debugVar = null;
            }
        }

        private void buttonAutoSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonAutoSpace.Checked)
            {
                exportProperties.AutoSpace = true;
                exportTab.Enabled = false;
                exportComma.Enabled = false;
                exportCustom1.Enabled = false;
                exportCustomTB.Enabled = false;

                refresh();
            }
            else
            {
                exportProperties.AutoSpace = false;
                exportTab.Enabled = true;
                exportComma.Enabled = true;
                exportCustom1.Enabled = true;
                exportCustomTB.Enabled = true;

                refresh();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (IsInt(textBox3.Text))
            {
                exportProperties.Spaces = int.Parse(textBox3.Text);
                refresh();
            }
            else
            {
                textBox3.Text = exportProperties.Spaces.ToString();
            }
        }

        public static bool IsNumeric(string s)
        {
            float output;
            return float.TryParse(s, out output);
        }

        public static bool IsInt(string s)
        {
            int output;
            return int.TryParse(s, out output);
        }

        private void buttonSwitchCase_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonSwitchCase.Checked)
            {
                exportProperties.ChangeCase = true;
                buttonUpperCase.Enabled = true;
                buttonLowerCase.Enabled = true;
            }
            else
            {
                exportProperties.ChangeCase = false;
                buttonUpperCase.Enabled = false;
                buttonLowerCase.Enabled = false;
            }
            refresh();
        }

        private void buttonUpperCase_CheckedChanged(object sender, EventArgs e)
        {
            exportProperties.AllUpperCase = buttonUpperCase.Checked;
            refresh();
        }

        private void buttonLowerCase_CheckedChanged(object sender, EventArgs e)
        {
            exportProperties.AllLowerCase = buttonLowerCase.Checked;
        }
    }
}
