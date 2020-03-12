using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" Pilih Menu Berikut : ");
		Menu:
			Console.WriteLine("1. Penjumlahan");
			Console.WriteLine("2. Pengurangan");
			Console.WriteLine("3. Perkalian");
			Console.WriteLine("4. Pembagian");
			Console.WriteLine();
			Console.Write("Masukan Pilihan anda 1-4 : ");
			int pil = int.Parse(Console.ReadLine());
			Console.Write("Masukan Nilai A : ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("Masukan Nilai B : ");
			int b = int.Parse(Console.ReadLine());

			switch (pil)
			{
				case 1:
					Console.WriteLine("Hasil penjumlahan {0} + {1} = {2}", a, b, penjumlahan(a, b));
					break;
				case 2:
					Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
					break;
				case 3:
					Console.WriteLine("Hasil Perkalian {0} x {1} = {2}", a, b, perkalian(a, b));
					break;
				case 4:
					Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
					break;
			}

			Console.WriteLine();
			Console.Write("Apakah Igin lagi (y/t) : ");
			string lagi = (Console.ReadLine());
			if (lagi == "y")
			{
				goto Menu;
			} 
		}
		static int penjumlahan(int a, int b)
		{
			return a + b;
		}

		static int pengurangan(int a, int b)
		{
			return a - b;
		}

		static int perkalian(int a, int b)
		{
			return a * b;
		}

		static int pembagian(int a, int b)
		{
			return a / b;
		}
	}
}
