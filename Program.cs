using System;
using MyMath;

namespace MyMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Programming();
        }
        public static int bienDem = 0;
        static void Programming()
        {
            Console.Clear();
            int Chon = 0;
            Console.Title = "Chương Trình Máy Tính";
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("|                  ---MENU---                    |");
            Console.WriteLine("| 1. Tính toán cơ bản                            |");
            Console.WriteLine("| 2. Tính hình học                               |");
            Console.WriteLine("| 0. Thoát                                       |");
            Console.WriteLine("--------------------------------------------------");
            do
            {
                Console.Write("Vui lòng chọn chức năng: ");
                Chon = int.Parse(Console.ReadLine());
                switch (Chon)
                {
                    case 0:
                        {
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("|                  ---ĐANG THOÁT---                   |");
                            Console.WriteLine("--------------------------------------------------");
                            Environment.Exit(0);
                            break;
                        }
                    case 1:
                        {
                            Console.Clear();
                            TinhToanCoBan();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            TinhHinhHoc();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("Không có sự lựa chọn này!");
                            break;
                        }
                }
            } while (true);
        }
        public static void TinhToanCoBan()
        {
            int Chon = 0;
            Console.Title = "Tính Toán Cơ Bản";
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("|                  ---MENU---                    |");
            Console.WriteLine("| 1. Tính tổng                                   |");
            Console.WriteLine("| 2. Tính hiệu                                   |");
            Console.WriteLine("| 3. Tính tích                                   |");
            Console.WriteLine("| 4. Tính thương                                 |");
            Console.WriteLine("| 5. Lũy thừa                                    |");
            Console.WriteLine("| 6. Căn bậc                                     |");
            Console.WriteLine("| 0. Thoát                                       |");
            Console.WriteLine("--------------------------------------------------");
            do
            {
                Console.Write("Vui lòng chọn chức năng: ");
                Chon = int.Parse(Console.ReadLine());
                switch (Chon)
                {
                    case 0:
                        {
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("|                  ---THOÁT---                   |");
                            Console.WriteLine("--------------------------------------------------");
                            Programming();
                            break;
                        }
                    case 1:
                        {
                            TinhToan ketQua = new TinhToan();
                            Console.WriteLine("                   ---TỔNG---                     ");
                            ketQua.NhapTinhToanCoBan();
                            ketQua.XuatTong();
                            break;
                        }
                    case 2:
                        {
                            TinhToan ketQua = new TinhToan();
                            Console.WriteLine("                   ---HIỆU---                     ");
                            ketQua.NhapTinhToanCoBan();
                            ketQua.XuatHieu();
                            break;
                        }
                    case 3:
                        {
                            TinhToan ketQua = new TinhToan();
                            Console.WriteLine("                   ---TÍCH---                     ");
                            ketQua.NhapTinhToanCoBan();
                            ketQua.XuatTich();
                            break;
                        }
                    case 4:
                        {
                            TinhToan ketQua = new TinhToan();
                            Console.WriteLine("                  ---THƯƠNG---                     ");
                            ketQua.NhapTinhToanCoBan();
                            ketQua.XuatThuong();
                            break;
                        }
                    case 5:
                        {
                            TinhToan ketQua = new TinhToan();
                            Console.WriteLine("                    ---MŨ---                       ");
                            ketQua.NhapTinhToanCoBan();
                            ketQua.XuatLuyThua();
                            break;
                        }
                    case 6:
                        {
                            TinhToan ketQua = new TinhToan();
                            Console.WriteLine("                 ---CĂN BẬC 2---                   ");
                            ketQua.NhapCanBac2();
                            ketQua.XuatCanBac2();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("Không có sự lựa chọn này!");
                            break;
                        }
                }
            } while (Chon != 0);
        }
        public static void TinhHinhHoc()
        {
            int Chon = 0;
            Console.Title = "Tính Hình Học";
            
            do
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|                  ---MENU---                    |");
                Console.WriteLine("| 1. Tính Hình Chữ nhật                          |");
                Console.WriteLine("| 2. Tính Hình Vuông                             |");
                Console.WriteLine("| 3. Tính Hình Thang                             |");
                Console.WriteLine("| 4. Tính Hình Bình hành                         |");
                Console.WriteLine("| 5. Tính Hình Tròn                              |");
                Console.WriteLine("| 6. Tính Tam Giác                               |");
                Console.WriteLine("| 0. Thoát                                       |");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Vui lòng chọn chức năng: ");
                Chon = int.Parse(Console.ReadLine());
                switch (Chon)
                {
                    case 0:
                        {
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("|                  ---THOÁT---                   |");
                            Console.WriteLine("--------------------------------------------------");
                            Programming();
                            break;
                        }
                    case 1:
                        {
                            TinhToan ketQua = new TinhToan();
                            Console.WriteLine("               ---HÌNH CHỮ NHẬT---                ");
                            ketQua.NhapHinhChuNhat();
                            ketQua.XuatHinhChuNhat();
                            Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            TinhToan ketQua = new TinhToan();
                            Console.WriteLine("                 ---HÌNH VUÔNG---                 ");
                            ketQua.NhapHinhVuong();
                            ketQua.XuatHinhVuong();
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            TinhToan ketQua = new TinhToan();
                            Console.WriteLine("                 ---HÌNH THANG---                 ");
                            ketQua.NhapHinhThang();
                            ketQua.XuatHinhThang();
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            TinhToan ketQua = new TinhToan();
                            Console.WriteLine("               ---HÌNH BÌNH HÀNH---               ");
                            ketQua.NhapHinhBinhHanh();
                            ketQua.XuatHinhBinhHanh();
                            Console.ReadLine();
                            break;
                        }
                    case 5:
                        {
                            TinhToan ketQua = new TinhToan();
                            Console.WriteLine("                 ---HÌNH TRÒN---                  ");
                            ketQua.NhapHinhTron();
                            ketQua.XuatHinhTron();
                            Console.ReadLine();
                            break;
                        }
                    case 6:
                        {
                            TinhToan ketQua = new TinhToan();
                            Console.WriteLine("               ---HÌNH TAM GIÁC---                ");
                            ketQua.NhapTamGiac();
                            ketQua.XuatTamGiac();
                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("Không có sự lựa chọn này!");
                            break;
                        }
                }
            } while (Chon != 0);
        }
    }
}
