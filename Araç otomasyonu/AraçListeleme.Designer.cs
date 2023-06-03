
namespace Araç_otomasyonu
{
    partial class AraçListeleme
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
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.btnGu2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnİp4 = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblMo = new System.Windows.Forms.Label();
            this.lblKu = new System.Windows.Forms.Label();
            this.ctxtMe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPl = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSil2 = new Guna.UI2.WinForms.Guna2Button();
            this.txtMa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEk2 = new Guna.UI2.WinForms.Guna2Button();
            this.txtPA = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.güncell = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.GridColor = System.Drawing.Color.Maroon;
            this.dgv2.Location = new System.Drawing.Point(288, 54);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 26;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(587, 473);
            this.dgv2.TabIndex = 0;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            // 
            // btnGu2
            // 
            this.btnGu2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGu2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGu2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGu2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGu2.FillColor = System.Drawing.Color.Maroon;
            this.btnGu2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGu2.ForeColor = System.Drawing.Color.White;
            this.btnGu2.Location = new System.Drawing.Point(12, 335);
            this.btnGu2.Name = "btnGu2";
            this.btnGu2.Size = new System.Drawing.Size(102, 26);
            this.btnGu2.TabIndex = 64;
            this.btnGu2.Text = "düzenleme";
            this.btnGu2.Click += new System.EventHandler(this.btnGu2_Click);
            // 
            // btnİp4
            // 
            this.btnİp4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnİp4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnİp4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnİp4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnİp4.FillColor = System.Drawing.Color.Maroon;
            this.btnİp4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnİp4.ForeColor = System.Drawing.Color.White;
            this.btnİp4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnİp4.Location = new System.Drawing.Point(161, 335);
            this.btnİp4.Name = "btnİp4";
            this.btnİp4.Size = new System.Drawing.Size(107, 26);
            this.btnİp4.TabIndex = 63;
            this.btnİp4.Text = "İptal";
            this.btnİp4.Click += new System.EventHandler(this.btnİp4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 62;
            this.label9.Text = "PLAKA";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.BackColor = System.Drawing.Color.Transparent;
            this.lblMa.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.ForeColor = System.Drawing.Color.White;
            this.lblMa.Location = new System.Drawing.Point(18, 120);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(65, 17);
            this.lblMa.TabIndex = 61;
            this.lblMa.Text = "MARKA";
            // 
            // lblMo
            // 
            this.lblMo.AutoSize = true;
            this.lblMo.BackColor = System.Drawing.Color.Transparent;
            this.lblMo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMo.ForeColor = System.Drawing.Color.White;
            this.lblMo.Location = new System.Drawing.Point(12, 175);
            this.lblMo.Name = "lblMo";
            this.lblMo.Size = new System.Drawing.Size(96, 17);
            this.lblMo.TabIndex = 59;
            this.lblMo.Text = "MODEL(yıl)";
            // 
            // lblKu
            // 
            this.lblKu.AutoSize = true;
            this.lblKu.BackColor = System.Drawing.Color.Transparent;
            this.lblKu.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKu.ForeColor = System.Drawing.Color.White;
            this.lblKu.Location = new System.Drawing.Point(2, 230);
            this.lblKu.Name = "lblKu";
            this.lblKu.Size = new System.Drawing.Size(115, 17);
            this.lblKu.TabIndex = 55;
            this.lblKu.Text = "KİRA ÜCRETİ";
            // 
            // ctxtMe
            // 
            this.ctxtMe.AutoRoundedCorners = true;
            this.ctxtMe.BackColor = System.Drawing.Color.Transparent;
            this.ctxtMe.BorderRadius = 17;
            this.ctxtMe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ctxtMe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxtMe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ctxtMe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ctxtMe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctxtMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ctxtMe.ItemHeight = 30;
            this.ctxtMe.Items.AddRange(new object[] {
            "Evet",
            "hayir"});
            this.ctxtMe.Location = new System.Drawing.Point(120, 265);
            this.ctxtMe.Name = "ctxtMe";
            this.ctxtMe.Size = new System.Drawing.Size(148, 36);
            this.ctxtMe.TabIndex = 54;
            // 
            // txtMo
            // 
            this.txtMo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMo.DefaultText = "";
            this.txtMo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMo.ForeColor = System.Drawing.Color.Black;
            this.txtMo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMo.Location = new System.Drawing.Point(120, 175);
            this.txtMo.Name = "txtMo";
            this.txtMo.PasswordChar = '\0';
            this.txtMo.PlaceholderText = "";
            this.txtMo.SelectedText = "";
            this.txtMo.Size = new System.Drawing.Size(148, 23);
            this.txtMo.TabIndex = 51;
            // 
            // txtPl
            // 
            this.txtPl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPl.DefaultText = "";
            this.txtPl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPl.ForeColor = System.Drawing.Color.Black;
            this.txtPl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPl.Location = new System.Drawing.Point(120, 65);
            this.txtPl.Name = "txtPl";
            this.txtPl.PasswordChar = '\0';
            this.txtPl.PlaceholderText = "";
            this.txtPl.SelectedText = "";
            this.txtPl.Size = new System.Drawing.Size(148, 30);
            this.txtPl.TabIndex = 47;
            // 
            // btnSil2
            // 
            this.btnSil2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSil2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSil2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSil2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSil2.FillColor = System.Drawing.Color.Maroon;
            this.btnSil2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil2.ForeColor = System.Drawing.Color.White;
            this.btnSil2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSil2.Location = new System.Drawing.Point(188, 501);
            this.btnSil2.Name = "btnSil2";
            this.btnSil2.Size = new System.Drawing.Size(68, 26);
            this.btnSil2.TabIndex = 67;
            this.btnSil2.Text = "Sil";
            this.btnSil2.Click += new System.EventHandler(this.btnSil2_Click);
            // 
            // txtMa
            // 
            this.txtMa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa.DefaultText = "";
            this.txtMa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMa.ForeColor = System.Drawing.Color.Black;
            this.txtMa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMa.Location = new System.Drawing.Point(120, 120);
            this.txtMa.Name = "txtMa";
            this.txtMa.PasswordChar = '\0';
            this.txtMa.PlaceholderText = "";
            this.txtMa.SelectedText = "";
            this.txtMa.Size = new System.Drawing.Size(148, 27);
            this.txtMa.TabIndex = 69;
            // 
            // txtKi
            // 
            this.txtKi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKi.DefaultText = "";
            this.txtKi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKi.ForeColor = System.Drawing.Color.Black;
            this.txtKi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKi.Location = new System.Drawing.Point(120, 226);
            this.txtKi.Name = "txtKi";
            this.txtKi.PasswordChar = '\0';
            this.txtKi.PlaceholderText = "";
            this.txtKi.SelectedText = "";
            this.txtKi.Size = new System.Drawing.Size(148, 23);
            this.txtKi.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "Mevcut";
            // 
            // btnEk2
            // 
            this.btnEk2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEk2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEk2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEk2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEk2.FillColor = System.Drawing.Color.Maroon;
            this.btnEk2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEk2.ForeColor = System.Drawing.Color.White;
            this.btnEk2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEk2.Location = new System.Drawing.Point(82, 367);
            this.btnEk2.Name = "btnEk2";
            this.btnEk2.Size = new System.Drawing.Size(107, 26);
            this.btnEk2.TabIndex = 72;
            this.btnEk2.Text = "Ekle";
            this.btnEk2.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtPA
            // 
            this.txtPA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPA.DefaultText = "";
            this.txtPA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPA.ForeColor = System.Drawing.Color.Black;
            this.txtPA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPA.Location = new System.Drawing.Point(108, 452);
            this.txtPA.Name = "txtPA";
            this.txtPA.PasswordChar = '\0';
            this.txtPA.PlaceholderText = "";
            this.txtPA.SelectedText = "";
            this.txtPA.Size = new System.Drawing.Size(148, 30);
            this.txtPA.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "Plaka Ara";
            // 
            // güncell
            // 
            this.güncell.AutoRoundedCorners = true;
            this.güncell.BackColor = System.Drawing.Color.Transparent;
            this.güncell.BorderRadius = 17;
            this.güncell.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.güncell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.güncell.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.güncell.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.güncell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.güncell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.güncell.ItemHeight = 30;
            this.güncell.Items.AddRange(new object[] {
            "mevcut",
            "kiralandı"});
            this.güncell.Location = new System.Drawing.Point(626, 2);
            this.güncell.Name = "güncell";
            this.güncell.Size = new System.Drawing.Size(148, 36);
            this.güncell.TabIndex = 75;
            this.güncell.SelectionChangeCommitted += new System.EventHandler(this.güncell_SelectionChangeCommitted);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Maroon;
            this.guna2Button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(780, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(102, 26);
            this.guna2Button1.TabIndex = 76;
            this.guna2Button1.Text = "güncelle";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // AraçListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.güncell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPA);
            this.Controls.Add(this.btnEk2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKi);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.btnSil2);
            this.Controls.Add(this.btnGu2);
            this.Controls.Add(this.btnİp4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblMo);
            this.Controls.Add(this.lblKu);
            this.Controls.Add(this.ctxtMe);
            this.Controls.Add(this.txtMo);
            this.Controls.Add(this.txtPl);
            this.Controls.Add(this.dgv2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AraçListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AraçListeleme";
            this.Load += new System.EventHandler(this.AraçListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv2;
        private Guna.UI2.WinForms.Guna2Button btnGu2;
        private Guna.UI2.WinForms.Guna2Button btnİp4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblMo;
        private System.Windows.Forms.Label lblKu;
        private Guna.UI2.WinForms.Guna2ComboBox ctxtMe;
        private Guna.UI2.WinForms.Guna2TextBox txtMo;
        private Guna.UI2.WinForms.Guna2TextBox txtPl;
        private Guna.UI2.WinForms.Guna2Button btnSil2;
        private Guna.UI2.WinForms.Guna2TextBox txtMa;
        private Guna.UI2.WinForms.Guna2TextBox txtKi;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnEk2;
        private Guna.UI2.WinForms.Guna2TextBox txtPA;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox güncell;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}