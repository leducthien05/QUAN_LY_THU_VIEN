using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using DTO;
using BUS;

namespace QLTV
{
    public partial class ThongKe: UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        ThongKe_BUS tkb = new ThongKe_BUS();
        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            DTO_ThongKeSach dk = new DTO_ThongKeSach();
            dk.TenSach = txtTenSach.Text.Trim();
            dk.TenTG = txtTacGia.Text.Trim();
            dk.TenNXB = txtNXB.Text.Trim();
            dk.TenDM = comboboxDanhMuc.Text.Trim();
            if (int.TryParse(txtSLtu.Text, out int sltu))
                dk.SoLuongTu = sltu;
            if (int.TryParse(txtSLden.Text, out int slden))
                dk.SoLuongDen = slden;
            if (int.TryParse(txtTonKhotu.Text, out int tontu))
                dk.TonKhoTu = tontu;
            if (int.TryParse(txtTonKhoden.Text, out int tokden))
                dk.TonKhoDen = tokden;
            if (float.TryParse(txtGiatu.Text, out float giatu))
                dk.GiaTu = giatu;
            if (float.TryParse(txtGiaden.Text, out float giaden))
                dk.GiaDen = giaden;
            if (int.TryParse(txtNamXBtu.Text, out int namtu))
                dk.NamTu = namtu;
            if (int.TryParse(txtNamXBden.Text, out int namden))
                dk.NamDen = namden;
        }

        private void guna2GradientTileButton5_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;

            Excel.Workbook wb = excel.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];

            // Header
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            // Data
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            ws.Columns.AutoFit();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            DTO_ThongKeDocGia dk = new DTO_ThongKeDocGia();
            dk.TenDocGia = txtDocGia.Text.Trim();
            dk.TrangThai = comboboxTrangThai.Text.Trim();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            Excel.Workbook wb = excel.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];
            // Header
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = dataGridView2.Columns[i].HeaderText;
            }
            // Data
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value;
                }
            }
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            DTO_ThongKeMuonTra dk = new DTO_ThongKeMuonTra();
            dk.LoaiPhieu = txtLoaiPhieu.Text.Trim();
            dk.NgayMuonTu = DATEngaymuontu.Checked ? (DateTime?)DATEngaymuontu.Value : null;
            dk.NgayMuonDen = DATEngaymuonden.Checked ? (DateTime?)DATEngaymuonden.Value : null;
        }

        private void guna2GradientTileButton6_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            Excel.Workbook wb = excel.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];
            // Header
            for (int i = 0; i < dataGridView3.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = dataGridView3.Columns[i].HeaderText;
            }
            // Data
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView3.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = dataGridView3.Rows[i].Cells[j].Value;
                }
            }
        }

        private void guna2GradientTileButton7_Click(object sender, EventArgs e)
        {
            DTO_ThongKeNhanVien dk = new DTO_ThongKeNhanVien();
            dk.TenNV = txtTenNV.Text.Trim();
            dk.TrangThai = comboboxTrangThai.Text.Trim();
            dk.ID_BoPhan = comboBoPhan.SelectedValue?.ToString();
            dk.ID_ChucVu = comboChucVu.SelectedValue?.ToString();
        }

        private void guna2GradientTileButton8_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            Excel.Workbook wb = excel.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];
            // Header
            for (int i = 0; i < dataGridView4.Columns.Count; i++)
            {
                ws.Cells[1, i + 1] = dataGridView4.Columns[i].HeaderText;
            }
            // Data
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView4.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = dataGridView4.Rows[i].Cells[j].Value;
                }
            }
        }
        Combobox_ThongKE_BUS cbbus = new Combobox_ThongKE_BUS();
        private void loadCombobox()
        {
            DataTable dtDM = cbbus.getDM();
            comboboxDanhMuc.DataSource = dtDM;
            comboboxDanhMuc.DisplayMember = "TenDM";
            comboboxDanhMuc.ValueMember = "ID_DM";
            comboboxDanhMuc.SelectedIndex = -1;
            DataTable dtPB = cbbus.getPB();
            comboBoPhan.DataSource = dtPB;
            comboBoPhan.DisplayMember = "TenPB";
            comboBoPhan.ValueMember = "ID_PB";
            comboBoPhan.SelectedIndex = -1;
            DataTable dtCV = cbbus.getCV();
            comboChucVu.DataSource = dtCV;
            comboChucVu.DisplayMember = "TenCV";
            comboChucVu.ValueMember = "ID_CV";
            comboChucVu.SelectedIndex = -1;
        }
        private void Loadcombobox2()
        {
            List<string> trangThai = new List<string> { "Đang mượn", "Chưa mượn" };
            comboboxTrangThai.DataSource = trangThai;
            comboboxTrangThai.SelectedIndex = -1;
            List<string> trangThaiNV = new List<string> { "Đang làm việc", "Nghỉ việc" };
            comboTrangThai.DataSource = trangThaiNV;
            comboTrangThai.SelectedIndex = -1;
            List<string> loaiPhieu = new List<string> { "Phiếu mượn", "Phiếu trả" };
            txtLoaiPhieu.DataSource = loaiPhieu;
            txtLoaiPhieu.SelectedIndex = -1;
        }
        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2TabControl1.SelectedIndex == 1 || guna2TabControl1.SelectedIndex == 4)
            {
                loadCombobox();
            }
            if (guna2TabControl1.SelectedIndex == 2 || guna2TabControl1.SelectedIndex == 3 || guna2TabControl1.SelectedIndex == 4)
            {
                Loadcombobox2();
            }
        }


    }
}
