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
    public partial class ModifyForm : Form
    {
        List<StudyCard> cardsToSave = new List<StudyCard>();
        StudyCard selectedCard;
        
        public ModifyForm()
        {
            InitializeComponent();
        }

        private bool ValidateInput()
        {
            if (rtxtEditQuestion.Text != "")
            {
                if (rtxtEditAnswer.Text != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Answer can not be empty.");
                    rtxtEditAnswer.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Question can not be empty.");
                rtxtEditQuestion.Focus();
                return false;
            }
        }

        /// <summary>
        /// Either adds or updates a card to the deck
        /// </summary>
        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            //if there is no card selected we are adding a card
            if(selectedCard == null)
            {
                if(ValidateInput())
                {
                    cardsToSave.Add(new StudyCard(rtxtEditQuestion.Text, rtxtEditAnswer.Text));
                    UpdateCardDisplayList();
                }
            }
            //if there is a card selected we will be replacing it with a new card
            else
            {
                if (ValidateInput())
                {
                        cardsToSave[lstCardDisplay.SelectedIndex] = new StudyCard(rtxtEditQuestion.Text, rtxtEditAnswer.Text);
                        UpdateCardDisplayList();
                }
            }
        }

        /// <summary>
        /// Updates the current cards in the deck to the list on the right
        /// </summary>
        private void UpdateCardDisplayList()
        {
            List<string> listDisplay = new List<string>();
            foreach (StudyCard card in cardsToSave)
            {
                listDisplay.Add($"{card.CardQuestionSide} | {card.CardAnswerSide}");
            }
            lstCardDisplay.DataSource = null;
            lstCardDisplay.DataSource = listDisplay;
            selectedCard = null;
            lstCardDisplay.SelectedIndex = -1;
        }

        /// <summary>
        /// Saves the deck to file and returns to the main menu
        /// </summary>
        private void btnSaveReturn_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {
                cardsToSave.Add(new StudyCard(rtxtEditQuestion.Text, rtxtEditAnswer.Text));
                SaveToFile();
            }
        }

        private void btnQuitNoSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to return to the menu?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        /// <summary>
        /// Used To Save the data to file
        /// </summary>
        private void SaveToFile()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "txt (*.txt)|*.txt";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveDialog.FileName;
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (StudyCard card in cardsToSave)
                    {
                        writer.WriteLine(card.ToFile());
                    }
                }
                MessageBox.Show("Save successful.");
                Close();
            }
            else
            {
                MessageBox.Show("Please select a save location.");
            }
        }

        /// <summary>
        /// opens a deck file and loads onto list
        /// </summary>
        private void OpenFile()
        {
            cardsToSave.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string record = reader.ReadLine();
                    while(record != null)
                    {
                        cardsToSave.Add(StudyCard.FromFile(record));
                        record = reader.ReadLine();
                    }
                }
                MessageBox.Show("File Opened.");
                UpdateCardDisplayList();
            }
            else
            {
                MessageBox.Show("Please select a file.");
            }
        }

        /// <summary>
        ///  updates the list to see all the cards in a deck
        /// </summary>
        private void lstCardDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstCardDisplay.SelectedIndex != -1)
            {
                rtxtEditQuestion.Text = cardsToSave[lstCardDisplay.SelectedIndex].CardQuestionSide;
                rtxtEditAnswer.Text = cardsToSave[lstCardDisplay.SelectedIndex].CardAnswerSide;
                selectedCard = cardsToSave[lstCardDisplay.SelectedIndex];
            }
            else
            {
                rtxtEditAnswer.Clear();
                rtxtEditQuestion.Clear();
                rtxtEditQuestion.Focus();
            }
        }

        private void openDeckToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void openDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cardsToSave.Clear();
            UpdateCardDisplayList();
        }
    }
}
