namespace RSA
{
    partial class FormRSA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxfn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonGenP = new System.Windows.Forms.Button();
            this.buttonGenQ = new System.Windows.Forms.Button();
            this.buttonFindE = new System.Windows.Forms.Button();
            this.buttonFindD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.textPublicE = new System.Windows.Forms.TextBox();
            this.textPublicN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textPublicMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textPrivateMessage = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textPrivateN = new System.Windows.Forms.TextBox();
            this.textPrivateD = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.coLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coAscii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coEncrypt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coDecrypt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coDeLetter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxP
            // 
            this.textBoxP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxP.Location = new System.Drawing.Point(278, 20);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 30);
            this.textBoxP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(200, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "p=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(200, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "q=";
            // 
            // textBoxq
            // 
            this.textBoxq.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxq.Location = new System.Drawing.Point(278, 71);
            this.textBoxq.Name = "textBoxq";
            this.textBoxq.Size = new System.Drawing.Size(100, 30);
            this.textBoxq.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(200, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "n=";
            // 
            // textBoxn
            // 
            this.textBoxn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxn.Location = new System.Drawing.Point(278, 126);
            this.textBoxn.Name = "textBoxn";
            this.textBoxn.Size = new System.Drawing.Size(100, 30);
            this.textBoxn.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(173, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "φ(n)=";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxfn
            // 
            this.textBoxfn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxfn.Location = new System.Drawing.Point(278, 182);
            this.textBoxfn.Name = "textBoxfn";
            this.textBoxfn.Size = new System.Drawing.Size(100, 30);
            this.textBoxfn.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(201, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "e=";
            // 
            // textBoxe
            // 
            this.textBoxe.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxe.Location = new System.Drawing.Point(278, 236);
            this.textBoxe.Name = "textBoxe";
            this.textBoxe.Size = new System.Drawing.Size(100, 30);
            this.textBoxe.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(200, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "d=";
            // 
            // textBoxd
            // 
            this.textBoxd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxd.Location = new System.Drawing.Point(278, 296);
            this.textBoxd.Name = "textBoxd";
            this.textBoxd.Size = new System.Drawing.Size(100, 30);
            this.textBoxd.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(417, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = ".GCD(e,φ(n))=1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(417, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "=e^-1mod φ(n)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(417, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "=(p-1)(q-1)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(417, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "=p*q";
            // 
            // buttonGenP
            // 
            this.buttonGenP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenP.Location = new System.Drawing.Point(32, 20);
            this.buttonGenP.Name = "buttonGenP";
            this.buttonGenP.Size = new System.Drawing.Size(104, 36);
            this.buttonGenP.TabIndex = 16;
            this.buttonGenP.Text = "Generate";
            this.buttonGenP.UseVisualStyleBackColor = true;
            this.buttonGenP.Click += new System.EventHandler(this.buttonGenP_Click);
            // 
            // buttonGenQ
            // 
            this.buttonGenQ.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenQ.Location = new System.Drawing.Point(32, 71);
            this.buttonGenQ.Name = "buttonGenQ";
            this.buttonGenQ.Size = new System.Drawing.Size(104, 36);
            this.buttonGenQ.TabIndex = 17;
            this.buttonGenQ.Text = "Generate";
            this.buttonGenQ.UseVisualStyleBackColor = true;
            this.buttonGenQ.Click += new System.EventHandler(this.buttonGenQ_Click);
            // 
            // buttonFindE
            // 
            this.buttonFindE.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindE.Location = new System.Drawing.Point(32, 232);
            this.buttonFindE.Name = "buttonFindE";
            this.buttonFindE.Size = new System.Drawing.Size(104, 36);
            this.buttonFindE.TabIndex = 18;
            this.buttonFindE.Text = "Generate";
            this.buttonFindE.UseVisualStyleBackColor = true;
            this.buttonFindE.Click += new System.EventHandler(this.buttonFindE_Click);
            // 
            // buttonFindD
            // 
            this.buttonFindD.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindD.Location = new System.Drawing.Point(32, 292);
            this.buttonFindD.Name = "buttonFindD";
            this.buttonFindD.Size = new System.Drawing.Size(104, 36);
            this.buttonFindD.TabIndex = 19;
            this.buttonFindD.Text = "Generate";
            this.buttonFindD.UseVisualStyleBackColor = true;
            this.buttonFindD.Click += new System.EventHandler(this.buttonFindD_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textPublicMessage);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textPublicN);
            this.panel1.Controls.Add(this.textPublicE);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(35, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 175);
            this.panel1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(16, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Public key:";
            // 
            // textPublicE
            // 
            this.textPublicE.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPublicE.Location = new System.Drawing.Point(105, 61);
            this.textPublicE.Name = "textPublicE";
            this.textPublicE.Size = new System.Drawing.Size(100, 30);
            this.textPublicE.TabIndex = 21;
            // 
            // textPublicN
            // 
            this.textPublicN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPublicN.Location = new System.Drawing.Point(307, 61);
            this.textPublicN.Name = "textPublicN";
            this.textPublicN.Size = new System.Drawing.Size(100, 30);
            this.textPublicN.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(40, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "{ e=";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(228, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 23);
            this.label13.TabIndex = 23;
            this.label13.Text = ", n =";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(429, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 23);
            this.label14.TabIndex = 24;
            this.label14.Text = "}";
            // 
            // textPublicMessage
            // 
            this.textPublicMessage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPublicMessage.Location = new System.Drawing.Point(44, 110);
            this.textPublicMessage.Name = "textPublicMessage";
            this.textPublicMessage.Size = new System.Drawing.Size(394, 30);
            this.textPublicMessage.TabIndex = 25;
            this.textPublicMessage.Text = "Veni Vidi Vici";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(478, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textPrivateMessage);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.textPrivateN);
            this.panel2.Controls.Add(this.textPrivateD);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(35, 542);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 175);
            this.panel2.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(478, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 36);
            this.button2.TabIndex = 21;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textPrivateMessage
            // 
            this.textPrivateMessage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrivateMessage.Location = new System.Drawing.Point(44, 110);
            this.textPrivateMessage.Name = "textPrivateMessage";
            this.textPrivateMessage.Size = new System.Drawing.Size(394, 30);
            this.textPrivateMessage.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(429, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 23);
            this.label15.TabIndex = 24;
            this.label15.Text = "}";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(228, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 23);
            this.label16.TabIndex = 23;
            this.label16.Text = ", n =";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(40, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 23);
            this.label17.TabIndex = 21;
            this.label17.Text = "{ d=";
            // 
            // textPrivateN
            // 
            this.textPrivateN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrivateN.Location = new System.Drawing.Point(307, 61);
            this.textPrivateN.Name = "textPrivateN";
            this.textPrivateN.Size = new System.Drawing.Size(100, 30);
            this.textPrivateN.TabIndex = 22;
            // 
            // textPrivateD
            // 
            this.textPrivateD.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrivateD.Location = new System.Drawing.Point(105, 61);
            this.textPrivateD.Name = "textPrivateD";
            this.textPrivateD.Size = new System.Drawing.Size(100, 30);
            this.textPrivateD.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(16, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 23);
            this.label18.TabIndex = 21;
            this.label18.Text = "Private key:";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coLetter,
            this.coAscii,
            this.coEncrypt,
            this.coDecrypt,
            this.coDeLetter});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.Location = new System.Drawing.Point(714, 27);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(503, 690);
            this.grid.TabIndex = 27;
            // 
            // coLetter
            // 
            this.coLetter.HeaderText = "Letter";
            this.coLetter.Name = "coLetter";
            this.coLetter.ReadOnly = true;
            // 
            // coAscii
            // 
            this.coAscii.HeaderText = "ASCII";
            this.coAscii.Name = "coAscii";
            this.coAscii.ReadOnly = true;
            // 
            // coEncrypt
            // 
            this.coEncrypt.HeaderText = "Encrypt";
            this.coEncrypt.Name = "coEncrypt";
            this.coEncrypt.ReadOnly = true;
            // 
            // coDecrypt
            // 
            this.coDecrypt.HeaderText = "Decrypt";
            this.coDecrypt.Name = "coDecrypt";
            this.coDecrypt.ReadOnly = true;
            // 
            // coDeLetter
            // 
            this.coDeLetter.HeaderText = "DeLetter";
            this.coDeLetter.Name = "coDeLetter";
            this.coDeLetter.ReadOnly = true;
            // 
            // FormRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 746);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonFindD);
            this.Controls.Add(this.buttonFindE);
            this.Controls.Add(this.buttonGenQ);
            this.Controls.Add(this.buttonGenP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxfn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxP);
            this.Name = "FormRSA";
            this.Text = "RSA Demo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxfn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonGenP;
        private System.Windows.Forms.Button buttonGenQ;
        private System.Windows.Forms.Button buttonFindE;
        private System.Windows.Forms.Button buttonFindD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textPublicMessage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textPublicN;
        private System.Windows.Forms.TextBox textPublicE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textPrivateMessage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textPrivateN;
        private System.Windows.Forms.TextBox textPrivateD;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn coLetter;
        private System.Windows.Forms.DataGridViewTextBoxColumn coAscii;
        private System.Windows.Forms.DataGridViewTextBoxColumn coEncrypt;
        private System.Windows.Forms.DataGridViewTextBoxColumn coDecrypt;
        private System.Windows.Forms.DataGridViewTextBoxColumn coDeLetter;
    }
}

