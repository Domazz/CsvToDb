using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace CsvToDb
{
    public  static class Utility
    {

        

        public static void ToCSV(this DataTable dataTable, string strFilePath)
        {

            StreamWriter streamWriter = new StreamWriter(strFilePath, false);

            for (int i = 0; i < dataTable.Columns.Count; i++)
            {

                streamWriter.Write(dataTable.Columns[i]);

                if (i < dataTable.Columns.Count - 1)
                {

                    streamWriter.Write(";");




                }

            }

            streamWriter.Write(streamWriter.NewLine);

            foreach (DataRow dl in dataTable.Rows)
            {

                for (int i = 0; i < dataTable.Columns.Count; i++)
                {

                    if (!Convert.IsDBNull(dl[i]))
                    {

                        string value = dl[i].ToString();

                        if (value.Contains(';'))
                        {

                            value = String.Format("\"{0}\"", value);
                            streamWriter.Write(value);


                        }
                        else
                        {
                            streamWriter.Write(dl[i].ToString());
                        }
                    }

                    if (i < dataTable.Columns.Count - 1)
                    {

                        streamWriter.Write(';');

                    }

                }

                streamWriter.Write(streamWriter.NewLine);


            }

            streamWriter.Close();


        }

    }
}
