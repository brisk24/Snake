using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_videosharp.info_
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            LabelAlfa(labelStart);
            LabelAlfa(labelSettings);
            LabelAlfa(labelExit);
            LabelAlfa(labelСopyright);
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelAlfa(Label label)
        {
            var pos = this.PointToScreen(label.Location);
            pos = pictureBox.PointToClient(pos);
            label.Parent = pictureBox;
            label.Location = pos;
            label.BackColor = Color.Transparent;
        }

        private void labelStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1(this);
            form.ShowDialog();
            this.Show();
        }

        private void labelStart_MouseHover(object sender, EventArgs e)
        {
            ((Label)(sender)).BackColor = ColorTranslator.FromHtml("#e26e11");
            ((Label)(sender)).ForeColor = Color.White;
        }

        private void labelStart_MouseLeave(object sender, EventArgs e)
        {
            ((Label)(sender)).BackColor = Color.White;
            ((Label)(sender)).ForeColor = Color.Black;
        }      
    }
}
