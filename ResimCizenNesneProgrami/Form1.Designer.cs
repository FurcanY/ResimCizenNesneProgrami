namespace ResimCizenNesneProgrami
{
    partial class Form1
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
            Nesne1 = new Label();
            yukari_btn = new Button();
            asagi_btn = new Button();
            sol_btn = new Button();
            sag_btn = new Button();
            ciz_btn = new Button();
            RenkAyarla_btn = new Button();
            renk_pnl = new Panel();
            label1 = new Label();
            ayarla_btn = new Button();
            ayarla_txtbox = new TextBox();
            panel1 = new Panel();
            gorunmez_btn = new Button();
            label2 = new Label();
            CizimArena_grbbx = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Nesne1
            // 
            Nesne1.BackColor = Color.White;
            Nesne1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Nesne1.Location = new Point(500, 350);
            Nesne1.Name = "Nesne1";
            Nesne1.Size = new Size(25, 25);
            Nesne1.TabIndex = 0;
            Nesne1.Text = "^";
            Nesne1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // yukari_btn
            // 
            yukari_btn.BackColor = Color.Tomato;
            yukari_btn.FlatStyle = FlatStyle.Flat;
            yukari_btn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            yukari_btn.ForeColor = SystemColors.ControlText;
            yukari_btn.Location = new Point(385, 10);
            yukari_btn.Name = "yukari_btn";
            yukari_btn.Size = new Size(70, 70);
            yukari_btn.TabIndex = 1;
            yukari_btn.Text = "↑";
            yukari_btn.UseMnemonic = false;
            yukari_btn.UseVisualStyleBackColor = true;
            yukari_btn.Click += yukari_btn_Click;
            // 
            // asagi_btn
            // 
            asagi_btn.BackColor = Color.Tomato;
            asagi_btn.FlatStyle = FlatStyle.Flat;
            asagi_btn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            asagi_btn.ForeColor = SystemColors.ControlText;
            asagi_btn.Location = new Point(385, 86);
            asagi_btn.Name = "asagi_btn";
            asagi_btn.Size = new Size(70, 70);
            asagi_btn.TabIndex = 1;
            asagi_btn.Text = "↓";
            asagi_btn.UseMnemonic = false;
            asagi_btn.UseVisualStyleBackColor = true;
            asagi_btn.Click += asagi_btn_Click;
            // 
            // sol_btn
            // 
            sol_btn.BackColor = Color.Tomato;
            sol_btn.FlatStyle = FlatStyle.Flat;
            sol_btn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            sol_btn.ForeColor = SystemColors.ControlText;
            sol_btn.Location = new Point(309, 50);
            sol_btn.Name = "sol_btn";
            sol_btn.Size = new Size(70, 70);
            sol_btn.TabIndex = 1;
            sol_btn.Text = "←";
            sol_btn.UseMnemonic = false;
            sol_btn.UseVisualStyleBackColor = true;
            sol_btn.Click += sol_btn_Click;
            // 
            // sag_btn
            // 
            sag_btn.BackColor = Color.Tomato;
            sag_btn.FlatStyle = FlatStyle.Flat;
            sag_btn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            sag_btn.ForeColor = SystemColors.ControlText;
            sag_btn.Location = new Point(461, 50);
            sag_btn.Name = "sag_btn";
            sag_btn.Size = new Size(70, 70);
            sag_btn.TabIndex = 1;
            sag_btn.Text = "→";
            sag_btn.UseMnemonic = false;
            sag_btn.UseVisualStyleBackColor = true;
            sag_btn.Click += sag_btn_Click;
            // 
            // ciz_btn
            // 
            ciz_btn.BackColor = Color.YellowGreen;
            ciz_btn.FlatStyle = FlatStyle.Flat;
            ciz_btn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ciz_btn.ForeColor = SystemColors.ControlText;
            ciz_btn.Location = new Point(574, 50);
            ciz_btn.Name = "ciz_btn";
            ciz_btn.Size = new Size(218, 70);
            ciz_btn.TabIndex = 1;
            ciz_btn.Text = "ÇİZ";
            ciz_btn.UseMnemonic = false;
            ciz_btn.UseVisualStyleBackColor = false;
            ciz_btn.Click += ciz_btn_Click;
            // 
            // RenkAyarla_btn
            // 
            RenkAyarla_btn.BackColor = Color.FloralWhite;
            RenkAyarla_btn.FlatStyle = FlatStyle.Flat;
            RenkAyarla_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RenkAyarla_btn.ForeColor = SystemColors.ControlText;
            RenkAyarla_btn.Location = new Point(12, 5);
            RenkAyarla_btn.Name = "RenkAyarla_btn";
            RenkAyarla_btn.Size = new Size(84, 90);
            RenkAyarla_btn.TabIndex = 1;
            RenkAyarla_btn.Text = "Cizim Rengi Ayarla";
            RenkAyarla_btn.UseMnemonic = false;
            RenkAyarla_btn.UseVisualStyleBackColor = false;
            RenkAyarla_btn.Click += RenkAyarla_btn_Click;
            // 
            // renk_pnl
            // 
            renk_pnl.BackColor = Color.Black;
            renk_pnl.Location = new Point(12, 101);
            renk_pnl.Name = "renk_pnl";
            renk_pnl.Size = new Size(84, 64);
            renk_pnl.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.FloralWhite;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(118, 5);
            label1.Name = "label1";
            label1.Size = new Size(91, 90);
            label1.TabIndex = 3;
            label1.Text = "Bir gidiste kac adim gidilecek ayarlayiniz.";
            // 
            // ayarla_btn
            // 
            ayarla_btn.BackColor = Color.YellowGreen;
            ayarla_btn.FlatStyle = FlatStyle.Flat;
            ayarla_btn.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            ayarla_btn.ForeColor = SystemColors.ControlText;
            ayarla_btn.Location = new Point(118, 135);
            ayarla_btn.Name = "ayarla_btn";
            ayarla_btn.Size = new Size(91, 30);
            ayarla_btn.TabIndex = 1;
            ayarla_btn.Text = "ayarla";
            ayarla_btn.TextAlign = ContentAlignment.TopCenter;
            ayarla_btn.UseMnemonic = false;
            ayarla_btn.UseVisualStyleBackColor = false;
            ayarla_btn.Click += ayarla_btn_Click;
            // 
            // ayarla_txtbox
            // 
            ayarla_txtbox.Location = new Point(118, 106);
            ayarla_txtbox.Name = "ayarla_txtbox";
            ayarla_txtbox.Size = new Size(91, 23);
            ayarla_txtbox.TabIndex = 4;
            ayarla_txtbox.Text = "1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(gorunmez_btn);
            panel1.Controls.Add(ciz_btn);
            panel1.Controls.Add(RenkAyarla_btn);
            panel1.Controls.Add(sag_btn);
            panel1.Controls.Add(ayarla_txtbox);
            panel1.Controls.Add(sol_btn);
            panel1.Controls.Add(ayarla_btn);
            panel1.Controls.Add(asagi_btn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(yukari_btn);
            panel1.Controls.Add(renk_pnl);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 476);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 177);
            panel1.TabIndex = 11;
            // 
            // gorunmez_btn
            // 
            gorunmez_btn.BackColor = Color.YellowGreen;
            gorunmez_btn.FlatStyle = FlatStyle.Flat;
            gorunmez_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gorunmez_btn.ForeColor = SystemColors.ControlText;
            gorunmez_btn.Location = new Point(574, 133);
            gorunmez_btn.Name = "gorunmez_btn";
            gorunmez_btn.Size = new Size(218, 25);
            gorunmez_btn.TabIndex = 1;
            gorunmez_btn.Text = "Nesneyi Gorunmez yap";
            gorunmez_btn.UseMnemonic = false;
            gorunmez_btn.UseVisualStyleBackColor = false;
            gorunmez_btn.Click += gorunmez_btn_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FloralWhite;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(824, 0);
            label2.Name = "label2";
            label2.Size = new Size(176, 177);
            label2.TabIndex = 3;
            label2.Text = "Bilgi !\r\n\r\ncizim beyaz nesne uzerindeki noktaya yapilir.\r\nBeyaz nesne gorunmez olursa ustune gelince silinmez.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CizimArena_grbbx
            // 
            CizimArena_grbbx.BackColor = Color.Transparent;
            CizimArena_grbbx.Dock = DockStyle.Top;
            CizimArena_grbbx.Location = new Point(0, 0);
            CizimArena_grbbx.Name = "CizimArena_grbbx";
            CizimArena_grbbx.Size = new Size(1000, 475);
            CizimArena_grbbx.TabIndex = 0;
            CizimArena_grbbx.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(574, 10);
            button1.Name = "button1";
            button1.Size = new Size(218, 25);
            button1.TabIndex = 1;
            button1.Text = "Cizimi Sil.";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1000, 653);
            Controls.Add(Nesne1);
            Controls.Add(panel1);
            Controls.Add(CizimArena_grbbx);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Resim Cizen Nesne Programi";
            Paint += Form1_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button yukari_btn;
        private Button asagi_btn;
        private Button sol_btn;
        private Button sag_btn;
        private Button ciz_btn;
        private Button RenkAyarla_btn;
        private Panel renk_pnl;
        private Label label1;
        private Button ayarla_btn;
        private TextBox ayarla_txtbox;
        private Panel panel1;
        private Label label2;
        private Label Nesne1;
        private Label CizimArena_grbbx;
        private Button gorunmez_btn;
        private Button button1;
    }
}