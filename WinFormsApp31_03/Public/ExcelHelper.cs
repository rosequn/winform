using ClosedXML.Excel;

namespace WinFormsApp31_03.Public;

public static class ExcelHelper
{
    public static void ExportDataGridViewToExcel(DataGridView dgv, string sheetName = "Sheet1", string fileName = "Export.xlsx")
    {
        if (dgv.Rows.Count == 0)
        {
            MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo");
            return;
        }

        using (var workbook = new XLWorkbook())
        {
            var ws = workbook.Worksheets.Add(sheetName);

            // Header
            for (int col = 0; col < dgv.Columns.Count; col++)
            {
                ws.Cell(1, col + 1).Value = dgv.Columns[col].HeaderText;
            }

            // Data rows
            for (int row = 0; row < dgv.Rows.Count; row++)
            {
                if (dgv.Rows[row].IsNewRow) continue;

                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    ws.Cell(row + 2, col + 1).Value = dgv.Rows[row].Cells[col].Value?.ToString();
                }
            }

            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx",
                Title = "Lưu tập tin Excel",
                FileName = fileName
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Xuất Excel thành công!", "Thông báo");
                }
            }
        }
    }
}

