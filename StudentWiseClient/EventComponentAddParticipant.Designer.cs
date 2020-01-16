namespace StudentWiseClient
{
    partial class EventComponentAddParticipant
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventComponentAddParticipant));
            this.EventDeadlineLbl = new System.Windows.Forms.Label();
            this.ImagePbx = new System.Windows.Forms.PictureBox();
            this.EventTypeLbl = new System.Windows.Forms.Label();
            this.EventTitleLbl = new System.Windows.Forms.Label();
            this.EventDescriptionLbl = new System.Windows.Forms.Label();
            this.DeleteEventPbx = new System.Windows.Forms.PictureBox();
            this.EventCompletePbx = new System.Windows.Forms.PictureBox();
            this.btnAddParticipant = new System.Windows.Forms.Button();
            this.ParticipantsCmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteEventPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventCompletePbx)).BeginInit();
            this.SuspendLayout();
            // 
            // EventDeadlineLbl
            // 
            this.EventDeadlineLbl.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDeadlineLbl.Location = new System.Drawing.Point(235, 13);
            this.EventDeadlineLbl.Name = "EventDeadlineLbl";
            this.EventDeadlineLbl.Size = new System.Drawing.Size(163, 66);
            this.EventDeadlineLbl.TabIndex = 5;
            this.EventDeadlineLbl.Text = "Start Date and End Date";
            // 
            // ImagePbx
            // 
            this.ImagePbx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImagePbx.Location = new System.Drawing.Point(16, 13);
            this.ImagePbx.Name = "ImagePbx";
            this.ImagePbx.Size = new System.Drawing.Size(106, 102);
            this.ImagePbx.TabIndex = 6;
            this.ImagePbx.TabStop = false;
            // 
            // EventTypeLbl
            // 
            this.EventTypeLbl.AutoSize = true;
            this.EventTypeLbl.Font = new System.Drawing.Font("Oswald", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTypeLbl.Location = new System.Drawing.Point(128, 47);
            this.EventTypeLbl.Name = "EventTypeLbl";
            this.EventTypeLbl.Size = new System.Drawing.Size(87, 32);
            this.EventTypeLbl.TabIndex = 7;
            this.EventTypeLbl.Text = "Event Type";
            // 
            // EventTitleLbl
            // 
            this.EventTitleLbl.AutoSize = true;
            this.EventTitleLbl.Font = new System.Drawing.Font("Oswald", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTitleLbl.Location = new System.Drawing.Point(127, 74);
            this.EventTitleLbl.Name = "EventTitleLbl";
            this.EventTitleLbl.Size = new System.Drawing.Size(121, 41);
            this.EventTitleLbl.TabIndex = 8;
            this.EventTitleLbl.Text = "Event Title";
            // 
            // EventDescriptionLbl
            // 
            this.EventDescriptionLbl.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDescriptionLbl.Location = new System.Drawing.Point(10, 133);
            this.EventDescriptionLbl.Name = "EventDescriptionLbl";
            this.EventDescriptionLbl.Size = new System.Drawing.Size(419, 65);
            this.EventDescriptionLbl.TabIndex = 9;
            this.EventDescriptionLbl.Text = "Event Description";
            // 
            // DeleteEventPbx
            // 
            this.DeleteEventPbx.BackColor = System.Drawing.Color.Red;
            this.DeleteEventPbx.Image = ((System.Drawing.Image)(resources.GetObject("DeleteEventPbx.Image")));
            this.DeleteEventPbx.Location = new System.Drawing.Point(227, 201);
            this.DeleteEventPbx.Name = "DeleteEventPbx";
            this.DeleteEventPbx.Size = new System.Drawing.Size(79, 76);
            this.DeleteEventPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteEventPbx.TabIndex = 10;
            this.DeleteEventPbx.TabStop = false;
            // 
            // EventCompletePbx
            // 
            this.EventCompletePbx.BackColor = System.Drawing.Color.LawnGreen;
            this.EventCompletePbx.Image = global::StudentWiseClient.Properties.Resources.kisspng_check_mark_symbol_icon_black_checkmark_5a76d35a732948_8416047115177367944717;
            this.EventCompletePbx.Location = new System.Drawing.Point(312, 201);
            this.EventCompletePbx.Name = "EventCompletePbx";
            this.EventCompletePbx.Size = new System.Drawing.Size(79, 76);
            this.EventCompletePbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EventCompletePbx.TabIndex = 11;
            this.EventCompletePbx.TabStop = false;
            // 
            // btnAddParticipant
            // 
            this.btnAddParticipant.Font = new System.Drawing.Font("Oswald", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddParticipant.Location = new System.Drawing.Point(16, 201);
            this.btnAddParticipant.Name = "btnAddParticipant";
            this.btnAddParticipant.Size = new System.Drawing.Size(161, 37);
            this.btnAddParticipant.TabIndex = 12;
            this.btnAddParticipant.Text = "Add participant";
            this.btnAddParticipant.UseVisualStyleBackColor = true;
            // 
            // ParticipantsCmb
            // 
            this.ParticipantsCmb.FormattingEnabled = true;
            this.ParticipantsCmb.Location = new System.Drawing.Point(16, 245);
            this.ParticipantsCmb.Name = "ParticipantsCmb";
            this.ParticipantsCmb.Size = new System.Drawing.Size(161, 24);
            this.ParticipantsCmb.TabIndex = 13;
            // 
            // EventComponentAddParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParticipantsCmb);
            this.Controls.Add(this.btnAddParticipant);
            this.Controls.Add(this.EventCompletePbx);
            this.Controls.Add(this.DeleteEventPbx);
            this.Controls.Add(this.EventDescriptionLbl);
            this.Controls.Add(this.EventTitleLbl);
            this.Controls.Add(this.EventTypeLbl);
            this.Controls.Add(this.ImagePbx);
            this.Controls.Add(this.EventDeadlineLbl);
            this.Name = "EventComponentAddParticipant";
            this.Size = new System.Drawing.Size(401, 296);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteEventPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventCompletePbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EventDeadlineLbl;
        private System.Windows.Forms.PictureBox ImagePbx;
        private System.Windows.Forms.Label EventTypeLbl;
        private System.Windows.Forms.Label EventTitleLbl;
        private System.Windows.Forms.Label EventDescriptionLbl;
        private System.Windows.Forms.PictureBox DeleteEventPbx;
        private System.Windows.Forms.PictureBox EventCompletePbx;
        private System.Windows.Forms.Button btnAddParticipant;
        private System.Windows.Forms.ComboBox ParticipantsCmb;
    }
}
