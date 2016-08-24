using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace PaCman
{
    public delegate void STREEP();

    class Model
    {
        public event STREEP changeStreep;
        int step=10;
        int collectedApples;
        int sizeField; 
        int amountSpirits;
        int amountApples;
       public int speedGame;

       public GameStatus gameStatus;

       Random r;
       Projectile projectile;

       internal Projectile Projectile
       {
           get { return projectile; }
       }
       Packman packman;
       internal Packman Packman
       {
           get { return packman; }
       }
       List<Tank> tanks;
       internal List<Tank> Tanks
       {
           get { return tanks; }
       }
       List<DeadSpirit> deadSpirit;
       internal List<DeadSpirit> DeadSpirit
       {
           get { return deadSpirit; }
       }
       List<Apple> apples;
       internal List<Apple> Apples
       {
           get { return apples; }
       }

       public Wall wall;

        public Model(int sizeField, int amountSpirits, int amountApples, int speedGame)
        {

            r = new Random();
           
            this.sizeField = sizeField;
            this.amountSpirits = amountSpirits;
            this.amountApples = amountApples;
            this.speedGame = speedGame;
            NewGame();
           
        }
        private void CreatApples()
        {
            CreatApples(0);
        }
        private void CreatApples(int newApples)
        {
            int x, y;
            while (apples.Count < amountApples + newApples)
            {
                x = r.Next(6) * 80;
                y = r.Next(6) * 80-4;

                bool flag = true;
                foreach (Apple a in apples)
                    if (a.X == x && a.Y == y)
                    {
                        flag = false;
                        break;
                    }

                if (flag)
                    apples.Add(new Apple( x, y));

            }
        }
        private void CreatTanks()
        {

            int x, y;
            while (tanks.Count < amountSpirits+1)
            {

                if(tanks.Count == 0)
                    tanks.Add(new Hunter(sizeField, r.Next(6) * 80,r.Next(6) * 80));
                x = r.Next(6) * 80;
                y = r.Next(6) * 80;

                bool flag = true;
                foreach (Tank t in tanks)
                    if (t.X == x && t.Y == y)
                    {
                        flag = false;
                        break;
                    }

                if (flag)
                    tanks.Add(new Tank(sizeField, x, y));

            }
        }
        public void Play()
        {

            while (gameStatus == GameStatus.playing)
            {
                Thread.Sleep(speedGame);
                projectile.Run();
                packman.Run();
                ((Hunter)tanks[0]).Run(packman.X, packman.Y);
                for (int i = 1; i < tanks.Count; i++ )
                    tanks[i].Run();

                foreach (DeadSpirit ds in deadSpirit)
                    ds.Dead();

                for (int i = 1; i < tanks.Count;i++ )
                    if ((projectile.X - tanks[i].X) < 30 && (projectile.Y - tanks[i].Y) < 30 &&
                        (projectile.X - tanks[i].X) > 10 && (projectile.Y - tanks[i].Y) > 10)
                    {
                        deadSpirit.Add(new DeadSpirit(tanks[i].X, tanks[i].Y));
                        tanks.RemoveAt(i);
                    }

                    for (int i = 0; i < tanks.Count - 1; i++)
                        for (int j = i + 1; j < tanks.Count; j++)
                            if (
                                (Math.Abs(tanks[i].X - tanks[j].X) <= 40 && (tanks[i].Y == tanks[j].Y))
                                ||
                                (Math.Abs(tanks[i].Y - tanks[j].Y) <= 40 && (tanks[i].X == tanks[j].X))
                                ||
                                (Math.Abs(tanks[i].X - tanks[j].X) <= 40 && Math.Abs(tanks[i].Y - tanks[j].Y) <= 40)
                                )
                            {

                                if (i == 0)
                                    ((Hunter)tanks[i]).TurnAround();
                                else
                                    tanks[i].TurnAround();

                                tanks[j].TurnAround();
                            }

                for (int i = 0; i < tanks.Count; i++)
                    if (
                            (Math.Abs(tanks[i].X - packman.X) <= 38 && (tanks[i].Y == packman.Y))
                            ||
                            (Math.Abs(tanks[i].Y - packman.Y) <= 38 && (tanks[i].X == packman.X))
                            ||
                            (Math.Abs(tanks[i].X - packman.X) <= 35 && Math.Abs(tanks[i].Y - packman.Y) <= 35)
                            )
                    {
                        gameStatus = GameStatus.loozer;
                        if(changeStreep != null)
                            changeStreep();
                        MessageBox.Show("Вы проиграли!", "Pacman", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }




                for (int i = 0; i < apples.Count; i++)
                    if (Math.Abs(packman.X - apples[i].X) < 6 && Math.Abs(packman.Y - apples[i].Y) < 6)
                    {
                        apples[i] = new Apple(step, 570);
                        step += 60;
                        CreatApples(++collectedApples);
                    }

                if (collectedApples > 4)
                {
                    gameStatus = GameStatus.winer;
                    if (changeStreep != null)
                        changeStreep();
                    DialogResult dr = MessageBox.Show("Поздравляем, Вы выиграли!", "Pacman", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }


            }
        }
        internal void NewGame()
        {
            collectedApples = 0;
            step = 10;
            projectile = new Projectile();
            packman = new Packman(sizeField);
            tanks = new List<Tank>();
            deadSpirit = new List<DeadSpirit>();
            apples = new List<Apple>();
            CreatTanks();
            CreatApples();
            wall = new Wall();

            gameStatus = GameStatus.stoping;
        }
    }
}
