using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSTrainingApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string age = ageField.Text;
            string bday = bDayField.Text;

            var greeting = String.Format("Hello {0}. You are {1} years old. Your birthday is at {2}.", name, age, bday);

            if (name == "" || age == null || bday == null)
            {
                resultText.Text = "Hello, please enter values in the fields";
            }
            else
            {
                resultText.Text = greeting;
            }
        }
    }
}
