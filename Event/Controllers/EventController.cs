
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event.Controllers
{
    class EventController
    {
        public List<Entity.Event> MyGridView()
        { 
            Repository.EventRepository repository = new Repository.EventRepository();

            List<Entity.Event> data = repository.GetAllEvent();

            //data.Columns.Add("id", "id");
            //data.Columns.Add("Name", "Name");
            //data.Columns.Add("Location", "Location");
            //data.Columns.Add("Bdate", "Bdate");
            //data.Columns.Add("EDate", "EDate");




        
            return data;
        }
        public void AddEvent(string name, string location, string beginningDate, string endDate)
        {
            Repository.EventRepository repository = new Repository.EventRepository();
            Entity.Event myEvent = new Entity.Event();
            myEvent.name = name;
            myEvent.location = location;
            myEvent.beginningDate = beginningDate;
            myEvent.endDate = endDate;
            repository.Insert(myEvent);
        }

        public void DeleteEvent(int id)
        {
            Repository.EventRepository repository = new Repository.EventRepository();
            repository.Delete(id);


        }
        public void UpdateEvent(int id,string name,string location,string beginningDate,string endDate)
        {
            
            Repository.EventRepository repository = new Repository.EventRepository();
            Entity.Event myEvent = new Entity.Event
            {
                id = id,
                name = name,
                location = location,
                beginningDate = beginningDate,
                endDate = endDate
            };
            repository.Update(myEvent);

        }
    }
}
