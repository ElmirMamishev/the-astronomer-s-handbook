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
            minuteStartEditNumericUpDown = new NumericUpDown();
            hoursStartEditNumericUpDown = new NumericUpDown();
            label1 = new Label();
            timeToStartViewEditText = new Label();
            TimeToStopViewEditText = new Label();
            hoursEndEditNumericUpDown = new NumericUpDown();
            minuteEndtEditNumericUpDown = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)minuteStartEditNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoursStartEditNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoursEndEditNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minuteEndtEditNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nameTextEdit
            // 
            nameTextEdit.AutoSize = true;
            nameTextEdit.Location = new Point(55, 41);
            nameTextEdit.Name = "nameTextEdit";
            nameTextEdit.Size = new Size(39, 15);
            nameTextEdit.TabIndex = 0;
            nameTextEdit.Text = "Назва";
            // 
            // nameEditBox
            // 
            nameEditBox.Location = new Point(161, 33);
            nameEditBox.Name = "nameEditBox";
            nameEditBox.Size = new Size(418, 23);
            nameEditBox.TabIndex = 1;
            nameEditBox.Validating += nameEditBox_Validating;
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
            constellationEditText.Size = new Size(45, 15);
            constellationEditText.TabIndex = 2;
            constellationEditText.Text = "Сузір'я";
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
            stellarEditText.Size = new Size(103, 15);
            stellarEditText.TabIndex = 4;
            stellarEditText.Text = "Зоряна величина";
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
            distanceEditText.Size = new Size(53, 15);
            distanceEditText.TabIndex = 6;
            distanceEditText.Text = "Відстань";
            // 
            // coordinateEditText
            // 
            coordinateEditText.AutoSize = true;
            coordinateEditText.Location = new Point(55, 157);
            coordinateEditText.Name = "coordinateEditText";
            coordinateEditText.Size = new Size(73, 15);
            coordinateEditText.TabIndex = 8;
            coordinateEditText.Text = "Координати";
            // 
            // cancelButtonEdit
            // 
            cancelButtonEdit.Anchor = AnchorStyles.Top;
            cancelButtonEdit.DialogResult = DialogResult.Retry;
            cancelButtonEdit.Location = new Point(504, 236);
            cancelButtonEdit.Name = "cancelButtonEdit";
            cancelButtonEdit.Size = new Size(75, 23);
            cancelButtonEdit.TabIndex = 13;
            cancelButtonEdit.Text = "Відмінити";
            cancelButtonEdit.UseVisualStyleBackColor = true;
            // 
            // okButtonEdit
            // 
            okButtonEdit.DialogResult = DialogResult.OK;
            okButtonEdit.Location = new Point(415, 236);
            okButtonEdit.Name = "okButtonEdit";
            okButtonEdit.Size = new Size(75, 23);
            okButtonEdit.TabIndex = 12;
            okButtonEdit.Text = "Ок";
            okButtonEdit.UseVisualStyleBackColor = true;
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
            // minuteStartEditNumericUpDown
            // 
            minuteStartEditNumericUpDown.Location = new Point(386, 178);
            minuteStartEditNumericUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minuteStartEditNumericUpDown.Name = "minuteStartEditNumericUpDown";
            minuteStartEditNumericUpDown.Size = new Size(104, 23);
            minuteStartEditNumericUpDown.TabIndex = 24;
            // 
            // hoursStartEditNumericUpDown
            // 
            hoursStartEditNumericUpDown.Location = new Point(250, 178);
            hoursStartEditNumericUpDown.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            hoursStartEditNumericUpDown.Name = "hoursStartEditNumericUpDown";
            hoursStartEditNumericUpDown.Size = new Size(104, 23);
            hoursStartEditNumericUpDown.TabIndex = 23;
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
            // timeToStartViewEditText
            // 
            timeToStartViewEditText.AutoSize = true;
            timeToStartViewEditText.Location = new Point(55, 186);
            timeToStartViewEditText.Name = "timeToStartViewEditText";
            timeToStartViewEditText.Size = new Size(145, 15);
            timeToStartViewEditText.TabIndex = 26;
            timeToStartViewEditText.Text = "Початок спостереження ";
            // 
            // TimeToStopViewEditText
            // 
            TimeToStopViewEditText.AutoSize = true;
            TimeToStopViewEditText.Location = new Point(55, 212);
            TimeToStopViewEditText.Name = "TimeToStopViewEditText";
            TimeToStopViewEditText.Size = new Size(131, 15);
            TimeToStopViewEditText.TabIndex = 27;
            TimeToStopViewEditText.Text = "Кінець спостереження";
            // 
            // hoursEndEditNumericUpDown
            // 
            hoursEndEditNumericUpDown.Location = new Point(250, 207);
            hoursEndEditNumericUpDown.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            hoursEndEditNumericUpDown.Name = "hoursEndEditNumericUpDown";
            hoursEndEditNumericUpDown.Size = new Size(104, 23);
            hoursEndEditNumericUpDown.TabIndex = 28;
            // 
            // minuteEndtEditNumericUpDown
            // 
            minuteEndtEditNumericUpDown.Location = new Point(386, 207);
            minuteEndtEditNumericUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minuteEndtEditNumericUpDown.Name = "minuteEndtEditNumericUpDown";
            minuteEndtEditNumericUpDown.Size = new Size(104, 23);
            minuteEndtEditNumericUpDown.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 209);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 30;
            label2.Text = ":";
            // 
            // EditStarForm
            // 
            AcceptButton = okButtonEdit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButtonEdit;
            ClientSize = new Size(655, 265);
            Controls.Add(label2);
            Controls.Add(minuteEndtEditNumericUpDown);
            Controls.Add(hoursEndEditNumericUpDown);
            Controls.Add(TimeToStopViewEditText);
            Controls.Add(minuteStartEditNumericUpDown);
            Controls.Add(hoursStartEditNumericUpDown);
            Controls.Add(label1);
            Controls.Add(timeToStartViewEditText);
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
            ((System.ComponentModel.ISupportInitialize)minuteStartEditNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoursStartEditNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoursEndEditNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)minuteEndtEditNumericUpDown).EndInit();
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
        private NumericUpDown minuteStartEditNumericUpDown;
        private NumericUpDown hoursStartEditNumericUpDown;
        private Label label1;
        private Label timeToStartViewEditText;
        private Label TimeToStopViewEditText;
        private NumericUpDown hoursEndEditNumericUpDown;
        private NumericUpDown minuteEndtEditNumericUpDown;
        private Label label2;
    }
}