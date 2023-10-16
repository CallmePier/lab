using QuanLy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DAO
{
    public class tableDAO
    {
        private static tableDAO instance;
        public static tableDAO Instance
        {
            get { if (instance == null) instance = new tableDAO(); return tableDAO.instance;}
            private set {tableDAO.instance = value; }
        }
        public void switchTable(int id1, int id2)
        {
            DataProvider.Instance.ExcuteQuery("USP_SwitchTable1 @idTable1 , @idTable2", new object[] { id1, id2 });
        }
        private tableDAO()
        {

        }
        public DataTable loadtableCombobox()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetTableList");
            return data;
        }
        public List<table> loadtableList()
        {
            List<table> tablelist = new List<table>();

            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetTableList");

            foreach(DataRow item in data.Rows)
            {
                table Table = new table(item);
                tablelist.Add(Table);

            }
            return tablelist;
        }
        public static int TableWith = 70;
        public static int tableHeigh = 70;
        
        public List<table> GetListTable()
        {
            List<table> listTable = new List<table>();
            string query = "select *from tableFood";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                listTable.Add(new table(row));
            }
            return listTable;
        }
        public List<table> GetListTabletoShow()
        {
            List<table> listTable = new List<table>();
            string query = "select *from tableFood";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                listTable.Add(new table(row));
            }
            return listTable;
        }

    }
}
