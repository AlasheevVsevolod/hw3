using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hw3
{
	class Program
	{
		static void Main(string[] args)
		{
			//Practice.B3_P1_9_NumbersAddition();
			//Practice.B3_P2_9_CheckResultAddition();
			//Practice.B3_P3_9_CheckResultAdditionWithTips();
			//Practice.B3_P4_9_CheckResultWithOperator();
			//Practice.B3_P5_9_CheckResultWithAttemps();
			//Practice.B3_P6_9_FiveNumbersAddition();
			//Practice.B3_P7_9_NumbersResultWithInfoIfCorrect();
			//Practice.B3_P8_9_CircleArea();
			Practice.B3_P9_9_CreaditCalculator();

			Console.ReadKey();
		}
	}

	public partial class Practice
	{
		/// <summary>
		/// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
		/// </summary>
		public static void B3_P1_9_NumbersAddition()
		{
			int num1, num2;

			Console.WriteLine("Сложение двух чисел");

			Console.Write("Введите первое слагаемое: ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите второе слагаемое: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine($"{num1} + {num2} = {num1 + num2}\n");

			return;
		}

		/// <summary>
		/// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
		/// Пускай он теперь не выводит ответ сам. 
		/// А запрашивает ответ и потом проверяет его на правильность.
		/// </summary>
		public static void B3_P2_9_CheckResultAddition()
		{
			int num1, num2, sum, guessedSum;
			bool isNotGuessed = true;

			Console.WriteLine("Сложение двух чисел с проверкой результата");

			Console.Write("Введите первое слагаемое: ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите второе слагаемое: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			sum = num1 + num2;

			while (isNotGuessed)
			{
				Console.Write("Введённые числа сложили. Ваш вариант ответа: ");
				guessedSum = Convert.ToInt32(Console.ReadLine());

				if (guessedSum == sum)
				{
					Console.WriteLine($"Всё так. {num1} + {num2} = {sum}\n");
					isNotGuessed = false;
				}
				else
				{
					Console.WriteLine("Неверно. Посчитайте ещё разок");
				}
			}
			return;
		}

		/// <summary>
		/// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
		/// Пускай он теперь выводит не только информацию правильно или не правильно, 
		/// но и дополнительно, ожидается число больше или меньше указанного.
		/// </summary>
		public static void B3_P3_9_CheckResultAdditionWithTips()
		{
			int num1, num2, sum, guessedSum;
			bool isNotGuessed = true;

			Console.WriteLine("Сложение двух чисел с проверкой результата и выводом подсказки");

			Console.Write("Введите первое слагаемое: ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите второе слагаемое: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			sum = num1 + num2;

			while (isNotGuessed)
			{
				Console.Write("Введённые числа сложили. Ваш вариант ответа: ");
				guessedSum = Convert.ToInt32(Console.ReadLine());

				if (guessedSum == sum)
				{
					Console.WriteLine($"Всё так. {num1} + {num2} = {sum}\n");
					isNotGuessed = false;
				}
				else if (sum > guessedSum)
				{
					Console.WriteLine("Неверно. Сумма больше указанного числа");
				}
				else
				{
					Console.WriteLine("Неверно. Сумма меньше указанного числа");
				}
			}
			return;
		}

		/// <summary>
		/// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
		/// Пускай алгоритм теперь запрашивает оператор (+ или -).
		/// </summary>
		public static void B3_P4_9_CheckResultWithOperator()
		{
			int num1, num2, result, guessedResult;
			bool isNotGuessed = true;
			char operation;

			Console.WriteLine("Сложение/вычитание двух чисел с проверкой результата и выводом подсказки");

			Console.Write("Введите первый операнд: ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите второй операнд: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Какую операцию будем делать(+, -): ");
			operation = Convert.ToChar(Console.ReadLine());

			if (operation == '+')
			{
				result = num1 + num2;
			}
			else if (operation == '-')
			{
				result = num1 - num2;
			}
			else
			{
				Console.WriteLine("Введён некорректный оператор");
				return;
			}

			while (isNotGuessed)
			{
				if (operation == '+')
				{
					Console.Write("Введённые числа сложили. Ваш вариант ответа: ");
				}
				else if (operation == '-')
				{
					Console.Write("Вычли второе число из первого. Ваш вариант ответа: ");
				}
				guessedResult = Convert.ToInt32(Console.ReadLine());

				if (guessedResult == result)
				{
					Console.WriteLine($"Всё так. {num1} {operation} {num2} = {result}\n");
					isNotGuessed = false;
				}
				else if (result > guessedResult)
				{
					Console.WriteLine("Неверно. Результат больше указанного числа");
				}
				else
				{
					Console.WriteLine("Неверно. Результат меньше указанного числа");
				}
			}
			return;
		}

		/// <summary>
		/// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
		/// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
		/// </summary>
		public static void B3_P5_9_CheckResultWithAttemps()
		{
			int num1, num2, result, guessedResult, numOfAttempts = 3;
			bool isNotGuessed = true;
			char operation;

			Console.WriteLine("Сложение/вычитание двух чисел с проверкой результата и выводом подсказки. На всё 3 попытки");

			Console.Write("Введите первый операнд: ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите второй операнд: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Какую операцию будем делать(+, -): ");
			operation = Convert.ToChar(Console.ReadLine());

			if (operation == '+')
			{
				result = num1 + num2;
			}
			else if (operation == '-')
			{
				result = num1 - num2;
			}
			else
			{
				Console.WriteLine("Введён некорректный оператор");
				return;
			}

			while (isNotGuessed)
			{
				//Вот тут по идее должно быть разделение вывода, т.к. "1 попыт{ка}", ">=5  попыт{ок}", но у нас чётко задано кол-во попыток, поэтому лень все случаи описывать)
				Console.WriteLine($"У вас {numOfAttempts} попытки решить задачу");
				if (operation == '+')
				{
					Console.Write("Введённые числа сложили. Ваш вариант ответа: ");
				}
				else if (operation == '-')
				{
					Console.Write("Вычли второе число из первого. Ваш вариант ответа: ");
				}
				guessedResult = Convert.ToInt32(Console.ReadLine());

				if (guessedResult == result)
				{
					Console.WriteLine($"Всё так. {num1} {operation} {num2} = {result}\n");
					isNotGuessed = false;
					return;
				}
				else if (result > guessedResult)
				{
					Console.WriteLine("Неверно. Результат больше указанного числа");
				}
				else
				{
					Console.WriteLine("Неверно. Результат меньше указанного числа");
				}
				numOfAttempts--;
				if (numOfAttempts == 0)
				{
					Console.WriteLine("Не осталось попыток решить задачу. Учите матчасть :D\n");
					return;
				}
			}
			return;
		}

		/// <summary>
		/// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
		/// Пускай алгоритм складывает пять чисел вместо двух.
		/// </summary>
		public static void B3_P6_9_FiveNumbersAddition()
		{
			int num1, num2, num3, num4, num5, result, guessedResult, numOfAttempts = 3;
			bool isNotGuessed = true;

			Console.WriteLine("Сложение пяти чисел с проверкой результата и выводом подсказки. На всё 3 попытки");

			Console.Write("Введите первый операнд: ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите второй операнд: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите третий операнд: ");
			num3 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите четвёртый операнд: ");
			num4 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите пятый операнд: ");
			//Я раньше каждый раз создавал строковую переменную, чтобы вычитать из консоли результат, но тут заколебался, немного подумал и пошёл переписывать всё заново. Насколько же проще писать так, чем каждый раз создавать строковую переменную)
			num5 = Convert.ToInt32(Console.ReadLine());

			result = num1 + num2 + num3 + num4 + num5;

			while (isNotGuessed)
			{
				//Вот тут по идее должно быть разделение вывода, т.к. "1 попыт{ка}", ">=5  попыт{ок}", но у нас чётко задано кол-во попыток, поэтому лень все случаи описывать)
				Console.WriteLine($"У вас {numOfAttempts} попытки решить задачу");

				Console.Write("Введённые числа сложили. Ваш вариант ответа: ");
				guessedResult = Convert.ToInt32(Console.ReadLine());

				if (guessedResult == result)
				{
					Console.WriteLine($"Всё так. {num1} + {num2} + {num3} + {num4} + {num5} = {result}\n");
					isNotGuessed = false;
					return;
				}
				else if (result > guessedResult)
				{
					Console.WriteLine("Неверно. Результат больше указанного числа");
				}
				else
				{
					Console.WriteLine("Неверно. Результат меньше указанного числа");
				}
				numOfAttempts--;
				if (numOfAttempts == 0)
				{
					Console.WriteLine("Не осталось попыток решить задачу. Учите матчасть :D\n");
					return;
				}
			}
			return;
		}

		/// <summary>
		/// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
		/// В конце алгоритма выводить информацию была ли задача решена правильно.
		/// </summary>
		public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
		{
			int num1, num2, num3, num4, num5, result, guessedResult, numOfAttempts = 3;
			bool isNotGuessed = true;

			Console.WriteLine("Сложение пяти чисел с проверкой результата и выводом подсказки. На всё 3 попытки. В конце выводим результат");

			Console.Write("Введите первый операнд: ");
			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите второй операнд: ");
			num2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите третий операнд: ");
			num3 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите четвёртый операнд: ");
			num4 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите пятый операнд: ");
			//Я раньше каждый раз создавал строковую переменную, чтобы вычитать из консоли результат, но тут заколебался, немного подумал и пошёл переписывать всё заново. Насколько же проще писать так, чем каждый раз создавать строковую переменную)
			num5 = Convert.ToInt32(Console.ReadLine());

			result = num1 + num2 + num3 + num4 + num5;

			while (isNotGuessed)
			{
				//Вот тут по идее должно быть разделение вывода, т.к. "1 попыт{ка}", ">=5  попыт{ок}", но у нас чётко задано кол-во попыток, поэтому лень все случаи описывать)
				Console.WriteLine($"У вас {numOfAttempts} попытки решить задачу");

				Console.Write("Введённые числа сложили. Ваш вариант ответа: ");
				guessedResult = Convert.ToInt32(Console.ReadLine());

				if (guessedResult == result)
				{
					Console.WriteLine($"Всё так. {num1} + {num2} + {num3} + {num4} + {num5} = {result}");
					isNotGuessed = false;
					printResultInfo(isNotGuessed);
					return;
				}
				else if (result > guessedResult)
				{
					Console.WriteLine("Неверно. Результат больше указанного числа");
				}
				else
				{
					Console.WriteLine("Неверно. Результат меньше указанного числа");
				}
				numOfAttempts--;
				if (numOfAttempts == 0)
				{
					Console.WriteLine("Не осталось попыток решить задачу. Учите матчасть :D");
					printResultInfo(isNotGuessed);
					return;
				}
			}
			return;
		}

		public static void printResultInfo(bool isNotGuessed)
		{
			if (isNotGuessed)
			{
				Console.WriteLine("Задача не решена. Отдохните немного и приходите снова\n");
			}
			else
			{
				Console.WriteLine("Задача решена. Мои поздравления!\n");
			}
			return;
		}

		/// <summary>
		/// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
		/// </summary>
		public static void B3_P8_9_CircleArea()
		{
			double radius, circleSquare;

			Console.WriteLine("Считаем площадь круга(пr^2) по заданному радиусу");

			Console.Write("Введите радиус: ");
			radius = Convert.ToDouble(Console.ReadLine());

			circleSquare = radius * radius * Math.PI;

			Console.WriteLine($"Площадь круга, радиусом {radius} равна {circleSquare}\n");
		}

		/// <summary>
		/// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
		/// </summary>
		public static void B3_P9_9_CreaditCalculator()
		{
			const int monthsInYear = 12, oneHundredPercents = 100;
			double creditAmount, creditPercents, monthlyPayment, totalPayments, remainingAmount;

			Console.WriteLine("Кредитный калькулятор. Вводите сумму, которую хотите взять и размер процентной ставки");

			Console.Write("Какую сумму желаете взять: ");
			creditAmount = Convert.ToDouble(Console.ReadLine());

			Console.Write("Размер процентной ставки банка: ");
			creditPercents = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Обработка запроса...");

			totalPayments = creditAmount + (creditAmount * creditPercents / oneHundredPercents);
			monthlyPayment = totalPayments / monthsInYear;

			Console.WriteLine("Месяц\t| Выплата\t| Остаток");
			Console.WriteLine("".PadRight(35, '-'));
			for (int i = 1; i <= monthsInYear; i++)
			{
				//Я не знаю, как считаются кредиты, поэтому описал самый простой (но не факт, что верный) вариант
				remainingAmount = totalPayments - monthlyPayment * i;
				Console.WriteLine($"{i}\t| {monthlyPayment:N}\t| {remainingAmount:N}");

			}

			Console.WriteLine("".PadRight(35, '-'));
			Console.WriteLine($"Оющая сумма выплат: {totalPayments}\n");

			Console.WriteLine("P. S. Демо-версия рассчитывает только оплату равными долями. Для рассчёта дифференцированных платежей приобретите полную версию программы)");
		}
	}
}
