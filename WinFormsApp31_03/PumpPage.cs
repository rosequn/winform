﻿using WinFormsApp31_03.Enums;
using WinFormsApp31_03.Models;
using static WinFormsApp31_03.Models.PumpStation;

namespace WinFormsApp31_03
{
    public partial class PumpPage : Form
    {
        private readonly int _userId;
        private readonly UserRole _userRole;
        private int? _pumpId = null;
        private int? _stationId = null;

        /// <summary>
        /// Initialize
        /// </summary>
        public PumpPage()
        {
            InitializeComponent();
            //_userId = userId;
            _userRole = UserRole.Admin;
            DeleteBtn.Enabled = false;
            UpdateBtn.Enabled = false;
            LoadPumps();
            LoadStation();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadPumps();
            _pumpId = null;
            _stationId = null;
        }

        // Load data
        private void LoadPumps()
        {
            dgPump.AutoGenerateColumns = false;
            using (var db = new PumpContext())
            {
                var query = db.Pumps.Where(p => p.IsDelete == false);
                if (_stationId != null)
                {
                    query = query.Where(p => p.StationId == _stationId);
                }
                var ett = query.Select(p => p.ToSearchDto()).ToList();
                dgPump.DataSource = ett;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa máy bơm này không", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new PumpContext())
                {
                    var ett = db.Pumps.FirstOrDefault(p => p.PumpId == _pumpId && p.IsDelete == false);
                    if (ett != null)
                    {
                        ett.Delete(1);
                        db.SaveChanges();
                        MessageBox.Show("Xóa máy bơm thành công");
                        LoadPumps();
                        _pumpId = null;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy máy bơm này");
                    }
                }
            }

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            PumpCreatePage createPage = new PumpCreatePage();
            createPage.Show();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (_pumpId != null)
            {
                PumpUpdatePage updatePage = new PumpUpdatePage(_pumpId);
                updatePage.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgPump_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgPump.CurrentRow.Index != -1)
                {
                    dgPump.AutoGenerateColumns = false;
                    using (var db = new PumpContext())
                    {
                        int pumpId = Convert.ToInt32(dgPump.CurrentRow.Cells["PumpId"].Value);
                        var ett = db.Pumps.Where(p => p.IsDelete == false && p.PumpId == pumpId).Select(p => p.ToViewDto()).FirstOrDefault();
                        if (ett != null)
                        {
                            _pumpId = pumpId;
                            DeleteBtn.Enabled = true;
                            UpdateBtn.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy trạm bơm này", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStation.SelectedItem != null)
            {
                var selectedStation = cbStation.SelectedItem as SearchCbDto;
                if (selectedStation != null)
                {
                    _stationId = selectedStation.StationId;
                    if (_stationId == 0)
                    {
                        _stationId = null;
                    }

                    LoadPumps();
                }
            }
        }
        private void LoadStation()
        {
            using (var db = new PumpContext())
            {
                var ett = db.PumpStations.Where(p => p.IsDelete == false).Select(p => p.ToSearchCbDto()).ToList();
                ett.Insert(0, new SearchCbDto { StationId = 0, StationName = "Tất cả" });

                cbStation.DataSource = ett;
                cbStation.DisplayMember = "StationName";
                cbStation.ValueMember = "StationId";
            }
        }
    }
}
