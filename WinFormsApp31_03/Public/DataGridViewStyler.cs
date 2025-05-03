public static class DataGridViewStyler
{
    public static void ApplyCustomStyle(DataGridView dgv)
    {
        // Header
        dgv.EnableHeadersVisualStyles = false;
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

        // Tự động điều chỉnh cột theo nội dung tiêu đề
        dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);

        // Xen kẽ màu dòng
        dgv.RowsDefaultCellStyle.BackColor = Color.White;
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

        // Dòng được chọn
        dgv.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
        dgv.DefaultCellStyle.SelectionForeColor = Color.White;

        foreach (DataGridViewColumn col in dgv.Columns)
        {
            col.Frozen = false;
        }

        // Tự động dãn cột theo nội dung (dữ liệu)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        // Tự động điều chỉnh chiều cao của header
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    }


    public static void RowRepaint(object sender, DataGridViewRowPrePaintEventArgs e)
    {
        var dgv = sender as DataGridView;
        if (dgv.Rows[e.RowIndex].Selected)
        {
            dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkBlue;
            dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;

        }
        else
        {
            // Dòng không được chọn thì dùng màu xen kẽ như bình thường
            if (e.RowIndex % 2 == 0)
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;

        }
    }

}
