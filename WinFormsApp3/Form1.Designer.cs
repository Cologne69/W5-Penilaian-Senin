namespace WinFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_output = new System.Windows.Forms.Label();
            this.check_merah = new System.Windows.Forms.RadioButton();
            this.check_biru = new System.Windows.Forms.RadioButton();
            this.checkbox_aktif = new System.Windows.Forms.CheckBox();
            this.lbl_settting = new System.Windows.Forms.Label();
            this.lbl_untukoutput = new System.Windows.Forms.Label();
            this.list_box = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(70, 24);
            this.txt_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(424, 23);
            this.txt_input.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(519, 22);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 22);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(437, 353);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(206, 22);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Clear";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_output.Location = new System.Drawing.Point(474, 252);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(28, 30);
            this.lbl_output.TabIndex = 4;
            this.lbl_output.Text = "...";
            this.lbl_output.Click += new System.EventHandler(this.label2_Click);
            // 
            // check_merah
            // 
            this.check_merah.AutoSize = true;
            this.check_merah.Checked = true;
            this.check_merah.Location = new System.Drawing.Point(451, 104);
            this.check_merah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_merah.Name = "check_merah";
            this.check_merah.Size = new System.Drawing.Size(99, 19);
            this.check_merah.TabIndex = 5;
            this.check_merah.TabStop = true;
            this.check_merah.Text = "Warna Merah ";
            this.check_merah.UseVisualStyleBackColor = true;
            this.check_merah.CheckedChanged += new System.EventHandler(this.check_merah_CheckedChanged);
            // 
            // check_biru
            // 
            this.check_biru.AutoSize = true;
            this.check_biru.Location = new System.Drawing.Point(451, 126);
            this.check_biru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_biru.Name = "check_biru";
            this.check_biru.Size = new System.Drawing.Size(83, 19);
            this.check_biru.TabIndex = 6;
            this.check_biru.Text = "Warna Biru";
            this.check_biru.UseVisualStyleBackColor = true;
            this.check_biru.CheckedChanged += new System.EventHandler(this.check_biru_CheckedChanged);
            // 
            // checkbox_aktif
            // 
            this.checkbox_aktif.AutoSize = true;
            this.checkbox_aktif.Location = new System.Drawing.Point(451, 81);
            this.checkbox_aktif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkbox_aktif.Name = "checkbox_aktif";
            this.checkbox_aktif.Size = new System.Drawing.Size(51, 19);
            this.checkbox_aktif.TabIndex = 7;
            this.checkbox_aktif.Text = "Aktif";
            this.checkbox_aktif.UseVisualStyleBackColor = true;
            this.checkbox_aktif.CheckedChanged += new System.EventHandler(this.checkbox_aktif_CheckedChanged);
            // 
            // lbl_settting
            // 
            this.lbl_settting.AutoSize = true;
            this.lbl_settting.Location = new System.Drawing.Point(390, 81);
            this.lbl_settting.Name = "lbl_settting";
            this.lbl_settting.Size = new System.Drawing.Size(50, 15);
            this.lbl_settting.TabIndex = 8;
            this.lbl_settting.Text = "Setting: ";
            // 
            // lbl_untukoutput
            // 
            this.lbl_untukoutput.AutoSize = true;
            this.lbl_untukoutput.Location = new System.Drawing.Point(391, 202);
            this.lbl_untukoutput.Name = "lbl_untukoutput";
            this.lbl_untukoutput.Size = new System.Drawing.Size(51, 15);
            this.lbl_untukoutput.TabIndex = 9;
            this.lbl_untukoutput.Text = "Output: ";
            // 
            // list_box
            // 
            this.list_box.FormattingEnabled = true;
            this.list_box.ItemHeight = 15;
            this.list_box.Location = new System.Drawing.Point(21, 81);
            this.list_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_box.Name = "list_box";
            this.list_box.Size = new System.Drawing.Size(314, 289);
            this.list_box.TabIndex = 10;
            this.list_box.SelectedIndexChanged += new System.EventHandler(this.list_box_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 392);
            this.Controls.Add(this.list_box);
            this.Controls.Add(this.lbl_untukoutput);
            this.Controls.Add(this.lbl_settting);
            this.Controls.Add(this.checkbox_aktif);
            this.Controls.Add(this.check_biru);
            this.Controls.Add(this.check_merah);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form Materi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_input;
        private Button btn_add;
        private Button btn_close;
        private Label lbl_output;
        private RadioButton check_merah;
        private RadioButton check_biru;
        private CheckBox checkbox_aktif;
        private Label lbl_settting;
        private Label lbl_untukoutput;
        private ListBox list_box;
    }
}