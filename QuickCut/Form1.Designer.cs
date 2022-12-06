namespace QuickCut
{
    partial class QuickCut
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.fileIn = new System.Windows.Forms.TextBox();
            this.folderIn = new System.Windows.Forms.TextBox();
            this.buttonCutByFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileIn
            // 
            this.fileIn.AllowDrop = true;
            this.fileIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileIn.Location = new System.Drawing.Point(12, 12);
            this.fileIn.Name = "fileIn";
            this.fileIn.Size = new System.Drawing.Size(500, 29);
            this.fileIn.TabIndex = 0;
            this.fileIn.Text = "拖拽一个视频文件到这里";
            this.fileIn.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileIn_DragDrop);
            this.fileIn.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileIn_DragEnter);
            // 
            // folderIn
            // 
            this.folderIn.AllowDrop = true;
            this.folderIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderIn.Location = new System.Drawing.Point(12, 72);
            this.folderIn.Name = "folderIn";
            this.folderIn.Size = new System.Drawing.Size(500, 29);
            this.folderIn.TabIndex = 1;
            this.folderIn.Text = "拖拽一个音频到这里";
            this.folderIn.TextChanged += new System.EventHandler(this.folderIn_TextChanged);
            this.folderIn.DragDrop += new System.Windows.Forms.DragEventHandler(this.folderIn_DragDrop);
            this.folderIn.DragEnter += new System.Windows.Forms.DragEventHandler(this.folderIn_DragEnter);
            // 
            // buttonCutByFile
            // 
            this.buttonCutByFile.Location = new System.Drawing.Point(10, 140);
            this.buttonCutByFile.Name = "buttonCutByFile";
            this.buttonCutByFile.Size = new System.Drawing.Size(500, 34);
            this.buttonCutByFile.TabIndex = 5;
            this.buttonCutByFile.Text = "合并";
            this.buttonCutByFile.UseVisualStyleBackColor = true;
            this.buttonCutByFile.Click += new System.EventHandler(this.buttonCutByFile_Click);
            // 
            // QuickCut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(522, 187);
            this.Controls.Add(this.buttonCutByFile);
            this.Controls.Add(this.folderIn);
            this.Controls.Add(this.fileIn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuickCut";
            this.Text = "QuickMerge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileIn;
        private System.Windows.Forms.TextBox folderIn;
        private System.Windows.Forms.Button buttonCutByFile;
    }
}

