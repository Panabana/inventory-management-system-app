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
        public void labelMessageSuccess(Label chosenLabel,string textInput)
        {
            chosenLabel.Text = (textInput);
            chosenLabel.ForeColor = Color.Black;
            chosenLabel.Visible = true;
        }

        // Outputs a message for failed user input. Parameters are which label you want to change to what text. Failure messages become red.
        public void labelMessageFailure(Label chosenLabel, string textInput)
        {
            chosenLabel.Text = (textInput);
            chosenLabel.ForeColor = Color.Red;
            chosenLabel.Visible = true;
        }
    }
}
