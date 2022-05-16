using System;

namespace HomeWorkLesson2_1_4_
{
    class Program
    {
		static void Main(string[] args)
		{
			Greet();
			Menu();
			Console.ReadKey();

		}
		static void Greet()
		{
			DateTime date = DateTime.Now;
			Console.WriteLine($"Привет, VladimirGerasimov, сегодня {date}");
			Console.Write("\n");
		}

		static void MenuPresent()
		{
			Console.WriteLine("=================================");
			Console.WriteLine(" T - cреднесуточная  температура ");
			Console.WriteLine(" M - Вывести название ук. месяца ");
			Console.WriteLine(" N - проверить число на четность ");
			Console.WriteLine(" R - Будет ли эта зима дождливой ");
			Console.WriteLine(" C-  Вывести  данные с касс. чека");
			Console.WriteLine("=================================");
		}

		static void Temp()
		{

			try
			{
				Console.Write("Минимальная температура: ");
				int mintemp = int.Parse(Console.ReadLine());
				Console.Write("Максимальная температура: ");
				int maxtemp = int.Parse(Console.ReadLine());
				int avg_temp = (mintemp + maxtemp) / 2;
				Console.WriteLine("Среднесуточная температура: " + avg_temp);
			}
			catch
			{
				Console.Write("Пожалуйста, введите число.\n");

			}



		}
		static void MntName()
		{
			try
			{
				Console.Write("Введите порядковый номер месяца: ");
				int number = Convert.ToInt32(Console.ReadLine());
				switch (number)
				{
					case 1:
						Console.WriteLine("Январь");
						break;
					case 2:
						Console.WriteLine("Февраль");
						break;
					case 3:
						Console.WriteLine("Март");
						break;
					case 4:
						Console.WriteLine("Апрель");
						break;
					case 5:
						Console.WriteLine("Май");
						break;
					case 6:
						Console.WriteLine("Июнь");
						break;
					case 7:
						Console.WriteLine("Июль");
						break;
					case 8:
						Console.WriteLine("Август");
						break;
					case 9:
						Console.WriteLine("Сентябрь");
						break;
					case 10:
						Console.WriteLine("Октябрь");
						break;
					case 11:
						Console.WriteLine("Ноябрь");
						break;
					case 12:
						Console.WriteLine("Декабрь");
						break;
					default:
						Console.WriteLine("такого месяца нет.");
						break;
				}
			}
			catch
			{
				Console.WriteLine("Извините, месяц не распознан.");
			}

		}
		static void Cheque()
		{
			string date = "01.01.22 00:19";
			int cmena = 3;
			int check = 5;
			string kassir = "СИСТ.АДМИН";
			string place = "Магазин №72";
			string service = "1.000 X 2000.00";
			double total = 2000.00;
			double cash = 2000.00;
			Console.WriteLine($"{date}");
			Console.WriteLine($"СМЕНА: {cmena} ЧЕК: {check}");
			Console.WriteLine($"КАССИР: {kassir}");
			Console.WriteLine($"МЕСТО РАСЧЕТОВ: {place}");
			Console.WriteLine($"плата за услуги телефона - {service}");
			Console.WriteLine($"ИТОГ: ={total}");
			Console.WriteLine("ПОЛУЧЕНО:");
			Console.WriteLine($"НАЛИЧНЫМИ: {cash}");

		}
		static bool UtilEven(int x)
		{
			if ((x % 2) != 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		static void IntEven()
		{
			try
			{
				Console.Write("Введите число: ");
				int number = Convert.ToInt32(Console.ReadLine());
				if (UtilEven(number) == false)
				{
					Console.Write("Данное число является нечетным.");
				}
				else
				{
					Console.Write("Данное число является четным.");
				}
			}
			catch
			{
				Console.Write("Пожалуйста, введите число.\n");
			}
		}

		static void WntRain()
		{
			try
			{
				Console.Write("Минимальная температура: ");
				int mintemp = int.Parse(Console.ReadLine());
				Console.Write("Максимальная температура: ");
				int maxtemp = int.Parse(Console.ReadLine());
				int avtemp = (mintemp + maxtemp) / 2;
				Console.Write("Введите порядковый номер месяца: ");
				int number = Convert.ToInt32(Console.ReadLine());
				if (number == 1 || number == 2 || number == 12)
				{
					if (avtemp > 0)
					{
						Console.WriteLine("Дождливая зима");
					}
					else
					{
						Console.WriteLine("Зима не будет дождливой.");
					}
				}
				else
				{
					Console.WriteLine("Зима не будет дождливой.");
				}
			}
			catch
			{
				Console.Write("Пожалуйста, введите число.\n");

			}


		}


		static void Menu()
		{
			MenuPresent();
			string input = Console.ReadLine();
			switch (input)
			{
				case "T":
					Temp();
					break;
				case "M":
					MntName();
					break;
				case "N":
					IntEven();
					break;
				case "R":
					WntRain();
					break;
				case "C":
					Cheque();
					break;
				default:
					Console.WriteLine("Ошибка проверьте вводимые данные.");
					Menu();
					break;

			}
		}
	}








}

