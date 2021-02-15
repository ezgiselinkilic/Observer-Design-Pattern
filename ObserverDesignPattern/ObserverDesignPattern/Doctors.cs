using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverDesignPattern
{
    public class Doctors : IObserver
    {
        public void notify(string message, Func<object, int> list1, Func<object, int> list2, Func<object, int> list3,List<String> doctors)
        {
            foreach (var item in doctors)
            {
                if (item == "Uzman Doktor Salih GÜVEN")
                    list1(message);
                if (item == "Uzman Doktor Halil DEDE")
                    list2(message);
                if (item == "Uzman Doktor Dilek ŞAHİN")
                    list3(message);
               
            }
        }

        public void update(CallPublisher callPublisher)
        {
        XtraMessageBox.Show("Hasta anons bilgisi başarılı ile iletildi", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
