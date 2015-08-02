using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raceday
{
    public partial class Form1 : Form
    {
        private int Funds = 1000;
        private int Wager = 0;
        private string BetCar;
        //private int[] Cars = new int[10];
        //private int[] Pos = new int[10];
        private int Finish = 625;
        private int FinishCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrTimer.Enabled = true;
            grpWager.Enabled = false;
            btnStart.Enabled = false;

            if (rdoCar1.Checked)
            {
                BetCar = "Car 1";
            }

            if (rdoCar2.Checked)
            {
                BetCar = "Car 2";
            }

            if (rdoCar3.Checked)
            {
                BetCar = "Car 3";
            }

            if (rdoCar4.Checked)
            {
                BetCar = "Car 4";
            }

            if (rdoCar5.Checked)
            {
                BetCar = "Car 5";
            }

            if (rdoCar6.Checked)
            {
                BetCar = "Car 6";
            }

            if (rdoCar7.Checked)
            {
                BetCar = "Car 7";
            }

            if (rdoCar8.Checked)
            {
                BetCar = "Car 8";
            }

            if (rdoCar9.Checked)
            {
                BetCar = "Car 9";
            }

            if (rdoCar10.Checked)
            {
                BetCar = "Car 10";
            }
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            int max = 0;
            int leader_car = 0;
            string CarText = "";
            Random random = new Random();

            CarText = "Car 1";

            if (btnCar1.Left < Finish)
            {
                btnCar1.Left = btnCar1.Left + random.Next(10);
                max = btnCar1.Left;
                leader_car = 1;
            }
            else
            {
                if (btnCar1.Enabled == true)
                {
                    FinishCount += 1;
                    btnCar1.Enabled = false;
                    if (lblFirst.Text == "")
                    {
                        lblFirst.Text = CarText;
                    }
                    else if (lblSecond.Text == "")
                    {
                        lblSecond.Text = CarText;
                    }
                    else if (lblThird.Text == "")
                    {
                        lblThird.Text = CarText;
                    }
                }
            }

            CarText = "Car 2";

            if (btnCar2.Left < Finish)
            {
                btnCar2.Left = btnCar2.Left + random.Next(10);
                if (btnCar2.Left > max)
                {
                    max = btnCar2.Left;
                    leader_car = 2;
                }
                
            }
            else
            {
                if (btnCar2.Enabled == true)
                {
                    FinishCount += 1;
                    btnCar2.Enabled = false;
                    if (lblFirst.Text == "")
                    {
                        lblFirst.Text = CarText;
                    }
                    else if (lblSecond.Text == "")
                    {
                        lblSecond.Text = CarText;
                    }
                    else if (lblThird.Text == "")
                    {
                        lblThird.Text = CarText;
                    }
                }
            }

            CarText = "Car 3";

            if (btnCar3.Left < Finish)
            {
                btnCar3.Left = btnCar3.Left + random.Next(10);
                if (btnCar3.Left > max)
                {
                    max = btnCar3.Left;
                    leader_car = 3;
                }
            }
            else
            {
                if (btnCar3.Enabled == true)
                {
                    FinishCount += 1;
                    btnCar3.Enabled = false;
                    if (lblFirst.Text == "")
                    {
                        lblFirst.Text = CarText;
                    }
                    else if (lblSecond.Text == "")
                    {
                        lblSecond.Text = CarText;
                    }
                    else if (lblThird.Text == "")
                    {
                        lblThird.Text = CarText;
                    }
                }
            }

            CarText = "Car 4";

            if (btnCar4.Left < Finish)
            {
                btnCar4.Left = btnCar4.Left + random.Next(10);
                if (btnCar4.Left > max)
                {
                    max = btnCar4.Left;
                    leader_car = 4;
                }
            }
            else
            {
                if (btnCar4.Enabled == true)
                {
                    FinishCount += 1;
                    btnCar4.Enabled = false;
                    if (lblFirst.Text == "")
                    {
                        lblFirst.Text = CarText;
                    }
                    else if (lblSecond.Text == "")
                    {
                        lblSecond.Text = CarText;
                    }
                    else if (lblThird.Text == "")
                    {
                        lblThird.Text = CarText;
                    }
                }
            }

            CarText = "Car 5";

            if (btnCar5.Left < Finish)
            {
                btnCar5.Left = btnCar5.Left + random.Next(10);
                if (btnCar5.Left > max)
                {
                    max = btnCar5.Left;
                    leader_car = 5;
                }
            }
            else
            {
                if (btnCar5.Enabled == true)
                {
                    FinishCount += 1;
                    btnCar5.Enabled = false;
                    if (lblFirst.Text == "")
                    {
                        lblFirst.Text = CarText;
                    }
                    else if (lblSecond.Text == "")
                    {
                        lblSecond.Text = CarText;
                    }
                    else if (lblThird.Text == "")
                    {
                        lblThird.Text = CarText;
                    }
                }
            }

            CarText = "Car 6";

            if (btnCar6.Left < Finish)
            {
                btnCar6.Left = btnCar6.Left + random.Next(10);
                if (btnCar6.Left > max)
                {
                    max = btnCar6.Left;
                    leader_car = 6;
                }
            }
            else
            {
                if (btnCar6.Enabled == true)
                {
                    FinishCount += 1;
                    btnCar6.Enabled = false;
                    if (lblFirst.Text == "")
                    {
                        lblFirst.Text = CarText;
                    }
                    else if (lblSecond.Text == "")
                    {
                        lblSecond.Text = CarText;
                    }
                    else if (lblThird.Text == "")
                    {
                        lblThird.Text = CarText;
                    }
                }
            }

            CarText = "Car 7";

            if (btnCar7.Left < Finish)
            {
                btnCar7.Left = btnCar7.Left + random.Next(10);
                if (btnCar7.Left > max)
                {
                    max = btnCar7.Left;
                    leader_car = 7;
                }
            }
            else
            {
                if (btnCar7.Enabled == true)
                {
                    FinishCount += 1;
                    btnCar7.Enabled = false;
                    if (lblFirst.Text == "")
                    {
                        lblFirst.Text = CarText;
                    }
                    else if (lblSecond.Text == "")
                    {
                        lblSecond.Text = CarText;
                    }
                    else if (lblThird.Text == "")
                    {
                        lblThird.Text = CarText;
                    }
                }
            }

            CarText = "Car 8";

            if (btnCar8.Left < Finish)
            {
                btnCar8.Left = btnCar8.Left + random.Next(10);
                if (btnCar8.Left > max)
                {
                    max = btnCar8.Left;
                    leader_car = 8;
                }
            }
            else
            {
                if (btnCar8.Enabled == true)
                {
                    FinishCount += 1;
                    btnCar8.Enabled = false;
                    if (lblFirst.Text == "")
                    {
                        lblFirst.Text = CarText;
                    }
                    else if (lblSecond.Text == "")
                    {
                        lblSecond.Text = CarText;
                    }
                    else if (lblThird.Text == "")
                    {
                        lblThird.Text = CarText;
                    }
                }
            }

            CarText = "Car 9";

            if (btnCar9.Left < Finish)
            {
                btnCar9.Left = btnCar9.Left + random.Next(10);
                if (btnCar9.Left > max)
                {
                    max = btnCar9.Left;
                    leader_car = 9;
                }
            }
            else
            {
                if (btnCar9.Enabled == true)
                {
                    FinishCount += 1;
                    btnCar9.Enabled = false;
                    if (lblFirst.Text == "")
                    {
                        lblFirst.Text = CarText;
                    }
                    else if (lblSecond.Text == "")
                    {
                        lblSecond.Text = CarText;
                    }
                    else if (lblThird.Text == "")
                    {
                        lblThird.Text = CarText;
                    }
                }
            }

            CarText = "Car 10";

            if (btnCar10.Left < Finish)
            {
                btnCar10.Left = btnCar10.Left + random.Next(10);
                if (btnCar10.Left > max)
                {
                    max = btnCar10.Left;
                    leader_car = 10;
                }
            }
            else
            {
                if (btnCar10.Enabled == true)
                {
                    FinishCount += 1;
                    btnCar10.Enabled = false;
                    if (lblFirst.Text == "")
                    {
                        lblFirst.Text = CarText;
                    }
                    else if (lblSecond.Text == "")
                    {
                        lblSecond.Text = CarText;
                    }
                    else if (lblThird.Text == "")
                    {
                        lblThird.Text = CarText;
                    }
                }
            }

            statusLeaderBoard.Text = "Leader: " + leader_car;

            if (FinishCount == 10)
            {
                DetermineOutcome(lblFirst.Text);
            }
        }

        private void DetermineOutcome(string Winner)
        {
            tmrTimer.Enabled = false;
            statusLeaderBoard.Text = "Winner: " + Winner;
            btnRestart.Enabled = true;

            if (BetCar == Winner)
            {
                Funds += Wager * 10;
                lblFunds.Text = Funds.ToString();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnCar1.Left = 12;
            btnCar1.Enabled = true;
            btnCar2.Left = 12;
            btnCar2.Enabled = true;
            btnCar3.Left = 12;
            btnCar3.Enabled = true;
            btnCar4.Left = 12;
            btnCar4.Enabled = true;
            btnCar5.Left = 12;
            btnCar5.Enabled = true;
            btnCar6.Left = 12;
            btnCar6.Enabled = true;
            btnCar7.Left = 12;
            btnCar7.Enabled = true;
            btnCar8.Left = 12;
            btnCar8.Enabled = true;
            btnCar9.Left = 12;
            btnCar9.Enabled = true;
            btnCar10.Left = 12;
            btnCar10.Enabled = true;

            btnRestart.Enabled = false;
            btnStart.Enabled = true;
            grpWager.Enabled = true;
            lblFirst.Text = "";
            lblSecond.Text = "";
            lblThird.Text = "";
            FinishCount = 0;
            Wager = 0;
            lblWager.Text = Wager.ToString();
        }

        private void btnBet10_Click(object sender, EventArgs e)
        {
            if (Funds >= 10)
            {
                Wager += 10;
                Funds -= 10;
                lblWager.Text = Wager.ToString();
                lblFunds.Text = Funds.ToString();
            }
        }

        private void btnBet100_Click(object sender, EventArgs e)
        {
            if (Funds >= 100)
            {
                Wager += 100;
                Funds -= 100;
                lblWager.Text = Wager.ToString();
                lblFunds.Text = Funds.ToString();
            }
        }

        private void btnClearWager_Click(object sender, EventArgs e)
        {
            Funds += Wager;
            Wager = 0;
            lblWager.Text = Wager.ToString();
            lblFunds.Text = Funds.ToString();
        }
    }
}
