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
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        private void AllElement()
        {
            Controllers.EventController controller = new Controllers.EventController();
            for (int i = 0; i < controller.MyGridView().Count; i++)
            {
                resultDataGridView.Rows.Add();
                resultDataGridView.Rows[i].Cells[0].Value = controller.MyGridView()[i].id;
                resultDataGridView.Rows[i].Cells[1].Value = controller.MyGridView()[i].name;
                resultDataGridView.Rows[i].Cells[2].Value = controller.MyGridView()[i].location;
                resultDataGridView.Rows[i].Cells[3].Value = controller.MyGridView()[i].beginningDate;
                resultDataGridView.Rows[i].Cells[4].Value = controller.MyGridView()[i].endDate;


            }
        }
        private bool ChekForColumnName(int rowIndex, int columnIndex, string columnName)
        {
            if (rowIndex > -1)
            {
                if (resultDataGridView.Rows[rowIndex].Cells[columnIndex].FormattedValue.Equals(columnName))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
        private void EventForm_Load(object sender, EventArgs e)
        {
            eventFormButton.Enabled = false;
            AllElement();
          
        
        }

       
        
        private void resultDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ChekForColumnName(e.RowIndex,e.ColumnIndex,"Edit")) // Edit Button
            {
                int id = (int)resultDataGridView.Rows[e.RowIndex].Cells[0].Value;
                string name=resultDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
               string location = resultDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
               string beginningDate = resultDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
               string endDate = resultDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                //this.Hide();
                UpdateForm updateForm = new UpdateForm(id,name,location,beginningDate,endDate);
                updateForm.ShowDialog();
                //this.Close();
               
                resultDataGridView.Rows.Clear();
                AllElement();


            }
            else if(ChekForColumnName(e.RowIndex, e.ColumnIndex, "Delete")) //Delete Button
            {
                Controllers.EventController controller = new Controllers.EventController();
                int id = (int)resultDataGridView.Rows[e.RowIndex].Cells[0].Value;
                controller.DeleteEvent(id);
                resultDataGridView.Rows.Clear();
                AllElement();
            }
        }

        private void goToAddFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForms addForm = new AddForms();
            addForm.ShowDialog();
            this.Close();
        }
    }
}
