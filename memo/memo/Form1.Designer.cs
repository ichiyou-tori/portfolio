namespace memo
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新しいウィンドウToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ウィンドウを閉じるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.太字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ズームToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.拡大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.縮小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.標準ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.表示ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成ToolStripMenuItem,
            this.新しいウィンドウToolStripMenuItem,
            this.開くToolStripMenuItem,
            this.保存ToolStripMenuItem1,
            this.名前を付けて保存ToolStripMenuItem,
            this.ウィンドウを閉じるToolStripMenuItem,
            this.終了ToolStripMenuItem1});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 新規作成ToolStripMenuItem
            // 
            this.新規作成ToolStripMenuItem.Name = "新規作成ToolStripMenuItem";
            this.新規作成ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.新規作成ToolStripMenuItem.Text = "新規作成";
            this.新規作成ToolStripMenuItem.Click += new System.EventHandler(this.新規作成ToolStripMenuItem_Click);
            // 
            // 新しいウィンドウToolStripMenuItem
            // 
            this.新しいウィンドウToolStripMenuItem.Name = "新しいウィンドウToolStripMenuItem";
            this.新しいウィンドウToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.新しいウィンドウToolStripMenuItem.Text = "新しいウィンドウ";
            this.新しいウィンドウToolStripMenuItem.Click += new System.EventHandler(this.新しいウィンドウToolStripMenuItem_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.開くToolStripMenuItem.Text = "開く";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem1
            // 
            this.保存ToolStripMenuItem1.Name = "保存ToolStripMenuItem1";
            this.保存ToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.保存ToolStripMenuItem1.Text = "保存";
            this.保存ToolStripMenuItem1.Click += new System.EventHandler(this.保存ToolStripMenuItem1_Click);
            // 
            // 名前を付けて保存ToolStripMenuItem
            // 
            this.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem";
            this.名前を付けて保存ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.名前を付けて保存ToolStripMenuItem.Text = "名前を付けて保存";
            this.名前を付けて保存ToolStripMenuItem.Click += new System.EventHandler(this.名前を付けて保存ToolStripMenuItem_Click);
            // 
            // ウィンドウを閉じるToolStripMenuItem
            // 
            this.ウィンドウを閉じるToolStripMenuItem.Name = "ウィンドウを閉じるToolStripMenuItem";
            this.ウィンドウを閉じるToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ウィンドウを閉じるToolStripMenuItem.Text = "ウィンドウを閉じる";
            this.ウィンドウを閉じるToolStripMenuItem.Click += new System.EventHandler(this.ウィンドウを閉じるToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem1
            // 
            this.終了ToolStripMenuItem1.Name = "終了ToolStripMenuItem1";
            this.終了ToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.終了ToolStripMenuItem1.Text = "終了";
            this.終了ToolStripMenuItem1.Click += new System.EventHandler(this.終了ToolStripMenuItem1_Click);
            // 
            // 表示ToolStripMenuItem
            // 
            this.表示ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ズームToolStripMenuItem,
            this.太字ToolStripMenuItem});
            this.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem";
            this.表示ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.表示ToolStripMenuItem.Text = "表示";
            // 
            // 太字ToolStripMenuItem
            // 
            this.太字ToolStripMenuItem.Name = "太字ToolStripMenuItem";
            this.太字ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.太字ToolStripMenuItem.Text = "太字";
            this.太字ToolStripMenuItem.Click += new System.EventHandler(this.太字ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(584, 315);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // ズームToolStripMenuItem
            // 
            this.ズームToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.拡大ToolStripMenuItem,
            this.縮小ToolStripMenuItem,
            this.標準ToolStripMenuItem});
            this.ズームToolStripMenuItem.Name = "ズームToolStripMenuItem";
            this.ズームToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ズームToolStripMenuItem.Text = "ズーム";
            // 
            // 拡大ToolStripMenuItem
            // 
            this.拡大ToolStripMenuItem.Name = "拡大ToolStripMenuItem";
            this.拡大ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.拡大ToolStripMenuItem.Text = "拡大";
            this.拡大ToolStripMenuItem.Click += new System.EventHandler(this.拡大ToolStripMenuItem_Click);
            // 
            // 縮小ToolStripMenuItem
            // 
            this.縮小ToolStripMenuItem.Name = "縮小ToolStripMenuItem";
            this.縮小ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.縮小ToolStripMenuItem.Text = "縮小";
            this.縮小ToolStripMenuItem.Click += new System.EventHandler(this.縮小ToolStripMenuItem_Click);
            // 
            // 標準ToolStripMenuItem
            // 
            this.標準ToolStripMenuItem.Name = "標準ToolStripMenuItem";
            this.標準ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.標準ToolStripMenuItem.Text = "標準";
            this.標準ToolStripMenuItem.Click += new System.EventHandler(this.標準ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "メモ帳";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新しいウィンドウToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ウィンドウを閉じるToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 新規作成ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 表示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 太字ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem ズームToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 拡大ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 縮小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 標準ToolStripMenuItem;
    }
}

