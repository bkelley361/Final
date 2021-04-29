using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Final_Project___Ben_Kelley
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates a random fact from the API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_GenFact_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txt_ID.Clear();
            Numbers fact = new Numbers();
            try
            {
                fact = await JSONHelper.GetRandomFact();
            }
            catch (Exception)
            {
                MessageBox.Show("Something has gone terribly wrong. Please try again");
            }
            try
            {
                listBox1.Items.Add(fact.text);
                lbl_Num.Text = Convert.ToString(fact.number);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Caught");
            }
        }

        /// <summary>
        /// Saves a fact to the database. Uses a name that the user inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbl_Num.Text);
            string name = txt_ID.Text;
            if (name == "")
            {
                name = "You forgot to name this one";
            }
            SQLHelper.SaveNumber(id, name);
            txt_ID.Clear();
            MessageBox.Show("Fact Saved");
        }

        /// <summary>
        /// Shows the saved facts in the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveID_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txt_ID.Clear();
            string format = SQLHelper.GetSaved();
            using (StringReader reader = new StringReader(format))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
            }
        }

        /// <summary>
        /// Shows a specific fact that was saved to the database. The user must enter the id of the fact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_Fact_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string number = txt_ID.Text;
            int id;

            bool parseSuccess = Int32.TryParse(number, out id);

            while (parseSuccess != true)
            {
                number = txt_ID.Text;
                if (parseSuccess == false)
                {
                    MessageBox.Show("Please enter a number into the text box");
                    parseSuccess = Int32.TryParse(number, out id);
                    return;
                }
            }
            int factID = SQLHelper.GetID(id);

            if (factID == 0)
            {
                MessageBox.Show("Please enter a number that actually corresponds to a fact");
            }
            else
            {
                string JsonfactID = factID.ToString();
                Numbers fact = new Numbers();
                try
                {
                    fact = await JSONHelper.GetSpecificFact(JsonfactID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something has gone terribly wrong. Please try again");
                }
                listBox1.Items.Add(fact.text);
                lbl_Num.Text = Convert.ToString(fact.number);
                txt_ID.Clear();
            }
        }

        /// <summary>
        /// Deletes a fact from the database. Uses the id that the user inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Dlt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string number = txt_ID.Text;
            int id;

            bool parseSuccess = Int32.TryParse(number, out id);

            while (parseSuccess != true)
            {
                number = txt_ID.Text;
                if (parseSuccess == false)
                {
                    MessageBox.Show("Please enter a number into the text box");
                    parseSuccess = Int32.TryParse(number, out id);
                    return;
                }
            }

            SQLHelper.Delete(id);

            txt_ID.Clear();
        }
    }
}
