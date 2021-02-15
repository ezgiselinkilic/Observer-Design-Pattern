using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverDesignPattern
{
    public class CallPublisher : IReceiveCall
    {
        SqlConnection connection = new SqlConnection(@"server= . ; initial catalog= AlarmCall; integrated security=true; "); 
        public static List<IObserver> observers = new List<IObserver>();
        public void subscribe(IObserver observer)
        {
            observers.Add(observer);  
        }
        public void unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void notifychanges()
        {
            foreach(var observer in observers)
            { 
                observer.update(this);
            }
        }
        public void AddNewCall()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into Call (PatientAge,PatientState,Time) values (@p1,@p2,@p3)", connection);
            command.Parameters.AddWithValue("@p1",Form1.call.PatientAge);
            command.Parameters.AddWithValue("@p2", Form1.call.PatientState);
            command.Parameters.AddWithValue("@p3", Form1.call.Time);
            object sonuc = null;
            sonuc = command.ExecuteNonQuery();
            if (sonuc != null)
            {
                MessageBox.Show("Sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sisteme eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connection.Close();
        }
      
    }
}
