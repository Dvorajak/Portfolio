namespace WinFormMojeTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            System.IO.Directory.CreateDirectory("log");

            InitializeComponent();

            //Metoda na oboven� informa�n�ho listu
            RefeshViewList();
            //Metoda na na�ten� informac� o datu apd.
            StartApp();




            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += timer_Tick; //timer.Tick += new EventHandler(timer_Tick);
            timer.Start();


        }
        public void StartApp()
        {

            var mujCas = Convert.ToInt32(DateTimeOffset.UtcNow.Hour) + 2;
            timeLabel.Text = mujCas + $"{DateTimeOffset.UtcNow::mm:sss}";

            DateLabel.Text = $"{DateTimeOffset.UtcNow: d.M.yyyy}";
            //DenLabel.Text = DateTimeOffset.UtcNow.DayOfWeek.ToString();


            switch (DateTimeOffset.UtcNow.DayOfWeek.ToString())
            {
                case "Monday":
                    DenLabel.Text = "Pond�l�";
                    break;

                case "Tuesday":
                    DenLabel.Text = "�ter�";
                    break;

                case "Wednesday":
                    DenLabel.Text = "St�eda";
                    break;

                case "Thursday":
                    DenLabel.Text = "�tvrtek";
                    break;

                case "Friday":
                    DenLabel.Text = "P�tek";
                    break;

                case "Saturday":
                    DenLabel.Text = "Sobota";
                    break;

                case "Sunday":
                    DenLabel.Text = "Ned�le";
                    break;

            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var mujCas = Convert.ToInt32(DateTimeOffset.UtcNow.Hour) + 2;
            timeLabel.Text = mujCas + $"{DateTimeOffset.UtcNow::mm:sss}";

        }


        public static void RefreshOdJinud()
        {
            var form = new Form1();

            form.RefeshViewList();

        }


        /// <summary>
        /// Vyhled�n� v listu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void SearchLupa_Click(object sender, EventArgs e)
        {
            var hledanyText = HledejText.Text;
            var prvniHledani = true;
            int pocetZaznamu = Directory.GetFiles("log/", "*", SearchOption.AllDirectories).Length;


            for (int i = 0; i < pocetZaznamu; i++)
            {
                if (File.Exists("log/" + i))
                {

                    var prectiObsah = File.ReadAllText("log/" + i);

                    if (prectiObsah.Contains(hledanyText))
                    {
                        if (prvniHledani)
                        {
                            while (DataGridMoje.Rows.Count > 0)
                            {
                                //Vyma�e nult� ��dek
                                DataGridMoje.Rows.Remove(DataGridMoje.Rows[0]);
                                prvniHledani = false;
                            }
                        }


                        string[] lines = prectiObsah.Split(Environment.NewLine);

                        DataGridMoje.Rows.Add(lines);

                    }

                }
            }



        }

        /// <summary>
        /// Po stisknut� tla��tka vytvo�it nov� z�znam
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateEntry_Click(object sender, EventArgs e)
        {
            //Metoda na vytvo�en� z�znamu
            VytvorNovyZaznam();

        }





        /// <summary>
        /// Po stisknut� tla��tka na obnovu listu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RefreshButton_Click(object sender, EventArgs e)
        {
            //Metoda na obnovu listu
            RefeshViewList();
        }






        //Vytvo�en� nov�ho z�znamu
        public void VytvorNovyZaznam()
        {
            //Vytvo�� prom�nou do kter� se na�te t��da s vytv��ec�m oknem
            AddRecordWindow pridatZaznam = new AddRecordWindow();

            //prom�n� bool kter� zjist� zda nen� okno na vytvo�en� ji� otev�eno
            var Addforms = Application.OpenForms["AddRecordWindow"];

            //Jestli�e nen�
            if (Addforms == null)
            {
                //Otev�e okno na vytvo�en� z�znamu
                pridatZaznam.Show();
                pridatZaznam.BringToFront();
            }
            //Jinak vyp�e chybov� hl�en�
            else
            {
                MessageBox.Show("Okno P�idat z�znam je ji� otev�eno");
            }



        }

        /// <summary>
        /// Obnoven� listu se z�znamy
        /// </summary>
        public void RefeshViewList()
        {
            //z�kladn� hodnota z�znam�

            int pocetZaznamu = Directory.GetFiles("log/", "*", SearchOption.AllDirectories).Length;

            //Vyma�e
            //DataGridMoje.DataSource = null;

            //Vyma�e aktu�ln� ��dky (kv�li duplikaci)
            //Jestli�e je po�et ��dk� v�t�� ne� 0
            while (DataGridMoje.Rows.Count > 0)
            {
                //Vyma�e nult� ��dek
                this.DataGridMoje.Rows.Remove(DataGridMoje.Rows[0]);
            }

            var zaznamy = 0;
            for (int i = 0; zaznamy < pocetZaznamu; i++)
            {
                if (File.Exists("log/" + i))
                {

                    var prectiObsah = File.ReadAllText("log/" + i);

                    string[] lines = prectiObsah.Split(Environment.NewLine);

                    DataGridMoje.Rows.Add(lines);

                    zaznamy++;


                }
            }

            DataGridMoje.Refresh();


        }


        /// <summary>
        /// Po kliknut� na tla��to vymazat nebo upravit v list�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridMoje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var getCollumnIndex = e.ColumnIndex;
            var getRowIndex = e.RowIndex;


            if (getCollumnIndex == -1 || getRowIndex == -1)
            {
                return;
            }



            var cisloZaznamu = DataGridMoje.Rows[getRowIndex].Cells[0].Value;
            var cisloZaznamuvInt = Convert.ToInt32(cisloZaznamu);


            if (getCollumnIndex == 5)
            {
                DialogResult dialogResult = MessageBox.Show("Opravdu chcete smazat tento z�znam?", "Delete", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    File.Delete("log/" + cisloZaznamu);
                    RefeshViewList();
                }


                return;
            }

            if (getCollumnIndex == 4)
            {
                EditWindow editWindow = new EditWindow();

                var EditForms = Application.OpenForms["EditWindow"];

                //Jestli�e nen�
                if (EditForms == null)
                {
                    //Otev�e okno na vytvo�en� z�znamu
                    editWindow.NactiTextZeSouboru(cisloZaznamuvInt);

                    editWindow.Show();
                    editWindow.BringToFront();
                }
                else
                {
                    MessageBox.Show("Okno editovat z�znam je ji� otev�em");
                    editWindow.BringToFront();
                }



            }
        }




    }
}
