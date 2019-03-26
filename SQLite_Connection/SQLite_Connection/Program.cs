using System;
using System.Data.SQLite;

namespace SQLite_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a first attempt of creating a Sqlite Database in C#"
            Console.WriteLine("This is a first attempt of creating a Sqlite Database in C#");
            SQLiteConnection my_Connect;
            my_Connect = CreateConection();
            DropTables(my_Connect);
            CreateTable(my_Connect);
            InsertData(my_Connect);
            ReadData(my_Connect);

        }

        private static void DropTables(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            string Createsql = "Drop table if exists DreamCars";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            string Createsql1 = "drop table if exists CurrentCars";
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();
            Console.WriteLine("Dropping Tables...");
        }

        static SQLiteConnection CreateConection()
        {
            SQLiteConnection my_Connect;

            my_Connect = new
                SQLiteConnection("Data Source = databaseTester.sqlite3; New = true; Compress = True;"); //This opens connection.
            try
            {
                my_Connect.Open();
                Console.WriteLine("SQLite Connection Created...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return my_Connect;
        }

        static void CreateTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE DreamCars (MAKE VARCHAR(40), MODEL VARCHAR(40), NUMBER INT)";
            string Createsql1 = "CREATE TABLE CurrentCars (MAKE VARCHAR(40), MODEL VARCHAR(40), NUMBER INT)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();
            Console.WriteLine("Creating tables...");
        }

        static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO DreamCars (MAKE, MODEL, NUMBER) VALUES('Porsche', '911 Carrea', 1); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO DreamCars (MAKE, MODEL, NUMBER) VALUES('BMW', 'M6', 2); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO DreamCars (MAKE, MODEL, NUMBER) VALUES('Bently', 'Fly Spur', 3); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO CurrentCars (MAKE, MODEL, NUMBER) VALUES('BMW', '325XI', 1); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO CurrentCars (MAKE, MODEL, NUMBER) VALUES('MINI', 'R53', 2); ";
            sqlite_cmd.ExecuteNonQuery();
            Console.WriteLine("Insert queries successfully executed...");
        }

        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM DreamCars UNION SELECT * FROM CurrentCars";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                string myreader2 = sqlite_datareader.GetString(1);
                Console.WriteLine(myreader + myreader2);
            }
            conn.Close();
        }

    }
}