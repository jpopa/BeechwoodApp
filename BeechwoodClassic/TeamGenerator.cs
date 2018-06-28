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
using System.Collections;




namespace BeechwoodClassic
{
    public partial class TeamGenerator : Form
    {
        public TeamGenerator()
        {
            InitializeComponent();


        }

        public int GetTeamSize()
        {
            int teamSize = 0;
            bool RyderCup; 

            if (FourManScramble.Checked == true)
            {
                teamSize = 4;
                

                return teamSize;

            }

            if (TwoManScramble.Checked == true)
            {
                teamSize = 2;
                

                return teamSize;

            }

            else
            {
                return 0;
            }


        }


        public static int GetNumber(int max)
        {
            


            Random random = new Random();

            

            int rand = random.Next(0, max);

            //string name = Players[rand].ToString();

            //Players.Remove(name);




            return rand;


        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {

            Team1.Clear();
            Team2.Clear();
            Team3.Clear();
            Team4.Clear();
            Team5.Clear();
            Team6.Clear();
            Team7.Clear();
            Team8.Clear();
            Team9.Clear();
            Team10.Clear();
            Team11.Clear();
            Team12.Clear();
            Team13.Clear();
            Team14.Clear();



            int teamSize = GetTeamSize();
            int totalTeams;

            if(teamSize == 4)
            {

                totalTeams = 7;

                vsLabel.Visible = false;
                usaLabel.Visible = false;
                europeLabel.Visible = false;
        
                Team8.Visible = false;
                Team9.Visible = false;
                Team10.Visible = false;
                Team11.Visible = false;
                Team12.Visible = false;
                Team13.Visible = false;
                Team14.Visible = false;
                SendItPictureBox.Visible = true;
                DalyBox.Visible = true;



            }
            else
            {

                totalTeams = 14;
                vsLabel.Visible = true;
                usaLabel.Visible = true;
                europeLabel.Visible = true;
                Team8.Visible = true;
                Team9.Visible = true;
                Team10.Visible = true;
                Team11.Visible = true;
                Team12.Visible = true;
                Team13.Visible = true;
                Team14.Visible = true;
                SendItPictureBox.Visible = false;
                DalyBox.Visible = false;
                    
            }




            string[] All = { "Brian Kelly ", "Lucas Bogard ", "Drew Taylor ", "Jordan Popa", "Ryan Popa", "Dan Kellogg", "Brent Whitten", "Buddy Sheffer", "Vikash Pillay", "Jake Desrochers", "Brad Smith", "Eddie Nickerson", "Connor Dixon", "Eric Gordon", "Jake Miller", "Jake Townsend", "James Strabel", "Jordan Rife", "Kevin Bartosek", "Mike Harmeson", "Brad Fite", "Drew Nichols", "Billy Auxier", "Cam Corteggiano", "Chad Bigger", "Justin Rife", "Nick Carlson", "Troy Kierczynski" };

            int[] Rankings = { 5, 5, 5, 3, 3, 3, 3, 3, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0};

            string[] OnesArray = { "Brian Kelly", "Lucas Bogard", "Drew Taylor" };
            string[] TwosArray = { "Jordan Popa", "Ryan Popa", "Dan Kellogg", "Brent Whitten", "Buddy Sheffer", "Vikash Pillay", "Jake Desrochers", "Brad Smith", "Connor Dixon" };
            string[] ThreesArray = { "Eddie Nickerson", "Eric Gordon", "Jake Miller", "Jake Townsend", "James Strabel", "Jordan Rife", "Kevin Bartosek", "Mike Harmeson", "Brad Fite" };
            string[] FoursArray = { "Drew Nichols", "Billy Auxier", "Cam Corteggiano", "Chad Bigger", "Justin Rife", "Nick Carlson", "Troy Kierczynski" };

            ArrayList Players = new ArrayList();
            ArrayList Ranks = new ArrayList();
            ArrayList Ones = new ArrayList();
            ArrayList Twos = new ArrayList();
            ArrayList Threes = new ArrayList();
            ArrayList Fours = new ArrayList();

            Players.AddRange(All);
            Ranks.AddRange(Rankings);
            Ones.AddRange(OnesArray);
            Twos.AddRange(TwosArray);
            Threes.AddRange(ThreesArray);
            Fours.AddRange(FoursArray);

            for (int y = 1; y <= totalTeams; y++)
            {
                ArrayList Team = new ArrayList();

                int Sum = 0;
                //for (int x = 0; x < teamSize; x++)
                //{

                    int playerNumber;
                if (teamSize == 4)
                {
                    if (y <= 2)
                    {
                        playerNumber = GetNumber(Ones.Count);
                        Team.Add(Ones[playerNumber]);
                        Ones.Remove(Ones[playerNumber]);

                        playerNumber = GetNumber(Threes.Count);
                        Team.Add(Threes[playerNumber]);
                        Threes.Remove(Threes[playerNumber]);

                        playerNumber = GetNumber(Threes.Count);
                        Team.Add(Threes[playerNumber]);
                        Threes.Remove(Threes[playerNumber]);

                        playerNumber = GetNumber(Fours.Count);
                        Team.Add(Fours[playerNumber]);
                        Fours.Remove(Fours[playerNumber]);


                    }


                    if (y == 3)
                    {

                        playerNumber = GetNumber(Ones.Count);
                        Team.Add(Ones[playerNumber]);
                        Ones.Remove(Ones[playerNumber]);

                        playerNumber = GetNumber(Twos.Count);
                        Team.Add(Twos[playerNumber]);
                        Twos.Remove(Twos[playerNumber]);

                        playerNumber = GetNumber(Threes.Count);
                        Team.Add(Threes[playerNumber]);
                        Threes.Remove(Threes[playerNumber]);

                        playerNumber = GetNumber(Fours.Count);
                        Team.Add(Fours[playerNumber]);
                        Fours.Remove(Fours[playerNumber]);


                    }





                    if (y > 3)
                    {

                        playerNumber = GetNumber(Twos.Count);
                        Team.Add(Twos[playerNumber]);
                        Twos.Remove(Twos[playerNumber]);

                        playerNumber = GetNumber(Twos.Count);
                        Team.Add(Twos[playerNumber]);
                        Twos.Remove(Twos[playerNumber]);

                        playerNumber = GetNumber(Threes.Count);
                        Team.Add(Threes[playerNumber]);
                        Threes.Remove(Threes[playerNumber]);

                        playerNumber = GetNumber(Fours.Count);
                        Team.Add(Fours[playerNumber]);
                        Fours.Remove(Fours[playerNumber]);


                    }





                    if (y == 1)
                    {
                        foreach (string s in Team)
                        {

                            Team1.AppendText(s);

                            Team1.AppendText("\r\n");

                            //Team1Sum.Text = Sum.ToString();
                        }

                    }

                    if (y == 2)
                    {
                        foreach (string s in Team)
                        {

                            Team2.AppendText(s);

                            Team2.AppendText("\r\n");

                            // Team2Sum.Text = Sum.ToString();
                        }
                    }

                    if (y == 3)
                    {
                        foreach (string s in Team)
                        {

                            Team3.AppendText(s);

                            Team3.AppendText("\r\n");

                            // Team3Sum.Text = Sum.ToString();
                        }
                    }

                    if (y == 4)
                    {
                        foreach (string s in Team)
                        {

                            Team4.AppendText(s);

                            Team4.AppendText("\r\n");

                            // Team4Sum.Text = Sum.ToString();
                        }
                    }

                    if (y == 5)
                    {
                        foreach (string s in Team)
                        {

                            Team5.AppendText(s);

                            Team5.AppendText("\r\n");

                            //Team5Sum.Text = Sum.ToString();
                        }
                    }

                    if (y == 6)
                    {
                        foreach (string s in Team)
                        {

                            Team6.AppendText(s);

                            Team6.AppendText("\r\n");

                            //Team6Sum.Text = Sum.ToString();
                        }
                    }

                    if (y == 7)
                    {
                        foreach (string s in Team)
                        {

                            Team7.AppendText(s);

                            Team7.AppendText("\r\n");

                            //Team7Sum.Text = Sum.ToString();
                        }
                    }
















                }
                else
                {

                    if(Ones.Count > 0)
                    {
                        if (Ones.Count == 3)
                        {
                            Team.Add("Brian Kelly");
                            Team.Add("Cam Corteggiano");

                            int findBron = Ones.IndexOf("Brian Kelly");
                            int findCam = Fours.IndexOf("Cam Corteggiano");

                            Ones.Remove(Ones[findBron]);
                            Fours.Remove(Fours[findCam]);


                        }
                        else
                        {


                            playerNumber = GetNumber(Ones.Count);
                            Team.Add(Ones[playerNumber]);


    
                                Team.Add(Fours[playerNumber]);
                                Fours.Remove(Fours[playerNumber]);

                                Ones.Remove(Ones[playerNumber]);
                           
                        }

                    }
                    else if (Fours.Count > 0)
                    {


                        playerNumber = GetNumber(Twos.Count);
                        Team.Add(Twos[playerNumber]);
                        Twos.Remove(Twos[playerNumber]);

                        playerNumber = GetNumber(Fours.Count);
                        Team.Add(Fours[playerNumber]);
                        Fours.Remove(Fours[playerNumber]);

                    }
                    else if (Twos.Count > 0)
                    {

                        playerNumber = GetNumber(Twos.Count);
                        Team.Add(Twos[playerNumber]);
                        Twos.Remove(Twos[playerNumber]);

                        playerNumber = GetNumber(Threes.Count);
                        Team.Add(Threes[playerNumber]);
                        Threes.Remove(Threes[playerNumber]);




                    }
                    else
                    {
                        playerNumber = GetNumber(Threes.Count);
                        Team.Add(Threes[playerNumber]);
                        Threes.Remove(Threes[playerNumber]);

                        playerNumber = GetNumber(Threes.Count);
                        Team.Add(Threes[playerNumber]);
                        Threes.Remove(Threes[playerNumber]);


                    }





                    if (y == 1)
                    {
                        foreach (string s in Team)
                        {

                            Team1.AppendText(s);

                            Team1.AppendText("\r\n");

                            //Team1Sum.Text = Sum.ToString();
                        }

                    }

                    if (y == 2)
                    {
                        foreach (string s in Team)
                        {

                            Team8.AppendText(s);

                            Team8.AppendText("\r\n");

                            // Team2Sum.Text = Sum.ToString();
                        }
                    }

                    if (y == 3)
                    {
                        foreach (string s in Team)
                        {

                            Team2.AppendText(s);

                            Team2.AppendText("\r\n");

                            // Team3Sum.Text = Sum.ToString();
                        }
                    }

                    if (y == 4)
                    {
                        foreach (string s in Team)
                        {

                            Team9.AppendText(s);

                            Team9.AppendText("\r\n");

                            // Team4Sum.Text = Sum.ToString();
                        }
                    }

                    if (y == 5)
                    {
                        foreach (string s in Team)
                        {

                            Team3.AppendText(s);

                            Team3.AppendText("\r\n");

                            //Team5Sum.Text = Sum.ToString();
                        }
                    }

                    if (y == 6)
                    {
                        foreach (string s in Team)
                        {

                            Team10.AppendText(s);

                            Team10.AppendText("\r\n");

                            //Team6Sum.Text = Sum.ToString();
                        }
                    }

                    if (y == 7)
                    {
                        foreach (string s in Team)
                        {

                            Team4.AppendText(s);

                            Team4.AppendText("\r\n");

                            //Team7Sum.Text = Sum.ToString();
                        }
                    }



                    if (y == 8)
                    {

                        foreach (string s in Team)
                        {


                            Team11.AppendText(s);

                            Team11.AppendText("\r\n");
                        }
                    }

                    if (y == 9)
                    {

                        foreach (string s in Team)
                        {

                            Team5.AppendText(s);

                            Team5.AppendText("\r\n");
                        }
                    }

                    if (y == 10)
                    {
                        foreach (string s in Team)
                        {

                            Team12.AppendText(s);

                            Team12.AppendText("\r\n");
                        }
                    }

                    if (y == 11)
                    {
                        foreach (string s in Team)
                        {

                            Team6.AppendText(s);

                            Team6.AppendText("\r\n");
                        }
                    }

                    if (y == 12)
                    {
                        foreach (string s in Team)
                        {

                            Team13.AppendText(s);

                            Team13.AppendText("\r\n");
                        }
                    }

                    if (y == 13)
                    {
                        foreach (string s in Team)
                        {

                            Team7.AppendText(s);

                            Team7.AppendText("\r\n");
                        }
                    }

                    if (y == 14)
                    {
                        foreach (string s in Team)
                        {

                            Team14.AppendText(s);

                            Team14.AppendText("\r\n");
                        }
                    }






























                }


                    





                    //if(Ones.Contains(Players[playerNumber]))
                    //{
                    //    Team.Add(Players[playerNumber]);

                    //    Sum = Sum + (int)Ranks[playerNumber];

                    //    Players.Remove(Players[playerNumber].ToString());
                    //    Ranks.Remove(Ranks[playerNumber]);

                    //    Ones.Remove(Ones[playerNumber].ToString());

                    //}
                    
                    //Team.Add(Players[playerNumber]);

                    //Sum = Sum + (int)Ranks[playerNumber];

                    //Players.Remove(Players[playerNumber].ToString());
                    //Ranks.Remove(Ranks[playerNumber]);


               // }





                //if (y == 1)
                //{
                //    foreach (string s in Team)
                //    {

                //        Team1.AppendText(s);
                       
                //        Team1.AppendText("\r\n");

                //        //Team1Sum.Text = Sum.ToString();
                //    }

                //}

                //if (y == 2)
                //{
                //    foreach (string s in Team)
                //    {

                //        Team2.AppendText(s);
                      
                //        Team2.AppendText("\r\n");

                //       // Team2Sum.Text = Sum.ToString();
                //    }
                //}

                //if (y == 3)
                //{
                //    foreach (string s in Team)
                //    {

                //        Team3.AppendText(s);
                      
                //        Team3.AppendText("\r\n");

                //       // Team3Sum.Text = Sum.ToString();
                //    }
                //}

                //if (y == 4)
                //{
                //    foreach (string s in Team)
                //    {

                //        Team4.AppendText(s);
                       
                //        Team4.AppendText("\r\n");

                //       // Team4Sum.Text = Sum.ToString();
                //    }
                //}

                //if (y == 5)
                //{
                //    foreach (string s in Team)
                //    {

                //        Team5.AppendText(s);
                       
                //        Team5.AppendText("\r\n");

                //        //Team5Sum.Text = Sum.ToString();
                //    }
                //}

                //if (y == 6)
                //{
                //    foreach (string s in Team)
                //    {

                //        Team6.AppendText(s);
                     
                //        Team6.AppendText("\r\n");

                //        //Team6Sum.Text = Sum.ToString();
                //    }
                //}

                //if (y == 7)
                //{
                //    foreach (string s in Team)
                //    {

                //        Team7.AppendText(s);
                     
                //        Team7.AppendText("\r\n");

                //        //Team7Sum.Text = Sum.ToString();
                //    }
                //}


                
                //if (y == 8)
                //{
                    
                //    foreach (string s in Team)
                //    {

                        
                //        Team8.AppendText(s);

                //        Team8.AppendText("\r\n");
                //    }
                //}

                //if (y == 9)
                //{
                    
                //    foreach (string s in Team)
                //    {

                //        Team9.AppendText(s);

                //        Team9.AppendText("\r\n");
                //    }
                //}

                //if (y == 10)
                //{
                //    foreach (string s in Team)
                //    {

                //        Team10.AppendText(s);

                //        Team10.AppendText("\r\n");
                //    }
                //}

                //if (y == 11)
                //{
                //    foreach (string s in Team)
                //    {

                //        Team11.AppendText(s);

                //        Team11.AppendText("\r\n");
                //    }
                //}

                //if (y == 12)
                //{
                //    foreach (string s in Team)
                //    {

                //        Team12.AppendText(s);

                //        Team12.AppendText("\r\n");
                //    }
                //}

                //if (y == 13)
                //{
                //    foreach (string s in Team)
                //    {

                //        Team13.AppendText(s);

                //        Team13.AppendText("\r\n");
                //    }
                //}

                //if (y == 14)
                //{
                //    foreach (string s in Team)
                //    {

                //        Team14.AppendText(s);

                //        Team14.AppendText("\r\n");
                //    }
                //}

            }

        }


    }
}
    

