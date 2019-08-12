using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeterninantTest
{
    //Не использовано
    public partial class InputDataForm : Form
    {
        public InputDataForm()
        {
            InitializeComponent();
        }

        private void InputDataForm_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            StaticData.Dimension = Convert.ToInt32(dimNumericUpDown.Value);
            Close();
        }
    }
}
