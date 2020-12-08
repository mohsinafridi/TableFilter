using Newtonsoft.Json;
using PagedList;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace TableFilter
{
    class Program
    {
        public PagedList<DataRow> plist { get; set; }
        static void Main(string[] args)
        {

            //  DataTable1 tbl = new DataTable1();
            //  string result  = tbl.getData();
           
            string constr = "Server=localhost;Database=PracticeDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", con))
                {
                    // ContactPerson = cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    da.Fill(ds);
                    dt = ds.Tables[0];
                    if (dt.Rows.Count == 0)
                    {
                        
                    }
                    var report = dt.AsEnumerable().ToList();  // 200


                    var ree = new PagedList<DataRow>(report, 1, 5);
                    DataTable dtt = new DataTable();
                   
                   string JSONString = JsonConvert.SerializeObject(ree);
                    Console.WriteLine(JSONString);
                }
                con.Close();
            }





            string filterTable = "study_id:R5069-OA-1849;subject_id:ID02;activity:walk-f-10;mohsin:7788";
            //string filterTable = "study_id:R5069-OA-1849;";
            var splitPairs = filterTable.Split(';');
            
            //if (splitPairs.Length > 0)
            //{
            //    string query = "";
            //    for (int i = 0; i < splitPairs.Length; i++)
            //    {
            //        string key = splitPairs[i].Split(':')[0];
            //        string value = "";
            //        if (string.IsNullOrEmpty(key))
            //            continue;
            //        else
            //            value = splitPairs[i].Split(':')[1];

            //        if (i == 0)
            //            query += " WHERE " + key + "=" + "'" + value + "'" ;
            //        else
            //        {
            //            query += " AND " + key + "=" + "'" + value + "'";
            //        }


            //        //else if(i>0)
            //        //    query += " AND " + key + "=" + value;

            //        //if (i==splitPairs.Length - 1)
            //        //    query += " AND" + key + "=" + value;
            //    }

            //    Console.WriteLine(query);
            //}




            // SELECT * FROM  gd_pwd_dev.stg_moticon_gait_line_stats WHERE study_id=R5069-OA-1849 and subject_id=ID02 and activity=walk-f-10
            // var result = filter.TableFilter.Split(';');
            // 1st Option


            //    string filterTable = "study_id:R5069-OA-1849;subject_id:ID02;activity:walk-f-10";
            //    string study_id = filterTable.Split(';')[0].Split(':')[1];
            //    string subject_id = filterTable.Split(';')[1].Split(':')[1];
            //    string activity = filterTable.Split(';')[2].Split(':')[1];

            // string query1 = $"SELECT * FROM {filter.TableName } WHERE study_id={study_id} AND subject_id={subject_id} AND activity={activity}";

            // 2nd Option
            /*
            string filterTable = "study_id:R5069-OA-1849;subject_id:ID02;activity:walk-f-10";
		string study_id = filterTable.Split(';')[0].Split(':')[1];
		string subject_id = filterTable.Split(';')[1];
		string activity = filterTable.Split(';')[2];
            */





        }
    }
}
