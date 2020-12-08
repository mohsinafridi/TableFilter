using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;

namespace TableFilter
{
    public static class StringExtentions
    {
        /// <summary>
        /// Converts a data table to json.
        /// </summary>
        /// <returns>The json string equivalent of the data table.</returns>
        /// <param name="dataTable">The Data Table to be converted.</param>
        public static string ToJson(this DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                // build out object dictionary
                var outArray = new List<Dictionary<string, string>>[dataTable.Rows.Count];
                var outRow = new List<Dictionary<string, string>>();

                var entry = new Dictionary<string, string>();

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    outRow = new List<Dictionary<string, string>>();
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        // setup the entry
                        entry = new Dictionary<string, string>();

                        //
                        entry.Add(dataTable.Columns[j].ToString(), dataTable.Rows[i].ItemArray[j].ToString());

                        // add the entry
                        outRow.Add(entry);

                    }
                    outArray[i] = outRow;
                }

                // serialize
                string json = JsonConvert.SerializeObject(outArray, Formatting.None);

                // deal with any formatting issues
                json = json.Replace("},{", ",");
                json = json.Replace("],[", ",");
                json = json.Replace("[[", "[");
                json = json.Replace("]]", "]");


                return json;
            }
            else
            {
                return null;
            }
        }
    }
}
