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
                textBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void 保存ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "テキストファイル(*.txt)|*.txt";
            ofd.Title = "保存";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(ofd.FileName, textBox1.Text);
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
                    System.IO.File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
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
                textBox1.Clear();
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
                        File.WriteAllText(ofd.FileName, textBox1.Text);
                    }
                }
                else if (result == DialogResult.No)
                {
                    this.textBox1.Text = string.Empty;
                    this.isSave = true;
                }
                else
                {
                    return;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // ステータスバーに文字数を表示する
            string text = string.Format("文字数 {0}", this.textBox1.Text.Length);
            this.toolStripStatusLabel1.Text = text;

            // テキストが更新されたら、未保存にする
            this.isSave = false;
        }
    }
}
