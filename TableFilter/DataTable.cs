using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TableFilter
{
   public class DataTable1
    {

        public string getData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("UserId", typeof(Int32));
            dt.Columns.Add("UserName", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Age", typeof(string));
            dt.Columns.Add("Phone", typeof(string));
            dt.Columns.Add("Education", typeof(string));
            dt.Columns.Add("Location", typeof(string));
            dt.Columns.Add("A", typeof(string));
            dt.Columns.Add("B", typeof(string));
            dt.Columns.Add("C", typeof(string));
            dt.Columns.Add("D", typeof(string));
            dt.Columns.Add("E", typeof(string));
            dt.Columns.Add("Ffffff", typeof(string));
            dt.Columns.Add("ggggggg", typeof(string));
            dt.Columns.Add("hhhh", typeof(string));
            dt.Columns.Add("iiii", typeof(string));
            dt.Columns.Add("jjj", typeof(string));



            dt.Rows.Add(1, "Satinder as","test@gmail.com","20","23123123123", "Bsc Com Sci", "Mumbai","1","2","3","4","5","6","7","8","9","10");
            dt.Rows.Add(2, "Amit asdas", "test@gmail.com", "20", "23123123123", "Mstr Com Sci", "Mumbai", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(3, "Andrea Ely", "test@gmail.com", "20", "23123123123", "Bsc Bio-Chemistry", "Queensland", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(4, "Leslie Mac", "test@gmail.com", "20", "23123123123", "MSC", "Town-ville", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(5, "Vaibhav ", "test@gmail.com", "20", "23123123123", "MBA", "New Delhi", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(6, "Vaibhav ", "test@gmail.com", "20", "23123123123", "MBA", "New Delhi", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(7, "Vaibhav ", "test@gmail.com", "20", "23123123123", "MBA", "New Delhi", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(8, "Vaibhav ", "test8@gmail.com", "20", "23123123123", "MBA", "New Delhi", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(9, "Vaibhav ", "test9@gmail.com", "20", "23123123123", "MBA", "New Delhi", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(10, "Vaibhav ", "test@gmail.com", "20", "23123123123", "MBA", "New Delhi", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(11, "Vaibhav ", "test@gmail.com", "20", "23123123123", "MBA", "New Delhi", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(12, "Vaibhav ", "test@gmail.com", "20", "23123123123", "MBA", "New Delhi", "5", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(13, "Vaibhav ", "test@gmail.com", "20", "23123123123", "MBA", "New Delhi", "5", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(14, "Vaibhav ", "test@gmail.com", "20", "23123123123", "MBA", "New Delhi", "5", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(15, "Vaibhav ", "test@gmail.com", "20", "23123123123", "MBA", "New Delhi", "5", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(16, "Vaibhav ", "test@gmail.com", "20", "23123123123", "MBA", "New Delhi", "5", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(17, "Vaibhav ", "test@gmail.com", "20", "23123123123", "MBA", "New Delhi", "5", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(18, "Vaibhav ", "test@gmail.com", "20", "23123123123", "MBA", "New Delhi", "5", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            dt.Rows.Add(19, "Vaibhav ", "test@gmail.com", "20", "23123123123", "MBA", "New Delhi", "5", "2", "3", "4", "5", "6", "7", "8", "9", "10");


            var json = dt.ToJson();

            string JSONString = JsonConvert.SerializeObject(dt);
            return JSONString;


        }

        
    }
}
