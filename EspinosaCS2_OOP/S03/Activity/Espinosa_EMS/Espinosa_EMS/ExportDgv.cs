using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espinosa_EMS
{
    public class ExportDgv
    {
        public static void ExportToExcel(DataGridView dgv, string fileName = "Exported Data")
        {
            try
            {
                if (dgv.Rows.Count == 0)
                {
                    MessageBox.Show("No Data to Export", "Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Workbooks.Add(Type.Missing);

                Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)excelApp.ActiveSheet;
                worksheet.Name = "ExportedData";

                for (int i = 1; i <= dgv.Columns.Count; i++)
                {
                    worksheet.Cells[1, 1] = dgv.Columns[i - 1].HeaderText;
                }

                for(int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString();

                    }
                }
                Microsoft.Office.Interop.Excel.Range headerRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgv.Columns.Count]];
                headerRange.Font.Bold = true;
                headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                headerRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                worksheet.Columns.AutoFit();

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = fileName,
                    DefaultExt = ".xlsx",
                    Filter = "Excel Files|*.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    worksheet.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Export Successful!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                excelApp.Quit();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
