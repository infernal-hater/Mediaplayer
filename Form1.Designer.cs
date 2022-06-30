
namespace Mediaplayer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_timer = new System.Windows.Forms.TrackBar();
            this.l_timer = new System.Windows.Forms.Label();
            this.tb_vol = new System.Windows.Forms.TrackBar();
            this.l_vol = new System.Windows.Forms.Label();
            this.b_stop = new System.Windows.Forms.Button();
            this.b_pause = new System.Windows.Forms.Button();
            this.b_play = new System.Windows.Forms.Button();
            this.b_openfile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vol)).BeginInit();
            this.SuspendLayout();
            // 
            // wmp
            // 
            this.wmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 0);
            this.wmp.Margin = new System.Windows.Forms.Padding(2);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(902, 456);
            this.wmp.TabIndex = 1;
            this.wmp.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmp_PlayStateChange);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_timer);
            this.panel2.Controls.Add(this.l_timer);
            this.panel2.Controls.Add(this.tb_vol);
            this.panel2.Controls.Add(this.l_vol);
            this.panel2.Controls.Add(this.b_stop);
            this.panel2.Controls.Add(this.b_pause);
            this.panel2.Controls.Add(this.b_play);
            this.panel2.Controls.Add(this.b_openfile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 456);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(902, 54);
            this.panel2.TabIndex = 1;
            // 
            // tb_timer
            // 
            this.tb_timer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_timer.Location = new System.Drawing.Point(565, 18);
            this.tb_timer.Margin = new System.Windows.Forms.Padding(2);
            this.tb_timer.Maximum = 100;
            this.tb_timer.Name = "tb_timer";
            this.tb_timer.Size = new System.Drawing.Size(184, 45);
            this.tb_timer.TabIndex = 7;
            this.tb_timer.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_timer.Scroll += new System.EventHandler(this.tb_timer_Scroll);
            // 
            // l_timer
            // 
            this.l_timer.AutoSize = true;
            this.l_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_timer.Location = new System.Drawing.Point(488, 18);
            this.l_timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_timer.Name = "l_timer";
            this.l_timer.Size = new System.Drawing.Size(36, 18);
            this.l_timer.TabIndex = 6;
            this.l_timer.Text = "0:00";
            // 
            // tb_vol
            // 
            this.tb_vol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_vol.Location = new System.Drawing.Point(356, 18);
            this.tb_vol.Margin = new System.Windows.Forms.Padding(2);
            this.tb_vol.Maximum = 100;
            this.tb_vol.Name = "tb_vol";
            this.tb_vol.Size = new System.Drawing.Size(94, 45);
            this.tb_vol.TabIndex = 5;
            this.tb_vol.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb_vol.Value = 50;
            this.tb_vol.ValueChanged += new System.EventHandler(this.tb_vol_ValueChanged);
            // 
            // l_vol
            // 
            this.l_vol.AutoSize = true;
            this.l_vol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_vol.Location = new System.Drawing.Point(297, 18);
            this.l_vol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_vol.Name = "l_vol";
            this.l_vol.Size = new System.Drawing.Size(55, 17);
            this.l_vol.TabIndex = 4;
            this.l_vol.Text = "Volume";
            // 
            // b_stop
            // 
            this.b_stop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_stop.Location = new System.Drawing.Point(175, 9);
            this.b_stop.Margin = new System.Windows.Forms.Padding(2);
            this.b_stop.Name = "b_stop";
            this.b_stop.Size = new System.Drawing.Size(82, 37);
            this.b_stop.TabIndex = 3;
            this.b_stop.Text = "Stop";
            this.b_stop.UseVisualStyleBackColor = true;
            this.b_stop.Click += new System.EventHandler(this.b_stop_Click);
            // 
            // b_pause
            // 
            this.b_pause.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_pause.Location = new System.Drawing.Point(89, 9);
            this.b_pause.Margin = new System.Windows.Forms.Padding(2);
            this.b_pause.Name = "b_pause";
            this.b_pause.Size = new System.Drawing.Size(82, 37);
            this.b_pause.TabIndex = 2;
            this.b_pause.Text = "Pause";
            this.b_pause.UseVisualStyleBackColor = true;
            this.b_pause.Click += new System.EventHandler(this.b_pause_Click);
            // 
            // b_play
            // 
            this.b_play.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_play.Location = new System.Drawing.Point(9, 9);
            this.b_play.Margin = new System.Windows.Forms.Padding(2);
            this.b_play.Name = "b_play";
            this.b_play.Size = new System.Drawing.Size(76, 37);
            this.b_play.TabIndex = 1;
            this.b_play.Text = "Play";
            this.b_play.UseVisualStyleBackColor = true;
            this.b_play.Click += new System.EventHandler(this.b_play_Click);
            // 
            // b_openfile
            // 
            this.b_openfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_openfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_openfile.Location = new System.Drawing.Point(753, 9);
            this.b_openfile.Margin = new System.Windows.Forms.Padding(2);
            this.b_openfile.Name = "b_openfile";
            this.b_openfile.Size = new System.Drawing.Size(138, 37);
            this.b_openfile.TabIndex = 0;
            this.b_openfile.Text = "Open";
            this.b_openfile.UseVisualStyleBackColor = true;
            this.b_openfile.Click += new System.EventHandler(this.b_openfile_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 510);
            this.Controls.Add(this.wmp);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Media Player";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_vol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button b_openfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button b_pause;
        private System.Windows.Forms.Button b_play;
        private System.Windows.Forms.Button b_stop;
        private System.Windows.Forms.TrackBar tb_vol;
        private System.Windows.Forms.Label l_vol;
        private System.Windows.Forms.TrackBar tb_timer;
        private System.Windows.Forms.Label l_timer;
        private System.Windows.Forms.Timer timer1;
    }
}

