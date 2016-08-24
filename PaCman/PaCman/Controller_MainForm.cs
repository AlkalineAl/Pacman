using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace PaCman
{
    delegate void Invoker();
    
    public partial class Controller_MainForm : Form
    {

        Thread modelPlay;
        bool isSound;
        View view;
        Model model;
        SoundPlayer sp;
        public Controller_MainForm() : this(520) { }
        public Controller_MainForm(int sizeField) : this(sizeField, 5) { }
        public Controller_MainForm(int sizeField, int amountSpirits) : this( sizeField, amountSpirits,5) {}
        public Controller_MainForm(int sizeField, int amountSpirits, int amountApples) : this(sizeField, amountSpirits, amountApples, 20) { }
        public Controller_MainForm(int sizeField, int amountSpirits, int amountApples, int speedGame)
        {
            InitializeComponent();
            model = new Model(sizeField, amountSpirits, amountApples, speedGame);
            model.changeStreep += new STREEP(ChangerStatusStripLbl);
            view = new View(model);
            this.Controls.Add(view);
            isSound = true;

            sp = new SoundPlayer(Properties.Resources.mar);
        }

        void ChangerStatusStripLbl()
        {
            Invoke(new Invoker(SetValueToStrLbl));
            
        }

        void SetValueToStrLbl()
        {
            GameStatus_lbl.Text = model.gameStatus.ToString();
            if (isSound)
            {
                if (model.gameStatus == GameStatus.playing)
                    sp.PlayLooping();
                else
                    sp.Stop();
            }
        }

        private void StartStop_btn_Click(object sender, EventArgs e)
        {
            if (model.gameStatus == GameStatus.playing)
            {
                modelPlay.Abort();
                StartStop_pcbx.Image = Properties.Resources.play;
                model.gameStatus = GameStatus.stoping;
                ChangerStatusStripLbl();
                
            }
            else
            {
                StartStop_pcbx.Focus();
                model.gameStatus = GameStatus.playing;
                modelPlay = new Thread(model.Play);
                modelPlay.Start();
                StartStop_pcbx.Image = Properties.Resources.pause;

                ChangerStatusStripLbl();
                view.Invalidate();
            }
        }

        private void Controller_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modelPlay != null)
            {
                model.gameStatus = GameStatus.stoping;
                modelPlay.Abort();
            }
          DialogResult dr =  MessageBox.Show("Вы уверенны, что хотите покинуть приложение?!","Pacman", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);
          if (dr == DialogResult.Yes)
              e.Cancel = false;
          else
              e.Cancel = true;
        }

        private void StartStop_pcbx_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyData.ToString())
            {

                case "A":
                    {
                        model.Packman.NextDirect_x = -1;
                        model.Packman.NextDirect_y = 0;
                    }
                    break;

                case "D":
                    {
                        model.Packman.NextDirect_x = 1;
                        model.Packman.NextDirect_y = 0;
                    }
                    break;

                case "W":
                    {
                        model.Packman.NextDirect_x = 0;
                        model.Packman.NextDirect_y = -1;
                    }
                    break;

                case "S":
                    {
                        model.Packman.NextDirect_x = 0;
                        model.Packman.NextDirect_y = 1;
                    }
                    break;
                case "L":
                    {
                        SetProjectileFromStart();                        
                    }
                    break;
            }
        }

        private void SetProjectileFromStart()
        {
            model.Projectile.Direct_x = model.Packman.Direct_x;
            model.Projectile.Direct_y = model.Packman.Direct_y;

            if (model.Packman.Direct_y == -1)
            {
                model.Projectile.Y = model.Packman.Y;
                model.Projectile.X = model.Packman.X + 20;
            }
            if (model.Packman.Direct_y == 1)
            {
                model.Projectile.X = model.Packman.X + 20;
                model.Projectile.Y = model.Packman.Y + 40;
            }
            if (model.Packman.Direct_x == -1)
            {
                model.Projectile.X = model.Packman.X;
                model.Projectile.Y = model.Packman.Y + 20;
            }
            if (model.Packman.Direct_x == 1)
            {
                model.Projectile.X = model.Packman.X + 40;
                model.Projectile.Y = model.Packman.Y + 20;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model.NewGame();
            StartStop_pcbx.Image = Properties.Resources.play;
            view.Refresh();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
             MessageBox.Show(@"
            Игра 'Пакмен' версии 1.0
          Разработчик Поддубный Алексей.
          
            Для управления пакменом 
   используйте клавиши 'A','S', 'D', 'W', 'L'", "Pacman", MessageBoxButtons.OK,
                           MessageBoxIcon.Asterisk,
                           MessageBoxDefaultButton.Button1,
                           MessageBoxOptions.DefaultDesktopOnly);
                MessageBox.Show("Огромное спасибо за помощь в разработке и предоставление материалов Александру Викторовичу Саенко \nа так-же Екатерине Лавриненко за вдохновление и поддержку)", "Pacman", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
           
        }

        private void SoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isSound = !isSound;
            if (isSound)
                soundToolStripMenuItem.Image = global::PaCman.Properties.Resources.Exit2__4_;
            else
                soundToolStripMenuItem.Image = global::PaCman.Properties.Resources.Exit2__5_;
        }


    }
}
