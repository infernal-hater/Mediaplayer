using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediaplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_openfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) //чтобы не выбрасывало из программы при закрытии диалогового окна
                return;
            string file = openFileDialog1.FileName;
            
            wmp.URL = file; //файл подключается к плееру
        }

        private void b_play_Click(object sender, EventArgs e) //воспроизведение
        {
            wmp.Ctlcontrols.play(); 
        }

        private void b_pause_Click(object sender, EventArgs e) //пауза
        {
            wmp.Ctlcontrols.pause(); 
        }

        private void b_stop_Click(object sender, EventArgs e) //стоп
        {
            wmp.Ctlcontrols.stop(); 
        }
        private void tb_timer_Scroll(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.currentPosition = tb_timer.Value; //прокрутка таймера
        }
        private void tb_vol_ValueChanged(object sender, EventArgs e)//управление звуком
        {
            wmp.settings.volume = tb_vol.Value; 
        }

        private void wmp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            timer1.Enabled = true; //таймер видео
            timer1.Interval = 1000; //1 секунда
        }

        private void timer1_Tick(object sender, EventArgs e) //таймер
        {
            tb_timer.Maximum = Convert.ToInt32(wmp.currentMedia.duration); //записывается конец видео
            tb_timer.Value = Convert.ToInt32(wmp.Ctlcontrols.currentPosition); //значения секунд, минут
             
            if (wmp != null)
            {
                int s = (int)wmp.Ctlcontrols.currentPosition; //секунда
                int h = s / 3600; //час
                int m = (s-(h*3600)) / 60; //минута
                s = s - (h * 3600 + m * 60); //рассчет секунды
                l_timer.Text = String.Format("{0:D}:{1:D2}:{2:D2}", h, m, s); //вывод на экран таймера
            }
            else
            {
                l_timer.Text = "0:00:00"; //начальное значение
            }
        }

        
    }
}
