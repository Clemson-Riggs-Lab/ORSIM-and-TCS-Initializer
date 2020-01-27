using System.Windows.Forms;

namespace ORSIMandTCSInitializer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fileBrowseButton = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.simBrowseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ORSIMStartImmediatelyCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tCSimBrowseButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SyncWithORSIMRadioButton = new System.Windows.Forms.RadioButton();
            this.TCSSetStartTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.TCSStartImmediatelyRadioButton = new System.Windows.Forms.RadioButton();
            this.TimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tCSstartButton = new System.Windows.Forms.Button();
            this.TCSTimedCheckBox = new System.Windows.Forms.CheckBox();
            this.tCSFileBrowseButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.StartBothButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileBrowseButton
            // 
            this.fileBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileBrowseButton.Location = new System.Drawing.Point(31, 87);
            this.fileBrowseButton.Margin = new System.Windows.Forms.Padding(4);
            this.fileBrowseButton.Name = "fileBrowseButton";
            this.fileBrowseButton.Size = new System.Drawing.Size(224, 28);
            this.fileBrowseButton.TabIndex = 0;
            this.fileBrowseButton.Text = "2. Browse to select input file";
            this.toolTip1.SetToolTip(this.fileBrowseButton, "Press this and browse for the input file.\r\nMake sure that you are selecting an OR" +
        "SIM input file\r\nFile format should be (.txt)\r\n");
            this.fileBrowseButton.UseVisualStyleBackColor = true;
            this.fileBrowseButton.Click += new System.EventHandler(this.FileBrowseButton_Click);
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(141, 31);
            this.timePicker.Margin = new System.Windows.Forms.Padding(4);
            this.timePicker.MinDate = new System.DateTime(2019, 3, 21, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(112, 22);
            this.timePicker.TabIndex = 1;
            this.timePicker.ValueChanged += new System.EventHandler(this.timePicker_ValueChanged);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LimeGreen;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Location = new System.Drawing.Point(31, 159);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(224, 28);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "4. Start ORSIM";
            this.toolTip1.SetToolTip(this.startButton, "Make sure:\r\n1- you have set up the start time\r\n2- you have selected the correct i" +
        "nput file\r\n3- you have selected the correct simulation file\r\n\r\nThen Press this b" +
        "utton to start the simulation\r\n");
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. Set Start Time";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(827, 399);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(0, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.ShowCellErrors = false;
            this.dataGridView2.ShowCellToolTips = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.ShowRowErrors = false;
            this.dataGridView2.Size = new System.Drawing.Size(827, 64);
            this.dataGridView2.TabIndex = 4;
            // 
            // simBrowseButton
            // 
            this.simBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.simBrowseButton.Location = new System.Drawing.Point(31, 123);
            this.simBrowseButton.Margin = new System.Windows.Forms.Padding(4);
            this.simBrowseButton.Name = "simBrowseButton";
            this.simBrowseButton.Size = new System.Drawing.Size(224, 28);
            this.simBrowseButton.TabIndex = 6;
            this.simBrowseButton.Text = "3. Browse to select simulation";
            this.toolTip1.SetToolTip(this.simBrowseButton, resources.GetString("simBrowseButton.ToolTip"));
            this.simBrowseButton.UseVisualStyleBackColor = true;
            this.simBrowseButton.Click += new System.EventHandler(this.simBrowseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(833, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "ORSIM and Tactile Cues Initializer Program";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 640);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "ORSIM Input file path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 657);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "ORSIM Simulation path:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 641);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "No File Selected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 657);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "No File Selected";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(24, 711);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Notes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 711);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(700, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "The program will automatically load the simulations if they are on the Desktop an" +
    "d named ORSIM.exe/TCS.exe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 727);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(743, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "The program will automatically load the input files if they are on the Desktop an" +
    "d named InputORSIM.txt/InputTCS.csv";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 743);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(546, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Input and Simulation files can always be changed using the browse buttons on the " +
    "left";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(377, 87);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 506);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(832, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ORSIM";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(832, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tactile Cues";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView3.Location = new System.Drawing.Point(8, 7);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView3.RowTemplate.ReadOnly = true;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView3.ShowCellErrors = false;
            this.dataGridView3.ShowCellToolTips = false;
            this.dataGridView3.ShowEditingIcon = false;
            this.dataGridView3.ShowRowErrors = false;
            this.dataGridView3.Size = new System.Drawing.Size(813, 464);
            this.dataGridView3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ORSIMStartImmediatelyCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.timePicker);
            this.groupBox1.Controls.Add(this.fileBrowseButton);
            this.groupBox1.Controls.Add(this.simBrowseButton);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Location = new System.Drawing.Point(28, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(341, 220);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ORSIM Control";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 60);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "or";
            // 
            // ORSIMStartImmediatelyCheckBox
            // 
            this.ORSIMStartImmediatelyCheckBox.AutoSize = true;
            this.ORSIMStartImmediatelyCheckBox.Location = new System.Drawing.Point(84, 60);
            this.ORSIMStartImmediatelyCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ORSIMStartImmediatelyCheckBox.Name = "ORSIMStartImmediatelyCheckBox";
            this.ORSIMStartImmediatelyCheckBox.Size = new System.Drawing.Size(138, 21);
            this.ORSIMStartImmediatelyCheckBox.TabIndex = 7;
            this.ORSIMStartImmediatelyCheckBox.Text = "Start immediately";
            this.ORSIMStartImmediatelyCheckBox.UseVisualStyleBackColor = true;
            this.ORSIMStartImmediatelyCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tCSimBrowseButton);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.tCSstartButton);
            this.groupBox2.Controls.Add(this.TCSTimedCheckBox);
            this.groupBox2.Controls.Add(this.tCSFileBrowseButton);
            this.groupBox2.Location = new System.Drawing.Point(28, 315);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(341, 273);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tactile Cue\'s Sim Control";
            // 
            // tCSimBrowseButton
            // 
            this.tCSimBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tCSimBrowseButton.Location = new System.Drawing.Point(31, 188);
            this.tCSimBrowseButton.Margin = new System.Windows.Forms.Padding(4);
            this.tCSimBrowseButton.Name = "tCSimBrowseButton";
            this.tCSimBrowseButton.Size = new System.Drawing.Size(224, 28);
            this.tCSimBrowseButton.TabIndex = 9;
            this.tCSimBrowseButton.Text = "3. Browse to select simulation";
            this.toolTip1.SetToolTip(this.tCSimBrowseButton, resources.GetString("tCSimBrowseButton.ToolTip"));
            this.tCSimBrowseButton.UseVisualStyleBackColor = true;
            this.tCSimBrowseButton.Click += new System.EventHandler(this.tCSimBrowseButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SyncWithORSIMRadioButton);
            this.groupBox3.Controls.Add(this.TCSSetStartTimeRadioButton);
            this.groupBox3.Controls.Add(this.TCSStartImmediatelyRadioButton);
            this.groupBox3.Controls.Add(this.TimePicker1);
            this.groupBox3.Location = new System.Drawing.Point(56, 42);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(284, 103);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // SyncWithORSIMRadioButton
            // 
            this.SyncWithORSIMRadioButton.AutoSize = true;
            this.SyncWithORSIMRadioButton.Checked = true;
            this.SyncWithORSIMRadioButton.Location = new System.Drawing.Point(19, 12);
            this.SyncWithORSIMRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.SyncWithORSIMRadioButton.Name = "SyncWithORSIMRadioButton";
            this.SyncWithORSIMRadioButton.Size = new System.Drawing.Size(136, 21);
            this.SyncWithORSIMRadioButton.TabIndex = 13;
            this.SyncWithORSIMRadioButton.TabStop = true;
            this.SyncWithORSIMRadioButton.Text = "Sync with ORSIM";
            this.toolTip1.SetToolTip(this.SyncWithORSIMRadioButton, "This will sync the timing with that of the ORSIM.\r\ncues will be presented based o" +
        "n the ORSIM start time.\r\nselect this if you want to run both simulations simulta" +
        "neously");
            this.SyncWithORSIMRadioButton.UseVisualStyleBackColor = true;
            // 
            // TCSSetStartTimeRadioButton
            // 
            this.TCSSetStartTimeRadioButton.AutoSize = true;
            this.TCSSetStartTimeRadioButton.Location = new System.Drawing.Point(19, 69);
            this.TCSSetStartTimeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.TCSSetStartTimeRadioButton.Name = "TCSSetStartTimeRadioButton";
            this.TCSSetStartTimeRadioButton.Size = new System.Drawing.Size(119, 21);
            this.TCSSetStartTimeRadioButton.TabIndex = 15;
            this.TCSSetStartTimeRadioButton.Text = "Set Start Time";
            this.toolTip1.SetToolTip(this.TCSSetStartTimeRadioButton, "Select this button to select the start time of the simulation\r\nNote that this is " +
        "not the time the first cue is presented, but an offset to it\r\n");
            this.TCSSetStartTimeRadioButton.UseVisualStyleBackColor = true;
            this.TCSSetStartTimeRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // TCSStartImmediatelyRadioButton
            // 
            this.TCSStartImmediatelyRadioButton.AutoSize = true;
            this.TCSStartImmediatelyRadioButton.Location = new System.Drawing.Point(19, 41);
            this.TCSStartImmediatelyRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.TCSStartImmediatelyRadioButton.Name = "TCSStartImmediatelyRadioButton";
            this.TCSStartImmediatelyRadioButton.Size = new System.Drawing.Size(137, 21);
            this.TCSStartImmediatelyRadioButton.TabIndex = 14;
            this.TCSStartImmediatelyRadioButton.Text = "Start immediately";
            this.toolTip1.SetToolTip(this.TCSStartImmediatelyRadioButton, "Selecting this option causes the cues to be presented immediately after starting " +
        "the simulation\r\nMeaning that no time offset will take place\r\n");
            this.TCSStartImmediatelyRadioButton.UseVisualStyleBackColor = true;
            // 
            // TimePicker1
            // 
            this.TimePicker1.Enabled = false;
            this.TimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker1.Location = new System.Drawing.Point(149, 69);
            this.TimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.TimePicker1.MinDate = new System.DateTime(2019, 3, 21, 0, 0, 0, 0);
            this.TimePicker1.Name = "TimePicker1";
            this.TimePicker1.ShowUpDown = true;
            this.TimePicker1.Size = new System.Drawing.Size(112, 22);
            this.TimePicker1.TabIndex = 7;
            this.TimePicker1.ValueChanged += new System.EventHandler(this.TimePicker1_ValueChanged);
            // 
            // tCSstartButton
            // 
            this.tCSstartButton.BackColor = System.Drawing.Color.LimeGreen;
            this.tCSstartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tCSstartButton.Location = new System.Drawing.Point(31, 225);
            this.tCSstartButton.Margin = new System.Windows.Forms.Padding(4);
            this.tCSstartButton.Name = "tCSstartButton";
            this.tCSstartButton.Size = new System.Drawing.Size(224, 28);
            this.tCSstartButton.TabIndex = 7;
            this.tCSstartButton.Text = "3. Start Tactile Cue\'s Sim";
            this.toolTip1.SetToolTip(this.tCSstartButton, "Make sure:\r\n1- you have set up the start time\r\n2- you have selected the correct i" +
        "nput file\r\n3- you have selected the correct simulation file\r\n\r\nThen Press this b" +
        "utton to start the simulation\r\n\r\n");
            this.tCSstartButton.UseVisualStyleBackColor = false;
            this.tCSstartButton.Click += new System.EventHandler(this.tCSstartButton_Click);
            // 
            // TCSTimedCheckBox
            // 
            this.TCSTimedCheckBox.AutoSize = true;
            this.TCSTimedCheckBox.Checked = true;
            this.TCSTimedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TCSTimedCheckBox.Location = new System.Drawing.Point(31, 26);
            this.TCSTimedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.TCSTimedCheckBox.Name = "TCSTimedCheckBox";
            this.TCSTimedCheckBox.Size = new System.Drawing.Size(129, 21);
            this.TCSTimedCheckBox.TabIndex = 9;
            this.TCSTimedCheckBox.Text = "1. Sim is timed?";
            this.toolTip1.SetToolTip(this.TCSTimedCheckBox, "check this box if you want the cues to be presented automatically\r\nif unchecked, " +
        "you\'ll have to manually present the cues\r\nwhen checked, the cues will be present" +
        "ed based on the criteria below\r\n");
            this.TCSTimedCheckBox.UseVisualStyleBackColor = true;
            this.TCSTimedCheckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // tCSFileBrowseButton
            // 
            this.tCSFileBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tCSFileBrowseButton.Location = new System.Drawing.Point(31, 153);
            this.tCSFileBrowseButton.Margin = new System.Windows.Forms.Padding(4);
            this.tCSFileBrowseButton.Name = "tCSFileBrowseButton";
            this.tCSFileBrowseButton.Size = new System.Drawing.Size(224, 28);
            this.tCSFileBrowseButton.TabIndex = 7;
            this.tCSFileBrowseButton.Text = "2. Browse to select input file";
            this.toolTip1.SetToolTip(this.tCSFileBrowseButton, "Press this and browse for the input file.\r\nMake sure that you are selecting a Tac" +
        "tile cues input file\r\nFile format should be CSV");
            this.tCSFileBrowseButton.UseVisualStyleBackColor = true;
            this.tCSFileBrowseButton.Click += new System.EventHandler(this.tCSFileBrowseButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 673);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "No File Selected";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(252, 690);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "No File Selected";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 690);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(220, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Tactile Cues Simulation path:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 673);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(208, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "Tactile Cues Input file path:";
            // 
            // StartBothButton
            // 
            this.StartBothButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StartBothButton.Enabled = false;
            this.StartBothButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartBothButton.Location = new System.Drawing.Point(59, 596);
            this.StartBothButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartBothButton.Name = "StartBothButton";
            this.StartBothButton.Size = new System.Drawing.Size(224, 28);
            this.StartBothButton.TabIndex = 17;
            this.StartBothButton.Text = "Start Both Simulations";
            this.toolTip1.SetToolTip(this.StartBothButton, "Make sure:\r\n1- you have set up the start time\r\n2- you have selected the correct i" +
        "nput file\r\n3- you have selected the correct simulation file\r\n\r\nThen Press this b" +
        "utton to start the simulation\r\n\r\n");
            this.StartBothButton.UseVisualStyleBackColor = false;
            this.StartBothButton.Click += new System.EventHandler(this.StartBothButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ORSIMandTCSInitializer.Properties.Resources.FullRiggsLab_AllClemson;
            this.pictureBox1.Location = new System.Drawing.Point(868, 711);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(92, 764);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(407, 17);
            this.label16.TabIndex = 24;
            this.label16.Text = "You can press the \"Start Both Simulations\" to start both at once\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1231, 788);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.StartBothButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ORSIM and TCS Initializer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileBrowseButton;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DateTimePicker TimePicker1;
        private Button startButton;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button simBrowseButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox TCSTimedCheckBox;
        private Button tCSFileBrowseButton;
        
        private Button tCSstartButton;
        private Label label11;
        private CheckBox ORSIMStartImmediatelyCheckBox;
        private GroupBox groupBox3;
        private RadioButton SyncWithORSIMRadioButton;
        private RadioButton TCSSetStartTimeRadioButton;
        private RadioButton TCSStartImmediatelyRadioButton;
        private Button tCSimBrowseButton;
        private DataGridView dataGridView3;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private ToolTip toolTip1;
        private Button StartBothButton;
        private Label label16;
    }
}

