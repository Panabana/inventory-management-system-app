using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class Utility
    {
        // Outputs a message for succesful user input. Parameters are which label you want to change to what text . Successful messages become black.
        public static void LabelMessageSuccess(Label chosenLabel,string textInput)
        {
            chosenLabel.Text = (textInput);
            chosenLabel.ForeColor = Color.Black;
            chosenLabel.Visible = true;
        }

        // Outputs a message for failed user input. Parameters are which label you want to change to what text. Failure messages become red.
        public static void LabelMessageFailure(Label chosenLabel, string textInput)
        {
            chosenLabel.Text = (textInput);
            chosenLabel.ForeColor = Color.Red;
            chosenLabel.Visible = true;
        }
    }
}
