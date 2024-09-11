using System;
using System.Linq;

class Program
{
	static void Main()
	{
		int choice;

		do
		{
			Console.WriteLine("Chọn bài tập:");
			Console.WriteLine("1. Tạo mảng số nguyên và tính tổng");
			Console.WriteLine("2. Đếm số lượng ký tự trong chuỗi");
			Console.WriteLine("3. Tìm phần tử lớn nhất trong mảng");
			Console.WriteLine("4. Đảo ngược chuỗi");
			Console.WriteLine("5. Kiểm tra mảng đối xứng");
			Console.WriteLine("6. Đếm số lần xuất hiện của một ký tự trong chuỗi");
			Console.WriteLine("7. Thoát");
			Console.Write("Lựa chọn của bạn: ");
			choice = int.Parse(Console.ReadLine());

			switch (choice)
			{
				case 1:
					Bai1_TaoMangVaTinhTong();
					break;
				case 2:
					Bai2_DemSoLuongKyTu();
					break;
				case 3:
					Bai3_TimPhanTuLonNhat();
					break;
				case 4:
					Bai4_DaoNguocChuoi();
					break;
				case 5:
					Bai5_KiemTraMangDoiXung();
					break;
				case 6:
					Bai6_DemSoLanXuatHienKyTu();
					break;
				case 7:
					Console.WriteLine("Thoát chương trình.");
					break;
				default:
					Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
					break;
			}
			Console.WriteLine();

		} while (choice != 7);
	}

	// Bài 1: Tạo mảng số nguyên và tính tổng
	static void Bai1_TaoMangVaTinhTong()
	{
		Console.Write("Nhập số lượng phần tử của mảng: ");
		int n = int.Parse(Console.ReadLine());
		int[] array = new int[n];

		for (int i = 0; i < n; i++)
		{
			Console.Write($"Nhập phần tử thứ {i + 1}: ");
			array[i] = int.Parse(Console.ReadLine());
		}

		int sum = array.Sum();
		Console.WriteLine($"Tổng các phần tử trong mảng là: {sum}");
	}

	// Bài 2: Đếm số lượng ký tự trong chuỗi (không tính khoảng trắng và dấu câu)
	static void Bai2_DemSoLuongKyTu()
	{
		Console.Write("Nhập một chuỗi: ");
		string input = Console.ReadLine();

		int charCount = input.Count(c => !char.IsWhiteSpace(c) && !char.IsPunctuation(c));

		Console.WriteLine($"Số lượng ký tự trong chuỗi (không tính khoảng trắng và dấu câu) là: {charCount}");
	}

	// Bài 3: Tìm phần tử lớn nhất trong mảng
	static void Bai3_TimPhanTuLonNhat()
	{
		Console.Write("Nhập số lượng phần tử của mảng: ");
		int n = int.Parse(Console.ReadLine());
		int[] array = new int[n];

		for (int i = 0; i < n; i++)
		{
			Console.Write($"Nhập phần tử thứ {i + 1}: ");
			array[i] = int.Parse(Console.ReadLine());
		}

		int max = array.Max();
		Console.WriteLine($"Phần tử lớn nhất trong mảng là: {max}");
	}

	// Bài 4: Đảo ngược chuỗi
	static void Bai4_DaoNguocChuoi()
	{
		Console.Write("Nhập một chuỗi: ");
		string input = Console.ReadLine();

		char[] charArray = input.ToCharArray();
		Array.Reverse(charArray);

		string reversedString = new string(charArray);

		Console.WriteLine($"Chuỗi đảo ngược là: {reversedString}");
	}

	// Bài 5: Kiểm tra mảng đối xứng (Palindrome)
	static void Bai5_KiemTraMangDoiXung()
	{
		Console.Write("Nhập số lượng phần tử của mảng: ");
		int n = int.Parse(Console.ReadLine());
		int[] array = new int[n];

		for (int i = 0; i < n; i++)
		{
			Console.Write($"Nhập phần tử thứ {i + 1}: ");
			array[i] = int.Parse(Console.ReadLine());
		}

		bool isPalindrome = true;
		for (int i = 0; i < n / 2; i++)
		{
			if (array[i] != array[n - 1 - i])
			{
				isPalindrome = false;
				break;
			}
		}

		if (isPalindrome)
			Console.WriteLine("Mảng là mảng đối xứng.");
		else
			Console.WriteLine("Mảng không phải là mảng đối xứng.");
	}

	// Bài 6: Đếm số lần xuất hiện của một ký tự trong chuỗi
	static void Bai6_DemSoLanXuatHienKyTu()
	{
		Console.Write("Nhập một chuỗi: ");
		string input = Console.ReadLine();

		Console.Write("Nhập ký tự cần đếm: ");
		char character = char.Parse(Console.ReadLine());

		int count = input.Count(c => c == character);

		Console.WriteLine($"Số lần xuất hiện của ký tự '{character}' trong chuỗi là: {count}");
	}
}
