using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event.Forms
{
    public partial class AddForms : Form
    {
        public AddForms()
        {
            InitializeComponent();
        }
        private void AddForms_Load(object sender, EventArgs e)
        {
            buttonAddForm.Enabled = false;
        }

        private void buttonAllEventForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            this.Close();
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            string name = addFormNameTextBox.Text;
            string location = addFormLocationTextBox.Text;
            string beginningDate = addFormBeginningDateDateTimePicker.Text;
            string endDate = addFormEndDateDateTimePicker.Text;
            Controllers.EventController controller = new Controllers.EventController();
            controller.AddEvent(name, location, beginningDate, endDate);

        }
    }
}
