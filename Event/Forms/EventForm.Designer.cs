namespace Event.Forms
{
    partial class EventForm
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
            this.buttonAllEvents = new System.Windows.Forms.Button();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventBeginningDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventEndDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eventFormButton = new System.Windows.Forms.Button();
            this.goToAddFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAllEvents
            // 
            this.buttonAllEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAllEvents.Location = new System.Drawing.Point(-114, -21);
            this.buttonAllEvents.Name = "buttonAllEvents";
            this.buttonAllEvents.Size = new System.Drawing.Size(92, 23);
            this.buttonAllEvents.TabIndex = 5;
            this.buttonAllEvents.Text = "All Events";
            this.buttonAllEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonAllEvents.UseVisualStyleBackColor = true;
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddEvent.Location = new System.Drawing.Point(-191, -21);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEvent.TabIndex = 4;
            this.buttonAddEvent.Text = "Add";
            this.buttonAddEvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.eventNameColumn,
            this.eventLocationColumn,
            this.eventBeginningDateColumn,
            this.eventEndDateColumn,
            this.updateButtonColumn,
            this.deleteButtonColumn});
            this.resultDataGridView.Location = new System.Drawing.Point(4, 32);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.Size = new System.Drawing.Size(646, 257);
            this.resultDataGridView.TabIndex = 3;
            this.resultDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultDataGridView_CellContentClick);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // eventNameColumn
            // 
            this.eventNameColumn.HeaderText = "Name";
            this.eventNameColumn.Name = "eventNameColumn";
            this.eventNameColumn.ReadOnly = true;
            // 
            // eventLocationColumn
            // 
            this.eventLocationColumn.HeaderText = "Location";
            this.eventLocationColumn.Name = "eventLocationColumn";
            this.eventLocationColumn.ReadOnly = true;
            // 
            // eventBeginningDateColumn
            // 
            this.eventBeginningDateColumn.HeaderText = "Beginning Date";
            this.eventBeginningDateColumn.Name = "eventBeginningDateColumn";
            this.eventBeginningDateColumn.ReadOnly = true;
            // 
            // eventEndDateColumn
            // 
            this.eventEndDateColumn.HeaderText = "End Date";
            this.eventEndDateColumn.Name = "eventEndDateColumn";
            this.eventEndDateColumn.ReadOnly = true;
            // 
            // updateButtonColumn
            // 
            this.updateButtonColumn.HeaderText = "Edit";
            this.updateButtonColumn.Name = "updateButtonColumn";
            this.updateButtonColumn.Text = "Edit";
            this.updateButtonColumn.ToolTipText = "Edit";
            this.updateButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // deleteButtonColumn
            // 
            this.deleteButtonColumn.HeaderText = "Delete";
            this.deleteButtonColumn.Name = "deleteButtonColumn";
            this.deleteButtonColumn.Text = "Delete";
            this.deleteButtonColumn.ToolTipText = "Delete";
            this.deleteButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // eventFormButton
            // 
            this.eventFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventFormButton.Location = new System.Drawing.Point(81, 3);
            this.eventFormButton.Name = "eventFormButton";
            this.eventFormButton.Size = new System.Drawing.Size(92, 23);
            this.eventFormButton.TabIndex = 7;
            this.eventFormButton.Text = "All Events";
            this.eventFormButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.eventFormButton.UseVisualStyleBackColor = true;
            // 
            // goToAddFormButton
            // 
            this.goToAddFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToAddFormButton.Location = new System.Drawing.Point(4, 3);
            this.goToAddFormButton.Name = "goToAddFormButton";
            this.goToAddFormButton.Size = new System.Drawing.Size(75, 23);
            this.goToAddFormButton.TabIndex = 6;
            this.goToAddFormButton.Text = "Add";
            this.goToAddFormButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.goToAddFormButton.UseVisualStyleBackColor = true;
            this.goToAddFormButton.Click += new System.EventHandler(this.goToAddFormButton_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 331);
            this.Controls.Add(this.eventFormButton);
            this.Controls.Add(this.goToAddFormButton);
            this.Controls.Add(this.buttonAllEvents);
            this.Controls.Add(this.buttonAddEvent);
            this.Controls.Add(this.resultDataGridView);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAllEvents;
        private System.Windows.Forms.Button buttonAddEvent;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.Button eventFormButton;
        private System.Windows.Forms.Button goToAddFormButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventLocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventBeginningDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventEndDateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn updateButtonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButtonColumn;
    }
}