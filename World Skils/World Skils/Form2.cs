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
    public partial class Form2 : Form
    {
        string[] Mas_teams; // Масив команд 
        string[] teams;
        public List<TextBox> txt = new List<TextBox>();
        public Form2(string[] s4)
        {
            InitializeComponent();
            teams = new string[s4.Length];
            teams = s4;
            button2.Visible = false;
            Mas_teams = new string [s4.Length];

        }

        private void Form2_Load(object sender, EventArgs e)
        { 
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < teams.Length * 2; i++) // перемешиваем команды 
            {
                int a = r.Next(teams.Length);
                int b = r.Next(teams.Length);
                string c = teams[a];
                teams[a] = teams[b];
                teams[b] = c;
            }
            for (int i = 0; i < teams.Length; i++)
            {
                listBox1.Items.Add(i+1+"  "+teams[i]);
                
            }
            button1.Visible = false;
            button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < teams.Length * 2; i++) // перемешиваем команды 
            {
                int a = r.Next(teams.Length);
                int b = r.Next(teams.Length);
                string c = teams[a];
                teams[a] = teams[b];
                teams[b] = c;
            }
            listBox1.Items.Clear();
            for (int i = 0; i < teams.Length; i++)
            {
                listBox1.Items.Add(i + 1 + "  " + teams[i]);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < teams.Length; i++)
            {
                Mas_teams[i] = teams[i];
            }
            this.Close();
        }
    }
}
