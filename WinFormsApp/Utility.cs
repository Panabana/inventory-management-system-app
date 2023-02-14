using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WinFormsApp
{
    static class Utility
    {
        // Outputs a message for a successful user input. Parameters are which label you want to change to what text. Successful messages become black.
        public static void LabelMessageSuccess(Label chosenLabel,string textInput)
        {
            chosenLabel.Text = (textInput);
            chosenLabel.ForeColor = Color.Black;
            chosenLabel.Visible = true;
        }

        // Outputs a message for a failed user input. Parameters are which label you want to change to what text. Failure messages become red.
        public static void LabelMessageFailure(Label chosenLabel, string textInput)
        {
            chosenLabel.Text = (textInput);
            chosenLabel.ForeColor = Color.Red;
            chosenLabel.Visible = true;
        }

        //Clears all textboxes. Taken from ChatGPT.
        public static void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearTextBoxes(c);
                }
            }
        }
    }
}
