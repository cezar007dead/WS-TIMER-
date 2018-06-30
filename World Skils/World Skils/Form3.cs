using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_Skils
{
    
    public partial class Form3 : Form
    {
        public List<TextBox> ListCommand = new List<TextBox>();
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Pole.Time_results.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                var result = MessageBox.Show("Вы уверены что хотите закрыть окно?","", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                timer1.Enabled = false;
                this.Close();
                }
           

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
