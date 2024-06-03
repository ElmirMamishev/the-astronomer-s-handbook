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
            coordinateEditBox2 = new TextBox();
            minuteStartEditNumericUpDown = new NumericUpDown();
            hoursStartEditNumericUpDown = new NumericUpDown();
            label1 = new Label();
            timeToStartViewEditText = new Label();
            TimeToStopViewEditText = new Label();
            hoursEndEditNumericUpDown = new NumericUpDown();
            minuteEndtEditNumericUpDown = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            coordinateXEditText = new Label();
            coordinateYEditText = new Label();
            label4 = new Label();
            coordinateEditHText = new Label();
            coordinateEditMText = new Label();
            coordinateEditSText = new Label();
            coordinateEditSBox = new TextBox();
            coordinateEditMBox = new TextBox();
            coordinateEditHBox = new TextBox();
            coordinateEditBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)minuteStartEditNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoursStartEditNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoursEndEditNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minuteEndtEditNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // nameTextEdit
            // 
            nameTextEdit.AutoSize = true;
            nameTextEdit.Location = new Point(50, 41);
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
            constellationEditBox.TabIndex = 2;
            // 
            // constellationEditText
            // 
            constellationEditText.AutoSize = true;
            constellationEditText.Location = new Point(50, 70);
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
            stellarEditBox.TabIndex = 3;
            stellarEditBox.Validating += stellarEditBox_Validating;
            // 
            // stellarEditText
            // 
            stellarEditText.AutoSize = true;
            stellarEditText.Location = new Point(50, 99);
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
            distanceEditBox.TabIndex = 4;
            distanceEditBox.Validating += distanceEditBox_Validating;
            // 
            // distanceEditText
            // 
            distanceEditText.AutoSize = true;
            distanceEditText.Location = new Point(50, 128);
            distanceEditText.Name = "distanceEditText";
            distanceEditText.Size = new Size(53, 15);
            distanceEditText.TabIndex = 6;
            distanceEditText.Text = "Відстань";
            // 
            // coordinateEditText
            // 
            coordinateEditText.AutoSize = true;
            coordinateEditText.Location = new Point(50, 157);
            coordinateEditText.Name = "coordinateEditText";
            coordinateEditText.Size = new Size(73, 15);
            coordinateEditText.TabIndex = 8;
            coordinateEditText.Text = "Координати";
            // 
            // cancelButtonEdit
            // 
            cancelButtonEdit.Anchor = AnchorStyles.Top;
            cancelButtonEdit.DialogResult = DialogResult.Cancel;
            cancelButtonEdit.Location = new Point(568, 278);
            cancelButtonEdit.Name = "cancelButtonEdit";
            cancelButtonEdit.Size = new Size(75, 23);
            cancelButtonEdit.TabIndex = 15;
            cancelButtonEdit.Text = "Відмінити";
            cancelButtonEdit.UseVisualStyleBackColor = true;
            // 
            // okButtonEdit
            // 
            okButtonEdit.DialogResult = DialogResult.OK;
            okButtonEdit.Location = new Point(487, 278);
            okButtonEdit.Name = "okButtonEdit";
            okButtonEdit.Size = new Size(75, 23);
            okButtonEdit.TabIndex = 14;
            okButtonEdit.Text = "Ок";
            okButtonEdit.UseVisualStyleBackColor = true;
            // 
            // coordinateEditBox2
            // 
            coordinateEditBox2.Location = new Point(413, 149);
            coordinateEditBox2.Name = "coordinateEditBox2";
            coordinateEditBox2.Size = new Size(166, 23);
            coordinateEditBox2.TabIndex = 6;
            coordinateEditBox2.Validating += coordinateEditBox2_Validating;
            // 
            // minuteStartEditNumericUpDown
            // 
            minuteStartEditNumericUpDown.Location = new Point(413, 207);
            minuteStartEditNumericUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minuteStartEditNumericUpDown.Name = "minuteStartEditNumericUpDown";
            minuteStartEditNumericUpDown.Size = new Size(104, 23);
            minuteStartEditNumericUpDown.TabIndex = 11;
            // 
            // hoursStartEditNumericUpDown
            // 
            hoursStartEditNumericUpDown.Location = new Point(244, 207);
            hoursStartEditNumericUpDown.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            hoursStartEditNumericUpDown.Name = "hoursStartEditNumericUpDown";
            hoursStartEditNumericUpDown.Size = new Size(104, 23);
            hoursStartEditNumericUpDown.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(377, 209);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 25;
            label1.Text = ":";
            // 
            // timeToStartViewEditText
            // 
            timeToStartViewEditText.AutoSize = true;
            timeToStartViewEditText.Location = new Point(51, 215);
            timeToStartViewEditText.Name = "timeToStartViewEditText";
            timeToStartViewEditText.Size = new Size(145, 15);
            timeToStartViewEditText.TabIndex = 26;
            timeToStartViewEditText.Text = "Початок спостереження ";
            // 
            // TimeToStopViewEditText
            // 
            TimeToStopViewEditText.AutoSize = true;
            TimeToStopViewEditText.Location = new Point(51, 244);
            TimeToStopViewEditText.Name = "TimeToStopViewEditText";
            TimeToStopViewEditText.Size = new Size(131, 15);
            TimeToStopViewEditText.TabIndex = 27;
            TimeToStopViewEditText.Text = "Кінець спостереження";
            // 
            // hoursEndEditNumericUpDown
            // 
            hoursEndEditNumericUpDown.Location = new Point(244, 236);
            hoursEndEditNumericUpDown.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            hoursEndEditNumericUpDown.Name = "hoursEndEditNumericUpDown";
            hoursEndEditNumericUpDown.Size = new Size(104, 23);
            hoursEndEditNumericUpDown.TabIndex = 12;
            // 
            // minuteEndtEditNumericUpDown
            // 
            minuteEndtEditNumericUpDown.Location = new Point(413, 236);
            minuteEndtEditNumericUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minuteEndtEditNumericUpDown.Name = "minuteEndtEditNumericUpDown";
            minuteEndtEditNumericUpDown.Size = new Size(104, 23);
            minuteEndtEditNumericUpDown.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 238);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 30;
            label2.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(585, 128);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 31;
            label3.Text = "св. р.";
            // 
            // coordinateXEditText
            // 
            coordinateXEditText.AutoSize = true;
            coordinateXEditText.Location = new Point(158, 157);
            coordinateXEditText.Name = "coordinateXEditText";
            coordinateXEditText.Size = new Size(18, 15);
            coordinateXEditText.TabIndex = 32;
            coordinateXEditText.Text = "Д:";
            // 
            // coordinateYEditText
            // 
            coordinateYEditText.AutoSize = true;
            coordinateYEditText.Location = new Point(389, 157);
            coordinateYEditText.Name = "coordinateYEditText";
            coordinateYEditText.Size = new Size(21, 15);
            coordinateYEditText.TabIndex = 33;
            coordinateYEditText.Text = "Ш:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 185);
            label4.Name = "label4";
            label4.Size = new Size(148, 15);
            label4.TabIndex = 34;
            label4.Text = "Координати на небосхилі";
            // 
            // coordinateEditHText
            // 
            coordinateEditHText.AutoSize = true;
            coordinateEditHText.Location = new Point(311, 175);
            coordinateEditHText.Name = "coordinateEditHText";
            coordinateEditHText.Size = new Size(12, 15);
            coordinateEditHText.TabIndex = 41;
            coordinateEditHText.Text = "°";
            // 
            // coordinateEditMText
            // 
            coordinateEditMText.AutoSize = true;
            coordinateEditMText.Location = new Point(445, 175);
            coordinateEditMText.Name = "coordinateEditMText";
            coordinateEditMText.Size = new Size(10, 15);
            coordinateEditMText.TabIndex = 42;
            coordinateEditMText.Text = "′";
            // 
            // coordinateEditSText
            // 
            coordinateEditSText.AutoSize = true;
            coordinateEditSText.Location = new Point(585, 175);
            coordinateEditSText.Name = "coordinateEditSText";
            coordinateEditSText.Size = new Size(12, 15);
            coordinateEditSText.TabIndex = 43;
            coordinateEditSText.Text = "″";
            // 
            // coordinateEditSBox
            // 
            coordinateEditSBox.Location = new Point(479, 178);
            coordinateEditSBox.Name = "coordinateEditSBox";
            coordinateEditSBox.Size = new Size(100, 23);
            coordinateEditSBox.TabIndex = 9;
            coordinateEditSBox.Validating += coordinateEditSBox_Validating;
            // 
            // coordinateEditMBox
            // 
            coordinateEditMBox.Location = new Point(339, 178);
            coordinateEditMBox.Name = "coordinateEditMBox";
            coordinateEditMBox.Size = new Size(100, 23);
            coordinateEditMBox.TabIndex = 8;
            coordinateEditMBox.Validating += coordinateEditMBox_Validating;
            // 
            // coordinateEditHBox
            // 
            coordinateEditHBox.Location = new Point(205, 178);
            coordinateEditHBox.Name = "coordinateEditHBox";
            coordinateEditHBox.Size = new Size(100, 23);
            coordinateEditHBox.TabIndex = 7;
            coordinateEditHBox.Validating += coordinateEditHBox_Validating;
            // 
            // coordinateEditBox1
            // 
            coordinateEditBox1.Location = new Point(182, 149);
            coordinateEditBox1.Name = "coordinateEditBox1";
            coordinateEditBox1.Size = new Size(166, 23);
            coordinateEditBox1.TabIndex = 5;
            coordinateEditBox1.Validating += coordinateEditBox1_Validating;
            // 
            // EditStarForm
            // 
            AcceptButton = okButtonEdit;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButtonEdit;
            ClientSize = new Size(655, 313);
            Controls.Add(coordinateEditSText);
            Controls.Add(coordinateEditMText);
            Controls.Add(coordinateEditHText);
            Controls.Add(coordinateEditSBox);
            Controls.Add(coordinateEditHBox);
            Controls.Add(coordinateEditMBox);
            Controls.Add(label4);
            Controls.Add(coordinateYEditText);
            Controls.Add(coordinateXEditText);
            Controls.Add(label3);
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
            MaximumSize = new Size(671, 352);
            MinimumSize = new Size(671, 352);
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
        private TextBox coordinateEditBox2;
        private NumericUpDown minuteStartEditNumericUpDown;
        private NumericUpDown hoursStartEditNumericUpDown;
        private Label label1;
        private Label timeToStartViewEditText;
        private Label TimeToStopViewEditText;
        private NumericUpDown hoursEndEditNumericUpDown;
        private NumericUpDown minuteEndtEditNumericUpDown;
        private Label label2;
        private Label label3;
        private Label coordinateXEditText;
        private Label coordinateYEditText;
        private Label label4;
        private Label coordinateEditHText;
        private Label coordinateEditMText;
        private Label coordinateEditSText;
        private TextBox coordinateEditSBox;
        private TextBox coordinateEditMBox;
        private TextBox coordinateEditHBox;
        private TextBox coordinateEditBox1;
    }
}