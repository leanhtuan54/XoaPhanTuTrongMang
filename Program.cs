using System;

namespace XoaPhanTuTrongMang
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // Bước 1: Khai báo và khởi tạo mảng số nguyên
            int[] array = { 10, 4, 6, 7, 8, 6, 0, 0, 0, 0 }; // Mảng cho trước
            int n = array.Length; // Số phần tử trong mảng

            // Hiển thị mảng ban đầu
            Console.WriteLine("Mang ban dau:");
            DisplayArray(array);

            // Bước 2: Nhập phần tử cần xoá
            Console.WriteLine("Nhap phan tu can xoa: ");
            int X = Int32.Parse(Console.ReadLine());

            // Bước 3: Tìm vị trí của phần tử X
            int index_del = -1; // Lưu vị trí của phần tử cần xoá
            for (int i = 0; i < n; i++)
            {
                if (array[i] == X)
                {
                    index_del = i; // Lưu vị trí của phần tử cần xoá
                    break;
                }
            }

            // Kiểm tra nếu phần tử X có xuất hiện trong mảng
            if (index_del != -1)
            {
                // Bước 4: Thực hiện xoá phần tử X khỏi mảng
                for (int i = index_del; i < n - 1; i++)
                {
                    array[i] = array[i + 1]; // Gán phần tử đằng sau lên vị trí hiện tại
                }
                array[n - 1] = 0; // Đặt giá trị 0 cho phần tử cuối cùng

                // Bước 5: In ra mảng sau khi xóa
                Console.WriteLine("Mang sau khi xoa phan tu " + X + ":");
                DisplayArray(array);
            }
            else
            {
                Console.WriteLine("Phan tu " + X + " khong ton tai trong mang.");
            }
        }

        // Hàm hiển thị mảng
        static void DisplayArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
    }
}
}