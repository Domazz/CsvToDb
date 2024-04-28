using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsvToDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable data;


        string datetime = DateTime.Now.ToString("yyyyMMddHHmmss");
        string LogFolder = @"C:\Log\";


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactsDataSet.Cnt_table' table. You can move, or remove it, as needed.
            this.cnt_tableTableAdapter.Fill(this.contactsDataSet.Cnt_table);

            DataTable dt = OperationsUtility.createDataTable();
            dgItems.DataSource = dt;



        }

        private void btnExpToCSV_Click(object sender, EventArgs e)
        {
            //Utility dl = new  Utility();
            DataTable dt = OperationsUtility.createDataTable();

            string fileName = OpenSavefileDialog();

            dt.ToCSV(fileName);




        }


        private string OpenSavefileDialog()
        {
            string Filename = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Excel|*.xls";
            saveFileDialog.Filter = "csv File|*.csv";
            saveFileDialog.Title = "Save Report";
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Filename = saveFileDialog.FileName;

            }

            return Filename;


        }

        private void btnImportToDb_Click(object sender, EventArgs e)
        {

            // DataTable dtItem = (DataTable)(dgItems.DataSource);
            try
            {
                OpenFileDialog dialWin = new OpenFileDialog();
                dialWin.ShowDialog();

                int importedRecords = 0, Errors = 0;

                string srcUlr = "";

                if (dialWin.FileName != "")
                {

                    if (dialWin.FileName.EndsWith(".csv"))
                    {

                        DataTable dtNew = new DataTable();
                        dtNew = GetDataTableFromCsvFile(dialWin.FileName);

                        if (Convert.ToString(dtNew.Columns[0]) != "ID")
                        {

                            MessageBox.Show("Neteisingas failas");

                            btnSave.Enabled = false;
                            return;

                        }
                        txtFile.Text = dialWin.SafeFileName;
                        srcUlr = dialWin.FileName;

                        if (dtNew.Rows != null && dtNew.Rows.ToString() != String.Empty)
                        {

                            dgItems.DataSource = dtNew;

                        }


                        foreach (DataGridViewRow row in dgItems.Rows)
                        {

                            if (Convert.ToString(row.Cells["ID"].Value) == ""
                                       || Convert.ToString(row.Cells["Vardas"].Value) == "" || row.Cells["Vardas"].Value == null
                                       || Convert.ToString(row.Cells["Pavarde"].Value) == "" || row.Cells["Pavarde"].Value == null
                                       || Convert.ToString(row.Cells["Email"].Value) == "" || row.Cells["Email"].Value == null)
                            {


                                row.DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                                Errors += 1;


                            }
                            else
                            {
                                importedRecords += 1;
                            }

                        }
                        if (dgItems.Rows.Count == 0)
                        {
                            btnSave.Enabled = false;
                            MessageBox.Show("Nėra duomenų faile", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected File is Invalid, Please Select valid csv file.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                //
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }


        }


        private static DataTable GetDataTableFromCsvFile(string csvFile)

        {
            DataTable dataCSV = new DataTable();

            try
            {

                if (csvFile.EndsWith(".csv")) {

                    using (Microsoft.VisualBasic.FileIO.TextFieldParser csvReader = new Microsoft.VisualBasic.FileIO.TextFieldParser(csvFile))
                    {
                        csvReader.SetDelimiters(new string[] { ";" });
                        csvReader.HasFieldsEnclosedInQuotes = true;
                        //read column
                        string[] colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            dataCSV.Columns.Add(datecolumn);
                        }
                        while (!csvReader.EndOfData)
                        {
                            string[] fieldData = csvReader.ReadFields();
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }
                            dataCSV.Rows.Add(fieldData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exce " + ex);
            }
            return dataCSV;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dtItem = (DataTable)(dgItems.DataSource);
                string ID, Vardas, Pavarde, Email;
                string InsertItemQry = "";
                int count = 0;
                foreach (DataRow dr in dtItem.Rows)
                {
                    ID = Convert.ToString(dr["ID"]);
                    Vardas = Convert.ToString(dr["Vardas"]);
                    Pavarde = Convert.ToString(dr["Pavarde"]);
                    Email = Convert.ToString(dr["Email"]);
                    if (ID != "" && Vardas != "" && Pavarde != "" && Email != "")
                    {
                        InsertItemQry += "Insert into Cnt_table(ID,Vardas,Parade,Email)Values('" + ID + "','" + Vardas + "','" + Pavarde + "','" + dr["Email"];
                        count++;
                    }
                }
              //  if (InsertItemQry.Length > 1)
               // {
                    bool isSuccess = DBAccess.ExecuteQuery(InsertItemQry);
                    if (isSuccess)
                    {
                        MessageBox.Show("Item Imported Successfully, Total Imported Records : " + count + "", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgItems.DataSource = null;
                    }
               // }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
        }
    



        public void FileSelect()
        {
            string filePath = string.Empty;
            string fileExt = string.Empty;
            OpenFileDialog file = new OpenFileDialog(); //open dialog to choose file  
            file.Filter = "Discovery Excel|*.xlsx| CSV (Coming Soon)| *.csv";
            file.Title = "Please select a valid data file";

            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK) //if there is a file choosen by the user    
            {
                filePath = file.FileName; //get the path of the file    
                fileExt = Path.GetExtension(filePath); //get the file extension   
                if (fileExt.CompareTo(".csv") == 0 || fileExt.CompareTo(".csv") == 0)
                {
                    try
                    {
                        //load excle data to datatable  
                      //  Workbook workbook = new Workbook();
//workbook.LoadFromFile(filePath);
                       // Worksheet sheet = workbook.Worksheets[0];
                       // data = sheet.ExportDataTable();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString()); ;
                    }
                }
                else
                {
                    MessageBox.Show("Please choose .xlsx or .CSV file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error    
                }
            }

            if (data != null && data.Rows.Count > 0)
            {
                string connStr = @"Data Source=LAPTOP-IUDN9I3L\SQLEXPRESS;Initial Catalog=Contacts;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    foreach (DataRow row in data.Rows) //iterate over all rows  
                    {
                        string str = "insert into Cnt_table(ID,Vardas,Pavarde,Email) values(@ID,@Vardas, @Pavarde, @Email)";
                        var com = new SqlCommand(str, conn);
                        com.Parameters.AddWithValue("@ID", Convert.ToInt32(row.Field<string>("ID")));
                        com.Parameters.AddWithValue("@Vardas", row.Field<string>("Varsdas"));
                        com.Parameters.AddWithValue("@Pavarde", row.Field<string>("Email"));
                        com.Parameters.AddWithValue("@Email", row.Field<string>("Email"));


                        com.ExecuteNonQuery();
                        MessageBox.Show("added");
                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileSelect();
        }
    }

    

}
