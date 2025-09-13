using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSHS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hocsinh> hs = new List<Hocsinh>()
            {
                new Hocsinh(){ SBD = 1, Ten = "An", Tuoi = 16 },
                new Hocsinh(){ SBD = 2, Ten = "Chung", Tuoi = 15 },
                new Hocsinh(){ SBD = 3, Ten = "Lan", Tuoi = 19 },
                new Hocsinh(){ SBD = 4, Ten = "Huy", Tuoi = 17 },
                new Hocsinh(){ SBD = 5, Ten = "Duy", Tuoi = 20 }
            };
            QuanLyHocSinh manager = new QuanLyHocSinh(hs);

            manager.DanhSach();
            manager.DSHSTuoiTu15Den18();
            manager.HSCoTenBatDauBangChuA();
            manager.TongTuoiHS();
            manager.HSCoTuoiLonNhat();
            manager.SapXepTangDanTheoTuoi();
        }
    }
}
