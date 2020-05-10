﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_buoi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap toa do diem x cua A: ");
            double xA = double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do diem y cua A: ");
            double yA = double.Parse(Console.ReadLine());
            Point A = new Point(xA, yA);

            Console.Write("Nhap toa do diem x cua B: ");
            double xB = double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do diem y cua B: ");
            double yB = double.Parse(Console.ReadLine());
            Point B = new Point(xB, yB);
            Console.WriteLine("Toa do cua diem A = ({0}, {1})", A.X, A.Y);
            Console.WriteLine("Toa do cua diem B = ({0}, {1})", B.X, B.Y);

            Vector AB = new Vector(A, B);
            Console.WriteLine("Vecto AB=({0}, {1})", AB.X, AB.Y);

            Console.WriteLine("Phuong Thuc Thanh Vien");
            Console.WriteLine("Do dai cua Vector AB la: " + AB.DoDai());

            Console.WriteLine("Phuong Thuc Tinh");
            Console.WriteLine("Do dai cua Vector AB la: " + Vector.DoDaiTinh(A, B));
        }
    }
}
