using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntArrayToHexArray
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string input = textBoxInput.Text;

            if (!String.IsNullOrEmpty(input)) {
                var selectedIds = input.Split(',').ToArray()
                            .Where(i => !string.IsNullOrWhiteSpace(i)
                             && int.TryParse(i, out int validNumber))
                            .Select(x => int.Parse(x).ToString("X")).ToList();

                textBoxOutput.Text = string.Join(", ", selectedIds);
            }
        }
    }
}
