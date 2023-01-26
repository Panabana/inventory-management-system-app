using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class Utility
    {
        // Input which label you want to change the text for. Successful messages are black.
        public void labelMessageSuccess(Label chosenLabel,string textInput)
        {
            chosenLabel.Text = (textInput);
            chosenLabel.ForeColor = Color.Black;
            chosenLabel.Visible = true;
        }

        // Input which label you want to change the text for. Successful messages are red.
        public void labelMessageFailure(Label chosenLabel, string textInput)
        {
            chosenLabel.Text = (textInput);
            chosenLabel.ForeColor = Color.Red;
            chosenLabel.Visible = true;
        }
    }
}
