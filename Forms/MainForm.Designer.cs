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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            imageList1 = new ImageList(components);
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            createNewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            coordinateXText = new Label();
            coordinateYText = new Label();
            label3 = new Label();
            addButton = new Button();
            minuteNumericUpDown = new NumericUpDown();
            hoursNumericUpDown = new NumericUpDown();
            searchButton = new Button();
            label1 = new Label();
            timeToView = new Label();
            coordinateBox2 = new TextBox();
            coordinateBox1 = new TextBox();
            coordinateText = new Label();
            distanceBox = new TextBox();
            distanceText = new Label();
            stellarBox = new TextBox();
            stellarText = new Label();
            constellationBox = new TextBox();
            label2 = new Label();
            nameBox = new TextBox();
            nameText = new Label();
            resultList = new ListBox();
            starBindingSource = new BindingSource(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minuteNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoursNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(146, 22);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(146, 22);
            openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(146, 22);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(146, 22);
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(146, 22);
            printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(146, 22);
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(146, 22);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(678, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createNewToolStripMenuItem, toolStripSeparator5, openToolStripMenuItem1, toolStripSeparator3, saveToolStripMenuItem1, toolStripSeparator4, exitToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "&Файл";
            // 
            // createNewToolStripMenuItem
            // 
            createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            createNewToolStripMenuItem.Size = new Size(172, 22);
            createNewToolStripMenuItem.Text = "Створити";
            createNewToolStripMenuItem.Click += createNewToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(169, 6);
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Image = (Image)resources.GetObject("openToolStripMenuItem1.Image");
            openToolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem1.Size = new Size(172, 22);
            openToolStripMenuItem1.Text = "&Відкирити";
            openToolStripMenuItem1.Click += openToolStripMenuItem1_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(169, 6);
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Image = (Image)resources.GetObject("saveToolStripMenuItem1.Image");
            saveToolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem1.Size = new Size(172, 22);
            saveToolStripMenuItem1.Text = "&Зберегти";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(169, 6);
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(172, 22);
            exitToolStripMenuItem1.Text = "В&ийти";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(coordinateXText);
            panel1.Controls.Add(coordinateYText);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(minuteNumericUpDown);
            panel1.Controls.Add(hoursNumericUpDown);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(timeToView);
            panel1.Controls.Add(coordinateBox2);
            panel1.Controls.Add(coordinateBox1);
            panel1.Controls.Add(coordinateText);
            panel1.Controls.Add(distanceBox);
            panel1.Controls.Add(distanceText);
            panel1.Controls.Add(stellarBox);
            panel1.Controls.Add(stellarText);
            panel1.Controls.Add(constellationBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(nameText);
            panel1.Location = new Point(31, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 274);
            panel1.TabIndex = 1;
            // 
            // coordinateXText
            // 
            coordinateXText.AutoSize = true;
            coordinateXText.Location = new Point(161, 149);
            coordinateXText.Name = "coordinateXText";
            coordinateXText.Size = new Size(18, 15);
            coordinateXText.TabIndex = 35;
            coordinateXText.Text = "Д:";
            // 
            // coordinateYText
            // 
            coordinateYText.AutoSize = true;
            coordinateYText.Location = new Point(372, 149);
            coordinateYText.Name = "coordinateYText";
            coordinateYText.Size = new Size(21, 15);
            coordinateYText.TabIndex = 34;
            coordinateYText.Text = "Ш:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(567, 120);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 23;
            label3.Text = "св. р.";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top;
            addButton.Location = new Point(441, 246);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 10;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // minuteNumericUpDown
            // 
            minuteNumericUpDown.Location = new Point(395, 170);
            minuteNumericUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minuteNumericUpDown.Name = "minuteNumericUpDown";
            minuteNumericUpDown.Size = new Size(104, 23);
            minuteNumericUpDown.TabIndex = 9;
            // 
            // hoursNumericUpDown
            // 
            hoursNumericUpDown.Location = new Point(247, 170);
            hoursNumericUpDown.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            hoursNumericUpDown.Name = "hoursNumericUpDown";
            hoursNumericUpDown.Size = new Size(104, 23);
            hoursNumericUpDown.TabIndex = 8;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(522, 246);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 11;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 172);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 21;
            label1.Text = ":";
            // 
            // timeToView
            // 
            timeToView.AutoSize = true;
            timeToView.Location = new Point(23, 178);
            timeToView.Name = "timeToView";
            timeToView.Size = new Size(115, 15);
            timeToView.TabIndex = 22;
            timeToView.Text = "Час спостереження";
            // 
            // coordinateBox2
            // 
            coordinateBox2.Location = new Point(395, 141);
            coordinateBox2.Name = "coordinateBox2";
            coordinateBox2.Size = new Size(166, 23);
            coordinateBox2.TabIndex = 7;
            coordinateBox2.Enter += searchButton_Click_2;
            coordinateBox2.Validating += coordinateBox2_Validating;
            // 
            // coordinateBox1
            // 
            coordinateBox1.Location = new Point(184, 141);
            coordinateBox1.Name = "coordinateBox1";
            coordinateBox1.Size = new Size(166, 23);
            coordinateBox1.TabIndex = 6;
            coordinateBox1.Enter += searchButton_Click_2;
            coordinateBox1.Validating += coordinateBox1_Validating;
            // 
            // coordinateText
            // 
            coordinateText.AutoSize = true;
            coordinateText.Location = new Point(22, 149);
            coordinateText.Name = "coordinateText";
            coordinateText.Size = new Size(73, 15);
            coordinateText.TabIndex = 8;
            coordinateText.Text = "Координати";
            // 
            // distanceBox
            // 
            distanceBox.Location = new Point(161, 112);
            distanceBox.Name = "distanceBox";
            distanceBox.Size = new Size(400, 23);
            distanceBox.TabIndex = 5;
            distanceBox.Enter += searchButton_Click_2;
            // 
            // distanceText
            // 
            distanceText.AutoSize = true;
            distanceText.Location = new Point(22, 120);
            distanceText.Name = "distanceText";
            distanceText.Size = new Size(53, 15);
            distanceText.TabIndex = 6;
            distanceText.Text = "Відстань";
            // 
            // stellarBox
            // 
            stellarBox.Location = new Point(161, 83);
            stellarBox.Name = "stellarBox";
            stellarBox.Size = new Size(400, 23);
            stellarBox.TabIndex = 4;
            stellarBox.Enter += searchButton_Click_2;
            stellarBox.Validating += stellarBox_Validating;
            // 
            // stellarText
            // 
            stellarText.AutoSize = true;
            stellarText.Location = new Point(22, 91);
            stellarText.Name = "stellarText";
            stellarText.Size = new Size(103, 15);
            stellarText.TabIndex = 4;
            stellarText.Text = "Зоряна величина";
            // 
            // constellationBox
            // 
            constellationBox.Location = new Point(161, 54);
            constellationBox.Name = "constellationBox";
            constellationBox.Size = new Size(400, 23);
            constellationBox.TabIndex = 3;
            constellationBox.Enter += searchButton_Click_2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 62);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Сузір'я";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(161, 25);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(400, 23);
            nameBox.TabIndex = 2;
            nameBox.Enter += searchButton_Click_2;
            // 
            // nameText
            // 
            nameText.AutoSize = true;
            nameText.Location = new Point(22, 33);
            nameText.Name = "nameText";
            nameText.Size = new Size(39, 15);
            nameText.TabIndex = 0;
            nameText.Text = "Назва";
            // 
            // resultList
            // 
            resultList.Anchor = AnchorStyles.Top;
            resultList.DataSource = starBindingSource;
            resultList.DisplayMember = "Name";
            resultList.ItemHeight = 15;
            resultList.Location = new Point(31, 303);
            resultList.Name = "resultList";
            resultList.Size = new Size(619, 289);
            resultList.Sorted = true;
            resultList.TabIndex = 12;
            resultList.ValueMember = "StellarMagnitude";
            resultList.DoubleClick += resultBox_DoubleClick;
            // 
            // starBindingSource
            // 
            starBindingSource.DataSource = typeof(Models.Star);
            // 
            // MainForm
            // 
            AcceptButton = searchButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 605);
            Controls.Add(resultList);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MinimumSize = new Size(694, 644);
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minuteNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoursNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private Panel panel1;
        private TextBox distanceBox;
        private Label distanceText;
        private TextBox stellarBox;
        private Label stellarText;
        private TextBox constellationBox;
        private Label label2;
        private TextBox nameBox;
        private Label nameText;
        private TextBox coordinateBox1;
        private Label coordinateText;
        private ListBox resultList;
        private BindingSource starBindingSource;
        private TextBox coordinateBox2;
        private Label timeToView;
        private Label label1;
        private Button searchButton;
        private NumericUpDown minuteNumericUpDown;
        private NumericUpDown hoursNumericUpDown;
        private Button addButton;
        private ToolStripMenuItem createNewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private Label label3;
        private Label coordinateXText;
        private Label coordinateYText;
    }
}