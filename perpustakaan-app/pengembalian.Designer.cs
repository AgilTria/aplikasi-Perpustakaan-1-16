﻿namespace perpustakaan_app
{
    partial class pengembalian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.label_page = new System.Windows.Forms.Label();
            this.txt_page = new System.Windows.Forms.TextBox();
            this.cmb_length = new System.Windows.Forms.ComboBox();
            this.cmb_kategori_cari = new System.Windows.Forms.ComboBox();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.dgv_data_kembali = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_next_page = new System.Windows.Forms.Button();
            this.btn_prev_page = new System.Windows.Forms.Button();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_kembali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(21, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 1);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Pengembalian";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.BackColor = System.Drawing.Color.DodgerBlue;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.Location = new System.Drawing.Point(9, 506);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(10, 16);
            this.label_info.TabIndex = 34;
            this.label_info.Text = " ";
            // 
            // label_page
            // 
            this.label_page.AutoSize = true;
            this.label_page.BackColor = System.Drawing.Color.DodgerBlue;
            this.label_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_page.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_page.Location = new System.Drawing.Point(689, 505);
            this.label_page.Name = "label_page";
            this.label_page.Size = new System.Drawing.Size(24, 18);
            this.label_page.TabIndex = 49;
            this.label_page.Text = "/ 1";
            // 
            // txt_page
            // 
            this.txt_page.BackColor = System.Drawing.Color.DodgerBlue;
            this.txt_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_page.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_page.Location = new System.Drawing.Point(645, 502);
            this.txt_page.Name = "txt_page";
            this.txt_page.Size = new System.Drawing.Size(42, 26);
            this.txt_page.TabIndex = 48;
            this.txt_page.Text = "1";
            this.txt_page.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_page_KeyPress);
            // 
            // cmb_length
            // 
            this.cmb_length.FormattingEnabled = true;
            this.cmb_length.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50"});
            this.cmb_length.Location = new System.Drawing.Point(105, 505);
            this.cmb_length.Name = "cmb_length";
            this.cmb_length.Size = new System.Drawing.Size(41, 21);
            this.cmb_length.TabIndex = 45;
            this.cmb_length.Text = "10";
            // 
            // cmb_kategori_cari
            // 
            this.cmb_kategori_cari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_kategori_cari.FormattingEnabled = true;
            this.cmb_kategori_cari.Items.AddRange(new object[] {
            "id_pinjam",
            "id_member",
            "tgl_pinjam"});
            this.cmb_kategori_cari.Location = new System.Drawing.Point(569, 104);
            this.cmb_kategori_cari.Name = "cmb_kategori_cari";
            this.cmb_kategori_cari.Size = new System.Drawing.Size(94, 24);
            this.cmb_kategori_cari.TabIndex = 44;
            this.cmb_kategori_cari.Text = "id_pinjam";
            // 
            // txt_cari
            // 
            this.txt_cari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cari.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.txt_cari.Location = new System.Drawing.Point(672, 103);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(130, 24);
            this.txt_cari.TabIndex = 42;
            this.txt_cari.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_cari_KeyUp);
            // 
            // dgv_data_kembali
            // 
            this.dgv_data_kembali.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_kembali.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data_kembali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_kembali.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data_kembali.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_data_kembali.Location = new System.Drawing.Point(16, 149);
            this.dgv_data_kembali.MultiSelect = false;
            this.dgv_data_kembali.Name = "dgv_data_kembali";
            this.dgv_data_kembali.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_kembali.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_data_kembali.RowHeadersWidth = 40;
            this.dgv_data_kembali.RowTemplate.Height = 28;
            this.dgv_data_kembali.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data_kembali.Size = new System.Drawing.Size(789, 335);
            this.dgv_data_kembali.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(17, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Menampilkan                  Data Buku.";
            // 
            // btn_next_page
            // 
            this.btn_next_page.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_next_page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next_page.FlatAppearance.BorderSize = 0;
            this.btn_next_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next_page.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_next_page.Image = global::perpustakaan_app.Properties.Resources.next;
            this.btn_next_page.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_next_page.Location = new System.Drawing.Point(730, 501);
            this.btn_next_page.Name = "btn_next_page";
            this.btn_next_page.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_next_page.Size = new System.Drawing.Size(74, 26);
            this.btn_next_page.TabIndex = 47;
            this.btn_next_page.Text = "NEXT";
            this.btn_next_page.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_next_page.UseVisualStyleBackColor = false;
            // 
            // btn_prev_page
            // 
            this.btn_prev_page.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_prev_page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prev_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prev_page.FlatAppearance.BorderSize = 0;
            this.btn_prev_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev_page.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_prev_page.Image = global::perpustakaan_app.Properties.Resources.prev;
            this.btn_prev_page.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prev_page.Location = new System.Drawing.Point(560, 502);
            this.btn_prev_page.Name = "btn_prev_page";
            this.btn_prev_page.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_prev_page.Size = new System.Drawing.Size(79, 26);
            this.btn_prev_page.TabIndex = 46;
            this.btn_prev_page.Text = "PREV";
            this.btn_prev_page.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_prev_page.UseVisualStyleBackColor = false;
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kembali.FlatAppearance.BorderSize = 0;
            this.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kembali.Image = global::perpustakaan_app.Properties.Resources.buku_kembali;
            this.btn_kembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kembali.Location = new System.Drawing.Point(16, 101);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_kembali.Size = new System.Drawing.Size(167, 32);
            this.btn_kembali.TabIndex = 43;
            this.btn_kembali.Text = "PENGEMBALIAN BUKU";
            this.btn_kembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kembali.UseVisualStyleBackColor = false;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_print.Image = global::perpustakaan_app.Properties.Resources.cetak;
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.Location = new System.Drawing.Point(202, 101);
            this.btn_print.Name = "btn_print";
            this.btn_print.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_print.Size = new System.Drawing.Size(127, 32);
            this.btn_print.TabIndex = 51;
            this.btn_print.Text = "DETAIL PINJAM";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 55);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.Location = new System.Drawing.Point(-5, 490);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(830, 55);
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(821, 545);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label_page);
            this.Controls.Add(this.txt_page);
            this.Controls.Add(this.btn_next_page);
            this.Controls.Add(this.btn_prev_page);
            this.Controls.Add(this.cmb_length);
            this.Controls.Add(this.cmb_kategori_cari);
            this.Controls.Add(this.btn_kembali);
            this.Controls.Add(this.txt_cari);
            this.Controls.Add(this.dgv_data_kembali);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pengembalian";
            this.Text = "member";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_kembali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_info;
        public System.Windows.Forms.Label label_page;
        public System.Windows.Forms.TextBox txt_page;
        public System.Windows.Forms.Button btn_next_page;
        public System.Windows.Forms.Button btn_prev_page;
        public System.Windows.Forms.ComboBox cmb_length;
        private System.Windows.Forms.ComboBox cmb_kategori_cari;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.DataGridView dgv_data_kembali;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}