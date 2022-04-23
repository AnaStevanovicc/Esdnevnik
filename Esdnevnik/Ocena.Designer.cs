namespace Esdnevnik
{
    partial class Ocena
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
            this.cmb_godina = new System.Windows.Forms.ComboBox();
            this.cmb_profesor = new System.Windows.Forms.ComboBox();
            this.cmb_predmet = new System.Windows.Forms.ComboBox();
            this.cmb_odeljenje = new System.Windows.Forms.ComboBox();
            this.cmb_ucenik = new System.Windows.Forms.ComboBox();
            this.cmb_ocena = new System.Windows.Forms.ComboBox();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.Grid_Ocene = new System.Windows.Forms.DataGridView();
            this.lbl_Godina = new System.Windows.Forms.Label();
            this.lbl_Profesor = new System.Windows.Forms.Label();
            this.lbl_Predmet = new System.Windows.Forms.Label();
            this.lbl_Odeljenje = new System.Windows.Forms.Label();
            this.lbl_Ucenik = new System.Windows.Forms.Label();
            this.lbl_Ocena = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_Datum = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocene)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_godina
            // 
            this.cmb_godina.FormattingEnabled = true;
            this.cmb_godina.Location = new System.Drawing.Point(12, 35);
            this.cmb_godina.Name = "cmb_godina";
            this.cmb_godina.Size = new System.Drawing.Size(158, 21);
            this.cmb_godina.TabIndex = 0;
            this.cmb_godina.SelectedValueChanged += new System.EventHandler(this.cmb_godina_SelectedValueChanged);
            // 
            // cmb_profesor
            // 
            this.cmb_profesor.FormattingEnabled = true;
            this.cmb_profesor.Location = new System.Drawing.Point(176, 35);
            this.cmb_profesor.Name = "cmb_profesor";
            this.cmb_profesor.Size = new System.Drawing.Size(158, 21);
            this.cmb_profesor.TabIndex = 1;
            this.cmb_profesor.SelectedValueChanged += new System.EventHandler(this.cmb_profesor_SelectedValueChanged);
            // 
            // cmb_predmet
            // 
            this.cmb_predmet.FormattingEnabled = true;
            this.cmb_predmet.Location = new System.Drawing.Point(340, 35);
            this.cmb_predmet.Name = "cmb_predmet";
            this.cmb_predmet.Size = new System.Drawing.Size(158, 21);
            this.cmb_predmet.TabIndex = 2;
            this.cmb_predmet.SelectedValueChanged += new System.EventHandler(this.cmb_predmet_SelectedValueChanged);
            // 
            // cmb_odeljenje
            // 
            this.cmb_odeljenje.FormattingEnabled = true;
            this.cmb_odeljenje.Location = new System.Drawing.Point(504, 35);
            this.cmb_odeljenje.Name = "cmb_odeljenje";
            this.cmb_odeljenje.Size = new System.Drawing.Size(158, 21);
            this.cmb_odeljenje.TabIndex = 3;
            this.cmb_odeljenje.SelectedValueChanged += new System.EventHandler(this.cmb_odeljenje_SelectedValueChanged);
            // 
            // cmb_ucenik
            // 
            this.cmb_ucenik.FormattingEnabled = true;
            this.cmb_ucenik.Location = new System.Drawing.Point(12, 90);
            this.cmb_ucenik.Name = "cmb_ucenik";
            this.cmb_ucenik.Size = new System.Drawing.Size(158, 21);
            this.cmb_ucenik.TabIndex = 4;
            // 
            // cmb_ocena
            // 
            this.cmb_ocena.FormattingEnabled = true;
            this.cmb_ocena.Location = new System.Drawing.Point(176, 91);
            this.cmb_ocena.Name = "cmb_ocena";
            this.cmb_ocena.Size = new System.Drawing.Size(158, 21);
            this.cmb_ocena.TabIndex = 5;
            // 
            // Datum
            // 
            this.Datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datum.Location = new System.Drawing.Point(504, 92);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(158, 20);
            this.Datum.TabIndex = 6;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(340, 91);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(158, 20);
            this.txt_id.TabIndex = 7;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(700, 27);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 8;
            this.btn_insert.Text = "Dodaj";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(700, 65);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Izmeni";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(700, 104);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Brisi";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Grid_Ocene
            // 
            this.Grid_Ocene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Ocene.Location = new System.Drawing.Point(12, 188);
            this.Grid_Ocene.Name = "Grid_Ocene";
            this.Grid_Ocene.Size = new System.Drawing.Size(676, 256);
            this.Grid_Ocene.TabIndex = 11;
            this.Grid_Ocene.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Ocene_CellClick);
            // 
            // lbl_Godina
            // 
            this.lbl_Godina.AutoSize = true;
            this.lbl_Godina.Location = new System.Drawing.Point(12, 16);
            this.lbl_Godina.Name = "lbl_Godina";
            this.lbl_Godina.Size = new System.Drawing.Size(41, 13);
            this.lbl_Godina.TabIndex = 12;
            this.lbl_Godina.Text = "Godina";
            // 
            // lbl_Profesor
            // 
            this.lbl_Profesor.AutoSize = true;
            this.lbl_Profesor.Location = new System.Drawing.Point(173, 16);
            this.lbl_Profesor.Name = "lbl_Profesor";
            this.lbl_Profesor.Size = new System.Drawing.Size(46, 13);
            this.lbl_Profesor.TabIndex = 13;
            this.lbl_Profesor.Text = "Profesor";
            // 
            // lbl_Predmet
            // 
            this.lbl_Predmet.AutoSize = true;
            this.lbl_Predmet.Location = new System.Drawing.Point(337, 16);
            this.lbl_Predmet.Name = "lbl_Predmet";
            this.lbl_Predmet.Size = new System.Drawing.Size(46, 13);
            this.lbl_Predmet.TabIndex = 14;
            this.lbl_Predmet.Text = "Predmet";
            // 
            // lbl_Odeljenje
            // 
            this.lbl_Odeljenje.AutoSize = true;
            this.lbl_Odeljenje.Location = new System.Drawing.Point(501, 16);
            this.lbl_Odeljenje.Name = "lbl_Odeljenje";
            this.lbl_Odeljenje.Size = new System.Drawing.Size(51, 13);
            this.lbl_Odeljenje.TabIndex = 15;
            this.lbl_Odeljenje.Text = "Odeljenje";
            // 
            // lbl_Ucenik
            // 
            this.lbl_Ucenik.AutoSize = true;
            this.lbl_Ucenik.Location = new System.Drawing.Point(12, 70);
            this.lbl_Ucenik.Name = "lbl_Ucenik";
            this.lbl_Ucenik.Size = new System.Drawing.Size(41, 13);
            this.lbl_Ucenik.TabIndex = 16;
            this.lbl_Ucenik.Text = "Ucenik";
            // 
            // lbl_Ocena
            // 
            this.lbl_Ocena.AutoSize = true;
            this.lbl_Ocena.Location = new System.Drawing.Point(173, 70);
            this.lbl_Ocena.Name = "lbl_Ocena";
            this.lbl_Ocena.Size = new System.Drawing.Size(39, 13);
            this.lbl_Ocena.TabIndex = 17;
            this.lbl_Ocena.Text = "Ocena";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(337, 70);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(15, 13);
            this.lbl_id.TabIndex = 18;
            this.lbl_id.Text = "id";
            // 
            // lbl_Datum
            // 
            this.lbl_Datum.AutoSize = true;
            this.lbl_Datum.Location = new System.Drawing.Point(501, 70);
            this.lbl_Datum.Name = "lbl_Datum";
            this.lbl_Datum.Size = new System.Drawing.Size(38, 13);
            this.lbl_Datum.TabIndex = 19;
            this.lbl_Datum.Text = "Datum";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(621, 20);
            this.textBox2.TabIndex = 20;
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 456);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_Datum);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_Ocena);
            this.Controls.Add(this.lbl_Ucenik);
            this.Controls.Add(this.lbl_Odeljenje);
            this.Controls.Add(this.lbl_Predmet);
            this.Controls.Add(this.lbl_Profesor);
            this.Controls.Add(this.lbl_Godina);
            this.Controls.Add(this.Grid_Ocene);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.cmb_ocena);
            this.Controls.Add(this.cmb_ucenik);
            this.Controls.Add(this.cmb_odeljenje);
            this.Controls.Add(this.cmb_predmet);
            this.Controls.Add(this.cmb_profesor);
            this.Controls.Add(this.cmb_godina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Ocene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_godina;
        private System.Windows.Forms.ComboBox cmb_profesor;
        private System.Windows.Forms.ComboBox cmb_predmet;
        private System.Windows.Forms.ComboBox cmb_odeljenje;
        private System.Windows.Forms.ComboBox cmb_ucenik;
        private System.Windows.Forms.ComboBox cmb_ocena;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView Grid_Ocene;
        private System.Windows.Forms.Label lbl_Godina;
        private System.Windows.Forms.Label lbl_Profesor;
        private System.Windows.Forms.Label lbl_Predmet;
        private System.Windows.Forms.Label lbl_Odeljenje;
        private System.Windows.Forms.Label lbl_Ucenik;
        private System.Windows.Forms.Label lbl_Ocena;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_Datum;
        private System.Windows.Forms.TextBox textBox2;
    }
}