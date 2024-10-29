using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WordPasswordGen
{
    public partial class Form1 : Form
    {
        readonly string[] symbols = new string[] { "-","+", "*", "_", "(", ")", ".", "," };
        readonly Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// フォームが開かれたら自動的に単語を読み取る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "WordPasswordGen " + Properties.Resources.version;

            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            // wordA.txt があった
            if (File.Exists(basePath + "wordA.txt"))
            {
                importTextBox(basePath + "wordA.txt", txtWordA);
            }
            // wordB.txt があった
            if (File.Exists(basePath + "wordB.txt"))
            {
                importTextBox(basePath + "wordB.txt", txtWordB);
            }
            // wordC.txt があった
            if (File.Exists(basePath + "wordC.txt"))
            {
                importTextBox(basePath + "wordC.txt", txtWordC);
            }

            // 初期値
            txtPatterns.Text = "#,Worda,a-z,Wordb,#,\r\n";
        }

        /// <summary>
        /// WordA のクリアが押されたら、WordA をクリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearWordA_Click(object sender, EventArgs e)
        {
            clearWordsA();
        }

        /// <summary>
        /// WordA のインポートが押されたら、インポートする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportWordA_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // ファイルを開く
            importTextBox(openFileDialog1.FileName, txtWordA);
        }

        /// <summary>
        /// WordB のクリアが押されたら、WordB をクリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearWordB_Click(object sender, EventArgs e)
        {
            clearWordsB();
        }

        /// <summary>
        /// WordB のインポートが押されたら、インポートする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportWordB_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            // ファイルを開く
            importTextBox(openFileDialog1.FileName, txtWordB);
        }

        /// <summary>
        /// WordC のクリアが押されたら、WordC をクリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearWordC_Click(object sender, EventArgs e)
        {
            clearWordsC();
        }

        /// <summary>
        /// WordC のインポートが押されたら、インポートする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportWordC_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            // ファイルを開く
            importTextBox(openFileDialog1.FileName, txtWordC);
        }


        /*///////////////////////////////////////////////////
         * 
         * パターンの処理
         * 
         * */

        private void btnLWordA_Click(object sender, EventArgs e)
        {
            addPattern("worda");
        }

        private void btnCWordA_Click(object sender, EventArgs e)
        {
            addPattern("Worda");
        }

        private void btnUWordA_Click(object sender, EventArgs e)
        {
            addPattern("WORDA");
        }

        private void btnInvWordA_Click(object sender, EventArgs e)
        {
            addPattern("wordA");
        }

        private void btnLWordB_Click(object sender, EventArgs e)
        {
            addPattern("wordb");
        }

        private void btnCWordB_Click(object sender, EventArgs e)
        {
            addPattern("Wordb");
        }

        private void btnUWordB_Click(object sender, EventArgs e)
        {
            addPattern("WORDB");
        }

        private void btnInvWordB_Click(object sender, EventArgs e)
        {
            addPattern("wordB");
        }

        private void btnLWordC_Click(object sender, EventArgs e)
        {
            addPattern("wordc");
        }

        private void btnCWordC_Click(object sender, EventArgs e)
        {
            addPattern("Wordc");
        }

        private void btnUWordC_Click(object sender, EventArgs e)
        {
            addPattern("WORDC");
        }

        private void btnInvWordC_Click(object sender, EventArgs e)
        {
            addPattern("wordC");
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            addPattern("#");
        }

        private void btnSymbol_Click(object sender, EventArgs e)
        {
            addPattern("sym");
        }

        private void btnNumSym_Click(object sender, EventArgs e)
        {
            addPattern("#sym");
        }


        private void btnLowAZ_Click(object sender, EventArgs e)
        {
            addPattern("a-z");
        }

        private void btnUpAZ_Click(object sender, EventArgs e)
        {
            addPattern("A-Z");
        }

        private void btnFullAZ_Click(object sender, EventArgs e)
        {
            addPattern("a-Z");
        }

        private void btnNewLine_Click(object sender, EventArgs e)
        {
            addPattern("\r\n", false);
        }

        private void btnClearPatterns_Click(object sender, EventArgs e)
        {
            clearPatterns();
        }



        /// <summary>
        /// Gen ボタンが押された
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGen_Click(object sender, EventArgs e)
        {
            generatePasswords();
        }

        /// <summary>
        /// txtPassword がダブルクリックされたら全選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_DoubleClick(object sender, EventArgs e)
        {
            selectAllPasswords();
        }

        /// <summary>
        /// txtPassword を全選択
        /// </summary>
        private void selectAllPasswords()
        {
            txtPassword.SelectAll();
        }
        
        /// <summary>
        /// txtWordA をクリアする
        /// </summary>
        private void clearWordsA()
        {
            txtWordA.Text = "";
        }

        /// <summary>
        /// txtWordB をクリアする
        /// </summary>
        private void clearWordsB()
        {
            txtWordB.Text = "";
        }

        /// <summary>
        /// txtWordC をクリアする
        /// </summary>
        private void clearWordsC()
        {
            txtWordC.Text = "";
        }

        /// <summary>
        /// txtPattern に追加する
        /// </summary>
        /// <param name="str"></param>
        private void addPattern(string str, bool addComma = true)
        {
            if (addComma)
            {
                txtPatterns.Text += str + ",";
            }
            else
            {
                txtPatterns.Text += str;
            }
            // フォーカス
            txtPatterns.Select(txtPatterns.Text.Length, 0);
            txtPatterns.Focus();
        }

        /// <summary>
        /// txtPatterns をクリアする
        /// </summary>
        private void clearPatterns()
        {
            txtPatterns.Text = "";
        }


        /// <summary>
        /// パスワードの生成数を取得する
        /// </summary>
        /// <returns></returns>
        private int getPasswordsNum()
        {
            if (int.TryParse(txtNum.Text, out int num))
            {
                return num;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// WordA から単語リストを作る
        /// </summary>
        /// <returns></returns>
        private List<string> getWordAList()
        {
            return getWordList(txtWordA.Text);
        }

        /// <summary>
        /// WordB から単語リストを作る
        /// </summary>
        /// <returns></returns>
        private List<string> getWordBList()
        {
            return getWordList(txtWordB.Text);
        }

        /// <summary>
        /// WordC から単語リストを作る
        /// </summary>
        /// <returns></returns>
        private List<string> getWordCList()
        {
            return getWordList(txtWordC.Text);
        }

        /// <summary>
        /// 文字列の改行で分割し、リストを作る
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private List<string> getWordList(string s)
        {
            var sep = new char[] { '\n', '\r' };
            var str = s.Split(sep);

            var ret = new List<string>();
            foreach (string v in str)
            {
                string tv = v.Trim();
                if (tv.Length >= 1)
                {
                    ret.Add(tv);
                }
            }
            return ret;
        }

        /// <summary>
        /// パスワードのパターンを取得する
        /// </summary>
        /// <returns></returns>
        private List<string> getPasswordPatterns()
        {
            var sep = new char[] { '\n', '\r' };
            return txtPatterns.Text.Split(sep).ToList<string>();
        }

        /// <summary>
        /// パスワードを生成する
        /// </summary>
        private void generatePasswords()
        {
            // パスワードの数を確認
            int num = getPasswordsNum();
            if (num <= 0)
            {
                MessageBox.Show("パスワードの数が不正です。");
                return;
            }

            // WordA
            var wa = getWordAList();
            if (wa.Count < 1)
            {
                MessageBox.Show("WordA がないです。");
                return;
            }

            // WordB
            var wb = getWordBList();
            if (wb.Count< 1)
            {
                MessageBox.Show("WordB がないです。");
                return;
            }

            // WordC
            var wc = getWordCList();
            if (wc.Count< 1)
            {
                MessageBox.Show("WordC がないです。");
                return;
            }

            // パスワードのパターンを取得
            var ptn = getPasswordPatterns();
            if (ptn.Count == 0)
            {
                MessageBox.Show("パスワードのパターンが指定されていないです。");
                return;
            }

            // 最大文字数・最小文字数
            if (!int.TryParse(txtWordMax.Text, out int max))
            {
                max = 1000;
            }
            if (!int.TryParse(txtWordMin.Text, out int min))
            {
                min = 1;
            }

            var pass = genPass(wa, wb, wc,  num, ptn, min , max);

            string adder = "";
            foreach(string v in pass)
            {
                adder += v + "\r\n";
            }
            txtPassword.Text = adder.Trim();
        }

        /// <summary>
        /// 受け取ったリストからパスワードを生成する
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        private List<string> genPass(List<string> a, List<string> b, List<string> c, int num, List<string> patterns, int min, int max)
        {
            int patternSize = patterns.Count;

            int fail = 0;

            var ret = new List<string>();
            for (int i = 0; i < num; i++)
            {
                // 生成パターンを決める
                string ptn = patterns[rnd.Next(patternSize)];

                string newPass = createNewPass(a, b, c, ptn);

                int len = newPass.Length;
                if (len >= min && len <= max)
                {
                    fail = 0;
                    ret.Add(newPass);
                }
                else
                {
                    // もう一回作り直させる
                    fail++;
                    i--;

                    if (fail > 1000)
                    {
                        MessageBox.Show("なんかパスワード作るの無理な気がする。");
                        break;
                    }
                }
            }

            return ret;
        }

        /// <summary>
        /// 1 個パスワードを作る
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="ptn"></param>
        /// <returns></returns>
        private string createNewPass(List<string> a, List<string> b, List<string> c, string ptn)
        {
            int symSize = symbols.Length;

            string r = "";
            var p = ptn.Split(new char[] { ',' });

            foreach(string tp in p)
            {
                string t = "";
                switch (tp)
                {
                    case "worda":
                        t = pickOneWord(a);
                        break;

                    case "Worda":
                        t = dropCap(pickOneWord(a));
                        break;

                    case "WORDA":
                        t = pickOneWord(a).ToUpper();
                        break;

                    case "wordA":
                        t = lastCap(pickOneWord(a));
                        break;

                    case "wordb":
                        t = pickOneWord(b);
                        break;

                    case "Wordb":
                        t = dropCap(pickOneWord(b));
                        break;

                    case "WORDB":
                        t = pickOneWord(b).ToUpper();
                        break;

                    case "wordB":
                        t = lastCap(pickOneWord(b));
                        break;

                    case "wordc":
                        t = pickOneWord(c);
                        break;

                    case "Wordc":
                        t = dropCap(pickOneWord(c));
                        break;

                    case "WORDC":
                        t = pickOneWord(c).ToUpper();
                        break;

                    case "wordC":
                        t = lastCap(pickOneWord(c));
                        break;

                    case "#":
                        t = rnd.Next(10).ToString();
                        break;

                    case "sym":
                        t = symbols[rnd.Next(symSize)];
                        break;

                    case "#sym":
                        int idx = rnd.Next(symSize + 10);
                        if (idx < 10)
                        {
                            t = idx.ToString();
                        }
                        else
                        {
                            t = symbols[idx - 10];
                        }
                        break;

                    case "a-z":
                        t = ((char)rnd.Next(97, 123)).ToString();
                        break;

                    case "A-Z":
                        t = ((char)rnd.Next(65, 91)).ToString();
                        break;

                    case "a-Z":
                        t = (rnd.Next(2) == 0) ? ((char)rnd.Next(97, 123)).ToString() : ((char)rnd.Next(65, 91)).ToString();
                        break;

                    default:
                        break;
                }
                r += t;
            }
            return r;
        }

        /// <summary>
        /// リストから 1 つ単語を選ぶ
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        private string pickOneWord(List<string> lst)
        {
            return lst[rnd.Next(lst.Count)].ToLower();
        }

        /// <summary>
        /// 1 文字目を大文字にする
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string dropCap(string s)
        {
            return s.Substring(0, 1).ToUpper() + s.Substring(1);
        }

        /// <summary>
        /// 最後の文字を大文字にする
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string lastCap(string s)
        {
            int size = s.Length;
            return s.Substring(0, size - 1) + s.Substring(size - 1, 1).ToUpper();
        }

        /// <summary>
        /// 指定した textbox にファイルを入れる
        /// </summary>
        /// <param name="fn"></param>
        /// <param name="txt"></param>
        private void importTextBox(string fn, TextBox txt)
        {
            // ファイルを開く
            using (var sr = new StreamReader(fn, Encoding.GetEncoding("Shift_JIS")))
            {
                string newString = sr.ReadToEnd();
                txt.Text = newString;
            }
        }
    }
}
