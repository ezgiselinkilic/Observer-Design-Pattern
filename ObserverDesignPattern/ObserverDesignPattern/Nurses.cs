using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverDesignPattern
{
    public class Nurses : IObserver
    {
        public void notify(string message, Func<object, int> list1, Func<object, int> list2, Func<object, int> list3, List<String> nurses)
        {
            foreach (var item in nurses)
            {
                if (item == "Hemşire Alya KULELİ")
                    list1(message);
                if (item == "Hemşire Soner DURGUN")
                    list2(message);
                if (item == "Hemşire Gül KORKMAZ")
                    list3(message);
            }
        }
        public void update(CallPublisher publisher)
        {
         XtraMessageBox.Show("Hasta anons bilgisi başarılı ile iletildi", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
