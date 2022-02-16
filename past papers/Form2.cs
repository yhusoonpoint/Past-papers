using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace past_papers
{
    public partial class Form2 : Form
    {
        private string checkbutton;static int onoroff;
        public Form2()
        {
            InitializeComponent();
            this.Text = "  MARK SCHEME";
        }
        private void openfile(string open, byte[] opner)
        {
            string locationToSavePdf = Path.Combine(Path.GetTempPath(), open);
            File.WriteAllBytes(locationToSavePdf, opner);
            Process.Start(locationToSavePdf);
        }        
        private void Form2_Load(object sender, EventArgs e)
        {
            DialogResult u = MessageBox.Show("ENABLE FLAHING COLOURS?", "ENABLE OR NA",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (u)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    timer1.Enabled = true;
                    button5.Text = "DISABLE FLAHING COLOURS";
                    onoroff = 1;
                    break;
                case System.Windows.Forms.DialogResult.No:
                    timer1.Enabled = false;
                    button5.Text = "ENABLE FLAHING COLOURS";
                    onoroff = 2;
                    break;
                default:
                    timer1.Enabled = true;
                    break;
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {

            Random rand = new Random();
            int change = rand.Next(1, 11);
            switch (change)
            {
                case 1:
                    this.BackColor = System.Drawing.Color.RoyalBlue;
                    this.button3.BackColor = System.Drawing.Color.RoyalBlue;
                    this.button4.BackColor = System.Drawing.Color.RoyalBlue;
                    this.button5.BackColor = System.Drawing.Color.RoyalBlue;
                    this.button1.BackColor = System.Drawing.Color.RoyalBlue;
                    this.button2.BackColor = System.Drawing.Color.RoyalBlue;
                    this.comboBox2.BackColor = System.Drawing.Color.RoyalBlue;
                    this.comboBox1.BackColor = System.Drawing.Color.RoyalBlue;
                    this.listBox1.BackColor = System.Drawing.Color.RoyalBlue;
                    this.Text = "MARK SCHEME";
                    break;
                case 2:
                    this.BackColor = System.Drawing.Color.Black;
                    this.button3.BackColor = System.Drawing.Color.Black;
                    this.button4.BackColor = System.Drawing.Color.Black;
                    this.button5.BackColor = System.Drawing.Color.Black;
                    this.button1.BackColor = System.Drawing.Color.Black;
                    this.button2.BackColor = System.Drawing.Color.Black;
                    this.comboBox2.BackColor = System.Drawing.Color.Black;
                    this.comboBox1.BackColor = System.Drawing.Color.Black;
                    this.listBox1.BackColor = System.Drawing.Color.Black;
                    this.Text = "      MARK SCHEME";
                    break;
                case 3:
                    this.BackColor = System.Drawing.Color.DarkGreen;
                    this.button3.BackColor = System.Drawing.Color.DarkGreen;
                    this.button5.BackColor = System.Drawing.Color.DarkGreen;
                    this.button1.BackColor = System.Drawing.Color.DarkGreen;
                    this.button4.BackColor = System.Drawing.Color.DarkGreen;
                    this.button2.BackColor = System.Drawing.Color.DarkGreen;
                    this.comboBox2.BackColor = System.Drawing.Color.DarkGreen;
                    this.comboBox1.BackColor = System.Drawing.Color.DarkGreen;
                    this.listBox1.BackColor = System.Drawing.Color.DarkGreen;
                    this.Text = "                MARK SCHEME";
                    break;
                case 4:
                    this.BackColor = System.Drawing.Color.DarkOrange;
                    this.button3.BackColor = System.Drawing.Color.DarkOrange;
                    this.button1.BackColor = System.Drawing.Color.DarkOrange;
                    this.button5.BackColor = System.Drawing.Color.DarkOrange;
                    this.button4.BackColor = System.Drawing.Color.DarkOrange;
                    this.button2.BackColor = System.Drawing.Color.DarkOrange;
                    this.comboBox2.BackColor = System.Drawing.Color.DarkOrange;
                    this.comboBox1.BackColor = System.Drawing.Color.DarkOrange;
                    this.listBox1.BackColor = System.Drawing.Color.DarkOrange;
                    this.Text = "         MARK SCHEME";
                    break;
                case 5:
                    this.BackColor = System.Drawing.Color.DarkGreen;
                    this.button3.BackColor = System.Drawing.Color.DarkGreen;
                    this.button1.BackColor = System.Drawing.Color.DarkGreen;
                    this.button5.BackColor = System.Drawing.Color.DarkGreen;
                    this.button4.BackColor = System.Drawing.Color.DarkGreen;
                    this.button2.BackColor = System.Drawing.Color.DarkGreen;
                    this.comboBox2.BackColor = System.Drawing.Color.DarkGreen;
                    this.comboBox1.BackColor = System.Drawing.Color.DarkGreen;
                    this.listBox1.BackColor = System.Drawing.Color.DarkGreen;
                    this.Text = "      MARK SCHEME";
                    break;
                case 6:
                    this.BackColor = System.Drawing.Color.DarkViolet;
                    this.button3.BackColor = System.Drawing.Color.DarkViolet;
                    this.button1.BackColor = System.Drawing.Color.DarkViolet;
                    this.button5.BackColor = System.Drawing.Color.DarkViolet;
                    this.button4.BackColor = System.Drawing.Color.DarkViolet;
                    this.button2.BackColor = System.Drawing.Color.DarkViolet;
                    this.comboBox2.BackColor = System.Drawing.Color.DarkViolet;
                    this.comboBox1.BackColor = System.Drawing.Color.DarkViolet;
                    this.listBox1.BackColor = System.Drawing.Color.DarkViolet;
                    this.Text = "       MARK SCHEME";
                    break;
                case 7:
                    this.BackColor = System.Drawing.Color.Purple;
                    this.button3.BackColor = System.Drawing.Color.Purple;
                    this.button1.BackColor = System.Drawing.Color.Purple;
                    this.button4.BackColor = System.Drawing.Color.Purple;
                    this.button2.BackColor = System.Drawing.Color.Purple;
                    this.button5.BackColor = System.Drawing.Color.Purple;
                    this.comboBox2.BackColor = System.Drawing.Color.Purple;
                    this.comboBox1.BackColor = System.Drawing.Color.Purple;
                    this.listBox1.BackColor = System.Drawing.Color.Purple;
                    this.Text = "           MARK SCHEME";
                    break;
                case 8:
                    this.BackColor = System.Drawing.Color.Tomato;
                    this.button3.BackColor = System.Drawing.Color.Tomato;
                    this.button1.BackColor = System.Drawing.Color.Tomato;
                    this.button2.BackColor = System.Drawing.Color.Tomato;
                    this.button5.BackColor = System.Drawing.Color.Tomato;
                    this.button4.BackColor = System.Drawing.Color.Tomato;
                    this.comboBox2.BackColor = System.Drawing.Color.Tomato;
                    this.comboBox1.BackColor = System.Drawing.Color.Tomato;
                    this.listBox1.BackColor = System.Drawing.Color.Tomato;
                    this.Text = "            MARK SCHEME";
                    break;
                case 9:
                    this.BackColor = System.Drawing.Color.Purple;
                    this.button3.BackColor = System.Drawing.Color.Purple;
                    this.button1.BackColor = System.Drawing.Color.Purple;
                    this.button4.BackColor = System.Drawing.Color.Purple;
                    this.button5.BackColor = System.Drawing.Color.Purple;
                    this.button2.BackColor = System.Drawing.Color.Purple;
                    this.comboBox2.BackColor = System.Drawing.Color.Purple;
                    this.comboBox1.BackColor = System.Drawing.Color.Purple;
                    this.listBox1.BackColor = System.Drawing.Color.Purple;
                    this.Text = "        DeaDViruS";
                    break;
                case 10:
                    this.BackColor = System.Drawing.Color.SandyBrown;
                    this.button3.BackColor = System.Drawing.Color.SandyBrown;
                    this.button1.BackColor = System.Drawing.Color.SandyBrown;
                    this.button4.BackColor = System.Drawing.Color.SandyBrown;
                    this.button5.BackColor = System.Drawing.Color.SandyBrown;
                    this.button2.BackColor = System.Drawing.Color.SandyBrown;
                    this.comboBox2.BackColor = System.Drawing.Color.SandyBrown;
                    this.comboBox1.BackColor = System.Drawing.Color.SandyBrown;
                    this.listBox1.BackColor = System.Drawing.Color.SandyBrown;
                    this.Text = "               MARK SCHEME";
                    break;

            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "MATHS")
            {
                comboBox2.Visible = true;
                button2.Visible = true;
                comboBox2.Items.Clear();
                this.comboBox2.Items.AddRange(new object[] {
            "C1",
            "C2",
            "C3",
            "C4",
            "S1"});

            }
            else if (comboBox1.Text == "PHYSICS")
            {
                comboBox2.Visible = true;
                button2.Visible = true;
                comboBox2.Items.Clear();
                this.comboBox2.Items.AddRange(new object[] {
            "ELECTRONS, WAVE AND PROTONS",
            "MECHANICS"});
            }
            else if (comboBox1.Text == "ELECTRONICS")
            {

                comboBox2.Visible = true;
                button2.Visible = true;
                comboBox2.Items.Clear();
                this.comboBox2.Items.AddRange(new object[] {
            "SIMPLE SYSTEMS",
            "SIGNAL PROCESSOR"});
            }
            else if (comboBox1.Text == "COMPUTING")
            {
                comboBox2.Visible = true;
                button2.Visible = true;
                comboBox2.Items.Clear();
                this.comboBox2.Items.AddRange(new object[] {
            "COMPUTER FUNDAMENTALS",
            "PROGRAMMING TECHNIQUES AND LOGICAL METHODS"});
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            comboBox2.Visible = false;
            button2.Visible = false;
            if (comboBox2.Text == "C1")
            {

                checkbutton = "c1";
                this.listBox1.Items.AddRange(new object[] {
                    "   C1",
            "january 2005",
            "january 2006",
            "january 2008",
            "january 2009",
            "january 2010",
            "january 2011",
            "january 2012",
            "january 2013",
            "june 2005",
            "june 2007",
            "june 2008",
            "june 2009",
            "june 2010",
            "june 2011",
            "june 2012",
            "june 2013"});
            }
            else if (comboBox2.Text == "C2")
            {
                checkbutton = "c2";
                this.listBox1.Items.AddRange(new object[] {
                     "   C2",
            "january 2005",
            "january 2006",
            "january 2008",
            "january 2009",
            "january 2010",
            "january 2011",
            "january 2012",
            "january 2013",
            "june 2005",
            "june 2006",
            "june 2007",
            "june 2008",
            "june 2009",
            "june 2010",
            "june 2011",
            "june 2012",
            "june 2013"});
            }
            else if (comboBox2.Text == "C3")
            {
                checkbutton = "c3";
                this.listBox1.Items.AddRange(new object[] {
                     "   C3",
            "january 2006",
            "january 2008",
            "january 2009",
            "january 2010",
            "january 2011",
            "january 2012",
            "january 2013",
            "june 2005",
            "june 2006",
            "june 2007",
            "june 2008",
            "june 2009",
            "june 2010",
            "june 2011",
            "june 2012",
            "june 2013"});
            }
            else if (comboBox2.Text == "C4")
            {
                checkbutton = "c4";
                this.listBox1.Items.AddRange(new object[] {
                     "   C4",
            "january 2006",
            "january 2008",
            "january 2009",
            "january 2010",
            "january 2011",
            "january 2012",
            "january 2013",
            "june 2005",
            "june 2006",
            "june 2007",
            "june 2008",
            "june 2009",
            "june 2010",
            "june 2011",
            "june 2012",
            "june 2013"});
            }
            else if (comboBox2.Text == "S1")
            {
                checkbutton = "s1";
                this.listBox1.Items.AddRange(new object[] {
                     "   S1",
            "january 2003",
            "january 2005",
            "january 2006",
            "january 2007",
            "january 2008",
            "january 2009",
            "january 2010",
            "january 2011",
            "january 2012",
            "january 2013",
            "june 2005",
            "june 2006",
            "june 2007",
            "june 2008",
            "june 2009",
            "june 2010",
            "june 2011",
            "june 2012",
            "june 2013"});
            }
            else if (comboBox2.Text == "ELECTRONS, WAVE AND PROTONS")
            {
                checkbutton = "EWP";
                this.listBox1.Items.AddRange(new object[] {
                     "ELECTRONS, WAVE AND PROTONS",
            "january 2010",
            "january 2011",
            "january 2012",
            "january 2013",
            "june 2009",
            "june 2010",
            "june 2011",
            "june 2012",
            "june 2013"});
            }
            else if (comboBox2.Text == "MECHANICS")
            {
                checkbutton = "MECH";
                this.listBox1.Items.AddRange(new object[] {
                     "MECHANICS",
            "january 2009",
            "january 2010",
            "january 2011",
            "january 2012",
            "january 2013",
            "june 2009",
            "june 2010",
            "june 2011",
            "june 2012",
            "june 2013"});
            }
            else if (comboBox2.Text == "COMPUTER FUNDAMENTALS")
            {
                checkbutton = "CF";
                this.listBox1.Items.AddRange(new object[] {
                     "COMPUTER FUNDAMENTALS",
            "january 2009",
            "january 2010",
            "january 2011",
            "january 2012",
            "january 2013",
            "june 2009",
            "june 2010",
            "june 2011",
            "june 2012",
            "june 2013"});
            }
            else if (comboBox2.Text == "PROGRAMMING TECHNIQUES AND LOGICAL METHODS")
            {
                checkbutton = "PTALM";
                this.listBox1.Items.AddRange(new object[] {
                     "PROGRAMMING TECHNIQUES AND LOGICAL METHODS",
            "january 2009",
            "january 2010",
            "january 2011",
            "january 2012",
            "january 2013",
            "june 2009",
            "june 2010",
            "june 2011",
            "june 2012",
            "june 2013"});
            }
            else if (comboBox2.Text == "SIMPLE SYSTEMS")
            {
                checkbutton = "SS";
                this.listBox1.Items.AddRange(new object[] {
                     "SIMPLE SYSTEMS",
            "june 2009",
            "june 2010",
            "june 2011",
            "june 2012",
            "june 2013"});
            }
            else if (comboBox2.Text == "SIGNAL PROCESSOR")
            {
                checkbutton = "SP";
                this.listBox1.Items.AddRange(new object[] {
                     "SIGNAL PROCESSOR",
            "june 2009",
            "june 2010",
            "june 2011",
            "june 2012",
            "june 2013"});
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {

            #region mathsc1
            if (checkbutton == "c1")
            {
                if (listBox1.SelectedItem.ToString() == "january 2005")
                { openfile("Markscheme-UnitC1(6663)-January2005.doc", Properties.Resources.mc1ja05); }
                else if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("Markscheme-UnitC1(6663)-January2006.doc", Properties.Resources.mc1ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("Markscheme-UnitC1(6663)-January2008.pdf", Properties.Resources.mc1ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("Markscheme-UnitC1(6663)-January2009.pdf", Properties.Resources.mc1ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("Markscheme-UnitC1(6663)-January2010.pdf", Properties.Resources.mc1ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("Markscheme-UnitC1(6663)-January2011.pdf", Properties.Resources.mc1ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("Markscheme-UnitC1(6663)-January2012.pdf", Properties.Resources.mc1ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("Markscheme-UnitC1(6663)-January2013.pdf", Properties.Resources.mc1ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("Markscheme-UnitC1(6663)-June2005.pdf", Properties.Resources.mc1ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("Markscheme-UnitC1(6663)-June2007.doc", Properties.Resources.mc1ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("Markscheme-UnitC1(6663)-June2008.pdf", Properties.Resources.mc1ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("Markscheme-Multipleunits-June2009.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("Markscheme-UnitC1(6663)-June2010.pdf", Properties.Resources.mc1ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("Markscheme-UnitC1(6663)-June2011.pdf", Properties.Resources.mc1ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("Markscheme-UnitC1(6663)-June2012.pdf", Properties.Resources.mc1ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("Markscheme-UnitC1(6663)-June2013.pdf", Properties.Resources.mc1ju13); }
            }
            #endregion
            #region mathc2
            else if (checkbutton == "c2")
            {
                if (listBox1.SelectedItem.ToString() == "january 2005")
                { openfile("Markscheme-UnitC2(6664)-January2005.doc", Properties.Resources.mc2ja05); }
                else if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("Markscheme-UnitC2(6664)-January2006.doc", Properties.Resources.mc2ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("Markscheme-UnitC2(6664)-January2008.pdf", Properties.Resources.mc2ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("Markscheme-UnitC2(6664)-January2009.pdf", Properties.Resources.mc2ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("Markscheme-UnitC2(6664)-January2010.pdf", Properties.Resources.mc2ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("Markscheme-UnitC2(6664)-January2011.pdf", Properties.Resources.mc2ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("Markscheme-UnitC2(6664)-January2012.pdf", Properties.Resources.mc2ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("Markscheme-UnitC2(6664)-January2013.pdf", Properties.Resources.mc2ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("Markscheme-UnitC2(6664)-June2005.pdf", Properties.Resources.mc2ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("Markscheme-UnitC2(6664)-June2006.pdf", Properties.Resources.mc2ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("Markscheme-UnitC2(6664)-June2007.doc", Properties.Resources.mc2ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("Markscheme-UnitC2(6664)-June2008.pdf", Properties.Resources.mc2ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("Markscheme-Multipleunits-June2009.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("Markscheme-UnitC2(6664)-June2010.pdf", Properties.Resources.mc2ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("Markscheme-UnitC2(6664)-June2011.pdf", Properties.Resources.mc2ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("Markscheme-UnitC2(6664)-June2012.pdf", Properties.Resources.mc2ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("Markscheme-UnitC2(6664)-June2013.pdf", Properties.Resources.mc2ju13); }
            }
            #endregion
            #region mathc3
            else if (checkbutton == "c3")
            {
                if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("mc3ja06.pdf", Properties.Resources.mc3ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("mc3ja08.pdf", Properties.Resources.mc3ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("mc3ja09.pdf", Properties.Resources.mc3ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("mc3ja10.pdf", Properties.Resources.mc3ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("mc3ja11.pdf", Properties.Resources.mc3ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("mc3ja12.pdf", Properties.Resources.mc3ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("mc3ja13.pdf", Properties.Resources.mc3ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("mc3ju05.pdf", Properties.Resources.mc3ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("mc3ju06.pdf", Properties.Resources.mc3ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("mc3ju07.doc", Properties.Resources.mc3ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("mc3ju08.pdf", Properties.Resources.mc3ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mc3ju09.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mc3ju10.pdf", Properties.Resources.mc3ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mc3ju11.pdf", Properties.Resources.mc3ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mc3ju12.pdf", Properties.Resources.mc3ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mc3ju13.pdf", Properties.Resources.mc3ju13); }
            }
            #endregion
            #region mathc4
            else if (checkbutton == "c4")
            {
                if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("mc4ja06.pdf", Properties.Resources.mc4ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("mc4ja08.pdf", Properties.Resources.mc4ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("mc4ja09.pdf", Properties.Resources.mc4ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("mc4ja10.pdf", Properties.Resources.mc4ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("mc4ja11.pdf", Properties.Resources.mc4ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("mc4ja12.pdf", Properties.Resources.mc4ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("mc4ja13.pdf", Properties.Resources.mc4ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("mc4ju05.pdf", Properties.Resources.mc4ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("mc4ju06.pdf", Properties.Resources.mc4ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("mc4ju07.doc", Properties.Resources.mc4ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("mc4ju08.pdf", Properties.Resources.mc4ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mc4ju09.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mc4ju10.pdf", Properties.Resources.mc4ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mc4ju11.pdf", Properties.Resources.mc4ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mc4ju12.pdf", Properties.Resources.mc4ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mc4ju13.pdf", Properties.Resources.mc4ju13); }
            }
            #endregion
            #region maths1
            else if (checkbutton == "s1")
            {
                if (listBox1.SelectedItem.ToString() == "january 2003")
                { openfile("ms1ja03.pdf", Properties.Resources.ms1ja03); }
                else if (listBox1.SelectedItem.ToString() == "january 2005")
                { openfile("ms1ja05.pdf", Properties.Resources.ms1ja05); }
                else if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("ms1ja06.pdf", Properties.Resources.ms1ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("ms1ja08.pdf", Properties.Resources.ms1ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("ms1ja09.pdf", Properties.Resources.ms1ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("ms1ja10.pdf", Properties.Resources.ms1ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("ms1ja11.pdf", Properties.Resources.ms1ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("ms1ja12.pdf", Properties.Resources.ms1ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("ms1ja13.pdf", Properties.Resources.ms1ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("ms1ju05.pdf", Properties.Resources.ms1ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("ms1ju06.pdf", Properties.Resources.ms1ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("ms1ju07.doc", Properties.Resources.ms1ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("ms1ju08.pdf", Properties.Resources.ms1ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("ms1ju09.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("ms1ju10.pdf", Properties.Resources.ms1ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("ms1ju11.pdf", Properties.Resources.ms1ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("ms1ju12.pdf", Properties.Resources.ms1ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("ms1ju13.pdf", Properties.Resources.ms1ju13); }
            }
            #endregion
            #region electronics wave and protons
            else if (checkbutton == "EWP")
            {
                if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("mewpja10.pdf", Properties.Resources.mewpja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("mewpja11.pdf", Properties.Resources.mewpja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("mewpja12.pdf", Properties.Resources.mewpja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("mewpja13.pdf", Properties.Resources.mewpja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mewpju09.pdf", Properties.Resources.mewpju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mewpju10.pdf", Properties.Resources.mewpju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mewpju11.pdf", Properties.Resources.mewpju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mewpju12.pdf", Properties.Resources.mewpju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mewpju13.pdf", Properties.Resources.mewpju13); }
            }
            #endregion
            #region mechanics
            else if (checkbutton == "MECH")
            {
                if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("mmechanicsja09.pdf", Properties.Resources.mmechanicsja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("mmechanicsja10.pdf", Properties.Resources.mmechanicsja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("mmechanicsja11.pdf", Properties.Resources.mmechanicsja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("mmechanicsja12.pdf", Properties.Resources.mmechanicsja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("mmechanicsja13.pdf", Properties.Resources.mmechanicsja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mmechanicsju09.pdf", Properties.Resources.mmechanicsju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mmechanicsju10.pdf", Properties.Resources.mmechanicsju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mmechanicsju11.pdf", Properties.Resources.mmechanicsju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mmechanicsju12.pdf", Properties.Resources.mmechanicsju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mmechanicsju13.pdf", Properties.Resources.mmechanicsju13); }
            }
            #endregion
            #region programming
            else if (checkbutton == "PTALM")
            {
                if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("mptalmja09.pdf", Properties.Resources.mptalmja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("mptalmja10.pdf", Properties.Resources.mptalmja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("mptalmja11.pdf", Properties.Resources.mptalmja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("mptalmja12.pdf", Properties.Resources.mptalmja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("mptalmja13.pdf", Properties.Resources.mptalmja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mptalmju09.pdf", Properties.Resources.mptalmju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mptalmju10.pdf", Properties.Resources.mptalmju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mptalmju11.pdf", Properties.Resources.mptalmju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mptalmju12.pdf", Properties.Resources.mptalmju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mptalmju13.pdf", Properties.Resources.mptalmju13); }
            }
            #endregion
            #region COMPUTER FUNDAMENTALS
            else if (checkbutton == "CF")
            {
                if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("mcfja09.pdf", Properties.Resources.mcfja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("mcfja10.pdf", Properties.Resources.mcfja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("mcfja11.pdf", Properties.Resources.mcfja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("mcfja12.pdf", Properties.Resources.mcfja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("mcfja13.pdf", Properties.Resources.mcfja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mcfju09.pdf", Properties.Resources.mcfju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mcfju10.pdf", Properties.Resources.mcfju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mcfju11.pdf", Properties.Resources.mcfju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mcfju12.pdf", Properties.Resources.mcfju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mcfju13.pdf", Properties.Resources.mcfju13); }
            }
            #endregion
            #region SIMPLE SYSTEM
            else if (checkbutton == "SS")
            {
                if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mssju09.pdf", Properties.Resources.mssju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mssju10.pdf", Properties.Resources.mssju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mssju11.pdf", Properties.Resources.mssju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mssju12.pdf", Properties.Resources.mssju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mssju13.pdf", Properties.Resources.mssju13); }
            }
            #endregion
            #region SIGNAL SYSTEM
            else if (checkbutton == "SP")
            {
                if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mspju09.pdf", Properties.Resources.mspju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mspju10.pdf", Properties.Resources.mspju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mspju11.pdf", Properties.Resources.mspju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mspju12.pdf", Properties.Resources.mspju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mspju13.pdf", Properties.Resources.mspju13); }
            }
            #endregion
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 forms = new Form1();
            forms.WindowState = FormWindowState.Maximized;
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
            #region mathsc1
            if (checkbutton == "c1")
            {
                if (listBox1.SelectedItem.ToString() == "january 2005")
                { openfile("Markscheme-UnitC1(6663)-January2005.doc", Properties.Resources.mc1ja05); }
                else if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("Markscheme-UnitC1(6663)-January2006.doc", Properties.Resources.mc1ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("Markscheme-UnitC1(6663)-January2008.pdf", Properties.Resources.mc1ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("Markscheme-UnitC1(6663)-January2009.pdf", Properties.Resources.mc1ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("Markscheme-UnitC1(6663)-January2010.pdf", Properties.Resources.mc1ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("Markscheme-UnitC1(6663)-January2011.pdf", Properties.Resources.mc1ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("Markscheme-UnitC1(6663)-January2012.pdf", Properties.Resources.mc1ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("Markscheme-UnitC1(6663)-January2013.pdf", Properties.Resources.mc1ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("Markscheme-UnitC1(6663)-June2005.pdf", Properties.Resources.mc1ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("Markscheme-UnitC1(6663)-June2007.doc", Properties.Resources.mc1ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("Markscheme-UnitC1(6663)-June2008.pdf", Properties.Resources.mc1ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("Markscheme-Multipleunits-June2009.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("Markscheme-UnitC1(6663)-June2010.pdf", Properties.Resources.mc1ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("Markscheme-UnitC1(6663)-June2011.pdf", Properties.Resources.mc1ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("Markscheme-UnitC1(6663)-June2012.pdf", Properties.Resources.mc1ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("Markscheme-UnitC1(6663)-June2013.pdf", Properties.Resources.mc1ju13); }
            }
            #endregion
            #region mathc2
            else if (checkbutton == "c2")
            {
                if (listBox1.SelectedItem.ToString() == "january 2005")
                { openfile("Markscheme-UnitC2(6664)-January2005.doc", Properties.Resources.mc2ja05); }
                else if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("Markscheme-UnitC2(6664)-January2006.doc", Properties.Resources.mc2ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("Markscheme-UnitC2(6664)-January2008.pdf", Properties.Resources.mc2ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("Markscheme-UnitC2(6664)-January2009.pdf", Properties.Resources.mc2ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("Markscheme-UnitC2(6664)-January2010.pdf", Properties.Resources.mc2ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("Markscheme-UnitC2(6664)-January2011.pdf", Properties.Resources.mc2ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("Markscheme-UnitC2(6664)-January2012.pdf", Properties.Resources.mc2ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("Markscheme-UnitC2(6664)-January2013.pdf", Properties.Resources.mc2ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("Markscheme-UnitC2(6664)-June2005.pdf", Properties.Resources.mc2ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("Markscheme-UnitC2(6664)-June2006.pdf", Properties.Resources.mc2ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("Markscheme-UnitC2(6664)-June2007.doc", Properties.Resources.mc2ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("Markscheme-UnitC2(6664)-June2008.pdf", Properties.Resources.mc2ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("Markscheme-Multipleunits-June2009.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("Markscheme-UnitC2(6664)-June2010.pdf", Properties.Resources.mc2ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("Markscheme-UnitC2(6664)-June2011.pdf", Properties.Resources.mc2ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("Markscheme-UnitC2(6664)-June2012.pdf", Properties.Resources.mc2ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("Markscheme-UnitC2(6664)-June2013.pdf", Properties.Resources.mc2ju13); }
            }
            #endregion
            #region mathc3
            else if (checkbutton == "c3")
            {
                if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("mc3ja06.pdf", Properties.Resources.mc3ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("mc3ja08.pdf", Properties.Resources.mc3ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("mc3ja09.pdf", Properties.Resources.mc3ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("mc3ja10.pdf", Properties.Resources.mc3ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("mc3ja11.pdf", Properties.Resources.mc3ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("mc3ja12.pdf", Properties.Resources.mc3ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("mc3ja13.pdf", Properties.Resources.mc3ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("mc3ju05.pdf", Properties.Resources.mc3ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("mc3ju06.pdf", Properties.Resources.mc3ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("mc3ju07.doc", Properties.Resources.mc3ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("mc3ju08.pdf", Properties.Resources.mc3ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mc3ju09.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mc3ju10.pdf", Properties.Resources.mc3ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mc3ju11.pdf", Properties.Resources.mc3ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mc3ju12.pdf", Properties.Resources.mc3ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mc3ju13.pdf", Properties.Resources.mc3ju13); }
            }
            #endregion
            #region mathc4
            else if (checkbutton == "c4")
            {
                if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("mc4ja06.pdf", Properties.Resources.mc4ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("mc4ja08.pdf", Properties.Resources.mc4ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("mc4ja09.pdf", Properties.Resources.mc4ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("mc4ja10.pdf", Properties.Resources.mc4ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("mc4ja11.pdf", Properties.Resources.mc4ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("mc4ja12.pdf", Properties.Resources.mc4ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("mc4ja13.pdf", Properties.Resources.mc4ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("mc4ju05.pdf", Properties.Resources.mc4ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("mc4ju06.pdf", Properties.Resources.mc4ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("mc4ju07.doc", Properties.Resources.mc4ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("mc4ju08.pdf", Properties.Resources.mc4ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mc4ju09.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mc4ju10.pdf", Properties.Resources.mc4ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mc4ju11.pdf", Properties.Resources.mc4ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mc4ju12.pdf", Properties.Resources.mc4ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mc4ju13.pdf", Properties.Resources.mc4ju13); }
            }
            #endregion
            #region maths1
            else if (checkbutton == "s1")
            {
                if (listBox1.SelectedItem.ToString() == "january 2003")
                { openfile("ms1ja03.pdf", Properties.Resources.ms1ja03); }
                else if (listBox1.SelectedItem.ToString() == "january 2005")
                { openfile("ms1ja05.pdf", Properties.Resources.ms1ja05); }
                else if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("ms1ja06.pdf", Properties.Resources.ms1ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("ms1ja08.pdf", Properties.Resources.ms1ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("ms1ja09.pdf", Properties.Resources.ms1ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("ms1ja10.pdf", Properties.Resources.ms1ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("ms1ja11.pdf", Properties.Resources.ms1ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("ms1ja12.pdf", Properties.Resources.ms1ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("ms1ja13.pdf", Properties.Resources.ms1ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("ms1ju05.pdf", Properties.Resources.ms1ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("ms1ju06.pdf", Properties.Resources.ms1ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("ms1ju07.doc", Properties.Resources.ms1ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("ms1ju08.pdf", Properties.Resources.ms1ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("ms1ju09.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("ms1ju10.pdf", Properties.Resources.ms1ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("ms1ju11.pdf", Properties.Resources.ms1ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("ms1ju12.pdf", Properties.Resources.ms1ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("ms1ju13.pdf", Properties.Resources.ms1ju13); }
            }
            #endregion
            #region electronics wave and protons
            else if (checkbutton == "EWP")
            {
                if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("mewpja10.pdf", Properties.Resources.mewpja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("mewpja11.pdf", Properties.Resources.mewpja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("mewpja12.pdf", Properties.Resources.mewpja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("mewpja13.pdf", Properties.Resources.mewpja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mewpju09.pdf", Properties.Resources.mewpju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mewpju10.pdf", Properties.Resources.mewpju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mewpju11.pdf", Properties.Resources.mewpju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mewpju12.pdf", Properties.Resources.mewpju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mewpju13.pdf", Properties.Resources.mewpju13); }
            }
            #endregion
            #region mechanics
            else if (checkbutton == "MECH")
            {
                if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("mmechanicsja09.pdf", Properties.Resources.mmechanicsja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("mmechanicsja10.pdf", Properties.Resources.mmechanicsja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("mmechanicsja11.pdf", Properties.Resources.mmechanicsja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("mmechanicsja12.pdf", Properties.Resources.mmechanicsja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("mmechanicsja13.pdf", Properties.Resources.mmechanicsja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mmechanicsju09.pdf", Properties.Resources.mmechanicsju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mmechanicsju10.pdf", Properties.Resources.mmechanicsju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mmechanicsju11.pdf", Properties.Resources.mmechanicsju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mmechanicsju12.pdf", Properties.Resources.mmechanicsju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mmechanicsju13.pdf", Properties.Resources.mmechanicsju13); }
            }
            #endregion
            #region programming
            else if (checkbutton == "PTALM")
            {
                if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("mptalmja09.pdf", Properties.Resources.mptalmja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("mptalmja10.pdf", Properties.Resources.mptalmja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("mptalmja11.pdf", Properties.Resources.mptalmja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("mptalmja12.pdf", Properties.Resources.mptalmja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("mptalmja13.pdf", Properties.Resources.mptalmja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mptalmju09.pdf", Properties.Resources.mptalmju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mptalmju10.pdf", Properties.Resources.mptalmju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mptalmju11.pdf", Properties.Resources.mptalmju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mptalmju12.pdf", Properties.Resources.mptalmju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mptalmju13.pdf", Properties.Resources.mptalmju13); }
            }
            #endregion
            #region COMPUTER FUNDAMENTALS
            else if (checkbutton == "CF")
            {
                if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("mcfja09.pdf", Properties.Resources.mcfja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("mcfja10.pdf", Properties.Resources.mcfja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("mcfja11.pdf", Properties.Resources.mcfja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("mcfja12.pdf", Properties.Resources.mcfja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("mcfja13.pdf", Properties.Resources.mcfja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mcfju09.pdf", Properties.Resources.mcfju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mcfju10.pdf", Properties.Resources.mcfju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mcfju11.pdf", Properties.Resources.mcfju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mcfju12.pdf", Properties.Resources.mcfju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mcfju13.pdf", Properties.Resources.mcfju13); }
            }
            #endregion
            #region SIMPLE SYSTEM
            else if (checkbutton == "SS")
            {
                if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mssju09.pdf", Properties.Resources.mssju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mssju10.pdf", Properties.Resources.mssju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mssju11.pdf", Properties.Resources.mssju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mssju12.pdf", Properties.Resources.mssju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mssju13.pdf", Properties.Resources.mssju13); }
            }
            #endregion
            #region SIGNAL SYSTEM
            else if (checkbutton == "SP")
            {
                if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mspju09.pdf", Properties.Resources.mspju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mspju10.pdf", Properties.Resources.mspju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mspju11.pdf", Properties.Resources.mspju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mspju12.pdf", Properties.Resources.mspju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mspju13.pdf", Properties.Resources.mspju13); }
            }
            #endregion
            }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }        
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (onoroff == 1)
            {
                timer1.Enabled = false;
                button5.Text = "ENABLE FLAHING COLOURS";
                onoroff = 2;
            }
            else if(onoroff == 2)
            {
                timer1.Enabled = true;
                button5.Text = "DISABLE FLAHING COLOURS";
                onoroff = 1;
            }
        }
        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                try
                {
                    #region mathsc1
                    if (checkbutton == "c1")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2005")
                        { openfile("Markscheme-UnitC1(6663)-January2005.doc", Properties.Resources.mc1ja05); }
                        else if (listBox1.SelectedItem.ToString() == "january 2006")
                        { openfile("Markscheme-UnitC1(6663)-January2006.doc", Properties.Resources.mc1ja06); }
                        else if (listBox1.SelectedItem.ToString() == "january 2008")
                        { openfile("Markscheme-UnitC1(6663)-January2008.pdf", Properties.Resources.mc1ja08); }
                        else if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("Markscheme-UnitC1(6663)-January2009.pdf", Properties.Resources.mc1ja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("Markscheme-UnitC1(6663)-January2010.pdf", Properties.Resources.mc1ja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("Markscheme-UnitC1(6663)-January2011.pdf", Properties.Resources.mc1ja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("Markscheme-UnitC1(6663)-January2012.pdf", Properties.Resources.mc1ja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("Markscheme-UnitC1(6663)-January2013.pdf", Properties.Resources.mc1ja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2005")
                        { openfile("Markscheme-UnitC1(6663)-June2005.pdf", Properties.Resources.mc1ju05); }
                        else if (listBox1.SelectedItem.ToString() == "june 2007")
                        { openfile("Markscheme-UnitC1(6663)-June2007.doc", Properties.Resources.mc1ju07); }
                        else if (listBox1.SelectedItem.ToString() == "june 2008")
                        { openfile("Markscheme-UnitC1(6663)-June2008.pdf", Properties.Resources.mc1ju08); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("Markscheme-Multipleunits-June2009.pdf", Properties.Resources.mc1ju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("Markscheme-UnitC1(6663)-June2010.pdf", Properties.Resources.mc1ju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("Markscheme-UnitC1(6663)-June2011.pdf", Properties.Resources.mc1ju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("Markscheme-UnitC1(6663)-June2012.pdf", Properties.Resources.mc1ju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("Markscheme-UnitC1(6663)-June2013.pdf", Properties.Resources.mc1ju13); }
                    }
                    #endregion
                    #region mathc2
                    else if (checkbutton == "c2")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2005")
                        { openfile("Markscheme-UnitC2(6664)-January2005.doc", Properties.Resources.mc2ja05); }
                        else if (listBox1.SelectedItem.ToString() == "january 2006")
                        { openfile("Markscheme-UnitC2(6664)-January2006.doc", Properties.Resources.mc2ja06); }
                        else if (listBox1.SelectedItem.ToString() == "january 2008")
                        { openfile("Markscheme-UnitC2(6664)-January2008.pdf", Properties.Resources.mc2ja08); }
                        else if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("Markscheme-UnitC2(6664)-January2009.pdf", Properties.Resources.mc2ja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("Markscheme-UnitC2(6664)-January2010.pdf", Properties.Resources.mc2ja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("Markscheme-UnitC2(6664)-January2011.pdf", Properties.Resources.mc2ja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("Markscheme-UnitC2(6664)-January2012.pdf", Properties.Resources.mc2ja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("Markscheme-UnitC2(6664)-January2013.pdf", Properties.Resources.mc2ja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2005")
                        { openfile("Markscheme-UnitC2(6664)-June2005.pdf", Properties.Resources.mc2ju05); }
                        else if (listBox1.SelectedItem.ToString() == "june 2006")
                        { openfile("Markscheme-UnitC2(6664)-June2006.pdf", Properties.Resources.mc2ju06); }
                        else if (listBox1.SelectedItem.ToString() == "june 2007")
                        { openfile("Markscheme-UnitC2(6664)-June2007.doc", Properties.Resources.mc2ju07); }
                        else if (listBox1.SelectedItem.ToString() == "june 2008")
                        { openfile("Markscheme-UnitC2(6664)-June2008.pdf", Properties.Resources.mc2ju08); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("Markscheme-Multipleunits-June2009.pdf", Properties.Resources.mc1ju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("Markscheme-UnitC2(6664)-June2010.pdf", Properties.Resources.mc2ju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("Markscheme-UnitC2(6664)-June2011.pdf", Properties.Resources.mc2ju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("Markscheme-UnitC2(6664)-June2012.pdf", Properties.Resources.mc2ju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("Markscheme-UnitC2(6664)-June2013.pdf", Properties.Resources.mc2ju13); }
                    }
                    #endregion
                    #region mathc3
                    else if (checkbutton == "c3")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2006")
                        { openfile("mc3ja06.pdf", Properties.Resources.mc3ja06); }
                        else if (listBox1.SelectedItem.ToString() == "january 2008")
                        { openfile("mc3ja08.pdf", Properties.Resources.mc3ja08); }
                        else if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("mc3ja09.pdf", Properties.Resources.mc3ja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("mc3ja10.pdf", Properties.Resources.mc3ja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("mc3ja11.pdf", Properties.Resources.mc3ja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("mc3ja12.pdf", Properties.Resources.mc3ja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("mc3ja13.pdf", Properties.Resources.mc3ja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2005")
                        { openfile("mc3ju05.pdf", Properties.Resources.mc3ju05); }
                        else if (listBox1.SelectedItem.ToString() == "june 2006")
                        { openfile("mc3ju06.pdf", Properties.Resources.mc3ju06); }
                        else if (listBox1.SelectedItem.ToString() == "june 2007")
                        { openfile("mc3ju07.doc", Properties.Resources.mc3ju07); }
                        else if (listBox1.SelectedItem.ToString() == "june 2008")
                        { openfile("mc3ju08.pdf", Properties.Resources.mc3ju08); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("mc3ju09.pdf", Properties.Resources.mc1ju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("mc3ju10.pdf", Properties.Resources.mc3ju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("mc3ju11.pdf", Properties.Resources.mc3ju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("mc3ju12.pdf", Properties.Resources.mc3ju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("mc3ju13.pdf", Properties.Resources.mc3ju13); }
                    }
                    #endregion
                    #region mathc4
                    else if (checkbutton == "c4")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2006")
                        { openfile("mc4ja06.pdf", Properties.Resources.mc4ja06); }
                        else if (listBox1.SelectedItem.ToString() == "january 2008")
                        { openfile("mc4ja08.pdf", Properties.Resources.mc4ja08); }
                        else if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("mc4ja09.pdf", Properties.Resources.mc4ja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("mc4ja10.pdf", Properties.Resources.mc4ja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("mc4ja11.pdf", Properties.Resources.mc4ja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("mc4ja12.pdf", Properties.Resources.mc4ja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("mc4ja13.pdf", Properties.Resources.mc4ja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2005")
                        { openfile("mc4ju05.pdf", Properties.Resources.mc4ju05); }
                        else if (listBox1.SelectedItem.ToString() == "june 2006")
                        { openfile("mc4ju06.pdf", Properties.Resources.mc4ju06); }
                        else if (listBox1.SelectedItem.ToString() == "june 2007")
                        { openfile("mc4ju07.doc", Properties.Resources.mc4ju07); }
                        else if (listBox1.SelectedItem.ToString() == "june 2008")
                        { openfile("mc4ju08.pdf", Properties.Resources.mc4ju08); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("mc4ju09.pdf", Properties.Resources.mc1ju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("mc4ju10.pdf", Properties.Resources.mc4ju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("mc4ju11.pdf", Properties.Resources.mc4ju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("mc4ju12.pdf", Properties.Resources.mc4ju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("mc4ju13.pdf", Properties.Resources.mc4ju13); }
                    }
                    #endregion
                    #region maths1
                    else if (checkbutton == "s1")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2003")
                        { openfile("ms1ja03.pdf", Properties.Resources.ms1ja03); }
                        else if (listBox1.SelectedItem.ToString() == "january 2005")
                        { openfile("ms1ja05.pdf", Properties.Resources.ms1ja05); }
                        else if (listBox1.SelectedItem.ToString() == "january 2006")
                        { openfile("ms1ja06.pdf", Properties.Resources.ms1ja06); }
                        else if (listBox1.SelectedItem.ToString() == "january 2008")
                        { openfile("ms1ja08.pdf", Properties.Resources.ms1ja08); }
                        else if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("ms1ja09.pdf", Properties.Resources.ms1ja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("ms1ja10.pdf", Properties.Resources.ms1ja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("ms1ja11.pdf", Properties.Resources.ms1ja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("ms1ja12.pdf", Properties.Resources.ms1ja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("ms1ja13.pdf", Properties.Resources.ms1ja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2005")
                        { openfile("ms1ju05.pdf", Properties.Resources.ms1ju05); }
                        else if (listBox1.SelectedItem.ToString() == "june 2006")
                        { openfile("ms1ju06.pdf", Properties.Resources.ms1ju06); }
                        else if (listBox1.SelectedItem.ToString() == "june 2007")
                        { openfile("ms1ju07.doc", Properties.Resources.ms1ju07); }
                        else if (listBox1.SelectedItem.ToString() == "june 2008")
                        { openfile("ms1ju08.pdf", Properties.Resources.ms1ju08); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("ms1ju09.pdf", Properties.Resources.mc1ju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("ms1ju10.pdf", Properties.Resources.ms1ju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("ms1ju11.pdf", Properties.Resources.ms1ju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("ms1ju12.pdf", Properties.Resources.ms1ju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("ms1ju13.pdf", Properties.Resources.ms1ju13); }
                    }
                    #endregion
                    #region electronics wave and protons
                    else if (checkbutton == "EWP")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("mewpja10.pdf", Properties.Resources.mewpja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("mewpja11.pdf", Properties.Resources.mewpja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("mewpja12.pdf", Properties.Resources.mewpja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("mewpja13.pdf", Properties.Resources.mewpja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("mewpju09.pdf", Properties.Resources.mewpju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("mewpju10.pdf", Properties.Resources.mewpju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("mewpju11.pdf", Properties.Resources.mewpju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("mewpju12.pdf", Properties.Resources.mewpju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("mewpju13.pdf", Properties.Resources.mewpju13); }
                    }
                    #endregion
                    #region mechanics
                    else if (checkbutton == "MECH")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("mmechanicsja09.pdf", Properties.Resources.mmechanicsja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("mmechanicsja10.pdf", Properties.Resources.mmechanicsja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("mmechanicsja11.pdf", Properties.Resources.mmechanicsja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("mmechanicsja12.pdf", Properties.Resources.mmechanicsja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("mmechanicsja13.pdf", Properties.Resources.mmechanicsja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("mmechanicsju09.pdf", Properties.Resources.mmechanicsju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("mmechanicsju10.pdf", Properties.Resources.mmechanicsju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("mmechanicsju11.pdf", Properties.Resources.mmechanicsju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("mmechanicsju12.pdf", Properties.Resources.mmechanicsju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("mmechanicsju13.pdf", Properties.Resources.mmechanicsju13); }
                    }
                    #endregion
                    #region programming
                    else if (checkbutton == "PTALM")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("mptalmja09.pdf", Properties.Resources.mptalmja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("mptalmja10.pdf", Properties.Resources.mptalmja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("mptalmja11.pdf", Properties.Resources.mptalmja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("mptalmja12.pdf", Properties.Resources.mptalmja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("mptalmja13.pdf", Properties.Resources.mptalmja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("mptalmju09.pdf", Properties.Resources.mptalmju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("mptalmju10.pdf", Properties.Resources.mptalmju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("mptalmju11.pdf", Properties.Resources.mptalmju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("mptalmju12.pdf", Properties.Resources.mptalmju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("mptalmju13.pdf", Properties.Resources.mptalmju13); }
                    }
                    #endregion
                    #region COMPUTER FUNDAMENTALS
                    else if (checkbutton == "CF")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("mcfja09.pdf", Properties.Resources.mcfja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("mcfja10.pdf", Properties.Resources.mcfja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("mcfja11.pdf", Properties.Resources.mcfja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("mcfja12.pdf", Properties.Resources.mcfja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("mcfja13.pdf", Properties.Resources.mcfja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("mcfju09.pdf", Properties.Resources.mcfju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("mcfju10.pdf", Properties.Resources.mcfju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("mcfju11.pdf", Properties.Resources.mcfju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("mcfju12.pdf", Properties.Resources.mcfju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("mcfju13.pdf", Properties.Resources.mcfju13); }
                    }
                    #endregion
                    #region SIMPLE SYSTEM
                    else if (checkbutton == "SS")
                    {
                        if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("mssju09.pdf", Properties.Resources.mssju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("mssju10.pdf", Properties.Resources.mssju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("mssju11.pdf", Properties.Resources.mssju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("mssju12.pdf", Properties.Resources.mssju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("mssju13.pdf", Properties.Resources.mssju13); }
                    }
                    #endregion
                    #region SIGNAL SYSTEM
                    else if (checkbutton == "SP")
                    {
                        if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("mspju09.pdf", Properties.Resources.mspju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("mspju10.pdf", Properties.Resources.mspju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("mspju11.pdf", Properties.Resources.mspju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("mspju12.pdf", Properties.Resources.mspju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("mspju13.pdf", Properties.Resources.mspju13); }
                    } button1.Focus();
                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }        
            }
        }
    }
}
