using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMojeTest
{
    public partial class EditWindow : Form
    {
        CislaZaznamu zaznamCisla = new CislaZaznamu();

        public int poslaneCislo { get; set; }

        public EditWindow()
        {
            InitializeComponent();

        }

        public void NactiTextZeSouboru(int PosliCislo)
        {

            poslaneCislo = PosliCislo;

            var textSouboru = File.ReadAllText("log/" + PosliCislo);

            string[] radkysouboru = textSouboru.Split(Environment.NewLine);

            EditDatumText.Text = radkysouboru[1];
            EditNazevText.Text = radkysouboru[2];
            EditPopisText.Text = radkysouboru[3];


        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var newLine = Environment.NewLine;
            File.WriteAllText("log/" + poslaneCislo, poslaneCislo + newLine + EditDatumText.Text + newLine + EditNazevText.Text + newLine + EditPopisText.Text);
            Form1.RefreshOdJinud();
            this.Close();

        }

        private void EditStrnoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
