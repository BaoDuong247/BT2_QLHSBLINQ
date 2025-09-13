using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSHS
{
    class QuanLyHocSinh
    {
        private List<Hocsinh> hs;

        public QuanLyHocSinh(List<Hocsinh> hs)
        {
            this.hs = hs;
        }

        public void DanhSach()
        {
            Console.WriteLine("Danh sach hoc sinh:");
            var query = from s in hs select s;
            foreach (var s in query)
                Console.WriteLine(s);
        }

        public void DSHSTuoiTu15Den18()
        {
            Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
            var query = from s in hs
                        where s.Tuoi >= 15 && s.Tuoi <= 18
                        select s;
            foreach (var s in query)
                Console.WriteLine(s);
        }

        public void HSCoTenBatDauBangChuA()
        {
            Console.WriteLine("\nHoc sinh co ten bat dau bang chu 'A':");
            var query = from s in hs
                        where s.Ten.StartsWith("A")
                        select s;
            foreach (var s in query)
                Console.WriteLine(s);
        }

        public void TongTuoiHS()
        {
            int totalAge = (from s in hs select s.Tuoi).Sum();
            Console.WriteLine($"\nTong so tuoi: {totalAge}");
        }

        public void HSCoTuoiLonNhat()
        {
            int maxAge = (from s in hs select s.Tuoi).Max();
            var query = from s in hs
                        where s.Tuoi == maxAge
                        select s;
            Console.WriteLine("\nHoc sinh co tuoi lon nhat:");
            foreach (var s in query)
                Console.WriteLine(s);
        }

        public void SapXepTangDanTheoTuoi()
        {
            Console.WriteLine("\nDanh sach sau khi sap xep theo tuoi tang dan:");
            var query = from s in hs
                        orderby s.Tuoi
                        select s;
            foreach (var s in query)
                Console.WriteLine(s);
        }
    }
}
