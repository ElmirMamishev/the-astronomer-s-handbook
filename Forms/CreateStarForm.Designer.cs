namespace StarBook.Forms
{
    partial class CreateStarForm
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
            minuteCreateNumericUpDown = new NumericUpDown();
            hoursCreateNumericUpDown = new NumericUpDown();
            label1 = new Label();
            timeToView = new Label();
            coordinateCreateBox2 = new TextBox();
            coordinateCreateBox1 = new TextBox();
            coordinateText = new Label();
            distanceCreateBox = new TextBox();
            distanceText = new Label();
            stellarCreateBox = new TextBox();
            stellarText = new Label();
            constellationCreateBox = new TextBox();
            label2 = new Label();
            nameCreateBox = new TextBox();
            nameText = new Label();
            panel1 = new Panel();
            okButton = new Button();
            ((System.ComponentModel.ISupportInitialize)minuteCreateNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoursCreateNumericUpDown).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // minuteCreateNumericUpDown
            // 
            minuteCreateNumericUpDown.Location = new Point(410, 189);
            minuteCreateNumericUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minuteCreateNumericUpDown.Name = "minuteCreateNumericUpDown";
            minuteCreateNumericUpDown.Size = new Size(104, 23);
            minuteCreateNumericUpDown.TabIndex = 38;
            // 
            // hoursCreateNumericUpDown
            // 
            hoursCreateNumericUpDown.Location = new Point(255, 189);
            hoursCreateNumericUpDown.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            hoursCreateNumericUpDown.Name = "hoursCreateNumericUpDown";
            hoursCreateNumericUpDown.Size = new Size(104, 23);
            hoursCreateNumericUpDown.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(380, 192);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 39;
            label1.Text = ":";
            // 
            // timeToView
            // 
            timeToView.AutoSize = true;
            timeToView.Location = new Point(46, 197);
            timeToView.Name = "timeToView";
            timeToView.Size = new Size(33, 15);
            timeToView.TabIndex = 40;
            timeToView.Text = "Time";
            // 
            // coordinateCreateBox2
            // 
            coordinateCreateBox2.Location = new Point(410, 160);
            coordinateCreateBox2.Name = "coordinateCreateBox2";
            coordinateCreateBox2.Size = new Size(104, 23);
            coordinateCreateBox2.TabIndex = 32;
            // 
            // coordinateCreateBox1
            // 
            coordinateCreateBox1.Location = new Point(255, 160);
            coordinateCreateBox1.Name = "coordinateCreateBox1";
            coordinateCreateBox1.Size = new Size(104, 23);
            coordinateCreateBox1.TabIndex = 30;
            // 
            // coordinateText
            // 
            coordinateText.AutoSize = true;
            coordinateText.Location = new Point(45, 168);
            coordinateText.Name = "coordinateText";
            coordinateText.Size = new Size(66, 15);
            coordinateText.TabIndex = 34;
            coordinateText.Text = "Coordinate";
            // 
            // distanceCreateBox
            // 
            distanceCreateBox.Location = new Point(184, 131);
            distanceCreateBox.Name = "distanceCreateBox";
            distanceCreateBox.Size = new Size(400, 23);
            distanceCreateBox.TabIndex = 29;
            // 
            // distanceText
            // 
            distanceText.AutoSize = true;
            distanceText.Location = new Point(45, 139);
            distanceText.Name = "distanceText";
            distanceText.Size = new Size(52, 15);
            distanceText.TabIndex = 31;
            distanceText.Text = "Distance";
            // 
            // stellarCreateBox
            // 
            stellarCreateBox.Location = new Point(184, 102);
            stellarCreateBox.Name = "stellarCreateBox";
            stellarCreateBox.Size = new Size(400, 23);
            stellarCreateBox.TabIndex = 27;
            // 
            // stellarText
            // 
            stellarText.AutoSize = true;
            stellarText.Location = new Point(45, 110);
            stellarText.Name = "stellarText";
            stellarText.Size = new Size(100, 15);
            stellarText.TabIndex = 28;
            stellarText.Text = "Stellar magnitude";
            // 
            // constellationCreateBox
            // 
            constellationCreateBox.Location = new Point(184, 73);
            constellationCreateBox.Name = "constellationCreateBox";
            constellationCreateBox.Size = new Size(400, 23);
            constellationCreateBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 81);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 25;
            label2.Text = "Constellation";
            // 
            // nameCreateBox
            // 
            nameCreateBox.Location = new Point(184, 44);
            nameCreateBox.Name = "nameCreateBox";
            nameCreateBox.Size = new Size(400, 23);
            nameCreateBox.TabIndex = 24;
            // 
            // nameText
            // 
            nameText.AutoSize = true;
            nameText.Location = new Point(45, 52);
            nameText.Name = "nameText";
            nameText.Size = new Size(39, 15);
            nameText.TabIndex = 23;
            nameText.Text = "Name";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(okButton);
            panel1.Controls.Add(minuteCreateNumericUpDown);
            panel1.Controls.Add(hoursCreateNumericUpDown);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(timeToView);
            panel1.Controls.Add(coordinateCreateBox2);
            panel1.Controls.Add(coordinateCreateBox1);
            panel1.Controls.Add(coordinateText);
            panel1.Controls.Add(distanceCreateBox);
            panel1.Controls.Add(distanceText);
            panel1.Controls.Add(stellarCreateBox);
            panel1.Controls.Add(stellarText);
            panel1.Controls.Add(constellationCreateBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nameCreateBox);
            panel1.Controls.Add(nameText);
            panel1.Location = new Point(27, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 295);
            panel1.TabIndex = 41;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Top;
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(564, 269);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 41;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // CreateStarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 342);
            Controls.Add(panel1);
            MaximumSize = new Size(714, 381);
            MinimumSize = new Size(714, 381);
            Name = "CreateStarForm";
            Text = "CreateStarForm";
            ((System.ComponentModel.ISupportInitialize)minuteCreateNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoursCreateNumericUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown minuteCreateNumericUpDown;
        private NumericUpDown hoursCreateNumericUpDown;
        private Label label1;
        private Label timeToView;
        private TextBox coordinateCreateBox2;
        private TextBox coordinateCreateBox1;
        private Label coordinateText;
        private TextBox distanceCreateBox;
        private Label distanceText;
        private TextBox stellarCreateBox;
        private Label stellarText;
        private TextBox constellationCreateBox;
        private Label label2;
        private TextBox nameCreateBox;
        private Label nameText;
        private Panel panel1;
        private Button okButton;
    }
}