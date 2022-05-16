using System;

namespace HomeWorkLesson2_1_4_
{
    class Program
    {
		static void Main(string[] args)
		{
			Welcome();
			Consol();
			Console.ReadKey();

		}
		static void Welcome()
		{
			DateTime date = DateTime.Now;
			Console.WriteLine($"Привет, VladimirGerasimov, сегодня {date}");
			Console.Write("\n");
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
			Console.WriteLine("Введи номер месяца");
			Console.WriteLine($"{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}");
		int n = int.Parse(Console.ReadLine()); 
			if (n == 1)
				Console.WriteLine("Месяц под номером " + n + " : Январь");
			if (n == 2)
				Console.WriteLine("Месяц под номером " + n + " : Февраль");
			if (n == 3)
				Console.WriteLine("Месяц под номером " + n + " : Март");
			if (n == 4)
				Console.WriteLine("Месяц под номером " + n + " : Апрель");
			if (n == 5)
				Console.WriteLine("Месяц под номером " + n + " : Май");
			if (n == 6)
				Console.WriteLine("Месяц под номером " + n + " : Июнь");
			if (n == 7)
				Console.WriteLine("Месяц под номером " + n + " : Июль");
			if (n == 8)
				Console.WriteLine("Месяц под номером " + n + " : Август");
			if (n == 9)
				Console.WriteLine("Месяц под номером " + n + " : Сентябрь");
			if (n == 10)
				Console.WriteLine("Месяц под номером " + n + " : Октябрь");
			if (n == 11)
				Console.WriteLine("Месяц под номером " + n + " : Ноябрь");
			if (n == 12)
				Console.WriteLine("Месяц под номером " + n + " : Декабрь");

			if (n == 13)
				Console.WriteLine("такого месяца нет");
			
			    Console.ReadLine();
			

		
			
			
			
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
					Console.Write("Это число является нечетным.");
				}
				else
				{
					Console.Write("Это число является четным.");
				}
			}
			catch
			{
				Console.Write(" введите число.\n");
			}
		}
		static void Cheque()
		{
			string date = "01.01.22 00:19";
			int cmena = 3;
			int check = 5;
			string kassir = "Кассовый Работник";
			string place = "Магазин №72";
			string service = "1.000 X 2000.00";
			double total = 2000.00;
			double cash = 2000.00;
			Console.WriteLine($"{date}");
			Console.WriteLine($"СМЕНА: {cmena} ЧЕК: {check}");
			Console.WriteLine($"КАССИР: {kassir}");
			Console.WriteLine($"МЕСТО РАСЧЕТОВ: {place}");
			Console.WriteLine($"плата за услуги телефона + Интр. - {service}");
			Console.WriteLine($"ИТОГ: ={total}");
			Console.WriteLine("ПОЛУЧЕНО:");
			Console.WriteLine($"НАЛИЧНЫМИ: {cash}");

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
				Console.Write(" введите число.\n");

			}


		}


		static void Consol()
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
					Consol();
					break;

			}
			static void MenuPresent()
			{
				Console.WriteLine("=================================" );
				Console.WriteLine("- T - cреднесуточная  температура " );
				Console.WriteLine("- M - Выввод названия ук. месяца " );
				Console.WriteLine("- N - проверка чисел на четность " );
				Console.WriteLine("- R - Будет ли эта зима дождливой " );
				Console.WriteLine("- C - Вывести  данные с касс. чека ");
				Console.WriteLine("=================================" );
			}




		}
	}








}

