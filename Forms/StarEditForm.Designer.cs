namespace StarBook.Forms
{
    partial class StarEditForm
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
            nameBoxEdit = new TextBox();
            constellationBoxEdit = new TextBox();
            constellationTextEdit = new Label();
            stellarBoxEdit = new TextBox();
            stellarTextEdit = new Label();
            distanceBoxEdit = new TextBox();
            distanceTextEdit = new Label();
            coordinateBoxEdit = new TextBox();
            label5 = new Label();
            okButtonEdit = new Button();
            cancelButtonEdit = new Button();
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
            // nameBoxEdit
            // 
            nameBoxEdit.Enabled = false;
            nameBoxEdit.Location = new Point(161, 33);
            nameBoxEdit.Name = "nameBoxEdit";
            nameBoxEdit.Size = new Size(418, 23);
            nameBoxEdit.TabIndex = 1;
            // 
            // constellationBoxEdit
            // 
            constellationBoxEdit.Location = new Point(161, 62);
            constellationBoxEdit.Name = "constellationBoxEdit";
            constellationBoxEdit.Size = new Size(418, 23);
            constellationBoxEdit.TabIndex = 3;
            // 
            // constellationTextEdit
            // 
            constellationTextEdit.AutoSize = true;
            constellationTextEdit.Location = new Point(55, 70);
            constellationTextEdit.Name = "constellationTextEdit";
            constellationTextEdit.Size = new Size(77, 15);
            constellationTextEdit.TabIndex = 2;
            constellationTextEdit.Text = "Constellation";
            // 
            // stellarBoxEdit
            // 
            stellarBoxEdit.Location = new Point(161, 91);
            stellarBoxEdit.Name = "stellarBoxEdit";
            stellarBoxEdit.Size = new Size(418, 23);
            stellarBoxEdit.TabIndex = 5;
            // 
            // stellarTextEdit
            // 
            stellarTextEdit.AutoSize = true;
            stellarTextEdit.Location = new Point(55, 99);
            stellarTextEdit.Name = "stellarTextEdit";
            stellarTextEdit.Size = new Size(100, 15);
            stellarTextEdit.TabIndex = 4;
            stellarTextEdit.Text = "Stellar magnitude";
            // 
            // distanceBoxEdit
            // 
            distanceBoxEdit.Location = new Point(161, 120);
            distanceBoxEdit.Name = "distanceBoxEdit";
            distanceBoxEdit.Size = new Size(418, 23);
            distanceBoxEdit.TabIndex = 7;
            // 
            // distanceTextEdit
            // 
            distanceTextEdit.AutoSize = true;
            distanceTextEdit.Location = new Point(55, 128);
            distanceTextEdit.Name = "distanceTextEdit";
            distanceTextEdit.Size = new Size(52, 15);
            distanceTextEdit.TabIndex = 6;
            distanceTextEdit.Text = "Distance";
            // 
            // coordinateBoxEdit
            // 
            coordinateBoxEdit.Location = new Point(161, 149);
            coordinateBoxEdit.Name = "coordinateBoxEdit";
            coordinateBoxEdit.Size = new Size(418, 23);
            coordinateBoxEdit.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 157);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 8;
            label5.Text = "Coordinate";
            // 
            // okButtonEdit
            // 
            okButtonEdit.DialogResult = DialogResult.OK;
            okButtonEdit.Location = new Point(410, 188);
            okButtonEdit.Name = "okButtonEdit";
            okButtonEdit.Size = new Size(75, 23);
            okButtonEdit.TabIndex = 12;
            okButtonEdit.Text = "Ok";
            okButtonEdit.UseVisualStyleBackColor = true;
            okButtonEdit.Click += okButtonEdit_Click;
            // 
            // cancelButtonEdit
            // 
            cancelButtonEdit.DialogResult = DialogResult.Cancel;
            cancelButtonEdit.Location = new Point(504, 188);
            cancelButtonEdit.Name = "cancelButtonEdit";
            cancelButtonEdit.Size = new Size(75, 23);
            cancelButtonEdit.TabIndex = 13;
            cancelButtonEdit.Text = "Cancel";
            cancelButtonEdit.UseVisualStyleBackColor = true;
            // 
            // StarEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 265);
            Controls.Add(cancelButtonEdit);
            Controls.Add(okButtonEdit);
            Controls.Add(coordinateBoxEdit);
            Controls.Add(label5);
            Controls.Add(distanceBoxEdit);
            Controls.Add(distanceTextEdit);
            Controls.Add(stellarBoxEdit);
            Controls.Add(stellarTextEdit);
            Controls.Add(constellationBoxEdit);
            Controls.Add(constellationTextEdit);
            Controls.Add(nameBoxEdit);
            Controls.Add(nameTextEdit);
            MaximumSize = new Size(671, 304);
            MinimumSize = new Size(671, 304);
            Name = "StarEditForm";
            Text = "SecondForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameTextEdit;
        private TextBox nameBoxEdit;
        private TextBox constellationBoxEdit;
        private Label constellationTextEdit;
        private TextBox stellarBoxEdit;
        private Label stellarTextEdit;
        private TextBox distanceBoxEdit;
        private Label distanceTextEdit;
        private TextBox coordinateBoxEdit;
        private Label label5;
        private Button okButtonEdit;
        private Button cancelButtonEdit;
    }
}