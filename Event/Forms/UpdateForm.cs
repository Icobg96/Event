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
    public partial class UpdateForm : Form
    {
        int id;
        string name;
        string location;
        string beginningDate;
        string endDate;
        public UpdateForm(int id, string name, string location, string beginningDate, string endDate)
        {
            this.id = id;
            this.name = name;
            this.location = location;
            this.beginningDate = beginningDate;
            this.endDate = endDate;
            InitializeComponent();
        }
        private void UpdateForm_Load(object sender, EventArgs e)
        {
            updateFormNameTextBox.Text = name;
            updateFormLocationTextBox.Text = location;
            updateFormBeginningDateDateTimePicker.Text = beginningDate;
            updateFormEndDateDateTimePicker.Text = endDate;

        }
        private void buttonUpdateEvent_Click(object sender, EventArgs e)
        {
            Controllers.EventController controller = new Controllers.EventController();
           string name = updateFormNameTextBox.Text;
            string location = updateFormLocationTextBox.Text;
            string beginningDate = updateFormBeginningDateDateTimePicker.Text;
            string endDate = updateFormEndDateDateTimePicker.Text;
            controller.UpdateEvent(id, name, location, beginningDate, endDate);
            this.Hide();
            this.Close();

        }

       
    }
}
