using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac;

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    listBox1.Items.Add(i + "-Sukran");
            //}
            //------------------------------------------------------------------------------
            int i = 0;
            for (; i < 10; i++)
            {
                listBox1.Items.Add(i + "-Burak");
            }
            MessageBox.Show(i + "");
            // eğer int i = 0 diye döngü içinde tanımlansaydı, bu i nin değeri sadece döngü içinde kullanılabilirdi. bunu dışarıda tanımlayarak, for scope dışında da kullanımını sağladık.
            //---------------------------------------------------------------------------------
            //int i;
            //for (i = 2; i < 10; i++)
            //{
            //}
            //--------------------------------------------------------------------------------
            //int i = 2;
            //for (; i < 10; )
            //{
            // listBox1.Items.Add(i + "-Ahmet");
            // i++;
            //}
            // döngü değişkeninni değeri, for scope iinde değiştirilebilir.
            //---------------------------------------------------------------------------------
            //for (; ; )
            //{
            // listBox1.Items.Add("-Ahmet");
            // // Bu döngü SONSUZ DÖNGÜDÜR.
            //}
            //MessageBox.Show("Test");
            // NOT : Döngünün çalışması sona ermeden, döngüden sonraki komutlar ÇALIŞTIRILMAZ.
            //------------------------------------------------------------------------------------
            //for (int i = 0; i < 10; i += 1)
            //{
            //}
            //for (int i = 0; i < 10; i = i + 1)
            //{
            //}
            //for (int i = 0; i < 10; i += 5)
            //{
            //}
            //for (int i = 0; i < 10; i = (i + 5) * 2 - 4)
            //{
            //}
            //for (int i = 0; i > 2 && i < (i + 5) % 2; i++)
            //{
            //}
            //for (int i = 0, k = 5, z = 15; i < 10 && k != 5 || z >= 4; i++, k -= 2)
            //{
            //    MessageBox.Show("Test");
            //    z = i + k;
            //}
            //for (ulong i = 10; i < 10; i++)
            //{
            //}
            //for (int i = 10; i > 0; i--)
            //{
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
