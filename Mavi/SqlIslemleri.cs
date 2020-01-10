using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mavi
{
    public abstract class SqlIslemleri
    {
        protected SqlConnection con = new SqlConnection("Data Source=FATIH-HP\\SQLEXPRESS;Initial Catalog=Proje;Integrated Security=True");
        
    }
}
