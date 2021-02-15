using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverDesignPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"server=. ; initial catalog= AlarmCall; integrated security=true");
        IObserver observer = new Doctors();
        IObserver nobserver = new Nurses();
        CallPublisher publisher = new CallPublisher();
        public static AlarmCall call = new AlarmCall();
        public List<string> doctors = new List<string>();
        public List<string> nurses = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Call", connection);
            da.Fill(dt);
            anonsgrid.DataSource = dt;
            connection.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
        }
        private void btnDOKTOREKLE_Click_1(object sender, EventArgs e)
        {
            string doctor = cmbdoktorlar.SelectedItem.ToString();

            if (doctor != " " && doctor != null)
            {
                cmbdoktorlar.Text = " ";
                publisher.subscribe(observer);
                observerlist.Items.Add(doctor);
                MessageBox.Show("Kullanıcı sisteme eklendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                doctors.Add(doctor);
                cmbdoktorlar.Items.Remove(observer);
            }
        }
        private void btnDOKTORSİL_Click(object sender, EventArgs e)
        {
            string doctor = cmbdoktorlar.SelectedItem.ToString();
            if (doctor != " " && doctor != null)
            {
                publisher.unsubscribe(observer);
                observerlist.Items.Remove(doctor);
                MessageBox.Show("Kullanıcı sistemden silindi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                doctors.Remove(doctor);
                cmbdoktorlar.Items.Add(observer);
            }
        }

       
        private void btnHEMŞİREEKLE_Click(object sender, EventArgs e)
        {
            string nurse = cmbhemsireler.SelectedItem.ToString();
            if (nurse != " " && nurse != null)
            {
                cmbhemsireler.Text = " ";
                publisher.subscribe(nobserver);
                observerlist.Items.Add(nurse);
                MessageBox.Show("Kullanıcı sisteme eklendi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nurses.Add(nurse);
                cmbhemsireler.Items.Remove(nobserver);
            }
        }
        private void btnHEMŞİRESİL_Click(object sender, EventArgs e)
        {
            string nurse = cmbdoktorlar.SelectedItem.ToString();
            if (nurse!= " " && nurse != null)
            {
                publisher.unsubscribe(observer);
                observerlist.Items.Remove(nurse);
                MessageBox.Show("Kullanıcı sistemden silindi", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                doctors.Remove(nurse);
                cmbdoktorlar.Items.Add(nobserver);
            }
        }
        private void btnanonsekle_Click(object sender, EventArgs e)
        {

            call.PatientAge = Convert.ToInt32(txtyas.Text);
            call.PatientState = txtdurum.Text;
            call.Time = txtsüre.Text;
            publisher.AddNewCall();
            anonsgrid.DataSource = call.GetAll2();
        }

        private void btncagrıyolla_Click(object sender, EventArgs e)
        {
            Doctors dr = new Doctors();
            dr.notify(anons, listBox1.Items.Add, listBox2.Items.Add, listBox3.Items.Add,doctors);
            Nurses nurse = new Nurses();
            nurse.notify(anons, listBox4.Items.Add, listBox5.Items.Add, listBox6.Items.Add, nurses);
        }
       public static string anons;
        private void anonsgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = anonsgrid.SelectedCells[0].RowIndex;
            call.CallId = Convert.ToInt32(anonsgrid.Rows[secilen].Cells[0].Value);
            call.PatientAge = Convert.ToInt32(anonsgrid.Rows[secilen].Cells[1].Value);
            call.PatientState = anonsgrid.Rows[secilen].Cells[2].Value.ToString();
            call.Time = anonsgrid.Rows[secilen].Cells[3].Value.ToString();
            anons = call.PatientAge.ToString() +" yaşında "+ call.PatientState +" "+call.Time+"içerisinde hastaneye ulaşacaktır.";

        }

        
    }
}


