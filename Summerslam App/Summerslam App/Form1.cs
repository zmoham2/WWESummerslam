using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace Summerslam_App
{
    public partial class Form1 : Form
    {
        public readonly string dbfilename = "wrastling.mdf";

        private wrastlingEntities db;

        public Form1()
        {
            InitializeComponent();

            db = new wrastlingEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();

            try
            {
                foreach (Human h in db.Humans)
                {
                    this.listBox1.Items.Add(h);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();
            this.listBox3.Items.Clear();
            this.listBox4.Items.Clear();
            this.listBox5.Items.Clear();
            this.listBox6.Items.Clear();
            this.listBox7.Items.Clear();
            this.listBox8.Items.Clear();
            this.listBox9.Items.Clear();
            this.listBox10.Items.Clear();
            this.listBox11.Items.Clear();
            this.listBox12.Items.Clear();
            this.listBox13.Items.Clear();
            this.listBox14.Items.Clear();
            this.listBox15.Items.Clear();
            this.listBox16.Items.Clear();

            var query1 = from a in db.Men
                         where a.LastName == "Lesnar"
                         select a;
            var query2 = from a in db.Men
                         where a.LastName == "Reigns"
                         select a;
            var query3 = from a in db.Men
                         where a.LastName == "Styles"
                         select a;
            var query4 = from a in db.Men
                         where a.LastName == "Joe"
                         select a;
            var query5 = from a in db.Women
                         where a.LastName == "Bliss"
                         select a;
            var query6 = from a in db.Women
                         where a.LastName == "Rousey"
                         select a;
            var query7 = from a in db.Women
                         where a.LastName == "Carmella"
                         select a;
            var query8 = from a in db.Women
                         where a.LastName == "Lynch"
                         select a;
            var query9 = from a in db.Women
                         where a.LastName == "Flair"
                         select a;
            var query10 = from a in db.Men
                         where a.LastName == "Team"
                         select a;
            var query11 = from a in db.Men
                         where a.LastName == "Revival"
                         select a;
            var query12 = from a in db.Men
                         where a.LastName == "Deleters"
                         select a;
            var query13 = from a in db.Men
                          where a.LastName == "Day"
                          select a;
            var query14 = from a in db.Men
                          where a.LastName == "Brothers"
                          select a;
            var query15 = from a in db.Men
                          where a.LastName == "Ziggler"
                          select a;
            var query16 = from a in db.Men
                          where a.LastName == "Rollins"
                          select a;
            var query17 = from a in db.Men
                          where a.LastName == "Nakamura"
                          select a;
            var query18 = from a in db.Men
                          where a.LastName == "Hardy"
                          select a;
            var query19 = from a in db.Men
                          where a.LastName == "Alexander"
                          select a;
            var query20 = from a in db.Men
                          where a.LastName == "Gulak"
                          select a;
            var query21 = from a in db.Men
                          where a.LastName == "Strowman"
                          select a;
            var query22 = from a in db.Men
                          where a.LastName == "Owens"
                          select a;
            var query23 = from a in db.Men
                          where a.LastName == "Bryan"
                          select a;
            var query24 = from a in db.Men
                          where a.LastName == "Miz"
                          select a;
            var query25 = from a in db.Men
                          where a.LastName == "Corbin"
                          select a;
            var query26 = from a in db.Men
                          where a.LastName == "Balor"
                          select a;
            var query27 = from a in db.Men
                          where a.LastName == "Almas"
                          select a;
            var query28 = from a in db.Men
                          where a.FirstName == "Rusev"
                          select a;
            var query29 = from a in db.Men
                          where a.LastName == "Lashley"
                          select a;
            var query30 = from a in db.Men
                          where a.LastName == "Elias"
                          select a;
            var query31 = from a in db.Women
                          where a.LastName == "Hug"
                          select a;
            var query32 = from a in db.Women
                          where a.LastName == "Squad"
                          select a;

            try
            {
                // WWE Universal Championship match
                this.listBox2.Items.Add(query1.FirstOrDefault());
                this.listBox2.Items.Add(query2.FirstOrDefault());
                // WWE Heavyweight Championship match
                this.listBox3.Items.Add(query3.FirstOrDefault());
                this.listBox3.Items.Add(query4.FirstOrDefault());
                // WWE RAW Women's Championship match
                this.listBox4.Items.Add(query5.FirstOrDefault());
                this.listBox4.Items.Add(query6.FirstOrDefault());
                // WWE Smackdown Women's Championship match
                this.listBox5.Items.Add(query7.FirstOrDefault());
                this.listBox5.Items.Add(query8.FirstOrDefault());
                this.listBox5.Items.Add(query9.FirstOrDefault());
                // WWE RAW Men's Tag Team Championship match
                this.listBox6.Items.Add(query10.FirstOrDefault());
                this.listBox6.Items.Add(query11.FirstOrDefault());
                this.listBox6.Items.Add(query12.FirstOrDefault());
                // WWE Smackdown Men's Tag Team Championship match
                this.listBox7.Items.Add(query13.FirstOrDefault());
                this.listBox7.Items.Add(query14.FirstOrDefault());
                // Intercontinental Championship
                this.listBox8.Items.Add(query15.FirstOrDefault());
                this.listBox8.Items.Add(query16.FirstOrDefault());
                // US Championship
                this.listBox9.Items.Add(query17.FirstOrDefault());
                this.listBox9.Items.Add(query18.FirstOrDefault());
                // Cruiserweight Championship
                this.listBox10.Items.Add(query19.FirstOrDefault());
                this.listBox10.Items.Add(query20.FirstOrDefault());
                // MITB 
                this.listBox11.Items.Add(query21.FirstOrDefault());
                this.listBox11.Items.Add(query22.FirstOrDefault());
                // Daniel Bryan vs. Miz
                this.listBox12.Items.Add(query23.FirstOrDefault());
                this.listBox12.Items.Add(query24.FirstOrDefault());
                // Finn Balor vs. Corbin
                this.listBox13.Items.Add(query25.FirstOrDefault());
                this.listBox13.Items.Add(query26.FirstOrDefault());
                // Cien Almas + Zelina Vega vs. Rusev + Lana
                this.listBox14.Items.Add(query27.FirstOrDefault());
                this.listBox14.Items.Add(query28.FirstOrDefault());
                // Bobby Lashley vs. Elias
                this.listBox15.Items.Add(query29.FirstOrDefault());
                this.listBox15.Items.Add(query30.FirstOrDefault());
                // Boss N Hug vs. Riott Squad
                this.listBox16.Items.Add(query31.FirstOrDefault());
                this.listBox16.Items.Add(query32.FirstOrDefault());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex < 0) // nothing selected:
            {
                MessageBox.Show("Please select your name...");
                return;
            }
            if (this.listBox2.SelectedIndex < 0 || this.listBox3.SelectedIndex < 0
                || this.listBox4.SelectedIndex < 0 || this.listBox5.SelectedIndex < 0
                || this.listBox6.SelectedIndex < 0 || this.listBox7.SelectedIndex < 0
                || this.listBox8.SelectedIndex < 0 || this.listBox9.SelectedIndex < 0
                || this.listBox10.SelectedIndex < 0 || this.listBox11.SelectedIndex < 0
                || this.listBox12.SelectedIndex < 0 || this.listBox13.SelectedIndex < 0
                || this.listBox14.SelectedIndex < 0 || this.listBox15.SelectedIndex < 0
                || this.listBox16.SelectedIndex < 0) 
            {
                MessageBox.Show("Please select all your picks before submitting...");
                return;
            }

            Human h = (Human)this.listBox1.SelectedItem;
            Man a = (Man)this.listBox2.SelectedItem;
            Man b = (Man)this.listBox3.SelectedItem;
            Woman c = (Woman)this.listBox4.SelectedItem;
            Woman d = (Woman)this.listBox5.SelectedItem;
            Man ea = (Man)this.listBox6.SelectedItem;
            Man f = (Man)this.listBox7.SelectedItem;
            Man g = (Man)this.listBox8.SelectedItem;
            Man ha = (Man)this.listBox9.SelectedItem;
            Man i = (Man)this.listBox10.SelectedItem;
            Man j = (Man)this.listBox11.SelectedItem;
            Man k = (Man)this.listBox12.SelectedItem;
            Man l = (Man)this.listBox13.SelectedItem;
            Man m = (Man)this.listBox14.SelectedItem;
            Man n = (Man)this.listBox15.SelectedItem;
            Woman o = (Woman)this.listBox16.SelectedItem;



            try
            {
                var query1 = from p in db.Picks
                             where p.HID == h.HID
                             select p;

                if (query1.Count() < 1)
                {
                    Pick enrollment = new Pick();
                    enrollment.HID = h.HID;
                    enrollment.Universal = a.FirstName + " " + a.LastName;
                    enrollment.Heavyweight = b.FirstName + " " + b.LastName;
                    enrollment.RWomen = c.FirstName + " " + c.LastName;
                    enrollment.SDWomen = d.FirstName + " " + d.LastName;
                    enrollment.RawTag = ea.FirstName + " " + ea.LastName;
                    enrollment.SDTag = f.FirstName + " " + f.LastName;
                    enrollment.IC = g.FirstName + " " + g.LastName;
                    enrollment.US = ha.FirstName + " " + ha.LastName;
                    enrollment.CW = i.FirstName + " " + i.LastName;
                    enrollment.DBMiz = j.FirstName + " " + j.LastName;
                    enrollment.MITB = k.FirstName + " " + k.LastName;
                    enrollment.BalCorbin = l.FirstName + " " + l.LastName;
                    enrollment.AlmasRusev = m.FirstName + " " + m.LastName;
                    enrollment.LashElias = n.FirstName + " " + n.LastName;
                    enrollment.BossSquad = o.FirstName + " " + o.LastName;

                    db.Picks.Add(enrollment);
                    db.SaveChanges();
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Zoheb\Desktop\SS2018\Summerslam App\smartmofo.wav");
                    player.Play();
                    MessageBox.Show(string.Format("Your picks have been created '{0}'. Good luck!", h.FirstName.ToString()));
                    this.listBox1.Items.Clear();
                    this.listBox2.Items.Clear();
                    this.listBox3.Items.Clear();
                    this.listBox4.Items.Clear();
                    this.listBox5.Items.Clear();
                    this.listBox6.Items.Clear();
                    this.listBox7.Items.Clear();
                    this.listBox8.Items.Clear();
                    this.listBox9.Items.Clear();
                    this.listBox10.Items.Clear();
                    this.listBox11.Items.Clear();
                    this.listBox12.Items.Clear();
                    this.listBox13.Items.Clear();
                    this.listBox14.Items.Clear();
                    this.listBox15.Items.Clear();
                    this.listBox16.Items.Clear();
                    this.listBox17.Items.Clear();
                }
                else
                {
                    MessageBox.Show(String.Format("Nice try {0}", h.FirstName.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Testing");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetPicksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void resetPicksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataAccessTier.Data datatier = new DataAccessTier.Data(dbfilename);

            try
            {
                // delete all records from StudentCourses
                string sql = string.Format(@"
                                       DELETE FROM Picks;  
                                       ");

                datatier.ExecuteActionQuery(sql);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Test");
            }

            //
            // reset the GUI:
            //
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox3.Items.Clear();
            this.listBox4.Items.Clear();
            this.listBox5.Items.Clear();
            this.listBox6.Items.Clear();
            this.listBox7.Items.Clear();
            this.listBox8.Items.Clear();
            this.listBox9.Items.Clear();
            this.listBox10.Items.Clear();
            this.listBox11.Items.Clear();
            this.listBox12.Items.Clear();
            this.listBox13.Items.Clear();
            this.listBox14.Items.Clear();
            this.listBox15.Items.Clear();
            this.listBox16.Items.Clear();
            this.listBox17.Items.Clear();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox17.Items.Clear();
            Human h = (Human)this.listBox1.SelectedItem;

            var query = from a in db.Picks
                        where a.HID == h.HID
                        select a;
            //
            // THE WINNER'S CIRCLE: UPDATED THROUGHOUT THE NIGHT!
            //

            /*var query2 = from a in db.Picks
                        where a.HID == h.HID && a.Universal == "Roman Reigns"
                        select a;*/
            var query3 = from a in db.Picks
                        where a.HID == h.HID && a.Heavyweight == "Samoa Joe"
                        select a;
            var query4 = from a in db.Picks
                        where a.HID == h.HID && a.RWomen == "Ronda Rousey"
                        select a; 
            var query5 = from a in db.Picks
                        where a.HID == h.HID && a.SDWomen == "Charlotte Flair"
                        select a;
            var query6 = from a in db.Picks
                        where a.HID == h.HID && a.RawTag == "B Team"
                        select a;
            var query7 = from a in db.Picks
                        where a.HID == h.HID && a.SDTag == "New Day"
                        select a;
            var query8 = from a in db.Picks
                        where a.HID == h.HID && a.IC == "Seth Rollins"
                        select a;
            var query12 = from a in db.Picks
                        where a.HID == h.HID && a.DBMiz == "Braun Strowman"
                          select a;
            var query9 = from a in db.Picks
                        where a.HID == h.HID && a.US == "Shinsuke Nakamura"
                        select a;
            var query11 = from a in db.Picks
                        where a.HID == h.HID && a.MITB == "Mike Miz"
                        select a;
            
            var query13 = from a in db.Picks
                        where a.HID == h.HID && a.BalCorbin == "Finn Balor"
                        select a;
           
           int winning = query6.Count() + query8.Count() + query7.Count() + query12.Count() + query5.Count() + query3.Count() + query11.Count() + query13.Count() + query9.Count() + query4.Count();

            if (query.Count() > 0)
            {
                this.listBox17.Items.Add("The amount of correct picks:");
                this.listBox17.Items.Add(winning);

            }
            else
            {
                this.listBox17.Items.Add("Waiting for picks");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
