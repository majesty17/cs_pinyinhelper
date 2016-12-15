using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 拼音助手
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        //1拼音输入
        private void textBox_typein_TextChanged(object sender, EventArgs e)
        {
            //āáǎàōóǒòêēéěèīíǐìūúǔù
            string input = textBox_typein.Text;
            input=input.Replace("a1", "ā");
            input = input.Replace("a2", "á");
            input = input.Replace("a3", "ǎ");
            input = input.Replace("a4", "à");

            input = input.Replace("o1", "ō");
            input = input.Replace("o2", "ó");
            input = input.Replace("o3", "ǒ");
            input = input.Replace("o4", "ò");

            input = input.Replace("e1", "ē");
            input = input.Replace("e2", "é");
            input = input.Replace("e3", "ě");
            input = input.Replace("e4", "è");

            input = input.Replace("i1", "ī");
            input = input.Replace("i2", "í");
            input = input.Replace("i3", "ǐ");
            input = input.Replace("i4", "ì");

            input = input.Replace("u1", "ū");
            input = input.Replace("u2", "ú");
            input = input.Replace("u3", "ǔ");
            input = input.Replace("u4", "ù");

            input = input.Replace("v1", "ū");
            input = input.Replace("v2", "ú");
            input = input.Replace("v3", "ǔ");
            input = input.Replace("v4", "ù");

            textBox_typein.Text = input;
            textBox_typein.SelectionStart = input.Length;
        }

        //2复制
        private void button_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox_typein.Text);
        }

        //3清空
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_typein.Clear();
        }


        //汉字转拼音
        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
            bool add_shengdiao = checkBox_hasshengdiao.Checked;
            bool add_space = checkBox_addspace.Checked;

            string input = textBox_input.Text;
            string output = NPinyin.Pinyin.GetPinyin(input);
            textBox_output.Text = output;
        }


    }
}
