using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;
using System.Threading;  //Именно это пространство имен поддерживает многопоточность



namespace World_Skils
{

    class Pole : Panel
    {
        int i = 0;
        public int time;
        public int alltime;
        public bool time_bool;
        string Name = "";// имя поля 
        System.Windows.Forms.Timer t;
        System.Windows.Forms.Timer timer_lbl;           // таймер для вывода  реального времени
        Label LabelTime;           // вывод времени
        Label TEAMS;               // вывод команд
        Label NEXT_TEAM;           // вывод следующей команды 
        Label Number_pole;         // вывод номера поля 
        Label disain_up; // верх 
        Label disain_down; // низ 
        Label disain_left; // лево 
        Label disain_right; // право
        Button p; //кнопка паузы

        public string[] mas_teams;
        int zaezdov;
        Label Realtime;
        int k; // количество заездов
        public static StreamWriter Time_results;
        SpeechSynthesizer synth = new SpeechSynthesizer();// Генератор речи
        Thread myThread_1; // поток 1
        Thread myThread_2; // поток 2
        double procent;



        public void close_form()
        {


        }

        public void func_1()
        {
            synth = new SpeechSynthesizer(); //Генератор речи
            synth.SetOutputToDefaultAudioDevice(); //выбор девайса да воспроизведения звука
            synth.Speak("Время заканчивается! Приготовиться команде" + mas_teams[i + 1]);
        }

        public void func_2()
        {
            synth = new SpeechSynthesizer(); //Генератор речи
            synth.SetOutputToDefaultAudioDevice(); //выбор девайса да воспроизведения звука
            synth.Speak("Время истекло! Cмените команду ");
        }
        private void Pause(object sender, EventArgs e)
        {
            if (p.Text == "Пауза")
            {
                t.Enabled = false;
                p.Text = "Продолжить";
            }
            else
            {
                t.Enabled = true;
                p.Text = "Пауза";
            }
 
        }

        public Pole(string p1, int time_podacha, string[] mas, int kol_zaezdov, int x_form, int y_form)
        {

            //  synth = new SpeechSynthesizer(); //Генератор речи
            //  synth.SetOutputToDefaultAudioDevice(); //выбор девайса да воспроизведения звука
            myThread_1 = new Thread(func_1); // Создаем поток с сылкой на функцию
            myThread_2 = new Thread(func_2); // Создаем поток с сылкой на функцию
            Name = p1;
            k = kol_zaezdov;
            int x = x_form;
            int y = y_form;
            int midddlepoint = y / 3;
            midddlepoint = midddlepoint * 2;

            procent = 100 * x / 1920;    // оптимизация шрифта под разные экраны 

            p = new Button();
            p.AutoSize = false;
            p.Text = "Пауза";
            p.Location = new System.Drawing.Point(x/10*8, y/2);
            p.Width = 100; //ширина 
            p.Height = 50; // высота 
            p.Show();
            p.Click += new EventHandler(Pause);
            this.Controls.Add(p);



            // Рамки

            disain_up = new Label(); // верх 
            disain_up.AutoSize = false;
            disain_up.Location = new System.Drawing.Point(0, 0);
            disain_up.Width = x; //ширина 
            disain_up.Height = 5; // высота 
            disain_up.BackColor = Color.Blue;
            disain_up.Show();
            this.Controls.Add(disain_up);


            disain_down = new Label(); // низ 
            disain_down.Location = new System.Drawing.Point(0, y - 5);
            disain_down.Width = x; //ширина 
            disain_down.Height = 5; // высота 
            disain_down.BackColor = Color.Blue;
            disain_down.Show();
            this.Controls.Add(disain_down);


            disain_left = new Label(); // лево 
            disain_left.Location = new System.Drawing.Point(0, 0);
            disain_left.Width = 5; //ширина 
            disain_left.Height = y; // высота 
            disain_left.BackColor = Color.Blue;
            disain_left.Show();
            this.Controls.Add(disain_left);


            disain_right = new Label(); // право
            disain_right.Location = new System.Drawing.Point(x - 4, 0);
            disain_right.Width = 5; //ширина 
            disain_right.Height = y; // высота 
            disain_right.BackColor = Color.Blue;
            disain_right.Show();
            this.Controls.Add(disain_right);


            // конец рамок


            // Label Вывода времени 
            LabelTime = new Label();
            LabelTime.Location = new System.Drawing.Point(0, y / 3);
            LabelTime.Text = Name;
            Controls.Add(LabelTime);
            LabelTime.Width = x; //ширина лейбола вывода времени 
            LabelTime.Height = y / 3; // высота лейбола вывода времени 
            LabelTime.Show();
            Font f1 = new Font("Arial", (int)(130 * procent / 100), FontStyle.Regular);   // 120
            LabelTime.AutoSize = false;
            LabelTime.TextAlign = ContentAlignment.MiddleCenter;
            LabelTime.Font = f1;


            // Label Вывода команд 
            TEAMS = new Label();
            TEAMS.Location = new System.Drawing.Point(0, midddlepoint);
            TEAMS.Text = "team";
            Controls.Add(TEAMS);
            TEAMS.Width = x; // ширина лейбола команд 
            TEAMS.Height = y / 3; // высота лейбола команд 
            TEAMS.Show();
            Font f2 = new Font("Arial", (int)(80 * procent / 100), FontStyle.Regular);  //80
            TEAMS.AutoSize = false;
            TEAMS.TextAlign = ContentAlignment.MiddleCenter;
            TEAMS.Font = f2;


            // Label Вывода следующей команды  
            NEXT_TEAM = new Label();
            NEXT_TEAM.Location = new System.Drawing.Point(x / 4, 0);
            NEXT_TEAM.Text = "team";
            Controls.Add(NEXT_TEAM);
            NEXT_TEAM.Width = x / 4 * 2; // ширина лейбола команд 
            NEXT_TEAM.Height = y / 3; // высота лейбола команд 
            NEXT_TEAM.Show();
            Font f3 = new Font("Arial", (int)(40 * procent / 100), FontStyle.Regular);   //40
            NEXT_TEAM.AutoSize = false;
            NEXT_TEAM.TextAlign = ContentAlignment.MiddleCenter;
            NEXT_TEAM.Font = f3;

            // Label Вывода следующей номера поля  
            Number_pole = new Label();
            Number_pole.Location = new System.Drawing.Point(0, 0);
            Number_pole.Text = "team";
            Controls.Add(Number_pole);
            Number_pole.Width = x / 4; // ширина лейбола номера поля 
            Number_pole.Height = y / 4; // высота лейбола номера поля  
            Number_pole.Show();
            Font f4 = new Font("Arial", (int)(60 * procent / 100), FontStyle.Regular);    // 60
            Number_pole.AutoSize = false;
            Number_pole.TextAlign = ContentAlignment.TopLeft;
            Number_pole.Font = f4;

            // Label Вывода реального времени
            Realtime = new Label();
            Realtime.Location = new System.Drawing.Point(0, y / 4);
            Controls.Add(Realtime);
            Realtime.Width = x / 3; // ширина лейбола  времени
            Realtime.Height = y / 5; // высота лейбола времени 
            Font f5 = new Font("Arial", (int)(30 * procent / 100), FontStyle.Regular);     // 30
            Realtime.AutoSize = false;
            Realtime.TextAlign = ContentAlignment.TopLeft;
            Realtime.Font = f5;


            mas_teams = new string[mas.Length];

            mas_teams = mas;
            t = new System.Windows.Forms.Timer();// создание таймера 
            t.Tick += DoTimer;
            // 
            // 
            time_bool = true;
            // timer1.Enabled = false; // таймер не должен работать в пустую 
            time = time_podacha * 60 * 10; // время для таймера 
            alltime = time;
            // MessageBox.Show(a.ToString()); 
            t.Enabled = true;
            Number_pole.Text = Name;




            timer_lbl = new System.Windows.Forms.Timer();// создание таймера 
            timer_lbl.Tick += Real_time;
            timer_lbl.Interval = 100;
            timer_lbl.Enabled = true;
            //Time_results = new StreamWriter("Time.txt");
        }
        int f = 0; // счетчик заездов 


        private void Real_time(object sender, EventArgs e)  // таймер реального времени 
        {
            DateTime dateTime = DateTime.Now;
            this.Realtime.Text = dateTime.ToString().Split()[1];

        }
        private void DoTimer(object sender, EventArgs e) // Место работы таймера 
        {

            if (time == 600 && i < mas_teams.Length - 1)
            {
                myThread_1.Start();
                //synth.Speak("Время заканчивается! Приготовиться команде" + mas_teams[i + 1]);
                //myThread_1.Abort();
            }

            if (time == 0 && i < mas_teams.Length - 1)
            {
                myThread_2 = new Thread(func_2);
                myThread_2.Start();
                //synth.Speak("Время заканчивается! Приготовиться команде" + mas_teams[i + 1]);
                //myThread_2.Abort();
            }

            if (time == 0)
            {

                //synth.Speak("Время истекло! Cмените команду ");
                DateTime dateTime = DateTime.Now;
                //Time_results.WriteLine(dateTime.ToString());
                LabelTime.Text = "00:00";
                time = alltime; // после окончание вереми одного заезда происходит обнуление времени 
                i++; // переход к следующей команде

            }
            if (i >= mas_teams.Length)
            {
                k--;
                i = 0;
                if (k == 0)
                {
                    LabelTime.Text = "00:00";
                    time_bool = false;
                    t.Enabled = false;
                    return;
                }
                else
                {
                    i = 0;
                    time = alltime;
                }
            }


            if (time == alltime && time_bool) // проверка окончания времени 
            {
                if (i < mas_teams.Length - 1)
                {
                    string s2 = "Следущая команда " + mas_teams[i + 1];
                    NEXT_TEAM.Text = s2;
                }
                else
                {
                    NEXT_TEAM.Text = "";
                }
                string s = "На поле команда " + mas_teams[i];
                TEAMS.Text = s;
            }
            int min = time / 600;
            int sec = time % 600 / 10;
            // int milisec = time % 10;
            time--;
            LabelTime.Text = min.ToString() + ":" + sec.ToString();// + ":" + milisec.ToString(); // вывод времени 
        }

        public string CommandName
        {
            get
            {
                return CommandName;
            }
            set
            {
                if (value.Length > 0)
                    CommandName = value;
                else CommandName = "noname";
            }
        }
    }
}


