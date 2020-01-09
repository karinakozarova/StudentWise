namespace StudentWiseClient
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpDashboard = new System.Windows.Forms.TabPage();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblEvents = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.TommorowEventsLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tpExpenses = new System.Windows.Forms.TabPage();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.tpComplaints = new System.Windows.Forms.TabPage();
            this.lblComplaints = new System.Windows.Forms.Label();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsBtnDashboard = new System.Windows.Forms.ToolStripButton();
            this.tsBtnEvents = new System.Windows.Forms.ToolStripButton();
            this.tsBtnExpenses = new System.Windows.Forms.ToolStripButton();
            this.tsBtnComplaints = new System.Windows.Forms.ToolStripButton();
            this.eventComponent1 = new StudentWiseClient.EventComponent();
            this.eventComponent3 = new StudentWiseClient.EventComponent();
            this.eventComponent4 = new StudentWiseClient.EventComponent();
            this.eventComponent5 = new StudentWiseClient.EventComponent();
            this.eventComponent2 = new StudentWiseClient.EventComponent();
            this.eventComponent6 = new StudentWiseClient.EventComponent();
            this.AddEventBtn = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpDashboard.SuspendLayout();
            this.tpEvents.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tpExpenses.SuspendLayout();
            this.tpComplaints.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpDashboard);
            this.tcMain.Controls.Add(this.tpEvents);
            this.tcMain.Controls.Add(this.tpExpenses);
            this.tcMain.Controls.Add(this.tpComplaints);
            this.tcMain.Location = new System.Drawing.Point(0, 39);
            this.tcMain.Margin = new System.Windows.Forms.Padding(0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(957, 475);
            this.tcMain.TabIndex = 0;
            // 
            // tpDashboard
            // 
            this.tpDashboard.Controls.Add(this.lblDashboard);
            this.tpDashboard.Location = new System.Drawing.Point(4, 25);
            this.tpDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.tpDashboard.Name = "tpDashboard";
            this.tpDashboard.Size = new System.Drawing.Size(949, 446);
            this.tpDashboard.TabIndex = 0;
            this.tpDashboard.Text = "Dashboard";
            this.tpDashboard.UseVisualStyleBackColor = true;
            // 
            // lblDashboard
            // 
            this.lblDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(0, 0);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblDashboard.Size = new System.Drawing.Size(949, 66);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpEvents
            // 
            this.tpEvents.Controls.Add(this.flowLayoutPanel1);
            this.tpEvents.Location = new System.Drawing.Point(4, 25);
            this.tpEvents.Margin = new System.Windows.Forms.Padding(0);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Size = new System.Drawing.Size(949, 446);
            this.tpEvents.TabIndex = 1;
            this.tpEvents.Text = "Events";
            this.tpEvents.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.lblEvents);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.TommorowEventsLbl);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.AddEventBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(933, 422);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lblEvents
            // 
            this.lblEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEvents.Font = new System.Drawing.Font("Oswald", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEvents.Location = new System.Drawing.Point(0, 0);
            this.lblEvents.Margin = new System.Windows.Forms.Padding(0);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblEvents.Size = new System.Drawing.Size(903, 89);
            this.lblEvents.TabIndex = 2;
            this.lblEvents.Text = "Today\'s events";
            this.lblEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.eventComponent1);
            this.flowLayoutPanel2.Controls.Add(this.eventComponent3);
            this.flowLayoutPanel2.Controls.Add(this.eventComponent4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 92);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(898, 658);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // TommorowEventsLbl
            // 
            this.TommorowEventsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TommorowEventsLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TommorowEventsLbl.Font = new System.Drawing.Font("Oswald", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TommorowEventsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TommorowEventsLbl.Location = new System.Drawing.Point(0, 753);
            this.TommorowEventsLbl.Margin = new System.Windows.Forms.Padding(0);
            this.TommorowEventsLbl.Name = "TommorowEventsLbl";
            this.TommorowEventsLbl.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.TommorowEventsLbl.Size = new System.Drawing.Size(903, 89);
            this.TommorowEventsLbl.TabIndex = 4;
            this.TommorowEventsLbl.Text = "Tommorow\'s events";
            this.TommorowEventsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.eventComponent5);
            this.flowLayoutPanel3.Controls.Add(this.eventComponent2);
            this.flowLayoutPanel3.Controls.Add(this.eventComponent6);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 845);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(898, 658);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // tpExpenses
            // 
            this.tpExpenses.Controls.Add(this.lblExpenses);
            this.tpExpenses.Location = new System.Drawing.Point(4, 25);
            this.tpExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.tpExpenses.Name = "tpExpenses";
            this.tpExpenses.Size = new System.Drawing.Size(949, 443);
            this.tpExpenses.TabIndex = 2;
            this.tpExpenses.Text = "Expenses";
            this.tpExpenses.UseVisualStyleBackColor = true;
            // 
            // lblExpenses
            // 
            this.lblExpenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenses.Location = new System.Drawing.Point(0, 0);
            this.lblExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblExpenses.Size = new System.Drawing.Size(949, 66);
            this.lblExpenses.TabIndex = 2;
            this.lblExpenses.Text = "Expenses";
            this.lblExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpComplaints
            // 
            this.tpComplaints.Controls.Add(this.lblComplaints);
            this.tpComplaints.Location = new System.Drawing.Point(4, 25);
            this.tpComplaints.Margin = new System.Windows.Forms.Padding(0);
            this.tpComplaints.Name = "tpComplaints";
            this.tpComplaints.Size = new System.Drawing.Size(949, 443);
            this.tpComplaints.TabIndex = 3;
            this.tpComplaints.Text = "Complaints";
            this.tpComplaints.UseVisualStyleBackColor = true;
            // 
            // lblComplaints
            // 
            this.lblComplaints.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaints.Location = new System.Drawing.Point(0, 0);
            this.lblComplaints.Margin = new System.Windows.Forms.Padding(0);
            this.lblComplaints.Name = "lblComplaints";
            this.lblComplaints.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblComplaints.Size = new System.Drawing.Size(949, 66);
            this.lblComplaints.TabIndex = 3;
            this.lblComplaints.Text = "Complaints";
            this.lblComplaints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsMain
            // 
            this.tsMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsMain.AutoSize = false;
            this.tsMain.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnDashboard,
            this.tsBtnEvents,
            this.tsBtnExpenses,
            this.tsBtnComplaints});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Padding = new System.Windows.Forms.Padding(10);
            this.tsMain.Size = new System.Drawing.Size(953, 53);
            this.tsMain.TabIndex = 1;
            // 
            // tsBtnDashboard
            // 
            this.tsBtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDashboard.Image")));
            this.tsBtnDashboard.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.tsBtnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnDashboard.Name = "tsBtnDashboard";
            this.tsBtnDashboard.Padding = new System.Windows.Forms.Padding(5);
            this.tsBtnDashboard.Size = new System.Drawing.Size(142, 33);
            this.tsBtnDashboard.Text = "Dashboard";
            this.tsBtnDashboard.Click += new System.EventHandler(this.TsBtn_Click);
            // 
            // tsBtnEvents
            // 
            this.tsBtnEvents.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnEvents.Image")));
            this.tsBtnEvents.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.tsBtnEvents.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnEvents.Name = "tsBtnEvents";
            this.tsBtnEvents.Padding = new System.Windows.Forms.Padding(5);
            this.tsBtnEvents.Size = new System.Drawing.Size(102, 40);
            this.tsBtnEvents.Text = "Events";
            this.tsBtnEvents.Click += new System.EventHandler(this.TsBtn_Click);
            // 
            // tsBtnExpenses
            // 
            this.tsBtnExpenses.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExpenses.Image")));
            this.tsBtnExpenses.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.tsBtnExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnExpenses.Name = "tsBtnExpenses";
            this.tsBtnExpenses.Padding = new System.Windows.Forms.Padding(5);
            this.tsBtnExpenses.Size = new System.Drawing.Size(124, 40);
            this.tsBtnExpenses.Text = "Expenses";
            this.tsBtnExpenses.Click += new System.EventHandler(this.TsBtn_Click);
            // 
            // tsBtnComplaints
            // 
            this.tsBtnComplaints.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnComplaints.Image")));
            this.tsBtnComplaints.ImageTransparentColor = System.Drawing.SystemColors.Window;
            this.tsBtnComplaints.Margin = new System.Windows.Forms.Padding(0);
            this.tsBtnComplaints.Name = "tsBtnComplaints";
            this.tsBtnComplaints.Padding = new System.Windows.Forms.Padding(5);
            this.tsBtnComplaints.Size = new System.Drawing.Size(145, 40);
            this.tsBtnComplaints.Text = "Complaints";
            this.tsBtnComplaints.Click += new System.EventHandler(this.TsBtn_Click);
            // 
            // eventComponent1
            // 
            this.eventComponent1.BackColor = System.Drawing.Color.Transparent;
            this.eventComponent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventComponent1.Font = new System.Drawing.Font("Oswald", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventComponent1.Location = new System.Drawing.Point(2, 4);
            this.eventComponent1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.eventComponent1.Name = "eventComponent1";
            this.eventComponent1.Size = new System.Drawing.Size(445, 321);
            this.eventComponent1.TabIndex = 3;
            // 
            // eventComponent3
            // 
            this.eventComponent3.BackColor = System.Drawing.Color.Transparent;
            this.eventComponent3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventComponent3.Font = new System.Drawing.Font("Oswald", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventComponent3.Location = new System.Drawing.Point(451, 4);
            this.eventComponent3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.eventComponent3.Name = "eventComponent3";
            this.eventComponent3.Size = new System.Drawing.Size(445, 321);
            this.eventComponent3.TabIndex = 1;
            // 
            // eventComponent4
            // 
            this.eventComponent4.BackColor = System.Drawing.Color.Transparent;
            this.eventComponent4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventComponent4.Font = new System.Drawing.Font("Oswald", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventComponent4.Location = new System.Drawing.Point(2, 333);
            this.eventComponent4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.eventComponent4.Name = "eventComponent4";
            this.eventComponent4.Size = new System.Drawing.Size(445, 321);
            this.eventComponent4.TabIndex = 2;
            // 
            // eventComponent5
            // 
            this.eventComponent5.BackColor = System.Drawing.Color.Transparent;
            this.eventComponent5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventComponent5.Font = new System.Drawing.Font("Oswald", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventComponent5.Location = new System.Drawing.Point(2, 4);
            this.eventComponent5.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.eventComponent5.Name = "eventComponent5";
            this.eventComponent5.Size = new System.Drawing.Size(445, 321);
            this.eventComponent5.TabIndex = 1;
            // 
            // eventComponent2
            // 
            this.eventComponent2.BackColor = System.Drawing.Color.Transparent;
            this.eventComponent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventComponent2.Font = new System.Drawing.Font("Oswald", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventComponent2.Location = new System.Drawing.Point(451, 4);
            this.eventComponent2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.eventComponent2.Name = "eventComponent2";
            this.eventComponent2.Size = new System.Drawing.Size(445, 321);
            this.eventComponent2.TabIndex = 3;
            // 
            // eventComponent6
            // 
            this.eventComponent6.BackColor = System.Drawing.Color.Transparent;
            this.eventComponent6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eventComponent6.Font = new System.Drawing.Font("Oswald", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventComponent6.Location = new System.Drawing.Point(2, 333);
            this.eventComponent6.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.eventComponent6.Name = "eventComponent6";
            this.eventComponent6.Size = new System.Drawing.Size(445, 321);
            this.eventComponent6.TabIndex = 2;
            // 
            // AddEventBtn
            // 
            this.AddEventBtn.AutoSize = true;
            this.AddEventBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.AddEventBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddEventBtn.Font = new System.Drawing.Font("Oswald SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEventBtn.Location = new System.Drawing.Point(3, 1509);
            this.AddEventBtn.Name = "AddEventBtn";
            this.AddEventBtn.Size = new System.Drawing.Size(898, 51);
            this.AddEventBtn.TabIndex = 4;
            this.AddEventBtn.Text = "Add new event";
            this.AddEventBtn.UseVisualStyleBackColor = false;
            this.AddEventBtn.Click += new System.EventHandler(this.AddEventBtn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.tcMain);
            this.MinimumSize = new System.Drawing.Size(470, 540);
            this.Name = "FormMain";
            this.Text = "StudentWise";
            this.tcMain.ResumeLayout(false);
            this.tpDashboard.ResumeLayout(false);
            this.tpEvents.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tpExpenses.ResumeLayout(false);
            this.tpComplaints.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpDashboard;
        private System.Windows.Forms.TabPage tpExpenses;
        private System.Windows.Forms.TabPage tpComplaints;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsBtnDashboard;
        private System.Windows.Forms.ToolStripButton tsBtnEvents;
        private System.Windows.Forms.ToolStripButton tsBtnExpenses;
        private System.Windows.Forms.ToolStripButton tsBtnComplaints;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.Label lblComplaints;
        private System.Windows.Forms.TabPage tpEvents;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label TommorowEventsLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private EventComponent eventComponent3;
        private EventComponent eventComponent4;
        private EventComponent eventComponent5;
        private EventComponent eventComponent6;
        private EventComponent eventComponent1;
        private EventComponent eventComponent2;
        private System.Windows.Forms.Button AddEventBtn;
    }
}

