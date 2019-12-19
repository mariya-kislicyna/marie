namespace SmartParkingUserGUI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тестыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьТестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьЗановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbHeader = new System.Windows.Forms.GroupBox();
            this.lblDurationText2 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDurationText = new System.Windows.Forms.Label();
            this.lblUserFIO = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTestName = new System.Windows.Forms.Label();
            this.lblLoadTest = new System.Windows.Forms.Label();
            this.pgbProgress = new System.Windows.Forms.ProgressBar();
            this.lblQuestionNumbers = new System.Windows.Forms.Label();
            this.lblQuestionsText = new System.Windows.Forms.Label();
            this.grbQuestions = new System.Windows.Forms.GroupBox();
            this.chkVariants = new System.Windows.Forms.CheckedListBox();
            this.lblQuestHeader = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnPredQuest = new System.Windows.Forms.Button();
            this.btnEndTest = new System.Windows.Forms.Button();
            this.btnPredNotAnswer = new System.Windows.Forms.Button();
            this.btnNextNotAnswer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grbHeader.SuspendLayout();
            this.grbQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // тестыToolStripMenuItem
            // 
            this.тестыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьТестToolStripMenuItem,
            this.начатьЗановоToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходИзПрограммыToolStripMenuItem});
            this.тестыToolStripMenuItem.Name = "тестыToolStripMenuItem";
            this.тестыToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.тестыToolStripMenuItem.Text = "Тесты";
            // 
            // загрузитьТестToolStripMenuItem
            // 
            this.загрузитьТестToolStripMenuItem.Name = "загрузитьТестToolStripMenuItem";
            this.загрузитьТестToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.загрузитьТестToolStripMenuItem.Text = "Загрузить тест";
            this.загрузитьТестToolStripMenuItem.Click += new System.EventHandler(this.загрузитьТестToolStripMenuItem_Click);
            // 
            // начатьЗановоToolStripMenuItem
            // 
            this.начатьЗановоToolStripMenuItem.Name = "начатьЗановоToolStripMenuItem";
            this.начатьЗановоToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.начатьЗановоToolStripMenuItem.Text = "Начать заново";
            this.начатьЗановоToolStripMenuItem.Click += new System.EventHandler(this.начатьЗановоToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 6);
            // 
            // выходИзПрограммыToolStripMenuItem
            // 
            this.выходИзПрограммыToolStripMenuItem.Name = "выходИзПрограммыToolStripMenuItem";
            this.выходИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.выходИзПрограммыToolStripMenuItem.Text = "Выход из программы";
            this.выходИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.выходИзПрограммыToolStripMenuItem_Click);
            // 
            // grbHeader
            // 
            this.grbHeader.Controls.Add(this.lblDurationText2);
            this.grbHeader.Controls.Add(this.lblDuration);
            this.grbHeader.Controls.Add(this.lblDurationText);
            this.grbHeader.Controls.Add(this.lblUserFIO);
            this.grbHeader.Controls.Add(this.lblUser);
            this.grbHeader.Controls.Add(this.lblTestName);
            this.grbHeader.Location = new System.Drawing.Point(12, 27);
            this.grbHeader.Name = "grbHeader";
            this.grbHeader.Size = new System.Drawing.Size(776, 99);
            this.grbHeader.TabIndex = 1;
            this.grbHeader.TabStop = false;
            // 
            // lblDurationText2
            // 
            this.lblDurationText2.AutoSize = true;
            this.lblDurationText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDurationText2.Location = new System.Drawing.Point(144, 73);
            this.lblDurationText2.Name = "lblDurationText2";
            this.lblDurationText2.Size = new System.Drawing.Size(37, 17);
            this.lblDurationText2.TabIndex = 10;
            this.lblDurationText2.Text = "мин.";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDuration.Location = new System.Drawing.Point(115, 73);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(26, 17);
            this.lblDuration.TabIndex = 9;
            this.lblDuration.Text = "90";
            // 
            // lblDurationText
            // 
            this.lblDurationText.AutoSize = true;
            this.lblDurationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDurationText.Location = new System.Drawing.Point(9, 73);
            this.lblDurationText.Name = "lblDurationText";
            this.lblDurationText.Size = new System.Drawing.Size(102, 17);
            this.lblDurationText.TabIndex = 8;
            this.lblDurationText.Text = "Длительность";
            // 
            // lblUserFIO
            // 
            this.lblUserFIO.AutoSize = true;
            this.lblUserFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserFIO.Location = new System.Drawing.Point(116, 50);
            this.lblUserFIO.Name = "lblUserFIO";
            this.lblUserFIO.Size = new System.Drawing.Size(221, 17);
            this.lblUserFIO.TabIndex = 2;
            this.lblUserFIO.Text = "Михалков Никита Сергеевич";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.Location = new System.Drawing.Point(9, 50);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(97, 17);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Тестируемый";
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestName.Location = new System.Drawing.Point(6, 16);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(393, 26);
            this.lblTestName.TabIndex = 0;
            this.lblTestName.Text = "Тест на знание английского языка";
            // 
            // lblLoadTest
            // 
            this.lblLoadTest.AutoSize = true;
            this.lblLoadTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoadTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLoadTest.Location = new System.Drawing.Point(195, 28);
            this.lblLoadTest.Name = "lblLoadTest";
            this.lblLoadTest.Size = new System.Drawing.Size(385, 26);
            this.lblLoadTest.TabIndex = 11;
            this.lblLoadTest.Text = "Загрузите тест при помощи меню";
            // 
            // pgbProgress
            // 
            this.pgbProgress.Location = new System.Drawing.Point(6, 244);
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(764, 10);
            this.pgbProgress.TabIndex = 5;
            this.pgbProgress.Value = 12;
            // 
            // lblQuestionNumbers
            // 
            this.lblQuestionNumbers.AutoSize = true;
            this.lblQuestionNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionNumbers.Location = new System.Drawing.Point(313, 404);
            this.lblQuestionNumbers.Name = "lblQuestionNumbers";
            this.lblQuestionNumbers.Size = new System.Drawing.Size(61, 24);
            this.lblQuestionNumbers.TabIndex = 4;
            this.lblQuestionNumbers.Text = "5 / 45";
            // 
            // lblQuestionsText
            // 
            this.lblQuestionsText.AutoSize = true;
            this.lblQuestionsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionsText.Location = new System.Drawing.Point(227, 404);
            this.lblQuestionsText.Name = "lblQuestionsText";
            this.lblQuestionsText.Size = new System.Drawing.Size(81, 24);
            this.lblQuestionsText.TabIndex = 3;
            this.lblQuestionsText.Text = "Вопрос:";
            // 
            // grbQuestions
            // 
            this.grbQuestions.Controls.Add(this.lblLoadTest);
            this.grbQuestions.Controls.Add(this.chkVariants);
            this.grbQuestions.Controls.Add(this.lblQuestHeader);
            this.grbQuestions.Controls.Add(this.pgbProgress);
            this.grbQuestions.Location = new System.Drawing.Point(12, 132);
            this.grbQuestions.Name = "grbQuestions";
            this.grbQuestions.Size = new System.Drawing.Size(776, 261);
            this.grbQuestions.TabIndex = 2;
            this.grbQuestions.TabStop = false;
            this.grbQuestions.Text = "Вопросы теста";
            // 
            // chkVariants
            // 
            this.chkVariants.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkVariants.FormattingEnabled = true;
            this.chkVariants.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkVariants.Items.AddRange(new object[] {
            "пвпвапвапва",
            "апвапавпва",
            "прапрапрапрап"});
            this.chkVariants.Location = new System.Drawing.Point(11, 66);
            this.chkVariants.Name = "chkVariants";
            this.chkVariants.Size = new System.Drawing.Size(750, 172);
            this.chkVariants.TabIndex = 12;
            this.chkVariants.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkVariants_ItemCheck);
            // 
            // lblQuestHeader
            // 
            this.lblQuestHeader.AutoSize = true;
            this.lblQuestHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestHeader.Location = new System.Drawing.Point(22, 28);
            this.lblQuestHeader.Name = "lblQuestHeader";
            this.lblQuestHeader.Size = new System.Drawing.Size(352, 24);
            this.lblQuestHeader.TabIndex = 11;
            this.lblQuestHeader.Text = "1. ___________________your name?";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNextQuestion.Location = new System.Drawing.Point(452, 399);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(124, 34);
            this.btnNextQuestion.TabIndex = 14;
            this.btnNextQuestion.Text = "Следующий";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnPredQuest
            // 
            this.btnPredQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPredQuest.Location = new System.Drawing.Point(29, 399);
            this.btnPredQuest.Name = "btnPredQuest";
            this.btnPredQuest.Size = new System.Drawing.Size(124, 34);
            this.btnPredQuest.TabIndex = 13;
            this.btnPredQuest.Text = "Предыдущий";
            this.btnPredQuest.UseVisualStyleBackColor = true;
            this.btnPredQuest.Click += new System.EventHandler(this.btnPredQuest_Click);
            // 
            // btnEndTest
            // 
            this.btnEndTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndTest.Location = new System.Drawing.Point(625, 399);
            this.btnEndTest.Name = "btnEndTest";
            this.btnEndTest.Size = new System.Drawing.Size(157, 34);
            this.btnEndTest.TabIndex = 11;
            this.btnEndTest.Text = "Завершить тест";
            this.btnEndTest.UseVisualStyleBackColor = true;
            this.btnEndTest.Click += new System.EventHandler(this.btnEndTest_Click);
            // 
            // btnPredNotAnswer
            // 
            this.btnPredNotAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPredNotAnswer.Location = new System.Drawing.Point(159, 399);
            this.btnPredNotAnswer.Name = "btnPredNotAnswer";
            this.btnPredNotAnswer.Size = new System.Drawing.Size(57, 34);
            this.btnPredNotAnswer.TabIndex = 15;
            this.btnPredNotAnswer.Text = "<<";
            this.btnPredNotAnswer.UseVisualStyleBackColor = true;
            this.btnPredNotAnswer.Click += new System.EventHandler(this.btnPredNotAnswer_Click);
            // 
            // btnNextNotAnswer
            // 
            this.btnNextNotAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNextNotAnswer.Location = new System.Drawing.Point(389, 399);
            this.btnNextNotAnswer.Name = "btnNextNotAnswer";
            this.btnNextNotAnswer.Size = new System.Drawing.Size(57, 34);
            this.btnNextNotAnswer.TabIndex = 16;
            this.btnNextNotAnswer.Text = ">>";
            this.btnNextNotAnswer.UseVisualStyleBackColor = true;
            this.btnNextNotAnswer.Click += new System.EventHandler(this.btnNextNotAnswer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.btnEndTest);
            this.Controls.Add(this.btnNextNotAnswer);
            this.Controls.Add(this.btnPredNotAnswer);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnPredQuest);
            this.Controls.Add(this.grbQuestions);
            this.Controls.Add(this.grbHeader);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblQuestionNumbers);
            this.Controls.Add(this.lblQuestionsText);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 484);
            this.MinimumSize = new System.Drawing.Size(816, 484);
            this.Name = "frmMain";
            this.Text = "Приложение: ТЕСТЫ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbHeader.ResumeLayout(false);
            this.grbHeader.PerformLayout();
            this.grbQuestions.ResumeLayout(false);
            this.grbQuestions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тестыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьТестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьЗановоToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходИзПрограммыToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbHeader;
        private System.Windows.Forms.ProgressBar pgbProgress;
        private System.Windows.Forms.Label lblQuestionNumbers;
        private System.Windows.Forms.Label lblQuestionsText;
        private System.Windows.Forms.Label lblUserFIO;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label lblDurationText2;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDurationText;
        private System.Windows.Forms.GroupBox grbQuestions;
        private System.Windows.Forms.CheckedListBox chkVariants;
        private System.Windows.Forms.Label lblQuestHeader;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnPredQuest;
        private System.Windows.Forms.Label lblLoadTest;
        private System.Windows.Forms.Button btnEndTest;
        private System.Windows.Forms.Button btnPredNotAnswer;
        private System.Windows.Forms.Button btnNextNotAnswer;
    }
}