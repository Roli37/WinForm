
namespace WinForm
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
            this.components = new System.ComponentModel.Container();
            this.bindingSourceAllData = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_megjelenit = new System.Windows.Forms.Button();
            this.btn_exportal = new System.Windows.Forms.Button();
            this.lb_valtozott = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.tb_ar = new System.Windows.Forms.TextBox();
            this.btn_szures = new System.Windows.Forms.Button();
            this.btn_ujadat = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllData)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_ujadat, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33112F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1234, 561);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView2, 2);
            this.dataGridView2.Location = new System.Drawing.Point(3, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView2, 3);
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1022, 495);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(384, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Karbantartások";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btn_megjelenit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_exportal, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_valtozott, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1031, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 161);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btn_megjelenit
            // 
            this.btn_megjelenit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_megjelenit.AutoSize = true;
            this.btn_megjelenit.Location = new System.Drawing.Point(3, 3);
            this.btn_megjelenit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btn_megjelenit.Name = "btn_megjelenit";
            this.btn_megjelenit.Size = new System.Drawing.Size(194, 29);
            this.btn_megjelenit.TabIndex = 2;
            this.btn_megjelenit.Text = "Karbantartások megjelenítése";
            this.btn_megjelenit.UseVisualStyleBackColor = true;
            this.btn_megjelenit.Click += new System.EventHandler(this.btn_megjelenit_Click);
            // 
            // btn_exportal
            // 
            this.btn_exportal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exportal.AutoSize = true;
            this.btn_exportal.Location = new System.Drawing.Point(3, 45);
            this.btn_exportal.Name = "btn_exportal";
            this.btn_exportal.Size = new System.Drawing.Size(194, 25);
            this.btn_exportal.TabIndex = 4;
            this.btn_exportal.Text = "Karbantartások exportálása";
            this.btn_exportal.UseVisualStyleBackColor = true;
            this.btn_exportal.Click += new System.EventHandler(this.btn_exportal_Click);
            // 
            // lb_valtozott
            // 
            this.lb_valtozott.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_valtozott.AutoSize = true;
            this.lb_valtozott.Location = new System.Drawing.Point(100, 83);
            this.lb_valtozott.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lb_valtozott.Name = "lb_valtozott";
            this.lb_valtozott.Size = new System.Drawing.Size(0, 15);
            this.lb_valtozott.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_szures, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1031, 230);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 161);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Összetett szűrés";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tb_nev, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tb_ar, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 63);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Szerelő neve:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Minimum ár:";
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(85, 3);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(100, 23);
            this.tb_nev.TabIndex = 2;
            // 
            // tb_ar
            // 
            this.tb_ar.Location = new System.Drawing.Point(85, 32);
            this.tb_ar.Name = "tb_ar";
            this.tb_ar.Size = new System.Drawing.Size(100, 23);
            this.tb_ar.TabIndex = 3;
            // 
            // btn_szures
            // 
            this.btn_szures.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_szures.AutoSize = true;
            this.btn_szures.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_szures.Location = new System.Drawing.Point(62, 125);
            this.btn_szures.Name = "btn_szures";
            this.btn_szures.Size = new System.Drawing.Size(76, 33);
            this.btn_szures.TabIndex = 9;
            this.btn_szures.Text = "Szűrés";
            this.btn_szures.UseVisualStyleBackColor = true;
            this.btn_szures.Click += new System.EventHandler(this.btn_szures_Click);
            // 
            // btn_ujadat
            // 
            this.btn_ujadat.BackColor = System.Drawing.Color.Gray;
            this.btn_ujadat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ujadat.Location = new System.Drawing.Point(1031, 397);
            this.btn_ujadat.MaximumSize = new System.Drawing.Size(200, 160);
            this.btn_ujadat.MinimumSize = new System.Drawing.Size(200, 160);
            this.btn_ujadat.Name = "btn_ujadat";
            this.btn_ujadat.Size = new System.Drawing.Size(200, 160);
            this.btn_ujadat.TabIndex = 7;
            this.btn_ujadat.UseVisualStyleBackColor = false;
            this.btn_ujadat.Click += new System.EventHandler(this.btn_ujadat_Click);
            this.btn_ujadat.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_ujadat_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(1250, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAllData)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSourceAllData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_megjelenit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exportal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.TextBox tb_ar;
        private System.Windows.Forms.Button btn_szures;
        private System.Windows.Forms.Button btn_ujadat;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lb_valtozott;
    }
}

