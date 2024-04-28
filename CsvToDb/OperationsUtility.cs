using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CsvToDb
{
    class OperationsUtility
    {
        public static DataTable createDataTable()
        {
            DataTable table = new DataTable();
            //columns
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Vardas", typeof(string));
            table.Columns.Add("Pavarde", typeof(string));
            table.Columns.Add("Email", typeof(string));

            //data
            table.Rows.Add(111, "Devesh", "Ghaziabad", "indo@info.lt");
            table.Rows.Add(222, "ROLI", "KANPUR", "info@info.lt");
            table.Rows.Add(102, "ROLI", "MAINPURI", "info@info.lt");
            table.Rows.Add(212, "DEVESH", "KANPUR", "info@info.lt");
            table.Rows.Add(102, "NIKHIL", "GZB", "info@info.lt");
            table.Rows.Add(212, "HIMANSHU", "NOIDa", "info@info.lt@info.lt");
            table.Rows.Add(102, "AVINASH", "NOIDa", "info@info.lt");
            table.Rows.Add(212, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(213, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(214, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(215, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(216, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(111, "Devesh", "Ghaziabad", "indo@info.lt");
            table.Rows.Add(222, "ROLI", "KANPUR", "info@info.lt");
            table.Rows.Add(102, "ROLI", "MAINPURI", "info@info.lt");
            table.Rows.Add(212, "DEVESH", "KANPUR", "info@info.lt");
            table.Rows.Add(102, "NIKHIL", "GZB", "info@info.lt");
            table.Rows.Add(212, "HIMANSHU", "NOIDa", "info@info.lt@info.lt");
            table.Rows.Add(102, "AVINASH", "NOIDa", "info@info.lt");
            table.Rows.Add(212, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(213, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(214, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(215, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(216, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(111, "Devesh", "Ghaziabad", "indo@info.lt");
            table.Rows.Add(222, "ROLI", "KANPUR", "info@info.lt");
            table.Rows.Add(102, "ROLI", "MAINPURI", "info@info.lt");
            table.Rows.Add(212, "DEVESH", "KANPUR", "info@info.lt");
            table.Rows.Add(102, "NIKHIL", "GZB", "info@info.lt");
            table.Rows.Add(212, "HIMANSHU", "NOIDa", "info@info.lt@info.lt");
            table.Rows.Add(102, "AVINASH", "NOIDa", "info@info.lt");
            table.Rows.Add(212, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(213, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(214, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(215, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(216, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(111, "Devesh", "Ghaziabad", "indo@info.lt");
            table.Rows.Add(222, "ROLI", "KANPUR", "info@info.lt");
            table.Rows.Add(102, "ROLI", "MAINPURI", "info@info.lt");
            table.Rows.Add(212, "DEVESH", "KANPUR", "info@info.lt");
            table.Rows.Add(102, "NIKHIL", "GZB", "info@info.lt");
            table.Rows.Add(212, "HIMANSHU", "NOIDa", "info@info.lt@info.lt");
            table.Rows.Add(102, "AVINASH", "NOIDa", "info@info.lt");
            table.Rows.Add(212, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(213, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(214, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(215, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(216, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(111, "Devesh", "Ghaziabad", "indo@info.lt");
            table.Rows.Add(222, "ROLI", "KANPUR", "info@info.lt");
            table.Rows.Add(102, "ROLI", "MAINPURI", "info@info.lt");
            table.Rows.Add(212, "DEVESH", "KANPUR", "info@info.lt");
            table.Rows.Add(102, "NIKHIL", "GZB", "info@info.lt");
            table.Rows.Add(212, "HIMANSHU", "NOIDa", "info@info.lt@info.lt");
            table.Rows.Add(102, "AVINASH", "NOIDa", "info@info.lt");
            table.Rows.Add(212, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(213, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(214, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(215, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(216, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(111, "Devesh", "Ghaziabad", "indo@info.lt");
            table.Rows.Add(222, "ROLI", "KANPUR", "info@info.lt");
            table.Rows.Add(102, "ROLI", "MAINPURI", "info@info.lt");
            table.Rows.Add(212, "DEVESH", "KANPUR", "info@info.lt");
            table.Rows.Add(102, "NIKHIL", "GZB", "info@info.lt");
            table.Rows.Add(212, "HIMANSHU", "NOIDa", "info@info.lt@info.lt");
            table.Rows.Add(102, "AVINASH", "NOIDa", "info@info.lt");
            table.Rows.Add(212, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(213, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(214, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(215, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(216, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(111, "Devesh", "Ghaziabad", "indo@info.lt");
            table.Rows.Add(222, "ROLI", "KANPUR", "info@info.lt");
            table.Rows.Add(102, "ROLI", "MAINPURI", "info@info.lt");
            table.Rows.Add(212, "DEVESH", "KANPUR", "info@info.lt");
            table.Rows.Add(102, "NIKHIL", "GZB", "info@info.lt");
            table.Rows.Add(212, "HIMANSHU", "NOIDa", "info@info.lt@info.lt");
            table.Rows.Add(102, "AVINASH", "NOIDa", "info@info.lt");
            table.Rows.Add(212, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(213, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(214, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(215, "BHUPPI", "GZB", "info@info.lt");
            table.Rows.Add(216, "BHUPPI", "GZB", "info@info.lt");

            return table;
        }
    }
}
