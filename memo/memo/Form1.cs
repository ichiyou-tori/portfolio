using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memo
{
    public partial class Form1 : Form
    {
        // 保存済みかどうか(true：保存済み、false：未保存)
        private bool isSave;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void 新しいウィンドウToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "テキストファイル(*.txt)|*.txt";
            ofd.Title = "開く";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void 保存ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "テキストファイル(*.txt)|*.txt";
            ofd.Title = "保存";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(ofd.FileName, richTextBox1.Text);
            }
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "テキスト ファイル (*.txt)|*.txt|すべてのファイル (*.*)|*.*";
            saveFileDialog.Title = "名前を付けて保存";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FileName = "新しいファイル.txt"; // デフォルトのファイル名

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // テキストボックスの内容を指定したファイルに保存
                try
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                    MessageBox.Show("ファイルが保存されました。", "保存完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("保存中にエラーが発生しました: " + ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ウィンドウを閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 終了ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("メモ帳を終了します", "終了", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.isSave)
            {
                richTextBox1.Clear();
            }
            else
            {
                DialogResult result = MessageBox.Show("内容を保存しますか？", "メモ帳", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
                {
                    SaveFileDialog ofd = new SaveFileDialog();
                    ofd.Filter = "テキストファイル(*.txt)|*.txt";
                    ofd.Title = "保存";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(ofd.FileName, richTextBox1.Text);
                    }
                }
                else if (result == DialogResult.No)
                {
                    this.richTextBox1.Text = string.Empty;
                    this.isSave = true;
                }
                else
                {
                    return;
                }
            }
        }

        private void 太字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 選択範囲のフォントを取得
            Font currentFont = richTextBox1.SelectionFont;

            if (currentFont != null)
            {
                // 現在のフォントが太字の場合は解除、それ以外は太字を適用
                FontStyle newFontStyle = currentFont.Bold ? FontStyle.Regular : FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // ステータスバーに文字数を表示する
            string text = string.Format("文字数 {0}", this.richTextBox1.Text.Length);
            this.toolStripStatusLabel1.Text = text;

            // テキストが更新されたら、未保存にする
            this.isSave = false;
        }

        private void 拡大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdjustFontSize(2);
            //RichTextBox richTextBox = this.Controls["richTextBox1"] as RichTextBox;
            //if (richTextBox != null)
            //{
            //    float currentSize = richTextBox.Font.Size;
            //    richTextBox.Font = new Font(richTextBox.Font.FontFamily, currentSize + 2);
            //}
        }

        private void 縮小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdjustFontSize(-2);
            //RichTextBox richTextBox = this.Controls["richTextBox1"] as RichTextBox;
            //if (richTextBox != null)
            //{
            //    float currentSize = richTextBox.Font.Size;
            //    if (currentSize > 6) // 最小サイズの制限
            //    {
            //        richTextBox.Font = new Font(richTextBox.Font.FontFamily, currentSize - 2);
            //    }
            //}
        }

        private void 標準ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDefaultFontSize();
            //RichTextBox richTextBox = this.Controls["richTextBox1"] as RichTextBox;
            //if (richTextBox != null)
            //{
            //    richTextBox.Font = new Font(richTextBox.Font.FontFamily, 12); // 標準サイズにリセット
            //}
        }

        // フォントサイズを調整する
        private void AdjustFontSize(int sizeChange)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                // 選択範囲の文字ごとに処理
                int selectionStart = richTextBox1.SelectionStart;
                int selectionLength = richTextBox1.SelectionLength;
                for (int i = selectionStart; i < selectionStart + selectionLength; i++)
                {
                    richTextBox1.Select(i, 1);
                    Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
                    FontStyle currentStyle = currentFont.Style;// 現在のフォントスタイル（太字、斜体など）を保持
                    float newSize = Math.Max(6, currentFont.Size + sizeChange); // 最小サイズを6ptに制限
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
                }
                richTextBox1.Select(selectionStart, selectionLength); // 選択範囲を復元
            }
            else
            {
                // 全体に適用
                Font currentFont = richTextBox1.Font;
                float newSize = Math.Max(6, currentFont.Size + sizeChange);
                richTextBox1.Font = new Font(currentFont.FontFamily, newSize, currentFont.Style);
            }
        }

        // フォントサイズを標準にリセットする
        private void SetDefaultFontSize()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                // 選択範囲の文字ごとに処理
                int selectionStart = richTextBox1.SelectionStart;
                int selectionLength = richTextBox1.SelectionLength;
                for (int i = selectionStart; i < selectionStart + selectionLength; i++)
                {
                    richTextBox1.Select(i, 1);
                    Font currentFont = richTextBox1.SelectionFont ?? richTextBox1.Font;
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, 12, currentFont.Style); // デフォルトサイズ12pt
                }
                richTextBox1.Select(selectionStart, selectionLength); // 選択範囲を復元
            }
            else
            {
                // 全体に適用
                Font currentFont = richTextBox1.Font;
                richTextBox1.Font = new Font(currentFont.FontFamily, 12, currentFont.Style);
            }
        }
    }
}
