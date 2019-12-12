using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swf_MainForm
{
    enum HelpScreens
    {
        GeneralHelpScreen,
        CreateEditOne,
        StudyOne,
        StudyTwo
    }
    public partial class HelpForm : Form
    {
        HelpScreens selectedScreen = HelpScreens.GeneralHelpScreen;
        public HelpForm()
        {
            InitializeComponent();
            UpdateHelpScreen();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int newIndexOfSelectedScreen = (int)selectedScreen + 1;
            if (newIndexOfSelectedScreen >= Enum.GetValues(typeof(HelpScreens)).Length)
            {
                if (MessageBox.Show("Are you ready to start studying?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Close();
                    return;
                }
                else
                {
                    newIndexOfSelectedScreen = 0;
                    UpdateHelpScreen();
                }
            }
            selectedScreen = (HelpScreens)newIndexOfSelectedScreen;
            UpdateHelpScreen();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int newIndexOfSelectedScreen = (int)selectedScreen - 1;
            if (newIndexOfSelectedScreen <= -1)
            {
                newIndexOfSelectedScreen = Enum.GetValues(typeof(HelpScreens)).Length - 1;
            }
            selectedScreen = (HelpScreens)newIndexOfSelectedScreen;
            UpdateHelpScreen();
        }

        private void UpdateHelpScreen()
        {
            switch (selectedScreen)
            {
                case HelpScreens.GeneralHelpScreen:
                    pboxHelpDisplay.Image = Properties.Resources.GeneralHelp;
                    break;
                case HelpScreens.CreateEditOne:
                    pboxHelpDisplay.Image = Properties.Resources.CreateHelp;
                    break;
                case HelpScreens.StudyOne:
                    pboxHelpDisplay.Image = Properties.Resources.StudyHelp1;
                    break;
                case HelpScreens.StudyTwo:
                    pboxHelpDisplay.Image = Properties.Resources.StudyHelp2;
                    break;
                default:
                    throw new Exception("Help screen not found.");
            }

            lblPageCounter.Text = $"{(int)selectedScreen + 1} / {Enum.GetValues(typeof(HelpScreens)).Length}";
        }

        
    }
}
