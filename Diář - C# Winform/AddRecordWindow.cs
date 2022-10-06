using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormMojeTest
{
    public partial class AddRecordWindow : Form
    {

        public AddRecordWindow()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            var nazevUdalostivlozeno = NameOfRecord.Text;
            var datumUdalostivlozeno = DateOfRecord.Text;
            var popisUdalostivlozeno = RecordDescription.Text;
            var pridano = false;

            var mojeForm = new Form1();

            var chyba = false;


            if (!DateTimeOffset.TryParse(datumUdalostivlozeno, out var datumUdalosti))
            {
                MessageBox.Show("Zadejte prosím platné datum");
                chyba = true;
            }
            else if (DateTimeOffset.UtcNow > datumUdalosti)
            {
                MessageBox.Show("Nelze zapisovat události v minulosti");
                chyba = true;
            }

            if (nazevUdalostivlozeno == null || nazevUdalostivlozeno == "")
            {
                MessageBox.Show("Název události je prázdný");
                chyba = true;
            }

            var upraveneDatum = datumUdalosti.Day + "." + datumUdalosti.Month + "." + datumUdalosti.Year;

            if (!chyba)
            {
                var i = 1;
                while (!pridano)
                {
                    if (!File.Exists("log/" + i))
                    {

                        var newLine = Environment.NewLine;

                        File.WriteAllText("log/" + i, i + newLine + upraveneDatum + newLine + nazevUdalostivlozeno + newLine + popisUdalostivlozeno);
                        mojeForm.RefeshViewList();
                        pridano = true;
                        this.Close();
                        break;
                    }
                    i++;
                }
            }
            chyba = false;


        }


        private void StornoButton_Click(object sender, EventArgs e)
        {
            var mojeForm = new Form1();
            this.Close();

        }
    }
}
