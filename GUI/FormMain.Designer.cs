namespace GUI
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.process1 = new System.Diagnostics.Process();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bttList = new System.Windows.Forms.Button();
            this.bttFind = new System.Windows.Forms.Button();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttDel = new System.Windows.Forms.Button();
            this.bttChange = new System.Windows.Forms.Button();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(51)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bttChange);
            this.panel1.Controls.Add(this.bttDel);
            this.panel1.Controls.Add(this.bttAdd);
            this.panel1.Controls.Add(this.bttFind);
            this.panel1.Controls.Add(this.bttList);
            this.panel1.Controls.Add(this.panelPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 711);
            this.panel1.TabIndex = 0;
            // 
            // panelPicture
            // 
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicture.Controls.Add(this.label1);
            this.panelPicture.Controls.Add(this.pictureBox1);
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPicture.Location = new System.Drawing.Point(0, 0);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(202, 156);
            this.panelPicture.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý sinh viên";
            // 
            // bttList
            // 
            this.bttList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttList.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttList.FlatAppearance.BorderSize = 0;
            this.bttList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttList.ImageKey = "(none)";
            this.bttList.Location = new System.Drawing.Point(0, 156);
            this.bttList.Name = "bttList";
            this.bttList.Size = new System.Drawing.Size(202, 65);
            this.bttList.TabIndex = 1;
            this.bttList.Text = "Danh sách";
            this.bttList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttList.UseVisualStyleBackColor = true;
            this.bttList.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttFind
            // 
            this.bttFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttFind.FlatAppearance.BorderSize = 0;
            this.bttFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttFind.ImageKey = "(none)";
            this.bttFind.Location = new System.Drawing.Point(0, 221);
            this.bttFind.Name = "bttFind";
            this.bttFind.Size = new System.Drawing.Size(202, 65);
            this.bttFind.TabIndex = 2;
            this.bttFind.Text = "Tìm kiếm";
            this.bttFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttFind.UseVisualStyleBackColor = true;
            this.bttFind.Click += new System.EventHandler(this.bttFind_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttAdd.FlatAppearance.BorderSize = 0;
            this.bttAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.ImageKey = "(none)";
            this.bttAdd.Location = new System.Drawing.Point(0, 286);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(202, 65);
            this.bttAdd.TabIndex = 3;
            this.bttAdd.Text = "Thêm sinh viên";
            this.bttAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttAdd.UseVisualStyleBackColor = true;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttDel
            // 
            this.bttDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttDel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttDel.FlatAppearance.BorderSize = 0;
            this.bttDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDel.ImageKey = "(none)";
            this.bttDel.Location = new System.Drawing.Point(0, 351);
            this.bttDel.Name = "bttDel";
            this.bttDel.Size = new System.Drawing.Size(202, 65);
            this.bttDel.TabIndex = 4;
            this.bttDel.Text = "Xóa sinh viên";
            this.bttDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttDel.UseVisualStyleBackColor = true;
            this.bttDel.Click += new System.EventHandler(this.bttDel_Click);
            // 
            // bttChange
            // 
            this.bttChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttChange.FlatAppearance.BorderSize = 0;
            this.bttChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttChange.ImageKey = "(none)";
            this.bttChange.Location = new System.Drawing.Point(0, 416);
            this.bttChange.Name = "bttChange";
            this.bttChange.Size = new System.Drawing.Size(202, 65);
            this.bttChange.TabIndex = 5;
            this.bttChange.Text = "Sửa thông tin";
            this.bttChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttChange.UseVisualStyleBackColor = true;
            this.bttChange.Click += new System.EventHandler(this.bttChange_Click);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplay.Location = new System.Drawing.Point(202, 0);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(982, 711);
            this.pnlDisplay.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.panel1.ResumeLayout(false);
            this.panelPicture.ResumeLayout(false);
            this.panelPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttList;
        private System.Windows.Forms.Button bttChange;
        private System.Windows.Forms.Button bttDel;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Button bttFind;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel pnlDisplay;
    }
}