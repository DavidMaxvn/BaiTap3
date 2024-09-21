using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            while (true)
            {
                Console.WriteLine("1. Kiểm tra số có chia hết cho 3 không?");
                Console.WriteLine("2. Hiển thị bảng cửu chương");
                Console.WriteLine("3. Tính tổng giai thừa từ 1 - n");
                Console.WriteLine("4. Kiểm tra số chính phương");
                Console.WriteLine("5. Hiển thị số ngày trong tháng");
                Console.WriteLine("6. Tính tổng dãy S");
                Console.WriteLine("7. Tính tổng các số lẻ");
                Console.WriteLine("8. Hiển thị các số nguyên tố");
                Console.WriteLine("9. Vẽ tam giác vuông dưới");                                
                Console.WriteLine("10. Hiển thị dãy Fibonacci");                
                Console.WriteLine("11. Thoát");
                Console.Write("Chọn chức năng (1-11): ");                
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        KTChiaHet();
                        break;
                    case 2:
                        HienThiBangCuuChuong();
                        break;
                    case 3:
                        TinhTongGiaiThua();
                        break;
                    case 4:
                        BT_KTSoChinhPhuong();
                        break;
                    case 5:                        
                        HienThiSoNgayTrongThang();
                        break;
                    case 6:
                        HienThihTongS();
                        break;
                    case 7:
                        TinhTongCacSoLe();
                        break;
                    case 8:
                        HienThiSoNguyenTo();
                        break;
                    case 9:
                        VeTamGiacVuongDuoi();
                        break;
                    case 10:
                        HienThiDayFibonacci();
                        break;
                    case 11:
                        return;
                    default:
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Chức năng không tồn tại!");
                        Console.WriteLine("Press Enter to continue...");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void KTChiaHet()
        {
            Console.Clear();
            Console.Write("Nhập vào số nguyên n:\t");
            int n = int.Parse(Console.ReadLine());
            // Kiểm tra n có phải bội số của 3 không?
            Console.WriteLine(n % 3 == 0 ? "{0} chia hết cho 3" : "{0} không chia hết cho 3", n);
            Console.WriteLine("Press Enter to go back...");
        }

        private static void HienThiBangCuuChuong()
        {
            Console.Clear();
            Console.Write("Nhập vào số nguyên n:\t");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"----- Bảng cửu chương từ 1 đến {n} -----");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"{j} x {i} = {j * i}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Press Enter to go back...");
        }

        private static void TinhTongGiaiThua()
        {
            Console.Clear();            
            int sum = 0;
            int giaithua = 1;
            Console.Write("Nhập vào số nguyên n:\t");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                giaithua *= i;
                sum += giaithua;
            }

            Console.WriteLine($"Tổng của {n} số giai thừa là: {sum}");
            Console.WriteLine("Press Enter to go back...");
        }

        private static bool laSoChinhPhuong(int num)
        {
            if (num < 0) return false;

            int sqrt = (int)Math.Sqrt(num);
            return (sqrt * sqrt == num);
        }
        private static void BT_KTSoChinhPhuong()
        {
            Console.Clear();
            Console.Write("Nhập vào số nguyên n:\t");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(laSoChinhPhuong(n) ? $"{n} là số chính phương" : $"{n} không phải là số chính phương");
            Console.WriteLine("Press Enter to go back...");
        }

        // Hàm trả về số ngày trong tháng
        private static int GetDaysInMonth(int month, int year)
        {
            // Kiểm tra tháng hợp lệ
            if (month < 1 || month > 12) return -1;

            // Xử lý số ngày của từng tháng
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    // Sử dụng DateTime.IsLeapYear để kiểm tra năm nhuận
                    return DateTime.IsLeapYear(year) ? 29 : 28;
                default:
                    return -1;
            }
        }
        private static void HienThiSoNgayTrongThang()
        {
            Console.Clear();
            Console.Write("Nhập vào tháng (1-12): ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào năm: ");
            int year = int.Parse(Console.ReadLine());
            // Kiểm tra số ngày trong tháng và hiển thị
            int days = GetDaysInMonth(month, year);
            if (days > 0)
            {
                Console.WriteLine($"Tháng {month} năm {year} có {days} ngày.");
            }
            else
            {
                Console.WriteLine("Tháng không hợp lệ.");
            }
            Console.WriteLine("Press Enter to go back...");
        }

        // Hàm tính tổng S
        private static long TinhTongS(int n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (long)Math.Pow(i, i); // Tính i*i và cộng vào tổng
            }
            return sum;
        }
        private static void HienThihTongS()
        {
            Console.Clear();
            Console.Write("Nhập vào số nguyên n:\t");
            int n = int.Parse(Console.ReadLine());
            // Tính tổng S
            long tong = TinhTongS(n);
            // Hiển thị kết quả
            Console.WriteLine($"Tổng S = {tong}");
            Console.WriteLine("Press Enter to go back...");
        }

        private static void TinhTongCacSoLe()
        {
            Console.Clear();
            int sum = 0;
            Console.Write("Nhập vào số nguyên n:\t");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 2)
            {
                sum += i;
            }
            Console.WriteLine($"Tổng các số lẻ từ 1 đến {n} là: {sum}");
            Console.WriteLine("Press Enter to go back...");
        }

        private static bool KiemTraSoNguyenTo(int n)
        {            
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        private static void HienThiSoNguyenTo()
        {
            Console.Clear();
            Console.Write("Nhập vào số nguyên n:\t");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Các số nguyên tố từ 1 đến {n}:");
            for (int i = 2; i <= n; i++)
            {
                if (KiemTraSoNguyenTo(i))
                {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine("\nPress Enter to go back...");
        }

        private static void VeTamGiacVuongDuoi()
        {
            Console.Clear();
            Console.Write("Nhập vào số hàng n:\t");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press Enter to go back...");
        }

        // Hàm tính số Fibonacci thứ i
        static int Fibonacci(int i)
        {
            if (i == 0) return 0;
            if (i == 1) return 1;
            return Fibonacci(i - 1) + Fibonacci(i - 2);
        }

        private static void HienThiDayFibonacci()
        {
            Console.Clear();            
            Console.Write("Nhập vào số nguyên n:\t");
            int n = int.Parse(Console.ReadLine());
            // Hiển thị dãy Fibonacci
            Console.WriteLine($"Dãy Fibonacci với {n} phần tử là:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + "\t");
            }
            Console.WriteLine("\nPress Enter to go back...");
        }
    }
}
