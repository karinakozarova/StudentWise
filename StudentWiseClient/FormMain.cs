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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
            var events = Event.Enumerate();

            //Event.Create("Test from form", "Test from form", EventType.Other, DateTime.Now, DateTime.Now.AddDays(1));

            foreach (Event ev in events)
            {
                EventComponent event1 = new EventComponent();
                flowLayoutPanelToday.Controls.Add(event1);
                event1.SetTitle(ev.Title);
                event1.SetDescription(ev.Description);
                event1.SetType(ev.Type);
                event1.SetDeadline(ev.StartsAt, ev.FinishesAt);
                event1.setEventPoints();
            }

            //for(int i = 1; i < 6; i++)
            //{
            //    EventComponent event1 = new EventComponent();
            //    flowLayoutPanelDay1.Controls.Add(event1);
            //    event1.SetTitle("sdsads");
            //    event1.SetDescription("This is the very long and cool event description");
            //    event1.SetType(EventType.Other);
            //    event1.SetDeadline(DateTime.Now, DateTime.Now.AddDays(1));
            //    event1.setEventPoints();
            //}
            //for (int i = 1; i < 3; i++)
            //{
            //   /* EventComponent event2 = new EventComponent(event);
            //    flowLayoutPanelDay2.Controls.Add(event2);
            //    event2.SetTitle(i);*/
            //}

        }
    }
}
