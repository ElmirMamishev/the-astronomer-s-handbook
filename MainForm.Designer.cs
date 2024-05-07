namespace StarBook
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            listBox1 = new ListBox();
            starBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)starBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 80);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "Star";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 120);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Constellation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 155);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 189);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Distance";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(361, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(205, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(361, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(205, 181);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(361, 23);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(291, 225);
            button1.Name = "button1";
            button1.Size = new Size(153, 52);
            button1.TabIndex = 8;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 155);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 10;
            label6.Text = "Coordinate";
            // 
            // listBox1
            // 
            listBox1.DataSource = starBindingSource;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(205, 356);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(361, 214);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // starBindingSource
            // 
            starBindingSource.DataSource = typeof(Models.Star);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 643);
            Controls.Add(listBox1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)starBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label6;
        private ListBox listBox1;
        private BindingSource starBindingSource;
    }
}