using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProgessly.Helpers
{
    public class ConnectionStringDb
    {
        public static string GetsConnectionString()
        {
            return "Server=EMAA;Database=ProgesslyDb;User ID=ProgesslyApp;Password=progessly123;TrustServerCertificate=True;MultipleActiveResultSets=true";
        } 
    }
}
