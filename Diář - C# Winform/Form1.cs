namespace WinFormMojeTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            System.IO.Directory.CreateDirectory("log");

            InitializeComponent();

            //Metoda na obovení informaèního listu
            RefeshViewList();
            //Metoda na naètení informací o datu apd.
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
                    DenLabel.Text = "Pondìlí";
                    break;

                case "Tuesday":
                    DenLabel.Text = "Úterý";
                    break;

                case "Wednesday":
                    DenLabel.Text = "Støeda";
                    break;

                case "Thursday":
                    DenLabel.Text = "Ètvrtek";
                    break;

                case "Friday":
                    DenLabel.Text = "Pátek";
                    break;

                case "Saturday":
                    DenLabel.Text = "Sobota";
                    break;

                case "Sunday":
                    DenLabel.Text = "Nedìle";
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
        /// Vyhledání v listu
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
                                //Vymaže nultý øádek
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
        /// Po stisknutí tlaèítka vytvoøit nový záznam
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateEntry_Click(object sender, EventArgs e)
        {
            //Metoda na vytvoøení záznamu
            VytvorNovyZaznam();

        }





        /// <summary>
        /// Po stisknutí tlaèítka na obnovu listu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RefreshButton_Click(object sender, EventArgs e)
        {
            //Metoda na obnovu listu
            RefeshViewList();
        }






        //Vytvoøení nového záznamu
        public void VytvorNovyZaznam()
        {
            //Vytvoøí promìnou do které se naète tøída s vytváøecím oknem
            AddRecordWindow pridatZaznam = new AddRecordWindow();

            //promìná bool která zjistí zda není okno na vytvoøení již otevøeno
            var Addforms = Application.OpenForms["AddRecordWindow"];

            //Jestliže není
            if (Addforms == null)
            {
                //Otevøe okno na vytvoøení záznamu
                pridatZaznam.Show();
                pridatZaznam.BringToFront();
            }
            //Jinak vypíše chybové hlášení
            else
            {
                MessageBox.Show("Okno Pøidat záznam je již otevøeno");
            }



        }

        /// <summary>
        /// Obnovení listu se záznamy
        /// </summary>
        public void RefeshViewList()
        {
            //základní hodnota záznamù

            int pocetZaznamu = Directory.GetFiles("log/", "*", SearchOption.AllDirectories).Length;

            //Vymaže
            //DataGridMoje.DataSource = null;

            //Vymaže aktuální øádky (kvùli duplikaci)
            //Jestliže je poèet øádkù vìtší než 0
            while (DataGridMoje.Rows.Count > 0)
            {
                //Vymaže nultý øádek
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
        /// Po kliknutí na tlaèíto vymazat nebo upravit v listì
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
                DialogResult dialogResult = MessageBox.Show("Opravdu chcete smazat tento záznam?", "Delete", MessageBoxButtons.YesNo);

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

                //Jestliže není
                if (EditForms == null)
                {
                    //Otevøe okno na vytvoøení záznamu
                    editWindow.NactiTextZeSouboru(cisloZaznamuvInt);

                    editWindow.Show();
                    editWindow.BringToFront();
                }
                else
                {
                    MessageBox.Show("Okno editovat záznam je již otevøem");
                    editWindow.BringToFront();
                }



            }
        }




    }
}
