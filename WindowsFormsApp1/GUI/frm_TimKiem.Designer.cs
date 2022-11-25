namespace WindowsFormsApp1.GUI
{
    partial class frm_TimKiem
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
            this.cob_TPB = new System.Windows.Forms.ComboBox();
            this.ckb_PB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cob_TBP = new System.Windows.Forms.ComboBox();
            this.ckb_BP = new System.Windows.Forms.CheckBox();
            this.cob_TCV = new System.Windows.Forms.ComboBox();
            this.ckb_CV = new System.Windows.Forms.CheckBox();
            this.txt_TimTen = new System.Windows.Forms.TextBox();
            this.ckb_HoTen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cob_TPB
            // 
            this.cob_TPB.FormattingEnabled = true;
            this.cob_TPB.Location = new System.Drawing.Point(249, 197);
            this.cob_TPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cob_TPB.Name = "cob_TPB";
            this.cob_TPB.Size = new System.Drawing.Size(228, 30);
            this.cob_TPB.TabIndex = 48;
            this.cob_TPB.SelectedIndexChanged += new System.EventHandler(this.cob_TPB_SelectedIndexChanged);
            // 
            // ckb_PB
            // 
            this.ckb_PB.AutoSize = true;
            this.ckb_PB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_PB.Location = new System.Drawing.Point(108, 201);
            this.ckb_PB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckb_PB.Name = "ckb_PB";
            this.ckb_PB.Size = new System.Drawing.Size(113, 26);
            this.ckb_PB.TabIndex = 47;
            this.ckb_PB.Text = "Phòng ban";
            this.ckb_PB.UseVisualStyleBackColor = true;
            this.ckb_PB.CheckedChanged += new System.EventHandler(this.ckb_PB_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 409);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 22);
            this.label5.TabIndex = 46;
            this.label5.Text = "Danh sách tìm kiếm";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(48, 473);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1013, 158);
            this.dataGridView2.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "TÌM KIẾM THÔNG TIN";
            // 
            // cob_TBP
            // 
            this.cob_TBP.FormattingEnabled = true;
            this.cob_TBP.Location = new System.Drawing.Point(249, 309);
            this.cob_TBP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cob_TBP.Name = "cob_TBP";
            this.cob_TBP.Size = new System.Drawing.Size(228, 30);
            this.cob_TBP.TabIndex = 50;
            this.cob_TBP.SelectedIndexChanged += new System.EventHandler(this.cob_TBP_SelectedIndexChanged);
            // 
            // ckb_BP
            // 
            this.ckb_BP.AutoSize = true;
            this.ckb_BP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_BP.Location = new System.Drawing.Point(108, 315);
            this.ckb_BP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckb_BP.Name = "ckb_BP";
            this.ckb_BP.Size = new System.Drawing.Size(97, 26);
            this.ckb_BP.TabIndex = 49;
            this.ckb_BP.Text = "Bộ phận";
            this.ckb_BP.UseVisualStyleBackColor = true;
            this.ckb_BP.CheckedChanged += new System.EventHandler(this.ckb_BP_CheckedChanged);
            // 
            // cob_TCV
            // 
            this.cob_TCV.FormattingEnabled = true;
            this.cob_TCV.Location = new System.Drawing.Point(776, 195);
            this.cob_TCV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cob_TCV.Name = "cob_TCV";
            this.cob_TCV.Size = new System.Drawing.Size(219, 30);
            this.cob_TCV.TabIndex = 52;
            this.cob_TCV.SelectedIndexChanged += new System.EventHandler(this.cob_TCV_SelectedIndexChanged);
            // 
            // ckb_CV
            // 
            this.ckb_CV.AutoSize = true;
            this.ckb_CV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_CV.Location = new System.Drawing.Point(602, 195);
            this.ckb_CV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckb_CV.Name = "ckb_CV";
            this.ckb_CV.Size = new System.Drawing.Size(113, 26);
            this.ckb_CV.TabIndex = 51;
            this.ckb_CV.Text = "Phòng ban";
            this.ckb_CV.UseVisualStyleBackColor = true;
            this.ckb_CV.CheckedChanged += new System.EventHandler(this.ckb_CV_CheckedChanged);
            // 
            // txt_TimTen
            // 
            this.txt_TimTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimTen.Location = new System.Drawing.Point(776, 307);
            this.txt_TimTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TimTen.Name = "txt_TimTen";
            this.txt_TimTen.Size = new System.Drawing.Size(219, 30);
            this.txt_TimTen.TabIndex = 75;
            this.txt_TimTen.TextChanged += new System.EventHandler(this.txt_TimTen_TextChanged);
            // 
            // ckb_HoTen
            // 
            this.ckb_HoTen.AutoSize = true;
            this.ckb_HoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_HoTen.Location = new System.Drawing.Point(602, 311);
            this.ckb_HoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckb_HoTen.Name = "ckb_HoTen";
            this.ckb_HoTen.Size = new System.Drawing.Size(130, 26);
            this.ckb_HoTen.TabIndex = 76;
            this.ckb_HoTen.Text = "Tìm theo tên";
            this.ckb_HoTen.UseVisualStyleBackColor = true;
            this.ckb_HoTen.CheckedChanged += new System.EventHandler(this.ckb_HoTen_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 22);
            this.label2.TabIndex = 77;
            this.label2.Text = "Bạn hãy tích chọn thông tin muốn tìm kiếm";
            // 
            // frm_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 760);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckb_HoTen);
            this.Controls.Add(this.txt_TimTen);
            this.Controls.Add(this.cob_TCV);
            this.Controls.Add(this.ckb_CV);
            this.Controls.Add(this.cob_TBP);
            this.Controls.Add(this.ckb_BP);
            this.Controls.Add(this.cob_TPB);
            this.Controls.Add(this.ckb_PB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_TimKiem";
            this.Text = "Tìm kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cob_TPB;
        public System.Windows.Forms.CheckBox ckb_PB;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cob_TBP;
        public System.Windows.Forms.CheckBox ckb_BP;
        public System.Windows.Forms.ComboBox cob_TCV;
        public System.Windows.Forms.CheckBox ckb_CV;
        public System.Windows.Forms.TextBox txt_TimTen;
        private System.Windows.Forms.CheckBox ckb_HoTen;
        private System.Windows.Forms.Label label2;
    }
}