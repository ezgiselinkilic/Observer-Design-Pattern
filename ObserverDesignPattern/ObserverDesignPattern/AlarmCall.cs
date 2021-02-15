using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class AlarmCall
    {
        [Key]
        public int CallId { get; set; }
        public int PatientAge { get; set; }
        public string PatientState { get; set; }
        public string Time { get; set; }
        public static List<AlarmCall> calls = new List<AlarmCall>();
        public List<AlarmCall> GetAll2()
        { 
            SqlConnection connection = new SqlConnection(@"server =. ; initial catalog = AlarmCall; integrated security = true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Call", connection);
            SqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
            {
                AlarmCall call = new AlarmCall();
                call.CallId = Convert.ToInt32(dr[0]);
                call.PatientAge = Convert.ToInt32(dr[1]);
                call.PatientState = dr[2].ToString();
                call.Time = dr[3].ToString();
                calls.Add(call);
            }
            connection.Close();
            return calls;
        }
    }
}
