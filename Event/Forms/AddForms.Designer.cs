namespace Event.Forms
{
    partial class AddForms
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
            this.buttonAddForm = new System.Windows.Forms.Button();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.addFormEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addFormBeginningDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addFormLocationTextBox = new System.Windows.Forms.TextBox();
            this.addFormNameTextBox = new System.Windows.Forms.TextBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelBeginningDate = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonAllEventForm = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddForm
            // 
            this.buttonAddForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddForm.Location = new System.Drawing.Point(3, 0);
            this.buttonAddForm.Name = "buttonAddForm";
            this.buttonAddForm.Size = new System.Drawing.Size(75, 23);
            this.buttonAddForm.TabIndex = 2;
            this.buttonAddForm.Text = "Add";
            this.buttonAddForm.UseVisualStyleBackColor = true;
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddEvent.Location = new System.Drawing.Point(131, 208);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(140, 23);
            this.buttonAddEvent.TabIndex = 20;
            this.buttonAddEvent.Text = "Add Event";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // addFormEndDateDateTimePicker
            // 
            this.addFormEndDateDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            this.addFormEndDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFormEndDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.addFormEndDateDateTimePicker.Location = new System.Drawing.Point(178, 164);
            this.addFormEndDateDateTimePicker.Name = "addFormEndDateDateTimePicker";
            this.addFormEndDateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.addFormEndDateDateTimePicker.TabIndex = 19;
            // 
            // addFormBeginningDateDateTimePicker
            // 
            this.addFormBeginningDateDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            this.addFormBeginningDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFormBeginningDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.addFormBeginningDateDateTimePicker.Location = new System.Drawing.Point(178, 128);
            this.addFormBeginningDateDateTimePicker.Name = "addFormBeginningDateDateTimePicker";
            this.addFormBeginningDateDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.addFormBeginningDateDateTimePicker.TabIndex = 18;
            // 
            // addFormLocationTextBox
            // 
            this.addFormLocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFormLocationTextBox.Location = new System.Drawing.Point(178, 88);
            this.addFormLocationTextBox.Name = "addFormLocationTextBox";
            this.addFormLocationTextBox.Size = new System.Drawing.Size(200, 23);
            this.addFormLocationTextBox.TabIndex = 17;
            // 
            // addFormNameTextBox
            // 
            this.addFormNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFormNameTextBox.Location = new System.Drawing.Point(178, 48);
            this.addFormNameTextBox.Name = "addFormNameTextBox";
            this.addFormNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.addFormNameTextBox.TabIndex = 16;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndDate.Location = new System.Drawing.Point(12, 168);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(107, 17);
            this.labelEndDate.TabIndex = 15;
            this.labelEndDate.Text = "Event End Date";
            // 
            // labelBeginningDate
            // 
            this.labelBeginningDate.AutoSize = true;
            this.labelBeginningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBeginningDate.Location = new System.Drawing.Point(12, 128);
            this.labelBeginningDate.Name = "labelBeginningDate";
            this.labelBeginningDate.Size = new System.Drawing.Size(145, 17);
            this.labelBeginningDate.TabIndex = 14;
            this.labelBeginningDate.Text = "Event Beginning Date";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLocation.Location = new System.Drawing.Point(12, 88);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(102, 17);
            this.labelLocation.TabIndex = 13;
            this.labelLocation.Text = "Event Location";
            // 
            // buttonAllEventForm
            // 
            this.buttonAllEventForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllEventForm.Location = new System.Drawing.Point(78, 0);
            this.buttonAllEventForm.Name = "buttonAllEventForm";
            this.buttonAllEventForm.Size = new System.Drawing.Size(95, 23);
            this.buttonAllEventForm.TabIndex = 12;
            this.buttonAllEventForm.Text = "All Events";
            this.buttonAllEventForm.UseMnemonic = false;
            this.buttonAllEventForm.UseVisualStyleBackColor = true;
            this.buttonAllEventForm.Click += new System.EventHandler(this.buttonAllEventForm_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 17);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Event Name";
            // 
            // AddForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 343);
            this.Controls.Add(this.buttonAddEvent);
            this.Controls.Add(this.addFormEndDateDateTimePicker);
            this.Controls.Add(this.addFormBeginningDateDateTimePicker);
            this.Controls.Add(this.addFormLocationTextBox);
            this.Controls.Add(this.addFormNameTextBox);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelBeginningDate);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.buttonAllEventForm);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonAddForm);
            this.Name = "AddForms";
            this.Text = "AddForms";
            this.Load += new System.EventHandler(this.AddForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddForm;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.DateTimePicker addFormEndDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker addFormBeginningDateDateTimePicker;
        private System.Windows.Forms.TextBox addFormLocationTextBox;
        private System.Windows.Forms.TextBox addFormNameTextBox;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelBeginningDate;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonAllEventForm;
        private System.Windows.Forms.Label labelName;
    }
}