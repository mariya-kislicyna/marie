using AppTests;
using AppTests.ModelsGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartParkingUserGUI
{
    public partial class frmMain : Form
    {
        private User _user;     // текущий пользователь
        private Test curTest { get; set; }      // текущий тест
        private int curQNumber { get; set; }    // текущий номер вопроса

        public frmMain(User user)       // конструктор класса
        {
            InitializeComponent();
            _user = user;
            Text = $"Приложение: ТЕСТЫ - {_user.FIO}";
            chkVariants.CheckOnClick = true;

            refreshHeader();        // обновляем все данные на форме
            refreshProgress();
            refreshQuestion();
        }

        private void refreshHeader()    // обновление данных заголовка
        {
            lblUserFIO.Text = _user.FIO;
            if (curTest == null)        // если тест не загружен
            {
                lblTestName.Text = "Приложение: \"ТЕСТЫ\"";
                lblDuration.Visible = lblDurationText.Visible
                    = lblDurationText2.Visible = false;
            }
            else    // если тест загружен
            {
                // делаем видимыми все элементы в заголовке
                foreach (Control ctr in grbHeader.Controls) ctr.Visible = true;
                lblTestName.Text = curTest.Name;
                lblDuration.Text = curTest.Duration.ToString();
            }
        }

        private void refreshProgress()  // обновление полоски прогресса
        {
            if (curTest == null)    // если тест не загружен
                pgbProgress.Visible = false;    // вообще скрываем полоску
            else        // если тест загружен
            {
                pgbProgress.Visible = true; // делаем полоску видимой
                int qNumber = curTest.Questions.Count();
                int qAnswer = curTest.Questions.Count(t => t.IsAnswer == true);
                // рассчитываем и устанавливаем проценты в ней
                pgbProgress.Value = (qAnswer * 100) / qNumber;
            }
        }

        private void refreshQuestion()  // обновление области вопроса
        {
            if (curTest == null)    // если тест не загружен
            {
                // все скрываем
                lblQuestionsText.Visible = lblQuestionNumbers.Visible 
                    = chkVariants.Visible = lblQuestHeader.Visible = false;
                // но показываем красную надпись "загрузите тест"
                lblLoadTest.Visible = true;                 
            }
            else    // если тест загружен
            {
                // все показываем
                lblQuestionsText.Visible = lblQuestionNumbers.Visible 
                    = chkVariants.Visible = lblQuestHeader.Visible = true;
                var q = curTest.Questions[curQNumber];  // получаем вопрос из теста
                lblQuestHeader.Text = q.Text;
                // очищаем, а затем заново выводим варианты из этого вопроса
                //chkVariants.ItemCheck -= chkVariants_ItemCheck;               
                chkVariants.Items.Clear();  
                chkVariants.Items.AddRange(q.Variants.ToArray());
                //chkVariants.ItemCheck += chkVariants_ItemCheck;
                lblQuestionNumbers.Text     // выводим текст вида "вопрос N/M"
                    = $"{curQNumber + 1}/{curTest.Questions.Count}";
                if (q.IsAnswer) // если на этот вопрос уже ответили
                {
                    int n = q.AnswerNum;    // устанавливаем галку на ответе
                    if (n >= 0) chkVariants.SetItemChecked(n, true);
                }
                lblLoadTest.Visible = false;
            }
        }

        private void загрузитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                curTest = TestsManager.GetTest(ofd.FileName);
                curQNumber = 0;
                refreshHeader();
                refreshProgress();
                refreshQuestion();
            }
        }

        private void начатьЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Question q in curTest.Questions) q.ResetAnswer();
            curQNumber = 0;
            refreshProgress();
            refreshQuestion();
        }

        private void btnPredQuest_Click(object sender, EventArgs e)
        {
            if (curQNumber > 0)
            {
                curQNumber--;
                refreshQuestion();
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (curQNumber < curTest.Questions.Count - 1)
            {
                curQNumber++;
                refreshQuestion();
            }
        }

        private void btnEndTest_Click(object sender, EventArgs e)
        {
            int balls = curTest.Questions.Sum(a => a.Balls);
            var t = curTest.GetResult(balls);
            MessageBox.Show($"{t.Status}\n{t.StatusInfo}");
        }

        private void chkVariants_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // код ниже снимает все галочки, кроме той, которую сейчас щелкнули
            var list = sender as CheckedListBox;
            if (e.NewValue == CheckState.Checked)
                foreach (int index in list.CheckedIndices)
                    if (index != e.Index)
                        list.SetItemChecked(index, false);

            var q = curTest.Questions[curQNumber];  // получаем вопрос
            q.Answer(e.Index); // отвечаем на вопрос
            refreshProgress();
        }

        private void btnPredNotAnswer_Click(object sender, EventArgs e)
        {
            if (curQNumber > 0)
                for (int i = curQNumber; i >= 0; i--)
                    if (!curTest.Questions[i].IsAnswer)
                    {
                        curQNumber = i;
                        refreshQuestion();
                        return;
                    }
        }

        private void btnNextNotAnswer_Click(object sender, EventArgs e)
        {
            if (curQNumber < curTest.Questions.Count - 1)
                for (int i = curQNumber; i < curTest.Questions.Count; i++)
                    if (!curTest.Questions[i].IsAnswer)
                    {
                        curQNumber = i;
                        refreshQuestion();
                        return;
                    }
        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
