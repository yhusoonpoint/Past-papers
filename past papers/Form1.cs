using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace past_papers
{    
    public partial class Form1 : Form
    {
        static int onoroff;
        private string checkbutton;
        public Form1()
        {
            InitializeComponent();
            this.Text = "DEADVIRUS PRESENTS---";
        }
        private void button1_Click(object sender, EventArgs e)
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
        private void button2_Click(object sender, EventArgs e)
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
            else if(comboBox2.Text == "MECHANICS")
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
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox2.Visible = false;
                button2.Visible=false;
        }
        private void openfile(string open, byte[] opner)
        {
            string locationToSavePdf = Path.Combine(Path.GetTempPath(), open);
            File.WriteAllBytes(locationToSavePdf, opner);
            Process.Start(locationToSavePdf);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            #region mathsc1
            if (checkbutton == "c1")
            {
                if (listBox1.SelectedItem.ToString() == "january 2005")
                {openfile("Questionpaper-UnitC1(6663)-January2005.doc", Properties.Resources.c1ja05);}
                else if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("Questionpaper-UnitC1(6663)-January2006.doc", Properties.Resources.c1ja06);}
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("Questionpaper-UnitC1(6663)-January2008.pdf", Properties.Resources.c1ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("Questionpaper-UnitC1(6663)-January2009.pdf", Properties.Resources.c1ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("Questionpaper-UnitC1(6663)-January2010.pdf", Properties.Resources.c1ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("Questionpaper-UnitC1(6663)-January2011.pdf", Properties.Resources.c1ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("Questionpaper-UnitC1(6663)-January2012.pdf", Properties.Resources.c1ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("Questionpaper-UnitC1(6663)-January2013.pdf", Properties.Resources.c1ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("Questionpaper-UnitC1(6663)-June2005.pdf", Properties.Resources.c1ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("Questionpaper-UnitC1(6663)-June2007.pdf", Properties.Resources.c1ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("Questionpaper-UnitC1(6663)-June2008.pdf", Properties.Resources.c1ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("Questionpaper-UnitC1(6663)-June2009.pdf", Properties.Resources.c1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("Questionpaper-UnitC1(6663)-June2010.pdf", Properties.Resources.c1ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("Questionpaper-UnitC1(6663)-June2011.pdf", Properties.Resources.c1ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("Questionpaper-UnitC1(6663)-June2012.pdf", Properties.Resources.c1ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("Questionpaper-UnitC1(6663)-June2013.pdf", Properties.Resources.c1ju13); }
            }
            #endregion
            #region mathc2
            else if (checkbutton == "c2")
            {
                if (listBox1.SelectedItem.ToString() == "january 2005")
                { openfile("Questionpaper-UnitC2(6664)-January2005.doc", Properties.Resources.c2ja05); }
                else if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("Questionpaper-UnitC2(6664)-January2006.doc", Properties.Resources.c2ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("Questionpaper-UnitC2(6664)-January2008.pdf", Properties.Resources.c2ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("Questionpaper-UnitC2(6664)-January2009.pdf", Properties.Resources.c2ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("Questionpaper-UnitC2(6664)-January2010.pdf", Properties.Resources.c2ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("Questionpaper-UnitC2(6664)-January2011.pdf", Properties.Resources.c2ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("Questionpaper-UnitC2(6664)-January2012.pdf", Properties.Resources.c2ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("Questionpaper-UnitC2(6664)-January2013.pdf", Properties.Resources.c2ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("Questionpaper-UnitC2(6664)-June2005.pdf", Properties.Resources.c2ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("Questionpaper-UnitC2(6664)-June2006.pdf", Properties.Resources.c2ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("Questionpaper-UnitC2(6664)-June2007.pdf", Properties.Resources.c2ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("Questionpaper-UnitC2(6664)-June2008.pdf", Properties.Resources.c2ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("Questionpaper-UnitC2(6664)-June2009.pdf", Properties.Resources.c2ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("Questionpaper-UnitC2(6664)-June2010.pdf", Properties.Resources.c2ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("Questionpaper-UnitC2(6664)-June2011.pdf", Properties.Resources.c2ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("Questionpaper-UnitC2(6664)-June2012.pdf", Properties.Resources.c2ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("Questionpaper-UnitC2(6664)-June2013.pdf", Properties.Resources.c2ju13); }
            }
            #endregion
            #region mathc3
            else if (checkbutton == "c3")
            {
                if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("c3ja06.pdf", Properties.Resources.c3ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("c3ja08.pdf", Properties.Resources.c3ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("c3ja09.pdf", Properties.Resources.c3ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("c3ja10.pdf", Properties.Resources.c3ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("c3ja11.pdf", Properties.Resources.c3ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("c3ja12.pdf", Properties.Resources.c3ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("c3ja13.pdf", Properties.Resources.c3ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("c3ju05.pdf", Properties.Resources.c3ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("c3ju06.pdf", Properties.Resources.c3ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("c3ju07.pdf", Properties.Resources.c3ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("c3ju08.pdf", Properties.Resources.c3ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("c3ju09.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("c3ju10.pdf", Properties.Resources.c3ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("c3ju11.pdf", Properties.Resources.c3ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("c3ju12.pdf", Properties.Resources.c3ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("c3ju13.pdf", Properties.Resources.c3ju13); }
            }
            #endregion
            #region mathc4
            else if (checkbutton == "c4")
            {
                if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("c4ja06.pdf", Properties.Resources.c4ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("c4ja08.pdf", Properties.Resources.c4ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("c4ja09.pdf", Properties.Resources.c4ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("c4ja10.pdf", Properties.Resources.c4ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("c4ja11.pdf", Properties.Resources.c4ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("c4ja12.pdf", Properties.Resources.c4ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("c4ja13.pdf", Properties.Resources.c4ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("c4ju05.pdf", Properties.Resources.c4ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("c4ju06.pdf", Properties.Resources.c4ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("c4ju07.pdf", Properties.Resources.c4ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("c4ju08.pdf", Properties.Resources.c4ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("c4ju09.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("c4ju10.pdf", Properties.Resources.c4ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("c4ju11.pdf", Properties.Resources.c4ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("c4ju12.pdf", Properties.Resources.c4ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("c4ju13.pdf", Properties.Resources.c4ju13); }
            }
            #endregion
            #region maths1
            else if (checkbutton == "s1")
            {
                if (listBox1.SelectedItem.ToString() == "january 2003")
                { openfile("s1ja03.pdf", Properties.Resources.s1ja03); }
                else if (listBox1.SelectedItem.ToString() == "january 2005")
                { openfile("s1ja05.pdf", Properties.Resources.s1ja05); }
                else if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("s1ja06.pdf", Properties.Resources.s1ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("s1ja08.pdf", Properties.Resources.s1ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("s1ja09.pdf", Properties.Resources.s1ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("s1ja10.pdf", Properties.Resources.s1ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("s1ja11.pdf", Properties.Resources.s1ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("s1ja12.pdf", Properties.Resources.s1ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("s1ja13.pdf", Properties.Resources.s1ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("s1ju05.pdf", Properties.Resources.s1ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("s1ju06.pdf", Properties.Resources.s1ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("s1ju07.pdf", Properties.Resources.s1ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("s1ju08.pdf", Properties.Resources.s1ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("s1ju09.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("s1ju10.pdf", Properties.Resources.s1ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("s1ju11.pdf", Properties.Resources.s1ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("s1ju12.pdf", Properties.Resources.s1ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("s1ju13.pdf", Properties.Resources.s1ju13); }
            }
            #endregion
            #region electronics wave and protons
            else if (checkbutton == "EWP")
            {
                if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("ewpja10.pdf", Properties.Resources.ewpja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("ewpja11.pdf", Properties.Resources.ewpja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("ewpja12.pdf", Properties.Resources.ewpja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("ewpja13.pdf", Properties.Resources.ewpja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("ewpju09.pdf", Properties.Resources.ewpju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("ewpju10.pdf", Properties.Resources.ewpju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("ewpju11.pdf", Properties.Resources.ewpju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("ewpju12.pdf", Properties.Resources.ewpju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("ewpju13.pdf", Properties.Resources.ewpju13); }
            }
            #endregion
            #region mechanics
            else if(checkbutton=="MECH")
            {
                if(listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("mechanicsja09.pdf", Properties.Resources.mechanicsja09);}
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("mechanicsja10.pdf", Properties.Resources.mechanicsja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("mechanicsja11.pdf", Properties.Resources.mechanicsja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("mechanicsja12.pdf", Properties.Resources.mechanicsja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("mechanicsja13.pdf", Properties.Resources.mechanicsja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mechanicsju09.pdf", Properties.Resources.mechanicsju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mechanicsju10.pdf", Properties.Resources.mechanicsju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mechanicsju11.pdf", Properties.Resources.mechanicsju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mechanicsju12.pdf", Properties.Resources.mechanicsju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mechanicsju13.pdf", Properties.Resources.mechanicsju13); }
            }
            #endregion
            #region programming
            else if (checkbutton == "PTALM")
            {
                if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("ptamlja09.pdf", Properties.Resources.ptamlja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("ptamlja10.pdf", Properties.Resources.ptamlja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("ptamlja11.pdf", Properties.Resources.ptamlja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("ptamlja12.pdf", Properties.Resources.ptamlja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("ptamlja13.pdf", Properties.Resources.ptamlja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("ptamlju09.pdf", Properties.Resources.ptamlju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("ptamlju10.pdf", Properties.Resources.ptamlju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("ptamlju11.pdf", Properties.Resources.ptamlju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("ptamlju12.pdf", Properties.Resources.ptamlju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("ptamlju13.pdf", Properties.Resources.ptamlju13); }
            }
            #endregion
            #region COMPUTER FUNDAMENTALS
            else if (checkbutton == "CF")
            {
                if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("cfja09.pdf", Properties.Resources.cfja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("cfja10.pdf", Properties.Resources.cfja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("cfja11.pdf", Properties.Resources.cfja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("cfja12.pdf", Properties.Resources.cfja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("cfja13.pdf", Properties.Resources.cfja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("cfju09.pdf", Properties.Resources.cfju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("cfju10.pdf", Properties.Resources.cfju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("cfju11.pdf", Properties.Resources.cfju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("cfju12.pdf", Properties.Resources.cfju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("cfju13.pdf", Properties.Resources.cfju13); }
            }
            #endregion
            #region SIMPLE SYSTEM
            else if (checkbutton == "SS")
            {
                if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("ssju09.pdf", Properties.Resources.ssju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("ssju10.pdf", Properties.Resources.ssju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("ssju11.pdf", Properties.Resources.ssju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("ssju12.pdf", Properties.Resources.ssju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("ssju13.pdf", Properties.Resources.ssju13); }
            }
            #endregion
            #region SIGNAL SYSTEM
            else if (checkbutton == "SP")
            {
                if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("spju09.pdf", Properties.Resources.spju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("spju10.pdf", Properties.Resources.spju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("spju11.pdf", Properties.Resources.spju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("spju12.pdf", Properties.Resources.spju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("spju13.pdf", Properties.Resources.spju13); }
            }
            #endregion
        }
        private void timer1_Tick(object sender, EventArgs e)
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
                    this.Text = "PAST PAPERS";
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
                    this.Text = "      PAST PAPERS";
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
                    this.Text = "                PAST PAPERS";
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
                    this.Text = "         PAST PAPERS";
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
                    this.Text = "      PAST PAPERS";
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
                    this.Text = "       PAST PAPERS";
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
                    this.Text = "           PAST PAPERS";
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
                    this.Text = "            PAST PAPERS";
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
                    this.Text = "               PAST PAPERS";
                    break;

            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            DialogResult u = MessageBox.Show("ENABLE FLAHING COLOURS?", "ENABLE OR NA",
        MessageBoxButtons.YesNo,MessageBoxIcon.Question);
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
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 forms = new Form2();
forms.Show();
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                try
                {
            #region mathsc1
            if (checkbutton == "c1")
            {
                if (listBox1.SelectedItem.ToString() == "january 2005")
                { openfile("Questionpaper-UnitC1(6663)-January2005.doc", Properties.Resources.c1ja05); }
                else if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("Questionpaper-UnitC1(6663)-January2006.doc", Properties.Resources.c1ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("Questionpaper-UnitC1(6663)-January2008.pdf", Properties.Resources.c1ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("Questionpaper-UnitC1(6663)-January2009.pdf", Properties.Resources.c1ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("Questionpaper-UnitC1(6663)-January2010.pdf", Properties.Resources.c1ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("Questionpaper-UnitC1(6663)-January2011.pdf", Properties.Resources.c1ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("Questionpaper-UnitC1(6663)-January2012.pdf", Properties.Resources.c1ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("Questionpaper-UnitC1(6663)-January2013.pdf", Properties.Resources.c1ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("Questionpaper-UnitC1(6663)-June2005.pdf", Properties.Resources.c1ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("Questionpaper-UnitC1(6663)-June2007.pdf", Properties.Resources.c1ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("Questionpaper-UnitC1(6663)-June2008.pdf", Properties.Resources.c1ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("Questionpaper-UnitC1(6663)-June2009.pdf", Properties.Resources.c1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("Questionpaper-UnitC1(6663)-June2010.pdf", Properties.Resources.c1ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("Questionpaper-UnitC1(6663)-June2011.pdf", Properties.Resources.c1ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("Questionpaper-UnitC1(6663)-June2012.pdf", Properties.Resources.c1ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("Questionpaper-UnitC1(6663)-June2013.pdf", Properties.Resources.c1ju13); }
            }
            #endregion
            #region mathc2
            else if (checkbutton == "c2")
            {
                if (listBox1.SelectedItem.ToString() == "january 2005")
                { openfile("Questionpaper-UnitC2(6664)-January2005.doc", Properties.Resources.c2ja05); }
                else if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("Questionpaper-UnitC2(6664)-January2006.doc", Properties.Resources.c2ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("Questionpaper-UnitC2(6664)-January2008.pdf", Properties.Resources.c2ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("Questionpaper-UnitC2(6664)-January2009.pdf", Properties.Resources.c2ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("Questionpaper-UnitC2(6664)-January2010.pdf", Properties.Resources.c2ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("Questionpaper-UnitC2(6664)-January2011.pdf", Properties.Resources.c2ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("Questionpaper-UnitC2(6664)-January2012.pdf", Properties.Resources.c2ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("Questionpaper-UnitC2(6664)-January2013.pdf", Properties.Resources.c2ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("Questionpaper-UnitC2(6664)-June2005.pdf", Properties.Resources.c2ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("Questionpaper-UnitC2(6664)-June2006.pdf", Properties.Resources.c2ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("Questionpaper-UnitC2(6664)-June2007.pdf", Properties.Resources.c2ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("Questionpaper-UnitC2(6664)-June2008.pdf", Properties.Resources.c2ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("Questionpaper-UnitC2(6664)-June2009.pdf", Properties.Resources.c2ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("Questionpaper-UnitC2(6664)-June2010.pdf", Properties.Resources.c2ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("Questionpaper-UnitC2(6664)-June2011.pdf", Properties.Resources.c2ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("Questionpaper-UnitC2(6664)-June2012.pdf", Properties.Resources.c2ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("Questionpaper-UnitC2(6664)-June2013.pdf", Properties.Resources.c2ju13); }
            }
            #endregion
            #region mathc3
            else if (checkbutton == "c3")
            {
                if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("c3ja06.pdf", Properties.Resources.c3ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("c3ja08.pdf", Properties.Resources.c3ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("c3ja09.pdf", Properties.Resources.c3ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("c3ja10.pdf", Properties.Resources.c3ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("c3ja11.pdf", Properties.Resources.c3ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("c3ja12.pdf", Properties.Resources.c3ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("c3ja13.pdf", Properties.Resources.c3ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("c3ju05.pdf", Properties.Resources.c3ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("c3ju06.pdf", Properties.Resources.c3ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("c3ju07.pdf", Properties.Resources.c3ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("c3ju08.pdf", Properties.Resources.c3ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("c3ju09.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("c3ju10.pdf", Properties.Resources.c3ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("c3ju11.pdf", Properties.Resources.c3ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("c3ju12.pdf", Properties.Resources.c3ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("c3ju13.pdf", Properties.Resources.c3ju13); }
            }
            #endregion
            #region mathc4
            else if (checkbutton == "c4")
            {
                if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("c4ja06.pdf", Properties.Resources.c4ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("c4ja08.pdf", Properties.Resources.c4ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("c4ja09.pdf", Properties.Resources.c4ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("c4ja10.pdf", Properties.Resources.c4ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("c4ja11.pdf", Properties.Resources.c4ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("c4ja12.pdf", Properties.Resources.c4ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("c4ja13.pdf", Properties.Resources.c4ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("c4ju05.pdf", Properties.Resources.c4ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("c4ju06.pdf", Properties.Resources.c4ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("c4ju07.pdf", Properties.Resources.c4ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("c4ju08.pdf", Properties.Resources.c4ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("c4ju09.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("c4ju10.pdf", Properties.Resources.c4ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("c4ju11.pdf", Properties.Resources.c4ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("c4ju12.pdf", Properties.Resources.c4ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("c4ju13.pdf", Properties.Resources.c4ju13); }
            }
            #endregion
            #region maths1
            else if (checkbutton == "s1")
            {
                if (listBox1.SelectedItem.ToString() == "january 2003")
                { openfile("s1ja03.pdf", Properties.Resources.s1ja03); }
                else if (listBox1.SelectedItem.ToString() == "january 2005")
                { openfile("s1ja05.pdf", Properties.Resources.s1ja05); }
                else if (listBox1.SelectedItem.ToString() == "january 2006")
                { openfile("s1ja06.pdf", Properties.Resources.s1ja06); }
                else if (listBox1.SelectedItem.ToString() == "january 2008")
                { openfile("s1ja08.pdf", Properties.Resources.s1ja08); }
                else if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("s1ja09.pdf", Properties.Resources.s1ja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("s1ja10.pdf", Properties.Resources.s1ja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("s1ja11.pdf", Properties.Resources.s1ja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("s1ja12.pdf", Properties.Resources.s1ja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("s1ja13.pdf", Properties.Resources.s1ja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2005")
                { openfile("s1ju05.pdf", Properties.Resources.s1ju05); }
                else if (listBox1.SelectedItem.ToString() == "june 2006")
                { openfile("s1ju06.pdf", Properties.Resources.s1ju06); }
                else if (listBox1.SelectedItem.ToString() == "june 2007")
                { openfile("s1ju07.pdf", Properties.Resources.s1ju07); }
                else if (listBox1.SelectedItem.ToString() == "june 2008")
                { openfile("s1ju08.pdf", Properties.Resources.s1ju08); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("s1ju09.pdf", Properties.Resources.mc1ju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("s1ju10.pdf", Properties.Resources.s1ju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("s1ju11.pdf", Properties.Resources.s1ju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("s1ju12.pdf", Properties.Resources.s1ju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("s1ju13.pdf", Properties.Resources.s1ju13); }
            }
            #endregion
            #region electronics wave and protons
            else if (checkbutton == "EWP")
            {
                if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("ewpja10.pdf", Properties.Resources.ewpja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("ewpja11.pdf", Properties.Resources.ewpja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("ewpja12.pdf", Properties.Resources.ewpja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("ewpja13.pdf", Properties.Resources.ewpja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("ewpju09.pdf", Properties.Resources.ewpju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("ewpju10.pdf", Properties.Resources.ewpju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("ewpju11.pdf", Properties.Resources.ewpju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("ewpju12.pdf", Properties.Resources.ewpju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("ewpju13.pdf", Properties.Resources.ewpju13); }
            }
            #endregion
            #region mechanics
            else if (checkbutton == "MECH")
            {
                if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("mechanicsja09.pdf", Properties.Resources.mechanicsja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("mechanicsja10.pdf", Properties.Resources.mechanicsja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("mechanicsja11.pdf", Properties.Resources.mechanicsja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("mechanicsja12.pdf", Properties.Resources.mechanicsja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("mechanicsja13.pdf", Properties.Resources.mechanicsja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("mechanicsju09.pdf", Properties.Resources.mechanicsju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("mechanicsju10.pdf", Properties.Resources.mechanicsju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("mechanicsju11.pdf", Properties.Resources.mechanicsju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("mechanicsju12.pdf", Properties.Resources.mechanicsju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("mechanicsju13.pdf", Properties.Resources.mechanicsju13); }
            }
            #endregion
            #region programming
            else if (checkbutton == "PTALM")
            {
                if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("ptamlja09.pdf", Properties.Resources.ptamlja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("ptamlja10.pdf", Properties.Resources.ptamlja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("ptamlja11.pdf", Properties.Resources.ptamlja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("ptamlja12.pdf", Properties.Resources.ptamlja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("ptamlja13.pdf", Properties.Resources.ptamlja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("ptamlju09.pdf", Properties.Resources.ptamlju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("ptamlju10.pdf", Properties.Resources.ptamlju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("ptamlju11.pdf", Properties.Resources.ptamlju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("ptamlju12.pdf", Properties.Resources.ptamlju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("ptamlju13.pdf", Properties.Resources.ptamlju13); }
            }
            #endregion
            #region COMPUTER FUNDAMENTALS
            else if (checkbutton == "CF")
            {
                if (listBox1.SelectedItem.ToString() == "january 2009")
                { openfile("cfja09.pdf", Properties.Resources.cfja09); }
                else if (listBox1.SelectedItem.ToString() == "january 2010")
                { openfile("cfja10.pdf", Properties.Resources.cfja10); }
                else if (listBox1.SelectedItem.ToString() == "january 2011")
                { openfile("cfja11.pdf", Properties.Resources.cfja11); }
                else if (listBox1.SelectedItem.ToString() == "january 2012")
                { openfile("cfja12.pdf", Properties.Resources.cfja12); }
                else if (listBox1.SelectedItem.ToString() == "january 2013")
                { openfile("cfja13.pdf", Properties.Resources.cfja13); }
                else if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("cfju09.pdf", Properties.Resources.cfju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("cfju10.pdf", Properties.Resources.cfju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("cfju11.pdf", Properties.Resources.cfju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("cfju12.pdf", Properties.Resources.cfju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("cfju13.pdf", Properties.Resources.cfju13); }
            }
            #endregion
            #region SIMPLE SYSTEM
            else if (checkbutton == "SS")
            {
                
                    if (listBox1.SelectedItem.ToString() == "june 2009")
                    { openfile("ssju09.pdf", Properties.Resources.ssju09); }
                    else if (listBox1.SelectedItem.ToString() == "june 2010")
                    { openfile("ssju10.pdf", Properties.Resources.ssju10); }
                    else if (listBox1.SelectedItem.ToString() == "june 2011")
                    { openfile("ssju11.pdf", Properties.Resources.ssju11); }
                    else if (listBox1.SelectedItem.ToString() == "june 2012")
                    { openfile("ssju12.pdf", Properties.Resources.ssju12); }
                    else if (listBox1.SelectedItem.ToString() == "june 2013")
                    { openfile("ssju13.pdf", Properties.Resources.ssju13); }
            }
            #endregion
            #region SIGNAL SYSTEM
            else if (checkbutton == "SP")
            {
                if (listBox1.SelectedItem.ToString() == "june 2009")
                { openfile("spju09.pdf", Properties.Resources.spju09); }
                else if (listBox1.SelectedItem.ToString() == "june 2010")
                { openfile("spju10.pdf", Properties.Resources.spju10); }
                else if (listBox1.SelectedItem.ToString() == "june 2011")
                { openfile("spju11.pdf", Properties.Resources.spju11); }
                else if (listBox1.SelectedItem.ToString() == "june 2012")
                { openfile("spju12.pdf", Properties.Resources.spju12); }
                else if (listBox1.SelectedItem.ToString() == "june 2013")
                { openfile("spju13.pdf", Properties.Resources.spju13); }
            }
            #endregion
            listBox1.ClearSelected(); }
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
            else if (onoroff == 2)
            {
                timer1.Enabled = true;
                button5.Text = "DISABLE FLAHING COLOURS";
                onoroff = 1;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            openfile("equation solver.exe",Properties.Resources.equationsolver);
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
                        { openfile("Questionpaper-UnitC1(6663)-January2005.doc", Properties.Resources.c1ja05); }
                        else if (listBox1.SelectedItem.ToString() == "january 2006")
                        { openfile("Questionpaper-UnitC1(6663)-January2006.doc", Properties.Resources.c1ja06); }
                        else if (listBox1.SelectedItem.ToString() == "january 2008")
                        { openfile("Questionpaper-UnitC1(6663)-January2008.pdf", Properties.Resources.c1ja08); }
                        else if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("Questionpaper-UnitC1(6663)-January2009.pdf", Properties.Resources.c1ja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("Questionpaper-UnitC1(6663)-January2010.pdf", Properties.Resources.c1ja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("Questionpaper-UnitC1(6663)-January2011.pdf", Properties.Resources.c1ja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("Questionpaper-UnitC1(6663)-January2012.pdf", Properties.Resources.c1ja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("Questionpaper-UnitC1(6663)-January2013.pdf", Properties.Resources.c1ja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2005")
                        { openfile("Questionpaper-UnitC1(6663)-June2005.pdf", Properties.Resources.c1ju05); }
                        else if (listBox1.SelectedItem.ToString() == "june 2007")
                        { openfile("Questionpaper-UnitC1(6663)-June2007.pdf", Properties.Resources.c1ju07); }
                        else if (listBox1.SelectedItem.ToString() == "june 2008")
                        { openfile("Questionpaper-UnitC1(6663)-June2008.pdf", Properties.Resources.c1ju08); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("Questionpaper-UnitC1(6663)-June2009.pdf", Properties.Resources.c1ju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("Questionpaper-UnitC1(6663)-June2010.pdf", Properties.Resources.c1ju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("Questionpaper-UnitC1(6663)-June2011.pdf", Properties.Resources.c1ju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("Questionpaper-UnitC1(6663)-June2012.pdf", Properties.Resources.c1ju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("Questionpaper-UnitC1(6663)-June2013.pdf", Properties.Resources.c1ju13); }
                    }
                    #endregion
                    #region mathc2
                    else if (checkbutton == "c2")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2005")
                        { openfile("Questionpaper-UnitC2(6664)-January2005.doc", Properties.Resources.c2ja05); }
                        else if (listBox1.SelectedItem.ToString() == "january 2006")
                        { openfile("Questionpaper-UnitC2(6664)-January2006.doc", Properties.Resources.c2ja06); }
                        else if (listBox1.SelectedItem.ToString() == "january 2008")
                        { openfile("Questionpaper-UnitC2(6664)-January2008.pdf", Properties.Resources.c2ja08); }
                        else if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("Questionpaper-UnitC2(6664)-January2009.pdf", Properties.Resources.c2ja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("Questionpaper-UnitC2(6664)-January2010.pdf", Properties.Resources.c2ja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("Questionpaper-UnitC2(6664)-January2011.pdf", Properties.Resources.c2ja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("Questionpaper-UnitC2(6664)-January2012.pdf", Properties.Resources.c2ja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("Questionpaper-UnitC2(6664)-January2013.pdf", Properties.Resources.c2ja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2005")
                        { openfile("Questionpaper-UnitC2(6664)-June2005.pdf", Properties.Resources.c2ju05); }
                        else if (listBox1.SelectedItem.ToString() == "june 2006")
                        { openfile("Questionpaper-UnitC2(6664)-June2006.pdf", Properties.Resources.c2ju06); }
                        else if (listBox1.SelectedItem.ToString() == "june 2007")
                        { openfile("Questionpaper-UnitC2(6664)-June2007.pdf", Properties.Resources.c2ju07); }
                        else if (listBox1.SelectedItem.ToString() == "june 2008")
                        { openfile("Questionpaper-UnitC2(6664)-June2008.pdf", Properties.Resources.c2ju08); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("Questionpaper-UnitC2(6664)-June2009.pdf", Properties.Resources.c2ju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("Questionpaper-UnitC2(6664)-June2010.pdf", Properties.Resources.c2ju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("Questionpaper-UnitC2(6664)-June2011.pdf", Properties.Resources.c2ju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("Questionpaper-UnitC2(6664)-June2012.pdf", Properties.Resources.c2ju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("Questionpaper-UnitC2(6664)-June2013.pdf", Properties.Resources.c2ju13); }
                    }
                    #endregion
                    #region mathc3
                    else if (checkbutton == "c3")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2006")
                        { openfile("c3ja06.pdf", Properties.Resources.c3ja06); }
                        else if (listBox1.SelectedItem.ToString() == "january 2008")
                        { openfile("c3ja08.pdf", Properties.Resources.c3ja08); }
                        else if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("c3ja09.pdf", Properties.Resources.c3ja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("c3ja10.pdf", Properties.Resources.c3ja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("c3ja11.pdf", Properties.Resources.c3ja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("c3ja12.pdf", Properties.Resources.c3ja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("c3ja13.pdf", Properties.Resources.c3ja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2005")
                        { openfile("c3ju05.pdf", Properties.Resources.c3ju05); }
                        else if (listBox1.SelectedItem.ToString() == "june 2006")
                        { openfile("c3ju06.pdf", Properties.Resources.c3ju06); }
                        else if (listBox1.SelectedItem.ToString() == "june 2007")
                        { openfile("c3ju07.pdf", Properties.Resources.c3ju07); }
                        else if (listBox1.SelectedItem.ToString() == "june 2008")
                        { openfile("c3ju08.pdf", Properties.Resources.c3ju08); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("c3ju09.pdf", Properties.Resources.mc1ju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("c3ju10.pdf", Properties.Resources.c3ju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("c3ju11.pdf", Properties.Resources.c3ju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("c3ju12.pdf", Properties.Resources.c3ju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("c3ju13.pdf", Properties.Resources.c3ju13); }
                    }
                    #endregion
                    #region mathc4
                    else if (checkbutton == "c4")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2006")
                        { openfile("c4ja06.pdf", Properties.Resources.c4ja06); }
                        else if (listBox1.SelectedItem.ToString() == "january 2008")
                        { openfile("c4ja08.pdf", Properties.Resources.c4ja08); }
                        else if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("c4ja09.pdf", Properties.Resources.c4ja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("c4ja10.pdf", Properties.Resources.c4ja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("c4ja11.pdf", Properties.Resources.c4ja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("c4ja12.pdf", Properties.Resources.c4ja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("c4ja13.pdf", Properties.Resources.c4ja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2005")
                        { openfile("c4ju05.pdf", Properties.Resources.c4ju05); }
                        else if (listBox1.SelectedItem.ToString() == "june 2006")
                        { openfile("c4ju06.pdf", Properties.Resources.c4ju06); }
                        else if (listBox1.SelectedItem.ToString() == "june 2007")
                        { openfile("c4ju07.pdf", Properties.Resources.c4ju07); }
                        else if (listBox1.SelectedItem.ToString() == "june 2008")
                        { openfile("c4ju08.pdf", Properties.Resources.c4ju08); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("c4ju09.pdf", Properties.Resources.mc1ju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("c4ju10.pdf", Properties.Resources.c4ju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("c4ju11.pdf", Properties.Resources.c4ju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("c4ju12.pdf", Properties.Resources.c4ju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("c4ju13.pdf", Properties.Resources.c4ju13); }
                    }
                    #endregion
                    #region maths1
                    else if (checkbutton == "s1")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2003")
                        { openfile("s1ja03.pdf", Properties.Resources.s1ja03); }
                        else if (listBox1.SelectedItem.ToString() == "january 2005")
                        { openfile("s1ja05.pdf", Properties.Resources.s1ja05); }
                        else if (listBox1.SelectedItem.ToString() == "january 2006")
                        { openfile("s1ja06.pdf", Properties.Resources.s1ja06); }
                        else if (listBox1.SelectedItem.ToString() == "january 2008")
                        { openfile("s1ja08.pdf", Properties.Resources.s1ja08); }
                        else if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("s1ja09.pdf", Properties.Resources.s1ja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("s1ja10.pdf", Properties.Resources.s1ja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("s1ja11.pdf", Properties.Resources.s1ja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("s1ja12.pdf", Properties.Resources.s1ja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("s1ja13.pdf", Properties.Resources.s1ja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2005")
                        { openfile("s1ju05.pdf", Properties.Resources.s1ju05); }
                        else if (listBox1.SelectedItem.ToString() == "june 2006")
                        { openfile("s1ju06.pdf", Properties.Resources.s1ju06); }
                        else if (listBox1.SelectedItem.ToString() == "june 2007")
                        { openfile("s1ju07.pdf", Properties.Resources.s1ju07); }
                        else if (listBox1.SelectedItem.ToString() == "june 2008")
                        { openfile("s1ju08.pdf", Properties.Resources.s1ju08); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("s1ju09.pdf", Properties.Resources.mc1ju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("s1ju10.pdf", Properties.Resources.s1ju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("s1ju11.pdf", Properties.Resources.s1ju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("s1ju12.pdf", Properties.Resources.s1ju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("s1ju13.pdf", Properties.Resources.s1ju13); }
                    }
                    #endregion
                    #region electronics wave and protons
                    else if (checkbutton == "EWP")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("ewpja10.pdf", Properties.Resources.ewpja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("ewpja11.pdf", Properties.Resources.ewpja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("ewpja12.pdf", Properties.Resources.ewpja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("ewpja13.pdf", Properties.Resources.ewpja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("ewpju09.pdf", Properties.Resources.ewpju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("ewpju10.pdf", Properties.Resources.ewpju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("ewpju11.pdf", Properties.Resources.ewpju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("ewpju12.pdf", Properties.Resources.ewpju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("ewpju13.pdf", Properties.Resources.ewpju13); }
                    }
                    #endregion
                    #region mechanics
                    else if (checkbutton == "MECH")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("mechanicsja09.pdf", Properties.Resources.mechanicsja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("mechanicsja10.pdf", Properties.Resources.mechanicsja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("mechanicsja11.pdf", Properties.Resources.mechanicsja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("mechanicsja12.pdf", Properties.Resources.mechanicsja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("mechanicsja13.pdf", Properties.Resources.mechanicsja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("mechanicsju09.pdf", Properties.Resources.mechanicsju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("mechanicsju10.pdf", Properties.Resources.mechanicsju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("mechanicsju11.pdf", Properties.Resources.mechanicsju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("mechanicsju12.pdf", Properties.Resources.mechanicsju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("mechanicsju13.pdf", Properties.Resources.mechanicsju13); }
                    }
                    #endregion
                    #region programming
                    else if (checkbutton == "PTALM")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("ptamlja09.pdf", Properties.Resources.ptamlja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("ptamlja10.pdf", Properties.Resources.ptamlja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("ptamlja11.pdf", Properties.Resources.ptamlja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("ptamlja12.pdf", Properties.Resources.ptamlja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("ptamlja13.pdf", Properties.Resources.ptamlja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("ptamlju09.pdf", Properties.Resources.ptamlju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("ptamlju10.pdf", Properties.Resources.ptamlju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("ptamlju11.pdf", Properties.Resources.ptamlju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("ptamlju12.pdf", Properties.Resources.ptamlju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("ptamlju13.pdf", Properties.Resources.ptamlju13); }
                    }
                    #endregion
                    #region COMPUTER FUNDAMENTALS
                    else if (checkbutton == "CF")
                    {
                        if (listBox1.SelectedItem.ToString() == "january 2009")
                        { openfile("cfja09.pdf", Properties.Resources.cfja09); }
                        else if (listBox1.SelectedItem.ToString() == "january 2010")
                        { openfile("cfja10.pdf", Properties.Resources.cfja10); }
                        else if (listBox1.SelectedItem.ToString() == "january 2011")
                        { openfile("cfja11.pdf", Properties.Resources.cfja11); }
                        else if (listBox1.SelectedItem.ToString() == "january 2012")
                        { openfile("cfja12.pdf", Properties.Resources.cfja12); }
                        else if (listBox1.SelectedItem.ToString() == "january 2013")
                        { openfile("cfja13.pdf", Properties.Resources.cfja13); }
                        else if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("cfju09.pdf", Properties.Resources.cfju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("cfju10.pdf", Properties.Resources.cfju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("cfju11.pdf", Properties.Resources.cfju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("cfju12.pdf", Properties.Resources.cfju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("cfju13.pdf", Properties.Resources.cfju13); }
                    }
                    #endregion
                    #region SIMPLE SYSTEM
                    else if (checkbutton == "SS")
                    {

                        if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("ssju09.pdf", Properties.Resources.ssju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("ssju10.pdf", Properties.Resources.ssju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("ssju11.pdf", Properties.Resources.ssju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("ssju12.pdf", Properties.Resources.ssju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("ssju13.pdf", Properties.Resources.ssju13); }
                    }
                    #endregion
                    #region SIGNAL SYSTEM
                    else if (checkbutton == "SP")
                    {
                        if (listBox1.SelectedItem.ToString() == "june 2009")
                        { openfile("spju09.pdf", Properties.Resources.spju09); }
                        else if (listBox1.SelectedItem.ToString() == "june 2010")
                        { openfile("spju10.pdf", Properties.Resources.spju10); }
                        else if (listBox1.SelectedItem.ToString() == "june 2011")
                        { openfile("spju11.pdf", Properties.Resources.spju11); }
                        else if (listBox1.SelectedItem.ToString() == "june 2012")
                        { openfile("spju12.pdf", Properties.Resources.spju12); }
                        else if (listBox1.SelectedItem.ToString() == "june 2013")
                        { openfile("spju13.pdf", Properties.Resources.spju13); }
                    }
                    #endregion
                    listBox1.ClearSelected();
                    button1.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }           
    }
}
