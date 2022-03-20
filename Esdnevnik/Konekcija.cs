using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Esdnevnik
{
    internal class Konekcija
    {
        static public SqlConnection connect() 
        {
            string cs;
            cs = "Data source = DESKTOP-UBL32UH; Initial catalog = ednevnik; Integrated security = true";
            SqlConnection veza = new SqlConnection(cs);
            return veza;
        }
    }
}
