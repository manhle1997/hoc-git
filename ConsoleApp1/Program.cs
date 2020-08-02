using System;

namespace ConsoleApp1
{
    struct Book
    {
        private string tenSach;
        private string tacGia;
        private string theLoai;
        private int maSach;
        public void nhapThongTin(string tensach, string tacgia, string theloai, int masach)
        {
            tenSach = tensach;
            tacGia = tacgia;
            theLoai = theloai;
            maSach = masach;
        }
        public void showInf()
        {
            Console.WriteLine("Tieu de: {0}", tenSach);
            Console.WriteLine("Tac gia: {0}", tacGia);
            Console.WriteLine("The loai: {0}", theLoai);
            Console.WriteLine("Ma sach: {0}", maSach);
            Console.WriteLine("---------------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p
            .P1()
            .P2()
        }
    }
}
