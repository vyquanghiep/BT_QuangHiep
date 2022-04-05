using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_VyQuangHiep
{
    class Program
    {
      
            struct SinhVien
        {
            public int MaSo119;
            public string HoTen119;
            public double DiemToan119;
            public double DiemLy119;
            public double DiemVan119;
        }

        static void NhapThongTinSinhVien(out SinhVien SV119)
        {
            Console.Write(" Ma so: ");
            SV119.MaSo119 = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV119.HoTen119 = Console.ReadLine();
            Console.Write(" Diem toan: ");
            SV119.DiemToan119 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV119.DiemLy119 = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV119.DiemVan119 = Double.Parse(Console.ReadLine());
        }

        static void XuatThongTinSinhVien(SinhVien SV119)
        {
            Console.WriteLine(" Ma so: " + SV119.MaSo119);
            Console.WriteLine(" Ho ten: " + SV119.HoTen119);
            Console.WriteLine(" Diem toan: " + SV119.DiemToan119);
            Console.WriteLine(" Diem ly: " + SV119.DiemLy119);
            Console.WriteLine(" Diem van: " + SV119.DiemVan119);
        }

        static double DiemTBSinhVien(SinhVien SV119)
        {
            return (SV119.DiemToan119 + SV119.DiemLy119 + SV119.DiemVan119) / 3;
        }
        enum thuoctinhSinhVien
        {
            Maso,
            Ten,
            Diemtrungbinh
        }
        static void Main(string[] args)
        {
            /*
             * Khai báo 1 kiểu dữ liệu SinhVien với các trường thông tin như đề bài.
             * Khai báo và khởi tạo 1 đối tượng SV1 kiểu SinhVien.
             */
            SinhVien SV1 = new SinhVien();
            Console.WriteLine(" Nhap thong tin sinh vien: ");
            /*
             * Đây là hàm hỗ trợ nhập thông tin sinh viên.
             * Sử dụng từ khoá out để có thể cập nhật giá trị nhập được ra biến SV1 bên ngoài 
             * khi kết thúc gọi hàm (có thể xem lại bài Hàm trong C#).
             */
            NhapThongTinSinhVien(out SV1);
            Console.WriteLine("*********");
            Console.WriteLine(" Thong tin sinh vien vua nhap la: ");
            XuatThongTinSinhVien(SV1);
            Console.WriteLine(" Diem TB cua sinh vien la: " + DiemTBSinhVien(SV1));

            Console.ReadLine();
        }


    }
}

