using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace baTask3
{
    public partial class Form1 : Form
    {
        private List<SchoolData> _schooldata;

        public Form1()
        {
            InitializeComponent();
        }

        private void ReadFile(string filepath)
        {
            _schooldata = new List<SchoolData>();
            const Int32 BUFFER_SIZE = 128;
            using (var fileStream = File.OpenRead(filepath))
                //Making sure that it would read lithuanian alphabet
            using (var streamReader = new StreamReader(fileStream, Encoding.GetEncoding(1252), true, BUFFER_SIZE))
            {
                streamReader.ReadLine();
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] lines = line.Split(';');
                    int CHILD_COUNT = Convert.ToInt32(lines[6]);
                    int FREE_SPACE = Convert.ToInt32(lines[7]);
                    SchoolData schooldata = new SchoolData(Convert.ToInt32(lines[0]), lines[1].Replace("\"", "")
                        , Convert.ToInt32(lines[2]), lines[3].Replace("\"", ""), Convert.ToInt32(lines[4]), lines[5], CHILD_COUNT, FREE_SPACE);
                    _schooldata.Add(schooldata);
                }
            }
        }

        private void ChildCountLabel()
        {
            int MAX_CHILD_COUNT = 0;
            int MIN_CHILD_COUNT = 9999;
            foreach (SchoolData schooldata in _schooldata)
            {
                if (MAX_CHILD_COUNT < schooldata.CHILD_COUNT)
                    MAX_CHILD_COUNT = schooldata.CHILD_COUNT;
                if (MIN_CHILD_COUNT > schooldata.CHILD_COUNT)
                    MIN_CHILD_COUNT = schooldata.CHILD_COUNT;
            }
            MAX_CHILD_COUNT_LABEL.Text = MAX_CHILD_COUNT.ToString();
            MIN_CHILD_COUNT_LABEL.Text = MIN_CHILD_COUNT.ToString();
        }

        private void LanguagePercentage()
        {
            List<Language> listlanguages = new List<Language>();
            int TOTAL_FREE_SPACE = 0;

            foreach(SchoolData schooldata in _schooldata)
            {
                Language language = new Language(schooldata.LAN_LABEL, schooldata.LAN_ID, 0);
                //Console.WriteLine(language.LAN_LABEL + " " + schooldata.LAN_ID);
                if (listlanguages.Count == 0 ) 
                    listlanguages.Add(language); 
                else
                {
                    bool ADD_LAN = true;
                    foreach (Language lan in listlanguages)
                    {
                        if(language.LAN_ID == lan.LAN_ID)
                        {
                            ADD_LAN = false;
                            break;
                        }
                    }
                    if (ADD_LAN)
                        listlanguages.Add(language);
                }
                foreach (Language lan in listlanguages)
                {                   
                    if (schooldata.LAN_ID == lan.LAN_ID)
                    {
                        lan.FREE_SPACE += schooldata.FREE_SPACE;
                        TOTAL_FREE_SPACE += schooldata.FREE_SPACE;
                    }                   
                }
            }
            
            DataTable dtable = new DataTable();
            dtable.Columns.AddRange(new DataColumn[3]
            {
                new DataColumn("Kalba"),
                new DataColumn("Procentais", typeof(float)),
                new DataColumn("Laisvu vietu skaicius", typeof(int))
            });

            foreach (Language lan in listlanguages)
            {
                dtable.Rows.Add(lan.LAN_LABEL, lan.Percentage(TOTAL_FREE_SPACE), lan.FREE_SPACE); ;
            }
            /*
             * Disabling user editing
             */
            LanguageDataGrid.AllowUserToResizeRows = false;
            LanguageDataGrid.AllowUserToResizeColumns = false;
            LanguageDataGrid.AllowUserToAddRows = false;
            LanguageDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            LanguageDataGrid.Font = new Font("Microsoft sans serif", 10);

            /*
             * For extra functionality
             */
            //dataTable.CellClick += dataTable_CellClick;

            LanguageDataGrid.DataSource = dtable;
        }

        private void SchoolSelection()
        {
            List<SchoolData> selectedSchools = new List<SchoolData>();

            foreach(SchoolData schooldata in _schooldata)
            {
                if (schooldata.FREE_SPACE >= 2 && schooldata.FREE_SPACE <= 4)
                    selectedSchools.Add(schooldata);
            }
            //List<SchoolData> sortedSchool = selectedSchools.OrderBy(o => o.SCHOOL_NAME).ToList();
            selectedSchools.Sort((x, y) => y.SCHOOL_NAME.CompareTo(x.SCHOOL_NAME));

            //foreach (SchoolData schooldata in selectedSchools)
            //{
            //    Console.WriteLine(schooldata.SCHOOL_NAME);
            //}

            MinMaxDataTable(selectedSchools);
        }

        private void MinMaxDataTable(List<SchoolData> tableInput)
        {
            DataTable dtable = new DataTable();
            dtable.Columns.AddRange(new DataColumn[6]
            {
                new DataColumn("ID"),
                new DataColumn("Pavadinimas"),
                new DataColumn("Amziaus riba"),
                new DataColumn("Kalba"),
                new DataColumn("Vaiku skaicius", typeof(int)),
                new DataColumn("Laisvu vietu skaicius", typeof(int))
            });

            foreach (SchoolData schooldata in tableInput)
            {
                dtable.Rows.Add(_schooldata.IndexOf(schooldata) + 1, schooldata.SCHOOL_NAME, schooldata.TYPE_LABEL, schooldata.LAN_LABEL,
                    schooldata.CHILD_COUNT, schooldata.FREE_SPACE); ;
            }
            /*
             * Disabling user editing
             * Making it easier to edit and read
             */
            MinMaxTable.AllowUserToResizeRows = false;
            MinMaxTable.AllowUserToResizeColumns = false;
            MinMaxTable.AllowUserToAddRows = false;
            MinMaxTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            MinMaxTable.Font = new Font("Microsoft sans serif", 10);

            /*
             * For extra functionality
             */
            //dataTable.CellClick += dataTable_CellClick;

            MinMaxTable.DataSource = dtable;
        }

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // Console.WriteLine(dataTable.CurrentCell.RowIndex);
            MinMaxTable.Rows.GetRowState(MinMaxTable.CurrentCell.RowIndex);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine("Pressed");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BrowseFilePath_Click(object sender, EventArgs e)
        {
            string sFileName = "";
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                sFileName = choofdlog.FileName;
                Console.WriteLine(sFileName);
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
            if (!sFileName.Equals(""))
            {
                ReadFile(sFileName);

                TextOutput Splitter = new TextOutput();
                List<string> dataOutput = Splitter.Splitter(_schooldata);

                foreach (string s in dataOutput) { SplitterListBox.Items.Add(s); }

                ChildCountLabel();
                LanguagePercentage();
                SchoolSelection();
                //DataTable(); 
            }
        }
    }
}
