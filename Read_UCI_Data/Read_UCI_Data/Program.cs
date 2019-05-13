using System;
using System.IO;
using System.Text;
using System.Data;


namespace Read_UCI_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wzup World!");

            string path = @"C:\Coding Practice\Practice\Read_UCI_Data\dow_jones_index\dow_jones_index.data";
           // string writePath = @"C:\Coding Practice\Practice\Read_UCI_Data\dow_jones_index\dow_jones_index2.txt";
            string[] readText = File.ReadAllLines(path);
            DataTable dowjones = new DataTable();
            dowjones = populateDJ(readText, dowjones);

           // dowjones.WriteXml(writePath, 0);
       
        }

        private static DataTable populateDJ(string[] readText, DataTable dowjones)
        {
            dowjones.Columns.Add("Quater", typeof(string)); 
            dowjones.Columns.Add("stock", typeof(string));
            dowjones.Columns.Add("date", typeof(DateTime));
            dowjones.Columns.Add("open", typeof(decimal));
            dowjones.Columns.Add("high", typeof(decimal));
            dowjones.Columns.Add("low", typeof(decimal));
            dowjones.Columns.Add("close", typeof(decimal));
            dowjones.Columns.Add("volume", typeof(decimal));
            dowjones.Columns.Add("percent_change_price", typeof(decimal));
            dowjones.Columns.Add("percent_change_volume_over_last_wk", typeof(decimal));
            dowjones.Columns.Add("previous_weeks_volume", typeof(decimal));
            dowjones.Columns.Add("next_weeks_open", typeof(decimal));
            dowjones.Columns.Add("next_weeks_close", typeof(decimal));
            dowjones.Columns.Add("percent_change_next_weeks_price", typeof(decimal));
            dowjones.Columns.Add("days_to_next_dividend", typeof(decimal));
            dowjones.Columns.Add("percent_return_next_dividend", typeof(decimal));

            for (int i = 0; i < readText.Length; i++)
            {
                Console.WriteLine(readText[i]);
                string text = readText[i];
                string[] textarray = text.Split(',');
                for (int j = 0; j < textarray.Length; j++)
                {
                    dowjones.Rows.Add(textarray[i]);
                }
            }
            return dowjones;
        }
    }
}
