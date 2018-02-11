namespace Event.Forms
{
    partial class UpdateForm
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
            this.buttonUpdateEvent = new System.Windows.Forms.Button();
            this.updateFormEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateFormBeginningDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateFormLocationTextBox = new System.Windows.Forms.TextBox();
            this.updateFormNameTextBox = new System.Windows.Forms.TextBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelBeginningDate = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUpdateEvent
            // 
            this.buttonUpdateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateEvent.Location = new System.Drawing.Point(136, 181);
            this.buttonUpdateEvent.Name = "buttonUpdateEvent";
            this.buttonUpdateEvent.Size = new System.Drawing.Size(140, 23);
            this.buttonUpdateEvent.TabIndex = 29;
            this.buttonUpdateEvent.Text = "Update Event";
            this.buttonUpdateEvent.UseVisualStyleBackColor = true;
            this.buttonUpdateEvent.Click += new System.EventHandler(this.buttonUpdateEvent_Click);
            // 
            // updateFormEndDateDateTimePicker
            // 
            this.updateFormEndDateDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            this.updateFormEndDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateFormEndDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.updateFormEndDateDateTimePicker.Location = new System.Drawing.Point(184, 137);
            this.updateFormEndDateDateTimePicker.Name = "updateFormEndDateDateTimePicker";
            this.updateFormEndDateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.updateFormEndDateDateTimePicker.TabIndex = 28;
            // 
            // updateFormBeginningDateDateTimePicker
            // 
            this.updateFormBeginningDateDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            this.updateFormBeginningDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateFormBeginningDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.updateFormBeginningDateDateTimePicker.Location = new System.Drawing.Point(184, 101);
            this.updateFormBeginningDateDateTimePicker.Name = "updateFormBeginningDateDateTimePicker";
            this.updateFormBeginningDateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.updateFormBeginningDateDateTimePicker.TabIndex = 27;
            // 
            // updateFormLocationTextBox
            // 
            this.updateFormLocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateFormLocationTextBox.Location = new System.Drawing.Point(184, 61);
            this.updateFormLocationTextBox.Name = "updateFormLocationTextBox";
            this.updateFormLocationTextBox.Size = new System.Drawing.Size(200, 23);
            this.updateFormLocationTextBox.TabIndex = 26;
            // 
            // updateFormNameTextBox
            // 
            this.updateFormNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateFormNameTextBox.Location = new System.Drawing.Point(184, 21);
            this.updateFormNameTextBox.Name = "updateFormNameTextBox";
            this.updateFormNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.updateFormNameTextBox.TabIndex = 25;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndDate.Location = new System.Drawing.Point(18, 141);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(107, 17);
            this.labelEndDate.TabIndex = 24;
            this.labelEndDate.Text = "Event End Date";
            // 
            // labelBeginningDate
            // 
            this.labelBeginningDate.AutoSize = true;
            this.labelBeginningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBeginningDate.Location = new System.Drawing.Point(18, 101);
            this.labelBeginningDate.Name = "labelBeginningDate";
            this.labelBeginningDate.Size = new System.Drawing.Size(145, 17);
            this.labelBeginningDate.TabIndex = 23;
            this.labelBeginningDate.Text = "Event Beginning Date";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLocation.Location = new System.Drawing.Point(18, 61);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(102, 17);
            this.labelLocation.TabIndex = 22;
            this.labelLocation.Text = "Event Location";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(18, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 17);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "Event Name";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 310);
            this.Controls.Add(this.buttonUpdateEvent);
            this.Controls.Add(this.updateFormEndDateDateTimePicker);
            this.Controls.Add(this.updateFormBeginningDateDateTimePicker);
            this.Controls.Add(this.updateFormLocationTextBox);
            this.Controls.Add(this.updateFormNameTextBox);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelBeginningDate);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelName);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateEvent;
        private System.Windows.Forms.DateTimePicker updateFormEndDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker updateFormBeginningDateDateTimePicker;
        private System.Windows.Forms.TextBox updateFormLocationTextBox;
        private System.Windows.Forms.TextBox updateFormNameTextBox;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelBeginningDate;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelName;
    }
}