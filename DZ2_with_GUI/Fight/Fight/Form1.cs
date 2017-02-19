using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fight
{

    public partial class Form1 : Form
    {

        class Fighter
        {
            private int healthPoints;
            private int blockValue;

            public Fighter()
            {
                healthPoints = 20;
            }

            public void HeadPunch()
            {
                if (healthPoints < 10)
                    healthPoints = 0;
                else
                    healthPoints -= 10;
            }

            public void BodyPunch()
            {
                if (healthPoints < 7)
                    healthPoints = 0;
                else
                    healthPoints -= 7;
            }

            public void LegsPunch()
            {
                if (healthPoints < 5)
                    healthPoints = 0;
                else
                    healthPoints -= 5;
            }

            public int getHealth()
            {
                return healthPoints;
            }

            public int getBlock()
            {
                return blockValue;
            }

            public void setBlock(int bv)
            {
                blockValue = bv;
            }

        }

        Fighter player = new Fighter();
        Fighter enemy = new Fighter();
        System.Random rnd = new System.Random();
        int move = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                    
                    if (move == 1)
                    {
                        listBox1.Items.Clear();
                        int punch;
                        label1.Text="Ход противника. Выберите,какую часть тела заблокировать:";
                        punch = comboBox1.SelectedIndex + 1;
                        int block = rnd.Next(1, 3);
                        enemy.setBlock(block);
                        if (enemy.getBlock() == punch)
                                listBox1.Items.Add("Противник заблокировал удар!");
                        else
                        {
                            listBox1.Items.Add("Вы попали по противнику!");
                            switch (punch)
                            {
                                case 1:
                                    enemy.HeadPunch();
                                    break;

                                case 2:
                                    enemy.BodyPunch();
                                    break;

                                case 3:
                                    enemy.LegsPunch();
                                    break;
                            }
                        }
                        listBox1.Items.Add("Ваше здоровье:" + player.getHealth());
                        listBox1.Items.Add("Здоровье противника:" + enemy.getHealth());
                        move = 2;
                    }
                    else
                    {
                        listBox1.Items.Clear();
                        int punch = rnd.Next(1, 3);
                        label1.Text="Ваш ход. Выберите, куда ударить!";
                        player.setBlock(comboBox1.SelectedIndex + 1);
                        if (player.getBlock() == punch)
                             listBox1.Items.Add("Вы заблокировали удар!");
                        else
                        {
                            listBox1.Items.Add("Противник ударил вас!");
                            switch (punch)
                            {
                                case 1:
                                    player.HeadPunch();
                                    break;

                                case 2:
                                    player.BodyPunch();
                                    break;

                                case 3:
                                    player.LegsPunch();
                                    break;
                            }
                        }
                        listBox1.Items.Add("Ваше здоровье:" + player.getHealth());
                        listBox1.Items.Add("Здоровье противника:" + enemy.getHealth());
                        move = 1;
                    }

            if (enemy.getHealth() == 0)
            {
                listBox1.Items.Add("Поздравляем! Вы одолели противника!");
                button1.Visible = false;
            }
            else if (player.getHealth() == 0)
            {
                listBox1.Items.Add("Вы проиграли. Противник одолел вас :-(");
                button1.Visible = false;
            }

}

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Первый ход за вами. Выберите, кудаударить!";
            comboBox1.Items.Add("Голова");
            comboBox1.Items.Add("Тело");
            comboBox1.Items.Add("Ноги");
        }
    }
}
