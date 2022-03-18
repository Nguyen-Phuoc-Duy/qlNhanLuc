
namespace qlNhanLuc
{
    partial class Form1
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
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnPhongban = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Location = new System.Drawing.Point(96, 126);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(195, 23);
            this.btnNhanvien.TabIndex = 0;
            this.btnNhanvien.Text = "Danh sách nhân viên";
            this.btnNhanvien.UseVisualStyleBackColor = true;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnPhongban
            // 
            this.btnPhongban.Location = new System.Drawing.Point(297, 126);
            this.btnPhongban.Name = "btnPhongban";
            this.btnPhongban.Size = new System.Drawing.Size(234, 23);
            this.btnPhongban.TabIndex = 1;
            this.btnPhongban.Text = "Danh sách phòng ban";
            this.btnPhongban.UseVisualStyleBackColor = true;
            this.btnPhongban.Click += new System.EventHandler(this.btnPhongban_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.btnPhongban);
            this.Controls.Add(this.btnNhanvien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnPhongban;
    }
}

