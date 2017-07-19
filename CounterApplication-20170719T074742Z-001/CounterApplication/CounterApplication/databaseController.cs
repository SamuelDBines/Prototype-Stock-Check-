using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterApplication
{
    class databaseController
    {
        databaseModel database = new databaseModel();
        public databaseController()
        {
           
        }
        public void addItem(string data, string item, string update, string value)
        {
            database.addItem(data, item);
            database.updateitem(data, item, update, value);
        }
        public void updateBroken(string data, string item, string update, string value)
        {
            database.updateitem(data,item, update,value);
        }
    }
}
