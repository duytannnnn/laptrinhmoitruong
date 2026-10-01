namespace tuan4
{
    partial class Listview
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
            dataGridView1 = new DataGridView();
            btn_them = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_dong = new Button();
            d1_msnv = new DataGridViewTextBoxColumn();
            d2_tennv = new DataGridViewTextBoxColumn();
            d3_luongcoban = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { d1_msnv, d2_tennv, d3_luongcoban });
            dataGridView1.Location = new Point(33, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(560, 188);
            dataGridView1.TabIndex = 0;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(641, 39);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(94, 29);
            btn_them.TabIndex = 1;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(641, 105);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 2;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(641, 167);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 29);
            btn_sua.TabIndex = 3;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_dong
            // 
            btn_dong.Location = new Point(641, 238);
            btn_dong.Name = "btn_dong";
            btn_dong.Size = new Size(94, 29);
            btn_dong.TabIndex = 4;
            btn_dong.Text = "Đóng";
            btn_dong.UseVisualStyleBackColor = true;
            // 
            // d1_msnv
            // 
            d1_msnv.HeaderText = "MSNV";
            d1_msnv.MinimumWidth = 6;
            d1_msnv.Name = "d1_msnv";
            d1_msnv.Width = 150;
            // 
            // d2_tennv
            // 
            d2_tennv.HeaderText = "Tên NV";
            d2_tennv.MinimumWidth = 6;
            d2_tennv.Name = "d2_tennv";
            d2_tennv.Width = 150;
            // 
            // d3_luongcoban
            // 
            d3_luongcoban.HeaderText = "Lương CB";
            d3_luongcoban.MinimumWidth = 6;
            d3_luongcoban.Name = "d3_luongcoban";
            d3_luongcoban.Width = 150;
            // 
            // Listview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_dong);
            Controls.Add(btn_sua);
            Controls.Add(btn_xoa);
            Controls.Add(btn_them);
            Controls.Add(dataGridView1);
            Name = "Listview";
            Text = "Listview";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_them;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_dong;
        private DataGridViewTextBoxColumn d1_msnv;
        private DataGridViewTextBoxColumn d2_tennv;
        private DataGridViewTextBoxColumn d3_luongcoban;
    }
}
