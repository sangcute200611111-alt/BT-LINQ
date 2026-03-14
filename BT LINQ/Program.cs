using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTapLINQ
{
    // 1. Định nghĩa lớp Student đầy đủ thuộc tính
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
        public int Age { get; set; }
        public string Faculty { get; set; }
        public int Year { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập tiếng Việt và thông tin sinh viên
            string info = "2415053122237 - Sang";
            Console.OutputEncoding = Encoding.UTF8;
            Random rand = new Random();

            // 2. KHỞI TẠO DANH SÁCH NGẪU NHIÊN (INIT RANDOM)
            string[] names = { "Võ Văn Sang", "Lê Minh Bảo", "Trần Thanh Chi", "Nguyễn Hoàng Duy", "Phạm Trọng Giang", "Đỗ Xuân Hòa", "Ngô Mạnh Hùng", "Đặng Khánh Linh", "Bùi Tuyết Mai", "Lý Hữu Phúc" };
            string[] faculties = { "CNTT", "Cơ khí", "Điện", "Ngôn ngữ Anh" };

            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student
                {
                    Id = i + 1,
                    Name = names[i],
                    Score = Math.Round(rand.NextDouble() * 10, 1), // Điểm 0 - 10
                    Age = rand.Next(18, 28),                      // Tuổi từ 18 ĐẾN 27
                    Faculty = faculties[rand.Next(faculties.Length)],
                    Year = rand.Next(1, 5)                        // Năm 1 - 4
                });
            }

            // In danh sách vừa random để thầy kiểm tra
            Console.WriteLine("--- DANH SÁCH SINH VIÊN KHỞI TẠO NGẪU NHIÊN ---");
            Console.WriteLine("{0,-5} | {1,-15} | {2,-10} | {3,-5} | {4,-5} | {5,-5}", "ID", "Họ Tên", "Khoa", "Điểm", "Tuổi", "Năm");
            foreach (var s in students)
            {
                Console.WriteLine("{0,-5} | {1,-15} | {2,-10} | {3,-5} | {4,-5} | {5,-5}", s.Id, s.Name, s.Faculty, s.Score, s.Age, s.Year);
            }

            Console.WriteLine("\n--- KẾT QUẢ THỰC HIỆN CÁC YÊU CẦU TRÊN BẢNG ---");

            // Bài 21: Tìm Max tuổi và Min tuổi
            Console.WriteLine($"\n{info} | Bài 21: Tìm Max/Min Age");
            Console.WriteLine($"+ Tuổi cao nhất: {students.Max(s => s.Age)}");
            Console.WriteLine($"+ Tuổi thấp nhất: {students.Min(s => s.Age)}");

            // Bài 22: Kiểm tra có sinh viên thuộc khoa CNTT không
            Console.WriteLine($"\n{info} | Bài 22: Kiểm tra khoa CNTT");
            bool hasCNTT = students.Any(s => s.Faculty == "CNTT");
            Console.WriteLine($"+ Kết quả: {(hasCNTT ? "Có sinh viên thuộc khoa CNTT" : "Không có sinh viên khoa CNTT")}");

            // Bài 23: Lấy 10 sinh viên có điểm TB cao nhất (Lấy Top 10)
            Console.WriteLine($"\n{info} | Bài 23: Top 10 sinh viên điểm cao nhất");
            var top10 = students.OrderByDescending(s => s.Score).Take(10);
            int rank = 1;
            foreach (var s in top10)
            {
                Console.WriteLine($"{rank++}. {s.Name} - Điểm: {s.Score}");
            }

            // Bài 24: Bỏ qua các sinh viên năm cuối (Năm 4) và hiển thị
            Console.WriteLine($"\n{info} | Bài 24: Danh sách sinh viên (Trừ năm cuối)");
            var nonFinalYear = students.Where(s => s.Year != 4);
            foreach (var s in nonFinalYear)
            {
                Console.WriteLine($"+ {s.Name} - Năm: {s.Year}");
            }

            Console.WriteLine("\n--- HOÀN THÀNH ---");
            Console.ReadLine();
        }
    }
}