using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLTV
{
    public partial class ThongKe: UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        ThongKe_BUS tkb = new ThongKe_BUS();
        private void LOAD_DATA()
        {
            DataTable dt = tkb.Load_Sach();
            dataGridView1.DataSource = dt;
            DataTable dt2 = tkb.Load_DocGia();
            dataGridView2.DataSource = dt2;
            DataTable dt3 = tkb.Load_PhieuMuonTra();
            dataGridView3.DataSource = dt3;
            DataTable dt4 = tkb.Load_NhanVien();
            dataGridView4.DataSource = dt4;
        }
        private void ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private int? ToIntorNull(string text)
        {
            if (int.TryParse(text, out int result)) return result;
            return null;
        }
        private void XuatExel(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }
            Excel.Application excel = new Excel.Application();
            Excel.Workbook wb = excel.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];
            try
            {
                excel.Visible = false;
                excel.ScreenUpdating = false;
                for (int i = 0; i < dgv.Columns.Count; i++)
                    ws.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                for (int i = 0; i < dgv.Rows.Count; i++)
                    for (int j = 0; j < dgv.Columns.Count; j++)
                        ws.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value;
                ws.Columns.AutoFit();
                excel.ScreenUpdating = true;
                excel.Visible = true;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(ws);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wb);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTenSach.Clear();
            txtTacGia.Clear();
            comboboxDanhMuc.SelectedIndex = -1;
            LOAD_DATA();
        }
        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            DTO_ThongKeSach dk = new DTO_ThongKeSach
            {
                TenSach = txtTenSach.Text.Trim(),
                TenTG = txtTacGia.Text.Trim(),
                TenNXB = txtNXB.Text.Trim(),
                TenDM = comboboxDanhMuc.Text.Trim(),
                SoLuongTu = ToIntorNull(txtSLtu.Text),
                SoLuongDen = ToIntorNull(txtSLden.Text),
                TonKhoTu = ToIntorNull(txtTonKhotu.Text),
                TonKhoDen = ToIntorNull(txtTonKhoden.Text),
                GiaTu = ToIntorNull(txtGiatu.Text),
                GiaDen = ToIntorNull(txtGiaden.Text),
                NamTu = ToIntorNull(txtNamXBtu.Text),
                NamDen = ToIntorNull(txtNamXBden.Text)
            };
            dataGridView1.DataSource = tkb.ThongKe_Sach(dk);
        }

        private void guna2GradientTileButton5_Click(object sender, EventArgs e)
        {
            XuatExel(dataGridView1);
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            DTO_ThongKeDocGia dk = new DTO_ThongKeDocGia
            {
                TenDocGia = txtDocGia.Text.Trim(),
                TrangThai = comboboxTrangThai.Text.Trim(),
                //SoSachMatDen = ToIntorNull(guna2TextBox13.Text),
                //SoSachMatTu = ToIntorNull(guna2TextBox12.Text),
                //SoSachMuonDen = ToIntorNull(guna2TextBox15.Text),
                //SoSachMuonTu = ToIntorNull(guna2TextBox14.Text)
            };
            dataGridView2.DataSource = tkb.ThongKe_DocGia(dk);
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            XuatExel(dataGridView2);
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
            if (DATEngaymuontu.Value > DATEngaymuonden.Value)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!", "Thông báo");
                return;
            }
            DTO_ThongKeMuonTra dk = new DTO_ThongKeMuonTra
            {

                LoaiPhieu = txtLoaiPhieu.Text.Trim(),
                NgayMuonTu = DATEngaymuontu.Checked ? (DateTime?)DATEngaymuontu.Value : null,
                NgayMuonDen = DATEngaymuonden.Checked ? (DateTime?)DATEngaymuonden.Value : null
            };
            dataGridView3.DataSource = tkb.ThongKeMuonTra(dk);
        }

        private void guna2GradientTileButton6_Click(object sender, EventArgs e)
        {
            XuatExel(dataGridView3);
        }

        private void guna2GradientTileButton7_Click(object sender, EventArgs e)
        {
            DTO_ThongKeNhanVien dk = new DTO_ThongKeNhanVien
            {
                TenNV = txtTenNV.Text.Trim(),
                TrangThai = comboTrangThai.Text.Trim(),
                ID_BoPhan = comboBoPhan.SelectedValue?.ToString(),
                ID_ChucVu = comboChucVu.SelectedValue?.ToString()
            };
            dataGridView4.DataSource = tkb.ThongKe_NhanVien(dk);
        }

        private void guna2GradientTileButton8_Click(object sender, EventArgs e)
        {
            XuatExel(dataGridView4);
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
                LOAD_DATA();
                Top4NV();
            }
            if (guna2TabControl1.SelectedIndex == 2 || guna2TabControl1.SelectedIndex == 3 || guna2TabControl1.SelectedIndex == 4)
            {
                Loadcombobox2();
                LOAD_DATA();
                Top4NV();
            }
            if (guna2TabControl1.SelectedIndex == 0)
            {
                LoadTop4DocGiaToLabels();
                LoadThongKeTongQuat();
                LoadChart();
            }
        }
        private void LoadTop4DocGiaToLabels()
        {
            // Gọi hàm lấy dữ liệu từ BUS (Hàm này trả về DataTable có 4 dòng)
            DataTable dt = tkb.Top4DG();

            // Kiểm tra nếu có dữ liệu
            if (dt != null && dt.Rows.Count > 0)
            {
                // Dòng 1 (Top 1)
                label2.Text = dt.Rows[0]["TenDG"].ToString();
                label13.Text = dt.Rows[0]["SoLuongMuon"].ToString();

                // Dòng 2 (Top 2)
                if (dt.Rows.Count > 1)
                {
                    label3.Text = dt.Rows[1]["TenDG"].ToString();
                    label14.Text = dt.Rows[1]["SoLuongMuon"].ToString();
                }

                // Dòng 3 (Top 3)
                if (dt.Rows.Count > 2)
                {
                    label11.Text = dt.Rows[2]["TenDG"].ToString();
                    label15.Text = dt.Rows[2]["SoLuongMuon"].ToString();
                }

                // Dòng 4 (Top 4)
                if (dt.Rows.Count > 3)
                {
                    label12.Text = dt.Rows[3]["TenDG"].ToString();
                    label16.Text = dt.Rows[3]["SoLuongMuon"].ToString();
                }
            }
            else
            {
                // Nếu không có dữ liệu, đặt các label về rỗng hoặc giá trị mặc định
                label2.Text = "N/A";
                label13.Text = "0";
                label3.Text = "N/A";
                label14.Text = "0";
                label11.Text = "N/A";
                label15.Text = "0";
                label12.Text = "N/A";
                label16.Text = "0";
            }
        }
        private void LoadThongKeTongQuat()
        {
            DataTable dt = tkb.SLSach();
            if (dt != null && dt.Rows.Count > 0)
            {
                label17.Text = dt.Rows[0]["TongSoLuong"] != DBNull.Value
                                       ? dt.Rows[0]["TongSoLuong"].ToString()
                                       : "0";

                label18.Text = dt.Rows[0]["TongTonKho"] != DBNull.Value
                                     ? dt.Rows[0]["TongTonKho"].ToString()
                                     : "0";
                label19.Text = (Convert.ToInt32(label17.Text) - Convert.ToInt32(label18.Text)).ToString();
            }

        }
        private void LoadChart()
        {
            DataTable dt = tkb.SLSach();
            if (dt != null && dt.Rows.Count > 0)
            {
                label17.Text = dt.Rows[0]["TongSoLuong"] != DBNull.Value ? dt.Rows[0]["TongSoLuong"].ToString() : "0";
                label18.Text = dt.Rows[0]["TongTonKho"] != DBNull.Value ? dt.Rows[0]["TongTonKho"].ToString() : "0";
                int tong = Convert.ToInt32(label17.Text);
                int tonKho = Convert.ToInt32(label18.Text);
                int dangMuon = tong - tonKho;
                label19.Text = dangMuon.ToString();
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add("Tỉ lệ tình trạng sách");
                Series series = new Series("StatusSeries");
                series.ChartType = SeriesChartType.Pie;
                series.Points.AddXY("Đang ở kho", tonKho);
                series.Points.AddXY("Đang cho mượn", dangMuon);
                series.IsValueShownAsLabel = true;
                series.LabelFormat = "{0} cuốn";
                chart1.Series.Add(series);
            }
        }
        private void Top4NV()
        {
            DataTable dt = tkb.Top4NV();
            if (dt != null && dt.Rows.Count > 0)
            {
                // Dòng 1 (Top 1)
                label69.Text = dt.Rows[0]["TenNV"].ToString();
                label73.Text = dt.Rows[0]["TongSachChoMuon"].ToString();
                // Dòng 2 (Top 2)
                if (dt.Rows.Count > 1)
                {
                    label70.Text = dt.Rows[1]["TenNV"].ToString();
                    label74.Text = dt.Rows[1]["TongSachChoMuon"].ToString();
                }
                // Dòng 3 (Top 3)
                if (dt.Rows.Count > 2)
                {
                    label71.Text = dt.Rows[2]["TenNV"].ToString();
                    label75.Text = dt.Rows[2]["TongSachChoMuon"].ToString();
                }
                // Dòng 4 (Top 4)
                if (dt.Rows.Count > 3)
                {
                    label72.Text = dt.Rows[3]["TenNV"].ToString();
                    label76.Text = dt.Rows[3]["TongSachChoMuon"].ToString();
                }
            }
            else
            {
                // Nếu không có dữ liệu, đặt các label về rỗng hoặc giá trị mặc định
                label69.Text = "N/A";
                label73.Text = "0";
                label70.Text = "N/A";
                label74.Text = "0";
                label71.Text = "N/A";
                label75.Text = "0";
                label72.Text = "N/A";
                label76.Text = "0";
            }
        }

        private void guna2TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox15_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
