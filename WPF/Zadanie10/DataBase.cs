using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Zadanie10
{
    internal class DataBase
    {
        private static string dbContext = "server=localhost;user=root;password='';database=szkola";
        public static MySqlConnection conn = new(dbContext);
    }
}
