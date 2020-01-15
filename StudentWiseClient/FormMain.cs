﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentWiseApi;

namespace StudentWiseClient
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            timeNowTimer.Start();

            List<Event> events = Event.Enumerate(); // TODO: filter them to be today's only
            todaysEventsFllpnl.Controls.Clear();
            foreach (Event ev in events)
            {
                EventComponent eventComponent = new EventComponent();
                eventComponent.SetAllNeededProperties(ev.Id, ev.Creator, Server.CurrentSession, ev.Title, ev.Description, ev.Type, ev.StartsAt, ev.FinishesAt);
                todaysEventsFllpnl.Controls.Add(eventComponent);
            }
        }

        private void TsBtn_Click(object sender, EventArgs e)
        { 
            int targetTabIndex = tsMain.Items.IndexOf(sender as ToolStripItem);
            tcMain.SelectTab(targetTabIndex);
        }

        private void AddEventBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewEvent dashboard = new NewEvent();
            dashboard.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            List<Event> events = Event.Enumerate();
           

            foreach (Event ev in events)
            {
                EventComponent eventComponent = new EventComponent();
                eventComponent.SetAllNeededProperties(ev.Id, ev.Creator, Server.CurrentSession, ev.Title, ev.Description, ev.Type, ev.StartsAt, ev.FinishesAt);
                flowLayoutPanelToday.Controls.Add(eventComponent);
            }

            List<Complaint> complaints = Complaint.Enumerate();

            complaintsFllPanel.Controls.Clear();

            foreach (Complaint complaint in complaints)
            {
                MiniComplaintComponent complaintComponent = new MiniComplaintComponent();
                complaintComponent.ChangeLabels(complaint.Title, complaint.Status);
                complaintsFllPanel.Controls.Add(complaintComponent);
            }

            ReloadComplaints();

            HashSet<User> users = new HashSet<User>();
            HashSet<int> userIds = new HashSet<int>();
            foreach(Expense expense in Expense.Enumerate())
            {
                ExpensesLv.Items.Add(new ListViewItem(new string[] { expense.Name, expense.Price.ToString(), expense.Amount.ToString(), expense.Notes}));
                foreach(User participant in expense.Participants)
                {
                    if (!userIds.Contains(participant.Id))
                    {
                        users.Add(participant);
                        userIds.Add(participant.Id);
                    }
                }
            }

            foreach (User participant in users)
            {
                decimal balance = 0;
                foreach (Expense expense  in Expense.Enumerate())
                {
                    foreach(User u in expense.Participants)
                    {
                        if(u.Id == participant.Id) balance += (expense.Price * expense.Amount) / (expense.Participants.Count);
                    }
                     
                }
                MembersLv.Items.Add(new ListViewItem(new string[] { participant.FirstName, balance.ToString() }));

            }
        }

        private void ReloadComplaints()
        {
            List<Complaint> complaints = Complaint.Enumerate();

            complaintsFllpnl.Controls.Clear();

            foreach (Complaint complaint in complaints)
            {
                ComplaintsComponent complaintComponent = new ComplaintsComponent();
                complaintComponent.ChangeLabels(complaint.Title, complaint.Description, complaint.Status, complaint.CreatedAt);
                complaintsFllpnl.Controls.Add(complaintComponent);
            }
        }

        private void FileComplaintBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(titleTbx.Text))
            {
                MessageBox.Show("Please enter a title for your complaint");
                return;
            }

            if (String.IsNullOrEmpty(descriptionTbx.Text))
            {
                MessageBox.Show("Please enter a description for your complaint");
                return;
            }

            Complaint.Create(titleTbx.Text, descriptionTbx.Text, Server.CurrentSession);
            titleTbx.Clear();
            descriptionTbx.Clear();
            ReloadComplaints();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timeNowLbl.Text = $"Today is {DateTime.Now.Date.ToString("dd/MM/yyyy")}";
        }

        private void AddExpenseBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ExpenseTitleTbx.Text))
            {
                MessageBox.Show("Please enter expense title");
                return;
            }

            string expenseTitle = ExpenseTitleTbx.Text;
            string expenseNotes = ExpenseNotesRtbx.Text;

            decimal expensePrice = 0;
            int expenseQuantity = 1;

            try
            {
                expensePrice = ExpensePriceNum.Value;
                expenseQuantity = Convert.ToInt32(ExpenseQuantityNum.Value);
            } catch(Exception ex)
            {
                MessageBox.Show("Please enter a correct number");
                return;
            }
            Expense expense = Expense.Create(expenseTitle, expensePrice, expenseQuantity, expenseNotes, Server.CurrentSession);
            MessageBox.Show("You successfully created the expense!");
            ExpensesLv.Items.Add(new ListViewItem(new string[] { expense.Name, expense.Price.ToString(), expense.Amount.ToString(), expense.Notes }));

        }
    }
}
