namespace 拼音助手
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_copy = new System.Windows.Forms.Button();
            this.textBox_typein = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox_addspace = new System.Windows.Forms.CheckBox();
            this.checkBox_hasshengdiao = new System.Windows.Forms.CheckBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 307);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_clear);
            this.tabPage1.Controls.Add(this.button_copy);
            this.tabPage1.Controls.Add(this.textBox_typein);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "拼音输入";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(549, 250);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "清空";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(468, 250);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(75, 23);
            this.button_copy.TabIndex = 7;
            this.button_copy.Text = "复制";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // textBox_typein
            // 
            this.textBox_typein.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_typein.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_typein.Location = new System.Drawing.Point(3, 3);
            this.textBox_typein.Multiline = true;
            this.textBox_typein.Name = "textBox_typein";
            this.textBox_typein.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_typein.Size = new System.Drawing.Size(629, 241);
            this.textBox_typein.TabIndex = 0;
            this.textBox_typein.TextChanged += new System.EventHandler(this.textBox_typein_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox_addspace);
            this.tabPage2.Controls.Add(this.checkBox_hasshengdiao);
            this.tabPage2.Controls.Add(this.textBox_input);
            this.tabPage2.Controls.Add(this.textBox_output);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(635, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "汉字转拼音";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox_addspace
            // 
            this.checkBox_addspace.AutoSize = true;
            this.checkBox_addspace.Checked = true;
            this.checkBox_addspace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_addspace.Location = new System.Drawing.Point(84, 253);
            this.checkBox_addspace.Name = "checkBox_addspace";
            this.checkBox_addspace.Size = new System.Drawing.Size(84, 16);
            this.checkBox_addspace.TabIndex = 7;
            this.checkBox_addspace.Text = "字符间空格";
            this.checkBox_addspace.UseVisualStyleBackColor = true;
            this.checkBox_addspace.CheckedChanged += new System.EventHandler(this.checkBox_addspace_CheckedChanged);
            // 
            // checkBox_hasshengdiao
            // 
            this.checkBox_hasshengdiao.AutoSize = true;
            this.checkBox_hasshengdiao.Checked = true;
            this.checkBox_hasshengdiao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_hasshengdiao.Location = new System.Drawing.Point(8, 253);
            this.checkBox_hasshengdiao.Name = "checkBox_hasshengdiao";
            this.checkBox_hasshengdiao.Size = new System.Drawing.Size(60, 16);
            this.checkBox_hasshengdiao.TabIndex = 4;
            this.checkBox_hasshengdiao.Text = "带声调";
            this.checkBox_hasshengdiao.UseVisualStyleBackColor = true;
            this.checkBox_hasshengdiao.CheckedChanged += new System.EventHandler(this.checkBox_hasshengdiao_CheckedChanged);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(6, 126);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_input.Size = new System.Drawing.Size(623, 117);
            this.textBox_input.TabIndex = 9;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // textBox_output
            // 
            this.textBox_output.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_output.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_output.Location = new System.Drawing.Point(3, 3);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ReadOnly = true;
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_output.Size = new System.Drawing.Size(629, 117);
            this.textBox_output.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 307);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "拼音助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.CheckBox checkBox_hasshengdiao;
        private System.Windows.Forms.CheckBox checkBox_addspace;
        private System.Windows.Forms.TextBox textBox_typein;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_copy;
    }
}

