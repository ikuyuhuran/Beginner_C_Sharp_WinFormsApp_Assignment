namespace Beginner_C_Sharp_WinFormsApp_Assignment
{

    /// <summary>
    /// ������^����
    /// </summary>
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

        }

        /*
         * �y�f�o�b�O�����Ă݂悤�z
         * 
         * ���̂���\�[�X�R�[�h��z�z���܂��̂ŁA������������Ă��������B
         * ���ꌩ���Ȃ������ȃR�[�h������܂�
         * 
         * �܂��A�������������Ăق������e���L�q����Ă��܂��̂ŁA��������������Ă��������B
         */

        /// <summary>
        /// �u7 + 3 = 10�v�ƕ\�����������B
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
        /// num1 �� num2 �̌��ʂ�\�����������B
        /// �G���[�Ŏ~�܂��Ăق����Ȃ��B
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

                label2.Text = "���p�����̐�������͂��Ă�������" + formatException.Message;

            }
            catch (OverflowException overflowException)
            {

                label2.Text = "���������������Ă�������" + overflowException.Message;

            }
            catch (DivideByZeroException divideByZeroException)
            {

                label2.Text = "�O�ł͊���܂���" + divideByZeroException.Message;

            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
    }

    //private void button3_Click(object sender, EventArgs e)




    /*
     * �������6�擾���A5W1h�̕��͂��쐬����v���O�����R�[�h�������Ă��������B
     * 
     * e.g.)
     * �@���́FWhen�i���j�AWhere�i�ǂ��Łj�AWho�i�N���j�AWhat�i�����j�AWhy�i�Ȃ��j�AHow�i�ǂ̂悤�Ɂj
     * �@�o�́F�u��T�A���͊w�Z����ۑ��^����ꂽ���߁A�����PC���g���Ă��̉ۑ�������������B�v
     */

    /*
     * 1�`100�̃����_���Ȑ�����2�g���A�l�����Z�̌��ʂ�\������v���O�����R�[�h�������Ă��������B
     * 
     * �����_���Ȑ����̔������@�F
     *    Random random = new Random(); �������_���I�u�W�F�N�g�𐶐�
     *    int number = random.Next(0, 10); ��0�`10�̐������Ă΂�邽�тɔ���
     * 
     * e.g.)
     * �@�o�͌��ʁF�u32 �{ 78 �� 110�v�u85 �| 24 �� 61�v�u5 �~ 61 �� 305�v�u40 �� 2 �� 20�v
     * 
     * cf.)
     * �wC#��Random�̎g�����bRandom�N���X�̋@�\�Ɨ����z��̐����x
     * https://www.fenet.jp/dotnet/column/language/8212/
     * 
     */

}

