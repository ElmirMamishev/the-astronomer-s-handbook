namespace StarBook.Forms
{
    partial class EditStarForm
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
            nameTextEdit = new Label();
            nameEditBox = new TextBox();
            constellationEditBox = new TextBox();
            constellationEditText = new Label();
            stellarEditBox = new TextBox();
            stellarEditText = new Label();
            distanceEditBox = new TextBox();
            distanceEditText = new Label();
            coordinateEditText = new Label();
            cancelButtonEdit = new Button();
            okButtonEdit = new Button();
            coordinateEditBox1 = new TextBox();
            coordinateEditBox2 = new TextBox();
            minuteEditNumericUpDown = new NumericUpDown();
            hoursEditNumericUpDown = new NumericUpDown();
            label1 = new Label();
            timeToViewEditText = new Label();
            ((System.ComponentModel.ISupportInitialize)minuteEditNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoursEditNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nameTextEdit
            // 
            nameTextEdit.AutoSize = true;
            nameTextEdit.Location = new Point(55, 41);
            nameTextEdit.Name = "nameTextEdit";
            nameTextEdit.Size = new Size(39, 15);
            nameTextEdit.TabIndex = 0;
            nameTextEdit.Text = "Name";
            // 
            // nameEditBox
            // 
            nameEditBox.Location = new Point(161, 33);
            nameEditBox.Name = "nameEditBox";
            nameEditBox.Size = new Size(418, 23);
            nameEditBox.TabIndex = 1;
            nameEditBox.Validating += nameBoxEdit_Validating;
            // 
            // constellationEditBox
            // 
            constellationEditBox.Location = new Point(161, 62);
            constellationEditBox.Name = "constellationEditBox";
            constellationEditBox.Size = new Size(418, 23);
            constellationEditBox.TabIndex = 3;
            // 
            // constellationEditText
            // 
            constellationEditText.AutoSize = true;
            constellationEditText.Location = new Point(55, 70);
            constellationEditText.Name = "constellationEditText";
            constellationEditText.Size = new Size(77, 15);
            constellationEditText.TabIndex = 2;
            constellationEditText.Text = "Constellation";
            // 
            // stellarEditBox
            // 
            stellarEditBox.Location = new Point(161, 91);
            stellarEditBox.Name = "stellarEditBox";
            stellarEditBox.Size = new Size(418, 23);
            stellarEditBox.TabIndex = 5;
            stellarEditBox.Validating += stellarBoxEdit_Validating;
            // 
            // stellarEditText
            // 
            stellarEditText.AutoSize = true;
            stellarEditText.Location = new Point(55, 99);
            stellarEditText.Name = "stellarEditText";
            stellarEditText.Size = new Size(100, 15);
            stellarEditText.TabIndex = 4;
            stellarEditText.Text = "Stellar magnitude";
            // 
            // distanceEditBox
            // 
            distanceEditBox.AcceptsTab = true;
            distanceEditBox.Location = new Point(161, 120);
            distanceEditBox.Name = "distanceEditBox";
            distanceEditBox.Size = new Size(418, 23);
            distanceEditBox.TabIndex = 7;
            distanceEditBox.Validating += distanceBoxEdit_Validating;
            // 
            // distanceEditText
            // 
            distanceEditText.AutoSize = true;
            distanceEditText.Location = new Point(55, 128);
            distanceEditText.Name = "distanceEditText";
            distanceEditText.Size = new Size(52, 15);
            distanceEditText.TabIndex = 6;
            distanceEditText.Text = "Distance";
            // 
            // coordinateEditText
            // 
            coordinateEditText.AutoSize = true;
            coordinateEditText.Location = new Point(55, 157);
            coordinateEditText.Name = "coordinateEditText";
            coordinateEditText.Size = new Size(66, 15);
            coordinateEditText.TabIndex = 8;
            coordinateEditText.Text = "Coordinate";
            // 
            // cancelButtonEdit
            // 
            cancelButtonEdit.DialogResult = DialogResult.Cancel;
            cancelButtonEdit.Location = new Point(572, 230);
            cancelButtonEdit.Name = "cancelButtonEdit";
            cancelButtonEdit.Size = new Size(75, 23);
            cancelButtonEdit.TabIndex = 13;
            cancelButtonEdit.Text = "Cancel";
            cancelButtonEdit.UseVisualStyleBackColor = true;
            // 
            // okButtonEdit
            // 
            okButtonEdit.DialogResult = DialogResult.OK;
            okButtonEdit.Location = new Point(491, 230);
            okButtonEdit.Name = "okButtonEdit";
            okButtonEdit.Size = new Size(75, 23);
            okButtonEdit.TabIndex = 12;
            okButtonEdit.Text = "Ok";
            okButtonEdit.UseVisualStyleBackColor = true;
            okButtonEdit.Click += okButtonEdit_Click;
            // 
            // coordinateEditBox1
            // 
            coordinateEditBox1.Location = new Point(161, 149);
            coordinateEditBox1.Name = "coordinateEditBox1";
            coordinateEditBox1.Size = new Size(193, 23);
            coordinateEditBox1.TabIndex = 14;
            // 
            // coordinateEditBox2
            // 
            coordinateEditBox2.Location = new Point(386, 149);
            coordinateEditBox2.Name = "coordinateEditBox2";
            coordinateEditBox2.Size = new Size(193, 23);
            coordinateEditBox2.TabIndex = 15;
            // 
            // minuteEditNumericUpDown
            // 
            minuteEditNumericUpDown.Location = new Point(386, 178);
            minuteEditNumericUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minuteEditNumericUpDown.Name = "minuteEditNumericUpDown";
            minuteEditNumericUpDown.Size = new Size(104, 23);
            minuteEditNumericUpDown.TabIndex = 24;
            // 
            // hoursEditNumericUpDown
            // 
            hoursEditNumericUpDown.Location = new Point(250, 178);
            hoursEditNumericUpDown.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            hoursEditNumericUpDown.Name = "hoursEditNumericUpDown";
            hoursEditNumericUpDown.Size = new Size(104, 23);
            hoursEditNumericUpDown.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 180);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 25;
            label1.Text = ":";
            // 
            // timeToViewEditText
            // 
            timeToViewEditText.AutoSize = true;
            timeToViewEditText.Location = new Point(55, 186);
            timeToViewEditText.Name = "timeToViewEditText";
            timeToViewEditText.Size = new Size(33, 15);
            timeToViewEditText.TabIndex = 26;
            timeToViewEditText.Text = "Time";
            // 
            // EditStarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 265);
            Controls.Add(minuteEditNumericUpDown);
            Controls.Add(hoursEditNumericUpDown);
            Controls.Add(label1);
            Controls.Add(timeToViewEditText);
            Controls.Add(coordinateEditBox2);
            Controls.Add(coordinateEditBox1);
            Controls.Add(cancelButtonEdit);
            Controls.Add(okButtonEdit);
            Controls.Add(coordinateEditText);
            Controls.Add(distanceEditBox);
            Controls.Add(distanceEditText);
            Controls.Add(stellarEditBox);
            Controls.Add(stellarEditText);
            Controls.Add(constellationEditBox);
            Controls.Add(constellationEditText);
            Controls.Add(nameEditBox);
            Controls.Add(nameTextEdit);
            MaximumSize = new Size(671, 304);
            MinimumSize = new Size(671, 304);
            Name = "EditStarForm";
            Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)minuteEditNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoursEditNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameTextEdit;
        private TextBox nameEditBox;
        private TextBox constellationEditBox;
        private Label constellationEditText;
        private TextBox stellarEditBox;
        private Label stellarEditText;
        private TextBox distanceEditBox;
        private Label distanceEditText;
        private Label coordinateEditText;
        private Button cancelButtonEdit;
        private Button okButtonEdit;
        private TextBox coordinateEditBox1;
        private TextBox coordinateEditBox2;
        private NumericUpDown minuteEditNumericUpDown;
        private NumericUpDown hoursEditNumericUpDown;
        private Label label1;
        private Label timeToViewEditText;
    }
}