namespace Calculator
{
    partial class calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.textPanel = new System.Windows.Forms.Panel();
            this.secondaryTextbox = new System.Windows.Forms.TextBox();
            this.primaryTextbox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.calculatorTitle = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.modulusBtn = new System.Windows.Forms.Button();
            this.inverseBtn = new System.Windows.Forms.Button();
            this.ceBtn = new System.Windows.Forms.Button();
            this.cBtn = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SQRTBtn = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.signBtn = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.textPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPanel
            // 
            this.textPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.textPanel.Controls.Add(this.secondaryTextbox);
            this.textPanel.Controls.Add(this.primaryTextbox);
            this.textPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.textPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.textPanel.Location = new System.Drawing.Point(0, 30);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(400, 155);
            this.textPanel.TabIndex = 1;
            // 
            // secondaryTextbox
            // 
            this.secondaryTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.secondaryTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondaryTextbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.secondaryTextbox.Enabled = false;
            this.secondaryTextbox.Font = new System.Drawing.Font("Nirmala UI", 18F);
            this.secondaryTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.secondaryTextbox.Location = new System.Drawing.Point(0, 0);
            this.secondaryTextbox.MaxLength = 100;
            this.secondaryTextbox.Multiline = true;
            this.secondaryTextbox.Name = "secondaryTextbox";
            this.secondaryTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.secondaryTextbox.Size = new System.Drawing.Size(400, 40);
            this.secondaryTextbox.TabIndex = 1;
            this.secondaryTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // primaryTextbox
            // 
            this.primaryTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.primaryTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.primaryTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.primaryTextbox.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold);
            this.primaryTextbox.ForeColor = System.Drawing.Color.White;
            this.primaryTextbox.Location = new System.Drawing.Point(0, 46);
            this.primaryTextbox.MaxLength = 10;
            this.primaryTextbox.Multiline = true;
            this.primaryTextbox.Name = "primaryTextbox";
            this.primaryTextbox.ReadOnly = true;
            this.primaryTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.primaryTextbox.Size = new System.Drawing.Size(400, 109);
            this.primaryTextbox.TabIndex = 0;
            this.primaryTextbox.Text = "0";
            this.primaryTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.exitBtn.Location = new System.Drawing.Point(345, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(55, 30);
            this.exitBtn.TabIndex = 22;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // calculatorTitle
            // 
            this.calculatorTitle.AutoSize = true;
            this.calculatorTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.calculatorTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.calculatorTitle.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.calculatorTitle.Location = new System.Drawing.Point(0, 0);
            this.calculatorTitle.Name = "calculatorTitle";
            this.calculatorTitle.Padding = new System.Windows.Forms.Padding(4);
            this.calculatorTitle.Size = new System.Drawing.Size(179, 53);
            this.calculatorTitle.TabIndex = 10;
            this.calculatorTitle.Text = "Calculator";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.titlePanel.Controls.Add(this.calculatorTitle);
            this.titlePanel.Controls.Add(this.exitBtn);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(400, 30);
            this.titlePanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.modulusBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inverseBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ceBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SQRTBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.mulBtn, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.subBtn, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.addBtn, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.signBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Btn0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dotBtn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.equalBtn, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.divideBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.backBtn, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 185);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 315);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // modulusBtn
            // 
            this.modulusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modulusBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.modulusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modulusBtn.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulusBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.modulusBtn.Location = new System.Drawing.Point(0, 0);
            this.modulusBtn.Margin = new System.Windows.Forms.Padding(0);
            this.modulusBtn.Name = "modulusBtn";
            this.modulusBtn.Size = new System.Drawing.Size(100, 52);
            this.modulusBtn.TabIndex = 0;
            this.modulusBtn.Text = "%";
            this.modulusBtn.UseVisualStyleBackColor = true;
            // 
            // inverseBtn
            // 
            this.inverseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inverseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.inverseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inverseBtn.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.inverseBtn.Location = new System.Drawing.Point(0, 52);
            this.inverseBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inverseBtn.Name = "inverseBtn";
            this.inverseBtn.Size = new System.Drawing.Size(100, 52);
            this.inverseBtn.TabIndex = 1;
            this.inverseBtn.Text = "1/x";
            this.inverseBtn.UseVisualStyleBackColor = true;
            this.inverseBtn.Click += new System.EventHandler(this.inverseBtn_Click);
            // 
            // ceBtn
            // 
            this.ceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ceBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ceBtn.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.ceBtn.Location = new System.Drawing.Point(100, 0);
            this.ceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ceBtn.Name = "ceBtn";
            this.ceBtn.Size = new System.Drawing.Size(100, 52);
            this.ceBtn.TabIndex = 2;
            this.ceBtn.Text = "CE";
            this.ceBtn.UseVisualStyleBackColor = true;
            this.ceBtn.Click += new System.EventHandler(this.ceBtn_Click);
            // 
            // cBtn
            // 
            this.cBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.cBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtn.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.cBtn.Location = new System.Drawing.Point(200, 0);
            this.cBtn.Margin = new System.Windows.Forms.Padding(0);
            this.cBtn.Name = "cBtn";
            this.cBtn.Size = new System.Drawing.Size(100, 52);
            this.cBtn.TabIndex = 3;
            this.cBtn.Text = "C";
            this.cBtn.UseVisualStyleBackColor = true;
            this.cBtn.Click += new System.EventHandler(this.cBtn_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.button7.Location = new System.Drawing.Point(100, 52);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 52);
            this.button7.TabIndex = 5;
            this.button7.Text = "SQR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // SQRTBtn
            // 
            this.SQRTBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SQRTBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.SQRTBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SQRTBtn.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQRTBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.SQRTBtn.Location = new System.Drawing.Point(200, 52);
            this.SQRTBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SQRTBtn.Name = "SQRTBtn";
            this.SQRTBtn.Size = new System.Drawing.Size(100, 52);
            this.SQRTBtn.TabIndex = 6;
            this.SQRTBtn.Text = "SQRT";
            this.SQRTBtn.UseVisualStyleBackColor = true;
            this.SQRTBtn.Click += new System.EventHandler(this.SQRTBtn_Click);
            // 
            // Btn7
            // 
            this.Btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.Btn7.Location = new System.Drawing.Point(0, 104);
            this.Btn7.Margin = new System.Windows.Forms.Padding(0);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(100, 52);
            this.Btn7.TabIndex = 8;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.num_handler);
            // 
            // Btn8
            // 
            this.Btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.Btn8.Location = new System.Drawing.Point(100, 104);
            this.Btn8.Margin = new System.Windows.Forms.Padding(0);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(100, 52);
            this.Btn8.TabIndex = 9;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.num_handler);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.btn9.Location = new System.Drawing.Point(200, 104);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(100, 52);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.num_handler);
            // 
            // mulBtn
            // 
            this.mulBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mulBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.mulBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mulBtn.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.mulBtn.Location = new System.Drawing.Point(300, 104);
            this.mulBtn.Margin = new System.Windows.Forms.Padding(0);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(100, 52);
            this.mulBtn.TabIndex = 11;
            this.mulBtn.Text = "x";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.basic_operation_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.btn4.Location = new System.Drawing.Point(0, 156);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 52);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.num_handler);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.btn5.Location = new System.Drawing.Point(100, 156);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 52);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.num_handler);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.btn6.Location = new System.Drawing.Point(200, 156);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(100, 52);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.num_handler);
            // 
            // subBtn
            // 
            this.subBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.subBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBtn.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.subBtn.Location = new System.Drawing.Point(300, 156);
            this.subBtn.Margin = new System.Windows.Forms.Padding(0);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(100, 52);
            this.subBtn.TabIndex = 15;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.basic_operation_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.btn1.Location = new System.Drawing.Point(0, 208);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 52);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.num_handler);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.btn2.Location = new System.Drawing.Point(100, 208);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 52);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.num_handler);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.btn3.Location = new System.Drawing.Point(200, 208);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 52);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.num_handler);
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.addBtn.Location = new System.Drawing.Point(300, 208);
            this.addBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 52);
            this.addBtn.TabIndex = 19;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.basic_operation_Click);
            // 
            // signBtn
            // 
            this.signBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.signBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signBtn.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.signBtn.Location = new System.Drawing.Point(0, 260);
            this.signBtn.Margin = new System.Windows.Forms.Padding(0);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(100, 55);
            this.signBtn.TabIndex = 20;
            this.signBtn.Text = "+/-";
            this.signBtn.UseVisualStyleBackColor = true;
            this.signBtn.Click += new System.EventHandler(this.signBtn_Click);
            // 
            // Btn0
            // 
            this.Btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.Btn0.Location = new System.Drawing.Point(100, 260);
            this.Btn0.Margin = new System.Windows.Forms.Padding(0);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(100, 55);
            this.Btn0.TabIndex = 21;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.num_handler);
            // 
            // dotBtn
            // 
            this.dotBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotBtn.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.dotBtn.Location = new System.Drawing.Point(200, 260);
            this.dotBtn.Margin = new System.Windows.Forms.Padding(0);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(100, 55);
            this.dotBtn.TabIndex = 22;
            this.dotBtn.Text = ".";
            this.dotBtn.UseVisualStyleBackColor = true;
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.equalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalBtn.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.equalBtn.Location = new System.Drawing.Point(300, 260);
            this.equalBtn.Margin = new System.Windows.Forms.Padding(0);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(100, 55);
            this.equalBtn.TabIndex = 23;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.divideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divideBtn.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.divideBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.divideBtn.Location = new System.Drawing.Point(300, 52);
            this.divideBtn.Margin = new System.Windows.Forms.Padding(0);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(100, 52);
            this.divideBtn.TabIndex = 25;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.basic_operation_Click);
            // 
            // backBtn
            // 
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.backBtn.Location = new System.Drawing.Point(300, 0);
            this.backBtn.Margin = new System.Windows.Forms.Padding(0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 52);
            this.backBtn.TabIndex = 26;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textPanel);
            this.Controls.Add(this.titlePanel);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.Name = "calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.calculator_Load);
            this.textPanel.ResumeLayout(false);
            this.textPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel textPanel;
        private System.Windows.Forms.TextBox secondaryTextbox;
        private System.Windows.Forms.TextBox primaryTextbox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label calculatorTitle;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button modulusBtn;
        private System.Windows.Forms.Button inverseBtn;
        private System.Windows.Forms.Button ceBtn;
        private System.Windows.Forms.Button cBtn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button SQRTBtn;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button signBtn;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button backBtn;
    }
}

