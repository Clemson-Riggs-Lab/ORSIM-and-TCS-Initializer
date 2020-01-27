using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ORSIMandTCSInitializer
{
    public partial class Form1 : Form
    {
        public string inputFileORSIM;
        public string SimFileORSIM;
        public string SimStartTimeORSIM;

        public string inputFileTCS;
        public string SimFileTCS;
        public string SimStartTimeTCS;

        public string DefaultORSIMName= "ORSIM.exe";
        public string DefaultORSIMInputName = "InputORSIM.txt";

        public string DefaultTCSName = "TCS.exe";
        public string DefaultTCSInputName = "InputTCS.csv";

        private string patientName;
        private bool gender;
        private int age;
        private string height;
        private string weight;
        private float baseHeartRate;
        private float basePulse;
        private float baseSpo2;
        private float baseSystolicPressure;
        private float baseDiastolicPressure;
        private float skinTemp;
        private float baseETCO2;
        private List<TimeEvent> timedEventList;
        private static DateTime ORSimulationStartTime;

        private List<Cue> cueList;
        private static DateTime TCSimulationStartTime;

        DataTable dataTable = new DataTable();
        DataTable infodataTable = new DataTable();

        DataTable TCSdataTable = new DataTable();




        public Form1()
        {
            InitializeComponent();
            timePicker.Value = DateTime.Now;
            TimePicker1.Value= DateTime.Now;

            ORSimulationStartTime = timePicker.Value;
            TCSimulationStartTime = TimePicker1.Value;

            dataTable.Columns.Add("Start Offset");
            dataTable.Columns.Add("End Offset");
            dataTable.Columns.Add("Start Time");
            dataTable.Columns.Add("End Time");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Type");
            dataTable.Columns.Add("Factor");
            dataGridView1.DataSource = dataTable;

            infodataTable.Columns.Add("Patient Name");
            infodataTable.Columns.Add("Base Heart Rate");
            infodataTable.Columns.Add("Base Spo2");
            infodataTable.Columns.Add("Base Systolic Pressure");
            infodataTable.Columns.Add("Base Diastolic Pressure");
            infodataTable.Columns.Add("Base ETCO2");
            dataGridView2.DataSource = infodataTable;

            TCSdataTable.Columns.Add("Cue #");
            TCSdataTable.Columns.Add("Offset time");
            TCSdataTable.Columns.Add("Change Type");
            TCSdataTable.Columns.Add("St. Gain");
            TCSdataTable.Columns.Add("End Gain");
            TCSdataTable.Columns.Add("St. Tac");
            TCSdataTable.Columns.Add("End Tac");
            TCSdataTable.Columns.Add("St. ISI");
            TCSdataTable.Columns.Add("St. Change pulse");
            TCSdataTable.Columns.Add("End Change pulse");
            dataGridView3.DataSource = TCSdataTable;

            foreach (string file in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)))
            {
                if (Path.GetFileName(file).Contains(DefaultORSIMName))
                {
                    SimFileORSIM = file;
                    label6.Text = file;
                }
                if (Path.GetFileName(file).Contains(DefaultORSIMInputName))
                {
                    inputFileORSIM = file;
                    label5.Text = file;
                    string text = File.ReadAllText(inputFileORSIM);
                    LoadPatientInfo(text);
                    LoadEvents(text);
                    CreateDataTable(timedEventList, dataTable);
                    CreateInfoDataTable(infodataTable);

                }
                if (Path.GetFileName(file).Contains(DefaultTCSName))
                {
                    SimFileTCS = file;
                    label13.Text = file;
                    //TODO
                }
                if (Path.GetFileName(file).Contains(DefaultTCSInputName))
                {
                    inputFileTCS = file;
                    label12.Text = file;
                    LoadTCSEvents(inputFileTCS);
                    CreateDataTable(cueList, TCSdataTable);
                    //TODO
                }
            }
            if (inputFileORSIM == null || SimFileORSIM == null)
            {
                startButton.Enabled = false;
                startButton.BackColor = Color.FromArgb(156, 158, 154);
            }

            if (inputFileTCS == null || SimFileTCS == null)
            {
                tCSstartButton.Enabled = false;
                tCSstartButton.BackColor = Color.FromArgb(156, 158, 154);
            }

            if(startButton.Enabled && tCSstartButton.Enabled)
            {
                StartBothButton.Enabled = true;
                StartBothButton.BackColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                StartBothButton.Enabled = false;
                StartBothButton.BackColor = Color.FromArgb(156, 158, 154);
            }
        }



        private void FileBrowseButton_Click(object sender, EventArgs e)
        {
            int size = -1;

            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            DialogResult result = fdlg.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                inputFileORSIM = fdlg.FileName;
                try
                {
                    string text = File.ReadAllText(inputFileORSIM);
                    size = text.Length;
                    label5.Text = inputFileORSIM;
                    LoadPatientInfo(text);
                    LoadEvents(text);
                    CreateDataTable(timedEventList, dataTable);
                    CreateInfoDataTable(infodataTable);
                    tabControl1.SelectedTab = tabPage1;
                    if (inputFileORSIM!= null && SimFileORSIM!=null)
                    {
                        startButton.Enabled = true;
                        startButton.BackColor = Color.FromArgb(140, 244, 66);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Couldn't load file, make sure it is in the correct format.", "Ok");
                }
            }
            Console.WriteLine(fdlg.FileName);

        }
        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            ORSimulationStartTime = timePicker.Value;
            SimStartTimeORSIM = ORSimulationStartTime.ToString("HH:mm:ss");
            Console.WriteLine(SimStartTimeORSIM);
            if (timedEventList != null)
            {
                dataTable.Clear();

                foreach (var item in timedEventList)
                {
                    {
                        item.eventStartTimeReal = ORSimulationStartTime.Add(TimeSpan.Parse(item.eventStartTime));
                        item.eventEndTimeReal = ORSimulationStartTime.Add(TimeSpan.Parse(item.eventEndTime));
                        dataTable.Rows.Add(item.eventStartTime, item.eventEndTime, item.eventStartTimeReal.ToString("HH:mm:ss"), item.eventEndTimeReal.ToString("HH:mm:ss"), item.evtCat, item.evtType, item.factor);
                    }
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.CurrentCell.Selected = false;
            }
            if (inputFileORSIM != null && SimFileORSIM != null)
            {
                startButton.Enabled = true;
                startButton.BackColor = Color.FromArgb(140, 244, 66);
            }
            if (startButton.Enabled && tCSstartButton.Enabled)
            {
                StartBothButton.Enabled = true;
                StartBothButton.BackColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                StartBothButton.Enabled = false;
                StartBothButton.BackColor = Color.FromArgb(156, 158, 154);
            }
        }

        private void simBrowseButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";

            DialogResult result = fdlg.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                SimFileORSIM = fdlg.FileName;
                label6.Text = SimFileORSIM;

                if (inputFileORSIM != null && SimFileORSIM != null)
                {
                    startButton.Enabled = true;
                    startButton.BackColor = Color.FromArgb(140, 244, 66);
                }
                if (startButton.Enabled && tCSstartButton.Enabled)
                {
                    StartBothButton.Enabled = true;
                    StartBothButton.BackColor = Color.FromArgb(255, 128, 0);
                }
                else
                {
                    StartBothButton.Enabled = false;
                    StartBothButton.BackColor = Color.FromArgb(156, 158, 154);
                }
            }
            Console.WriteLine(fdlg.FileName);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string startTime;

            if(ORSIMStartImmediatelyCheckBox.Checked)
            {
                startTime= DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                startTime = SimStartTimeORSIM;
            }

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string strCmdText = "/C " + "\"" + "\"" + SimFileORSIM + "\"" + " -startTimeReal " + "\"" + startTime + "\"" + " -inputFilePath " + "\"" + inputFileORSIM + "\"" + "\"";
            startInfo.Arguments = strCmdText;
            process.StartInfo = startInfo;
            process.Start();
            Console.WriteLine(strCmdText);
        }

        private void CreateDataTable(List<TimeEvent> list, DataTable dataTable)
        {
            dataTable.Clear();

            foreach (var item in list)
            {
                {
                    dataTable.Rows.Add(item.eventStartTime, item.eventEndTime, item.eventStartTimeReal.ToString("HH:mm:ss"), item.eventEndTimeReal.ToString("HH:mm:ss"), item.evtCat, item.evtType, item.factor);
                }
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.CurrentCell.Selected = false;

        }

        private void CreateInfoDataTable(DataTable dataTable)
        {
            dataTable.Clear();
            dataTable.Rows.Add(patientName, baseHeartRate, baseSpo2, baseSystolicPressure, baseDiastolicPressure, baseETCO2);
            dataGridView2.DataSource = dataTable;
            dataGridView2.CurrentCell.Selected = false;

        }


        private void LoadPatientInfo(string filetext)
        {
            string rawtxt = filetext;
            string[] rawsplit = Regex.Split(rawtxt, "\r\n");

            if (string.Compare(rawsplit[0], "~") != 0)
            {
                Console.WriteLine("Error reading config file 1");
            }

            if (string.Compare(rawsplit[1], "Patient Monitor Config") != 0)
            {
                Console.WriteLine("Error reading config file 2");
            }

            for (int i = 2; rawsplit[i] != "~"; i++)
            {
                string[] colonSplit = rawsplit[i].Split(':');
                if (colonSplit[0] == "Name")
                {
                    patientName = colonSplit[1];
                }
                else if (colonSplit[0] == "Gender")
                {
                    if (colonSplit[1] == "Male")
                    {
                        gender = false;
                    }
                    else if (colonSplit[1] == "Female")
                    {
                        gender = true;
                    }
                }
                else if (colonSplit[0] == "Age")
                {
                    age = int.Parse(colonSplit[1]);
                }
                else if (colonSplit[0] == "Height")
                {
                    height = colonSplit[1];
                }
                else if (colonSplit[0] == "Weight")
                {
                    weight = colonSplit[1];
                }
                else if (colonSplit[0] == "HeartRate" || colonSplit[0] == "Pulse")
                {
                    baseHeartRate = float.Parse(colonSplit[1]);

                    basePulse = baseHeartRate;

                }
                else if (colonSplit[0] == "SPO2")
                {
                    baseSpo2 = float.Parse(colonSplit[1]);
                }
                else if (colonSplit[0] == "ETCO2")
                {
                    baseETCO2 = float.Parse(colonSplit[1]);
                }
                else if (colonSplit[0] == "Systolic")
                {
                    baseSystolicPressure = float.Parse(colonSplit[1]);
                }
                else if (colonSplit[0] == "Diastolic")
                {
                    baseDiastolicPressure = float.Parse(colonSplit[1]);
                }
                else if (colonSplit[0] == "Tskin")
                {
                    skinTemp = float.Parse(colonSplit[1]);
                }
            }
        }



        // load time events
        private void LoadEvents(string filetext)
        {

            // initialize arraylist
            timedEventList = new List<TimeEvent>();

            string rawEvents = filetext;
            string[] lines = Regex.Split(rawEvents, "\r\n");

            int i;
            for (i = 0; lines[i] != "Patient Monitor Events"; i++)
            {
                // this loop just puts i at the right position
            }
            i++;

            for (string eventLine; i < lines.Length && lines[i] != "~"; i++)
            {
                //Debug.Log(eventLine);
                eventLine = lines[i];
                timedEventList.Add(new TimeEvent(eventLine));
            }

            // timedEventList.Sort(new TimeEvent.TimeEventComparer());
            timedEventList.Sort(Comparer<object>.Create(
           (x, y) => ((TimeEvent)x).eventStartTimeReal.CompareTo(((TimeEvent)y).eventStartTimeReal)));
        }


        public class Cue
        {
            public int NewScreenNumber;
            public int CueNumberForInput;
            public string TypeoOfChange;
            public int StartingGain;
            public int StartingFrequency;
            public int EndingGain;
            public int EndingFrequency;
            public int StartingTactorLocation;
            public int EndingTactorLocation;
            public int StartingISI;
            public int EndingISI;
            public int StartingPulseDuration;
            public int EndingPulseDuration;
            public int StartChangeAfterPulseNumber;
            public int EndChangeAfterPulseNumber;
            public string presentTime="-";
            public DateTime cueStartTimeReal;
        }


        public class TimeEvent
        {

            private string evt;     // raw string read from text file
            public string evtCat;   // catagory of event (heart rate, blood pressure, etc)
            public string evtType;  // type of event (increase, decrease, etc.)
            public float factor;       // value used to make events happen
            public string eventStartTime; // time the event begins
            public string eventEndTime; // time the event ends

            public DateTime eventStartTimeReal; // time the event begins
            public DateTime eventEndTimeReal; // time the event ends

            public TimeEvent(string s)
            {
                evt = s;
                // split the string into tokens
                string[] evtSplit = evt.Split(' ', '(', ';', ')');

                // save category and type
                evtCat = evtSplit[0];
                evtType = evtSplit[1];
                // need fload.parse to get a number from this token
                factor = float.Parse(evtSplit[3]);

                // parse out time, need to split the last taken of the original split
                eventStartTime = evtSplit[4];

                //end time
                eventEndTime = evtSplit[5];

                eventStartTimeReal = ORSimulationStartTime.Add(TimeSpan.Parse(evtSplit[4]));
                eventEndTimeReal = ORSimulationStartTime.Add(TimeSpan.Parse(evtSplit[5]));
            }
        }

        private void tCSFileBrowseButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";

            DialogResult result = fdlg.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                inputFileTCS = fdlg.FileName;
                try
                {
                    label12.Text = inputFileTCS;
                    LoadTCSEvents(inputFileTCS);
                    CreateDataTable(cueList, TCSdataTable);
                    tabControl1.SelectedTab = tabPage2;
                    if (inputFileTCS!= null && SimFileTCS != null)
                    {
                        tCSstartButton.Enabled = true;
                        tCSstartButton.BackColor = Color.FromArgb(140, 244, 66);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Couldn't load file, make sure it is in the correct format.", "Ok");
                }
            }
            Console.WriteLine(fdlg.FileName);

        }

        private void CreateDataTable(List<Cue> cueList, DataTable tCSdataTable)
        {
            TCSdataTable.Clear();

            foreach (var item in cueList)
            {
                {
                    TCSdataTable.Rows.Add(item.CueNumberForInput, item.presentTime, item.TypeoOfChange, item.StartingGain, item.EndingGain, item.StartingTactorLocation, item.EndingTactorLocation, item.StartingISI, item.StartChangeAfterPulseNumber, item.EndChangeAfterPulseNumber);
                }
            }
            dataGridView3.DataSource = TCSdataTable;
            dataGridView3.CurrentCell.Selected = false;

        }

        private void LoadTCSEvents(string file)
        {
            try
            {
                CSVReader reader = new CSVReader();
                cueList= reader.Load(file, true, TCSimulationStartTime);

                if (reader.checkTimed(file))
                {
                    TCSTimedCheckBox.Checked = true;
                    TCSTimedCheckBox.Enabled = true;
                }
                else
                {
                    TCSTimedCheckBox.Checked = false;
                    TCSTimedCheckBox.Enabled = false;
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Couldnt Load File, make sure it is not opened and try again\n");
            }
        }

        private void tCSimBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";

            DialogResult result = fdlg.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                SimFileTCS = fdlg.FileName;
                label13.Text = SimFileTCS;

                if (inputFileTCS != null && SimFileTCS != null)
                {
                    tCSstartButton.Enabled = true;
                    tCSstartButton.BackColor = Color.FromArgb(140, 244, 66);
                }
                if (startButton.Enabled && tCSstartButton.Enabled)
                {
                    StartBothButton.Enabled = true;
                    StartBothButton.BackColor = Color.FromArgb(255, 128, 0);
                }
                else
                {
                    StartBothButton.Enabled = false;
                    StartBothButton.BackColor = Color.FromArgb(156, 158, 154);
                }
            }
            Console.WriteLine(fdlg.FileName);

        }

        private void tCSstartButton_Click(object sender, EventArgs e)
        {
            string simTimed;
            string startTime=" - ";

            if (TCSTimedCheckBox.Checked)
            {
                simTimed ="True";
                if(SyncWithORSIMRadioButton.Checked)
                {
                    startTime = SimStartTimeORSIM;
                }
                else if(TCSStartImmediatelyRadioButton.Checked)
                {
                    startTime = "immediate";
                }
                else if(TCSSetStartTimeRadioButton.Checked)
                {
                    startTime = SimStartTimeTCS;
                }
            }
            else
            {
                simTimed = "False";
            }


            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string strCmdText = "/C " + "\"" + "\""+SimFileTCS + "\"" + " -simTimed " + "\"" + simTimed+ "\""+ " -simStartTime " + "\"" + startTime + "\"" + " -inputFilePath " + "\"" + inputFileTCS + "\"" + "\"";
            startInfo.Arguments = strCmdText;
            process.StartInfo = startInfo;
            process.Start();
            Console.WriteLine(strCmdText);

        }

        private void TimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TCSimulationStartTime = TimePicker1.Value;
            SimStartTimeTCS = TCSimulationStartTime.ToString("HH:mm:ss");
            Console.WriteLine(SimStartTimeTCS);
            if (inputFileTCS != null && SimFileTCS != null)
            {
                tCSstartButton.Enabled = true;
                tCSstartButton.BackColor = Color.FromArgb(140, 244, 66);
            }
            if (startButton.Enabled && tCSstartButton.Enabled)
            {
                StartBothButton.Enabled = true;
                StartBothButton.BackColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                StartBothButton.Enabled = false;
                StartBothButton.BackColor = Color.FromArgb(156, 158, 154);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = !groupBox3.Enabled;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timePicker.Enabled = !timePicker.Enabled;

            if (!timePicker.Enabled)
            {
                if (timedEventList != null)
                {
                    dataTable.Clear();

                    foreach (var item in timedEventList)
                    {
                        {
                            item.eventStartTimeReal = ORSimulationStartTime.Add(TimeSpan.Parse(item.eventStartTime));
                            item.eventEndTimeReal = ORSimulationStartTime.Add(TimeSpan.Parse(item.eventEndTime));
                            dataTable.Rows.Add(item.eventStartTime, item.eventEndTime, "-", "-", item.evtCat, item.evtType, item.factor);
                        }
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.CurrentCell.Selected = false;
                }
                if (inputFileORSIM != null && SimFileORSIM != null)
                {
                    startButton.Enabled = true;
                    startButton.BackColor = Color.FromArgb(140, 244, 66);
                }
                if (startButton.Enabled && tCSstartButton.Enabled)
                {
                    StartBothButton.Enabled = true;
                    StartBothButton.BackColor = Color.FromArgb(255, 128, 0);
                }
                else
                {
                    StartBothButton.Enabled = false;
                    StartBothButton.BackColor = Color.FromArgb(156, 158, 154);
                }
            }
            else
            {
                timePicker_ValueChanged(new object(), new EventArgs());
            }
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            TimePicker1.Enabled = !TimePicker1.Enabled;
        }


        private void StartBothButton_Click(object sender, EventArgs e)
        {
            StartButton_Click(new object(), new EventArgs());
            tCSstartButton_Click(new object(), new EventArgs());
        }

     
    }
}
