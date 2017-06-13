namespace DoneNote
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.centerUserControl1 = new DoneNote.CenterUserControl();
            this.topUserControl1 = new DoneNote.TopUserControl();
            this.topPanel = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // centerUserControl1
            // 
            this.centerUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerUserControl1.Location = new System.Drawing.Point(0, 0);
            this.centerUserControl1.Name = "centerUserControl1";
            this.centerUserControl1.Size = new System.Drawing.Size(284, 231);
            this.centerUserControl1.TabIndex = 0;
            this.centerUserControl1.TextBoxText = "";
            // 
            // topUserControl1
            // 
            this.topUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topUserControl1.Location = new System.Drawing.Point(0, 0);
            this.topUserControl1.Name = "topUserControl1";
            this.topUserControl1.Size = new System.Drawing.Size(284, 30);
            this.topUserControl1.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.topUserControl1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(284, 30);
            this.topPanel.TabIndex = 2;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.centerUserControl1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 30);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(284, 231);
            this.centerPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.topPanel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "ドーンノート";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.topPanel.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CenterUserControl centerUserControl1;
        private TopUserControl topUserControl1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel centerPanel;
    }
}

