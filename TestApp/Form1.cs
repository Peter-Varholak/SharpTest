using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        Evaluator evaluator;

        public Form1()
        {
            InitializeComponent();
            evaluator = new Evaluator();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            evaluator.CorrectAnswers = 0;
            evaluateQuestions();
            score.Text = evaluator.CorrectAnswers.ToString();
            scorePanel.Visible = true;
        }

        private void evaluateQuestions()
        {
            label1.ForeColor = evaluator.evaluateAnswer1(question1answer0.Text) ? Color.Green : Color.Red;
            label2.ForeColor = evaluator.evaluateAnswer2(getQuestion2Answers()) ? Color.Green : Color.Red;
            label3.ForeColor = evaluator.evaluateAnswer3(getQuestion3Answers()) ? Color.Green : Color.Red;
            label4.ForeColor = evaluator.evaluateAnswer4(getQuestion4Answers()) ? Color.Green : Color.Red;
            label5.ForeColor = evaluator.evaluateAnswer5(question5answer0.SelectedIndex) ? Color.Green : Color.Red;
            label6.ForeColor = evaluator.evaluateAnswer6(question6answer0.Value.ToShortDateString()) ? Color.Green : Color.Red;
        }

        private bool[] getQuestion2Answers()
        {
            bool[] answers = new bool[question2panel.Controls.Count];

            for(int i = 0; i < answers.Length; i++)
            {
                answers[i] = ((RadioButton) question2panel.Controls["question2answer" + i]).Checked;
            }

            return answers;
        }

        private bool[] getQuestion3Answers()
        {
            bool[] answers = new bool[question3panel.Controls.Count];

            for (int i = 0; i < answers.Length; i++)
            {
                answers[i] = ((CheckBox)question3panel.Controls["question3answer" + i]).Checked;
            }

            return answers;
        }

        private bool[] getQuestion4Answers()
        {
            bool[] answers = new bool[question4panel.Controls.Count];

            for (int i = 0; i < answers.Length; i++)
            {
                answers[i] = ((RadioButton)question4panel.Controls["question4answer" + i]).Checked;
            }

            return answers;
        }
    }
}
