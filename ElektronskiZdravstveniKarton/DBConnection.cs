using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client; // ODP.NET Oracle managed provider
using Oracle.DataAccess.Types;

namespace ElektronskiZdravstveniKarton
{
    public class DBConnection
    {

        public enum Spiskovi { Lekovi = 1, Dijagnoze, Ustanove, Pacijenti, Lekari };

        public static bool spec = false;
        public static bool analiza = false;
        public static string idzu = "GCKUJKWB";
        public static double dozvoljeno = 1000;

        static public string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file. 
            return "Data Source=(DESCRIPTION=" + "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))" + "(CONNECT_DATA=(SERVICE_NAME=XE)));"
                    + "User Id=E13080;Password=ftn;";
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);
        static public string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }


    }
}
