using swf_MainForm.Classes;
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

namespace swf_MainForm
{
    public partial class StudyForm : Form
    {
        private string fileName;

        private int randomNum = 0;
        private int cardsStudied = -1;

        private List<StudyCard> currentStudyDeck = new List<StudyCard>();
        private List<StudyCard> studiedCards = new List<StudyCard>();

        private int deckSize = 0;
        private int cardsCorrect = 0;

        public StudyForm(string fileName)
        {
            InitializeComponent();
            this.fileName = fileName;
        }
        private void NextCard()
        {
            pnlCardDisplay.Controls.Clear();
            try
            {
                if(currentStudyDeck.Count != 0)
                {
                    randomNum = StudyCard.random.Next(0, currentStudyDeck.Count);
                    pnlCardDisplay.Controls.Add(currentStudyDeck[randomNum]);

                    studiedCards.Add(currentStudyDeck[randomNum]);
                    currentStudyDeck.RemoveAt(randomNum);
                    cardsStudied++;
                }
                else
                {
                    DisplayStats();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }
            
        }
        private void StudyForm_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string record = reader.ReadLine();
                while (record != null)
                {
                    currentStudyDeck.Add(StudyCard.FromFile(record));
                    record = reader.ReadLine();
                }
                deckSize = currentStudyDeck.Count;
                NextCard();
            }
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            EvaluationMode(false);
            NextCard();
            cardsCorrect++;
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            studiedCards[cardsStudied].ToggleAnswer();
            EvaluationMode(true);
        }

        private void btnIncorrect_Click(object sender, EventArgs e)
        {
            EvaluationMode(false);
            NextCard();
        }

        private void DisplayStats()
        {
            double correctPercentage = Math.Round(cardsCorrect / (float)deckSize * 100f, 2);
            RichTextBox rtxtCorrectPercentage = new RichTextBox();
            pnlCardDisplay.Controls.Add(rtxtCorrectPercentage);
            rtxtCorrectPercentage.Location = new Point(0,0);
            rtxtCorrectPercentage.ReadOnly = true;
            rtxtCorrectPercentage.Text = $"You got {correctPercentage}% correct.";
            rtxtCorrectPercentage.Size = new Size(pnlCardDisplay.Width, pnlCardDisplay.Height);
            rtxtCorrectPercentage.BorderStyle = BorderStyle.None;
            rtxtCorrectPercentage.Font = new Font(FontFamily.GenericSansSerif, 15f, FontStyle.Bold);
            rtxtCorrectPercentage.SelectionAlignment = HorizontalAlignment.Center;
            btnShowAnswer.Visible = false;
        }

        private void EvaluationMode(bool yes)
        {
            btnShowAnswer.Visible = !yes;
            btnCorrect.Visible = yes;
            btnIncorrect.Visible = yes;
        }
    }
}
