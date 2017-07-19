using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterApplication
{
    public partial class Form1 : Form
    {
        private static System.Windows.Forms.Timer stockTimer;
        private static System.Windows.Forms.Timer brokenTimer;
        databaseModel database = new databaseModel();
        private string previous;
        public Form1()
        {
            initializeTimers();
            InitializeComponent();
           // printInfo();
        }
        public void initializeTimers()
        {
            stockTimer = new System.Windows.Forms.Timer(); // Check for communication activity on Non-Blocking sockets every 200ms
            stockTimer.Tick += new EventHandler(stockUpdateTimer); // Set event handler method for timer
            stockTimer.Interval = 300;  // Timer interval is 1/10 second
            brokenTimer = new System.Windows.Forms.Timer(); // Check for communication activity on Non-Blocking sockets every 200ms
            brokenTimer.Tick += new EventHandler(brokenUpdateTimer); // Set event handler method for timer
            brokenTimer.Interval = 300;  // Timer interval is 1/10 second            
        }
        public void printInfo()
        {
            stockBox.Text = "";
            if (database.showAll("StockCheck"))
            {
                foreach (String s in database.showItems)
                {
                    stockBox.Text += s;
                }
            }
        }
        private void stockUpdateTimer(Object myObject, EventArgs myEventArgs)
        {
            if (database.getItem("BrokenPile", itemBox.Text))
            {                
                itemBox.Text = "";
                stockTimer.Enabled = false;
                MessageBox.Show("This is currently in the broken pile","Error : Broken", MessageBoxButtons.OKCancel,    MessageBoxIcon.Asterisk);
            }
            else if (database.getItem("StockCheck", itemBox.Text))
            {
                //Do nothing
            }
            else
            {
                addStock();                
            }
            previous = itemBox.Text;
            printInfo();
            itemBox.Text = "";
            stockTimer.Enabled = false;
        }
        private void tabChangeControl(object sender, EventArgs e)
        {
            Color color = Color.White;
            printInfo();
            reasonBox.Text = "";
            resultBox.Text = "";
        }
        private void brokenUpdateTimer(Object myObject, EventArgs myEventArgs)
        {
            if (database.getItem("StockCheck", itemBox.Text))
            {
                database.removeItem("StockCheck", itemBox.Text);
                database.addItem("BrokenPile", itemBox.Text);
                
            }
            else
            {
                if (database.getItem("BrokenPile", itemBox.Text))
                {
                    reasonBox.Text = database.reason;
                    resultBox.Text = database.result;
                }
                else
                {
                    if (database.addItem("BrokenPile", itemBox.Text))
                    {
                        database.updateitem("BrokenPile", itemBox.Text, "reason", reasonBox.Text);
                        reasonBox.BackColor = Color.White;
                       
                    }
                   
                }
            }
            previous = itemBox.Text;
            itemBox.Text = "";
            brokenTimer.Enabled = false;
        }
        private void itemBox_TextChanged(object sender, EventArgs e)
        {
            if (itemBox.Text != "")
            {
                if (tabControl1.SelectedTab == reportPage)               
                    brokenTimer.Enabled = true;
                
                else if (tabControl1.SelectedTab == stockPage)
                    stockTimer.Enabled = true;
            }
        }

       
        private void addStock()
        {
            if (database.addItem("StockCheck", itemBox.Text))
            {
                itemBox.BackColor = Color.White;
                if(badButton.Checked)
                    database.updateitem("StockCheck", itemBox.Text, "condition", "Bad");
                else
                    database.updateitem("StockCheck", itemBox.Text, "condition", "Good");
                if (missingButton.Checked)
                    database.updateitem("StockCheck", itemBox.Text, "condition", " Missing Component");
                database.updateitem("StockCheck", itemBox.Text, "additional", itemNameBox.Text);
                database.updateitem("StockCheck", previous, "location", locationBox.Text);
            }
            else
            {
                itemBox.BackColor = Color.Red;
            }
        }


        private void itemNameBox_TextChanged(object sender, EventArgs e)
        {
            database.updateitem("StockCheck", previous, "name", itemNameBox.Text);
        }

        private void reasonBox_TextChanged(object sender, EventArgs e)
        {
            if(previous != "")
                database.updateitem("BrokenPile", previous, "reason", reasonBox.Text);
        }

        private void disposedButton_CheckedChanged(object sender, EventArgs e)
        {
            database.addItem("Disposed", previous);
            if (database.getItem("BrokenPile", previous))
                database.updateitem("Disposed", previous, "reason", database.reason);
            database.removeItem("BrokenPile", previous);
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            database.updateitem("BrokenPile", previous, "result", resultBox.Text);
        }

        private void checkedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (checkedButton.Checked)
            {
                database.addItem("StockCheck", previous);
                database.removeItem("BrokenPile", previous);
            }
        }

        private void badButton_CheckedChanged(object sender, EventArgs e)
        {
            if(badButton.Checked) 
                database.updateitem("StockCheck", previous, "condition", "Bad");
        }

        private void missingButton_CheckedChanged(object sender, EventArgs e)
        {
            if(missingButton.Checked)
                database.updateitem("StockCheck", previous, "condition", "Missing Component");
        }

        private void disposed_CheckedChanged(object sender, EventArgs e)
        {
            if(disposed.Checked) {
                showInfo("Disposed");
            }
        }

        private void brokenButton_CheckedChanged(object sender, EventArgs e)
        {
            if (brokenButton.Checked)
            {
                showInfo("BrokenPile");
            }
        }

        private void stockButton_CheckedChanged(object sender, EventArgs e)
        {
            if(stockButton.Checked) 
            {
                showInfo("StockCheck");
            }
        }
        private void showInfo(string type) {
            showField.Text = type + "\n\n";
            if (database.showAll(type))
            {
                foreach (String s in database.showItems)
                {
                    showField.Text += s;
                }
            }
        }

        private void locationBox_TextChanged(object sender, EventArgs e)
        {
            if (previous != "")
                database.updateitem("StockCheck", previous, "location", locationBox.Text);
        }
    }
}
