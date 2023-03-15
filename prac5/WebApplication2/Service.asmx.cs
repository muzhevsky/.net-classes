using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {
        const string ConnectionString = "";

        [WebMethod]
        public DataSet GetCustomers()
        {
            var ds = new DataSet();
            using (var connection = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from customer", connection);
                dataAdapter.Fill(ds, "customer");
            }

            return ds;
        }
    }
}
