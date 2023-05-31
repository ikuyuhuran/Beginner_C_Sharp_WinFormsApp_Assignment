namespace Beginner_C_Sharp_WinFormsApp_Assignment
{

    /// <summary>
    /// 題解決型授業
    /// </summary>
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

        }

        /*
         * 【デバッグをしてみよう】
         * 
         * 問題のあるソースコードを配布しますので、これを解決してください。
         * ※一見問題なさそうなコードもあります
         * 
         * また、いくつか実装してほしい内容も記述されていますので、こちらも解決してください。
         */

        /// <summary>
        /// 「7 + 3 = 10」と表示させたい。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            int num1 = 7;
            int num2 = 3;
            int num3 = num1 + num2;

            label1.Text = num1 + " + " + num2 + " = " + num3;

        }

        /// <summary>
        /// num1 ÷ num2 の結果を表示させたい。
        /// エラーで止まってほしくない。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int xest = 0;

                xest = num1 / num2;

                label2.Text = "" + xest;
            }
            catch (FormatException formatException)
            {

                label2.Text = "半角数字の整数を入力してください" + formatException.Message;

            }
            catch (OverflowException overflowException)
            {

                label2.Text = "数字を小さくしてください" + overflowException.Message;

            }
            catch (DivideByZeroException divideByZeroException)
            {

                label2.Text = "０では割れません" + divideByZeroException.Message;

            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
    }

    //private void button3_Click(object sender, EventArgs e)




    /*
     * 文字列を6つ取得し、5W1hの文章を作成するプログラムコードを書いてください。
     * 
     * e.g.)
     * 　入力：When（いつ）、Where（どこで）、Who（誰が）、What（何を）、Why（なぜ）、How（どのように）
     * 　出力：「先週、私は学校から課題を与えられたため、自宅でPCを使ってその課題を完成させた。」
     */

    /*
     * 1～100のランダムな整数を2つ使い、四則演算の結果を表示するプログラムコードを書いてください。
     * 
     * ランダムな整数の発生方法：
     *    Random random = new Random(); ←ランダムオブジェクトを生成
     *    int number = random.Next(0, 10); ←0～10の整数が呼ばれるたびに発生
     * 
     * e.g.)
     * 　出力結果：「32 ＋ 78 ＝ 110」「85 － 24 ＝ 61」「5 × 61 ＝ 305」「40 ÷ 2 ＝ 20」
     * 
     * cf.)
     * 『C#のRandomの使い方｜Randomクラスの機能と乱数配列の生成』
     * https://www.fenet.jp/dotnet/column/language/8212/
     * 
     */

}

