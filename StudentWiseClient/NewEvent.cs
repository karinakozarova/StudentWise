using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWiseClient
{
    public partial class NewEvent : Form
    {
        /// <summary>
        /// Disables Datetime pickers past dates
        /// </summary>
        private void DisablePastDates()
        {
            // make sure you cant add past events
            endDttpkr.MinDate = DateTime.Today;
            startDttpkr.MinDate = DateTime.Today;
        }

        public NewEvent()
        {
            InitializeComponent();
            DisablePastDates();
        }

        private void CreateBttn_Click(object sender, EventArgs e)
        {
            // check that the fields are populated
            if (String.IsNullOrEmpty(titleTbx.Text))
            {
                MessageBox.Show("Enter a title");
                return;
            }

            if (String.IsNullOrEmpty(descriptionTbx.Text))
            {
                MessageBox.Show("Enter a description");
                return;
            }


            // create new event object
            Event newEvent = new Event(titleTbx.Text, descriptionTbx.Text, startDttpkr.Value, endDttpkr.Value);

            // TODO: send event object to the API
        }
    }
}
