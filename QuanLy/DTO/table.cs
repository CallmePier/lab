using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
    public class table
    {
        private int ID;
        private string Name;
        private string status;

        public int ID1 
        {
            get { return ID; } set { ID = value; }
        }
        public string Name1 
        {
            get { return Name; } set { Name = value; }
        }
        public string Status {
            get { return status; } set { status = value; }
        }

        public table() { }

        public table(int id, string name, string status)
        {
            this.ID1 = id;
            this.Name1 = name;
            this.Status = status;
        }
        public table(DataRow row)
        {
            this.ID1 = (int)row["id"];
            this.Name1 = row["name"].ToString();
            this.Status = row["status"].ToString();
            
        }
    }
}
