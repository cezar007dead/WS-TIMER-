using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace World_Skils
{

    public partial class Form1 : Form
    {
        public string[] teams;
        public bool time_bool = false;
        public List<TextBox> txt = new List<TextBox>();
        public List<Label> Lab = new List<Label>();
        public int k = 0;
        int A = 1; // Не парься =) 
        string[] Mas_teams; // Масив команд 
        public int time;
        static Form3 s2;
        static Form2 s_random;
        static FullScreen fullScreen = new FullScreen();





        public Form1()
        {
            InitializeComponent();
            StreamReader Read = new StreamReader("Teams.txt");
            int j = 0;
            string Data_file;
            try
            {
                while (!Read.EndOfStream)
                {
                    Data_file = Read.ReadLine();
                    if (Data_file != "")
                    {

                        txt.Add(new TextBox());
                        Lab.Add(new Label());
                        Lab[j].Text = (j + 1).ToString();
                        Lab[j].Visible = true;
                        //txt[i].Text = "button" + i; 
                        Point p1 = new Point(40, 30 * A);
                        Point p2 = new Point(40 - 30, 30 * A);
                        //tb.Text = "ADI" + A; 
                        txt[j].Tag = j; // присваивание тега
                        Lab[j].Location = p2;
                        txt[j].Location = p1;
                        txt[j].Width = 220;
                        txt[j].KeyDown += Enter_press; // Enter press
                        Lab[j].Width = 100;
                        txt[j].Text = Data_file;
                        panel1.Controls.Add(txt[j]);
                        panel1.Controls.Add(Lab[j]);
                        A++;
                        j++;
                        k++;

                    }
                }

                textBox4_teams.Text = Convert.ToString(j);

                button2.PerformClick();
            }
            catch { }
            Read.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter Write = new StreamWriter("Teams.txt");
            for (int j = 0; j < txt.Count; j++)// Сохранине списка комнад 
            {
                Write.WriteLine(txt[j].Text);
            }
            Write.Close();


            string s = textBox1_Time.Text;

            for (int i = 0; i < s.Length; i++)// проверка ввода времени(правильно ли вводит данные пользователь) 
            {
                if (s[i] >= '0' && s[i] <= '9')// проверка ввода времени(правильно ли вводит данные пользователь) 
                {
                }
                else
                {
                    MessageBox.Show("В строке 'Время' вводить можно только числа!");
                    return;
                }
            }

            s = textBox2_Kol_polei.Text;

            for (int i = 0; i < s.Length; i++)// проверка ввода количество полей(ограничение на поля ) 
            {
                if (s[i] >= '0' && s[i] <= '9')// проверка ввода количество полей(НЕ должно быть букв) 
                {

                    if (s[i] >= '0' && s[i] <= '2')// проверка ввода количество полей(Максимум 2 поля) 
                    {
                    }
                    else
                    {
                        MessageBox.Show("Максимум полей 2!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("В строке 'Количество полей' вводить можно только числа!");
                    return;
                }


            }

            s = textBox3_Kol_zaezd.Text;

            for (int i = 0; i < s.Length; i++)// проверка ввода количество заездов
            {
                if (s[i] >= '0' && s[i] <= '9')// проверка ввода количество заездов
                {
                }
                else
                {
                    MessageBox.Show("В строку 'Количество заездов' вводить можно только числа!");
                    return;
                }

            }


            //s2.ListCommand = txt; 
            s2 = new Form3();
            s2.Show();
            fullScreen.EnterFullScreenMode(s2); // выводит на полный экран
            string[] mas_of_teams = new string[txt.Count];
            time = Convert.ToInt32(textBox1_Time.Text);//Считывание времени 


            for (int i = 0; i < txt.Count; i++)
            {
                mas_of_teams[i] = Convert.ToString(txt[i].Text);

            }
            int k = Convert.ToInt32(textBox2_Kol_polei.Text); // количество Полей 
            if (k == 1)// Если количество полей -1 
            {
                int x = Screen.PrimaryScreen.WorkingArea.Width;
                int y = Screen.PrimaryScreen.WorkingArea.Height;
                int kol_zaezdov = Convert.ToInt32(textBox3_Kol_zaezd.Text);

                Pole a = new Pole("Поле - 1", time, mas_of_teams, kol_zaezdov, x, y);
                a.Location = new System.Drawing.Point(0, 0);
                a.Width = x;
                a.Height = y;
                s2.Controls.Add(a);
            }
            if (k == 2)// Если количество полей -2 
            {
                int x = Screen.PrimaryScreen.WorkingArea.Width;
                int y = Screen.PrimaryScreen.WorkingArea.Height;
                int kol_zaezdov = Convert.ToInt32(textBox3_Kol_zaezd.Text);

                string[] P1 = new string[mas_of_teams.Length / 2 + mas_of_teams.Length % 2];
                string[] P2 = new string[mas_of_teams.Length / 2];
                for (int i = 0; i < mas_of_teams.Length; i++)
                {
                    if ((i + 1) % 2 == 0)
                    {
                        P2[i / 2] = mas_of_teams[i];
                    }
                    else
                    {
                        P1[i / 2] = mas_of_teams[i];
                    }

                }
                Pole a = new Pole("Поле - 1", time, P1, kol_zaezdov, x / 2, y);
                a.Location = new System.Drawing.Point(0, 0);
                a.Width = x / 2;
                a.Height = y;
                s2.Controls.Add(a);

                Pole b = new Pole("Поле - 2", time, P2, kol_zaezdov, x / 2, y);
                b.Location = new System.Drawing.Point(x / 2, 0);
                b.Width = x / 2;
                b.Height = y;
                s2.Controls.Add(b);
            }
            if (k == 3)// Если количество полей -3
            {
                int x = Screen.PrimaryScreen.WorkingArea.Width;
                int y = Screen.PrimaryScreen.WorkingArea.Height;


                Pole a = new Pole("Поле - 1", time, mas_of_teams, k, x, y / 3);
                a.Location = new System.Drawing.Point(0, 0);
                a.Width = x;
                a.Height = y / 3;
                s2.Controls.Add(a);

                Pole b = new Pole("Поле - 2", time, mas_of_teams, k, x, y / 3);
                b.Location = new System.Drawing.Point(0, y / 3);
                b.Width = x;
                b.Height = y / 3;
                s2.Controls.Add(b);


                Pole с = new Pole("Поле - 2", time, mas_of_teams, k, x, y / 3);
                с.Location = new System.Drawing.Point(0, y / 3 * 2);
                с.Width = x;
                с.Height = y / 3;
                s2.Controls.Add(с);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Pole a = new Pole("Pole" + 5, time); 
            //a.CommandName = ""; 
            button2.PerformClick();
        }

        private void Random_Click(object sender, EventArgs e)
        {
            /*
            Mas_teams = new string[txt.Count];
            if (txt.Count== 0)
            {
                MessageBox.Show("Введите команды");
                return;
            }
            teams = new string[txt.Count];
            for (int i = 0; i < txt.Count; i++)
            {
                teams[i] = Convert.ToString(txt[i].Text);
            }
            Form2 s_random = new Form2(teams);
            teams = new string[txt.Count];                   
            s_random.Show();
            */

        }

        private void textBox1_Time_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox3_Kol_zaezd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Kol_polei_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_teams_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int poloxenie = 40;
            string s = textBox4_teams.Text;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')// проверка ввода Количество команд(правильно ли вводит данные пользователь) 
                {
                }
                else
                {
                    MessageBox.Show("В строку 'Количество команд'  вводить можно только числа!");
                    return;
                }

            }
            int a = Convert.ToInt32(textBox4_teams.Text);
            if (a > 100)
            {
                MessageBox.Show("Максимум команд 100 !");
                return;
            }

            int n = Convert.ToInt32(textBox4_teams.Text);

            for (int i = k - 1; i > n - 1; i--)// удаление лишних textbox и label 
            {
                txt[i].Dispose();
                txt.RemoveAt(i);
                Lab[i].Dispose();
                Lab.RemoveAt(i);
                A--;
            }

            for (int i = k; i < n; i++)// создание textbox и label 
            {
                txt.Add(new TextBox());
                Lab.Add(new Label());
                Lab[i].Text = (i + 1).ToString();
                Lab[i].Visible = true;
                //txt[i].Text = "button" + i; 
                Point p1 = new Point(poloxenie, 30 * A);
                Point p2 = new Point(poloxenie - 30, 30 * A);
                //tb.Text = "ADI" + A; 
                txt[i].Tag = i; // присваивание тега
                Lab[i].Location = p2;
                txt[i].Location = p1;
                txt[i].Width = 220;
                txt[i].KeyDown += Enter_press; // Enter press
                Lab[i].Width = 100;
                panel1.Controls.Add(txt[i]);
                panel1.Controls.Add(Lab[i]);
                A++;
            }
            k = n;
        }

        private void Enter_press(object sender, KeyEventArgs e)
        {
            string ss1 = e.KeyData.ToString();
            int x;
            switch (ss1)
            {
                case "Return":
                    x = Convert.ToInt32((sender as TextBox).Tag);
                    if (x < txt.Count - 1)
                    {
                        txt[x + 1].Focus();
                    }
                    break;
                case "Up":
                    x = Convert.ToInt32((sender as TextBox).Tag);
                    if (x > 0)
                    {
                        txt[x - 1].Focus();
                    }
                    break;
                case "Down":
                    x = Convert.ToInt32((sender as TextBox).Tag);
                    if (x < txt.Count - 1)
                    {
                        txt[x + 1].Focus();
                    }
                    break;




            }
            /*
            if (e.KeyData.ToString()== "Return")
            {
                int x = Convert.ToInt32((sender as TextBox).Tag);
                if (x < txt.Count-1)
                {
                    txt[x + 1].Focus();
                }

            }
            */
            // КАК переместить курсор????+
        }

        private void jerebievka_Click(object sender, EventArgs e)
        {
            if (txt.Count == 0)
            {
                MessageBox.Show("Введите команды");
                return;
            }

            teams = new string[txt.Count];
            for (int i = 0; i < txt.Count; i++)
            {
                teams[i] = Convert.ToString(txt[i].Text);
            }
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
                txt[i].Text = teams[i];
            }
        }
    }
}