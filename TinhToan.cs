using System;

namespace MyMath
{
    class TinhToan
    {
        float so1, so2, a, b, c, d, h;
        public void setso1(float so1)
        {
            this.so1 = so1;
        }
        public float getso1()
        {
            return this.so1;
        }
        public void setso2(float so2)
        {
            this.so2 = so2;
        }
        public float getso2()
        {
            return this.so2;
        }
        public void seta(float a)
        {
            this.a = a;
        }
        public float geta()
        {
            return this.a;
        }
        public void setb(float b)
        {
            this.b = b;
        }
        public float getb()
        {
            return this.b;
        }
        public void setc(float c)
        {
            this.c = c;
        }
        public float getc()
        {
            return this.c;
        }
        public void setd(float d)
        {
            this.d = d;
        }
        public float getd()
        {
            return this.d;
        }
        public void seth(float h)
        {
            this.h = h;
        }
        public float geth()
        {
            return this.h;
        }
        public void NhapTinhToanCoBan()
        {
            Console.Write("Nhập số thứ nhất       : ");
            so1 = int.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai        : ");
            so2 = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
        }
        public void XuatTong()
        {
            float KetQua = so1 + so2;
            Console.WriteLine("{0} + {1} = {2}", so1, so2, KetQua);
            Console.WriteLine("--------------------------------------------------");
        }
        public void XuatHieu()
        {
            float KetQua = so1 - so2;
            Console.WriteLine("{0} - {1} = {2}", so1, so2, KetQua);
            Console.WriteLine("--------------------------------------------------");
        }
        public void XuatTich()
        {
            float KetQua = so1 * so2;
            Console.WriteLine("{0} x {1} = {2}", so1, so2, KetQua);
            Console.WriteLine("--------------------------------------------------");
        }
        public void XuatThuong()
        {
            float KetQua = so1 / so2;
            Console.WriteLine("{0} / {1} = {2}", so1, so2, KetQua);
            Console.WriteLine("--------------------------------------------------");
        }
        public void XuatLuyThua()
        {
            double KetQua = Math.Pow(so1, so2);
            Console.WriteLine("{0} ^ {1} = {2}", so1, so2, KetQua);
            Console.WriteLine("--------------------------------------------------");
        }
        public void NhapCanBac2()
        {
            Console.Write("Nhập số                : ");
            so1 = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
        }
        public void XuatCanBac2()
        {
            double KetQua = Math.Sqrt(so1);
            Console.WriteLine("Căn bậc 2 của {0} = {1}", so1, KetQua);
            Console.WriteLine("--------------------------------------------------");
        }
        public void NhapHinhChuNhat()
        {
            Console.Write("Nhập cạnh a            : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh b            : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh h            : ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
        }
        public void XuatHinhChuNhat()
        {
            Console.WriteLine("Chu vi    : {0}", (a + b) * 2);
            Console.WriteLine("Diện tích : {0}", a * b);
            Console.WriteLine("Thệ tích  : {0}", a * b * h);
            Console.WriteLine("--------------------------------------------------");
        }
        public void NhapHinhVuong()
        {
            Console.Write("Nhập cạnh              : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
        }
        public void XuatHinhVuong()
        {
            Console.WriteLine("Chu vi    : {0}", a + a);
            Console.WriteLine("Diện tích : {0}", a * a);
            Console.WriteLine("Thệ tích  : {0}", a * a * a);
            Console.WriteLine("--------------------------------------------------");
        }
        public void NhapHinhThang()
        {
            Console.Write("Nhập cạnh a            : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh b            : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh c            : ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh d            : ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh h            : ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
        }
        public void XuatHinhThang()
        {
            Console.WriteLine("Chu vi    : {0}", a + b + c + d);
            Console.WriteLine("Diện tích : {0}", h * ((a + b) / 2));
            Console.WriteLine("--------------------------------------------------");
        }
        public void NhapHinhBinhHanh()
        {
            Console.Write("Nhập cạnh a            : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh b            : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh h            : ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
        }
        public void XuatHinhBinhHanh()
        {
            Console.WriteLine("Chu vi    : {0}", (a + b) * 2);
            Console.WriteLine("Diện tích : {0}", a * h);
            Console.WriteLine("--------------------------------------------------");
        }
        public void NhapHinhTron()
        {
            Console.Write("Nhập cạnh r            : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh h            : ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
        }
        public void XuatHinhTron()
        {
            Console.WriteLine("Chu vi    : {0}", a * 2 * 3.14);
            Console.WriteLine("Diện tích : {0}", a * a * 3.14);
            Console.WriteLine("Thể tích  : {0}", a * a * 3.14 * h);
            Console.WriteLine("--------------------------------------------------");
        }
        public void NhapTamGiac()
        {
            Console.Write("Nhập cạnh a            : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh b            : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh c            : ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
        }
        public void XuatTamGiac()
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Chu vi    : {0}", p);
            Console.WriteLine("Diện tích : {0}", s);
            Console.WriteLine("Thể tích  : {0}", a * a * 3.14 * h);
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
