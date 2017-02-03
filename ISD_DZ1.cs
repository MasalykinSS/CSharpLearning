namespace MainNamespace
{	
	class MainClass
	{	
		//точка входа
		static int Main(string[] args)
		{
		uint choose=20;
		while(choose!=0)
		{
			System.Console.WriteLine("Введите номер задания:");
			System.Console.WriteLine("1.Большее из 2-х чисел");
			System.Console.WriteLine("2.Кот или собака");
			System.Console.WriteLine("3.Время года");
			System.Console.WriteLine("4.Хорошо или плохо");
			System.Console.WriteLine("5.День недели");
			System.Console.WriteLine("6.Такси");
			System.Console.WriteLine("7.Простое число");
			System.Console.WriteLine("8.Лотерея");
			System.Console.WriteLine("9.Валюты");
			System.Console.WriteLine("10.Таблица умножения");
			System.Console.WriteLine("11.Разряды");
			System.Console.WriteLine("12.Угадать число");
			System.Console.WriteLine("13.Квадраты");
			System.Console.WriteLine("14.Среднее арифметическое (с клавиатуры)");
			System.Console.WriteLine("15.Среднее арифметическое (случайные числа)");
			System.Console.WriteLine("16.Гуси и кролики");
			System.Console.WriteLine("17.Проверка пароля");
			System.Console.WriteLine(" ");
			System.Console.WriteLine("0.Выход");
			choose = uint.Parse(System.Console.ReadLine());
			switch(choose)
			{
				case 1:
				Task1_max_number();
				break;

				case 2:
				Task2_animals();
				break;

				case 3:
				Task3_seasons();
				break;

				case 4:
				Task4_goodorbad();
				break;

				case 5:
				Task5_dayofweek();
				break;

				case 6:
				Task6_taxi();
				break;

				case 7:
				Task7_simple();
				break;

				case 8:
				Task8_luckynumber();
				break;

				case 9:
				Task9_moneyconverter();
				break;

				case 10:
				Task1_multtable();
				break;

				case 11:
				Task2_rozryady();
				break;

				case 12:
				Task3_guess();
				break;

				case 13:
				Task4_square();
				break;

				case 14:
				Task5_arifmet();
				break;

				case 15:
				Task6_randarifmet();
				break;

				case 16:
				Task7_ducksandrabbits();
				break;

				case 17:
				Task8_password();
				break;
			
				case 0:
				break;
			}		
		
		}
		return 0;
		}

		//блок 1 

		static void Task1_max_number()
		{
			double a,b;
			a=double.Parse(System.Console.ReadLine());
			b=double.Parse(System.Console.ReadLine());
			if (a>b) 
				System.Console.WriteLine("Большее число " + a);
			else  
				System.Console.WriteLine("Большее число " + b);
		}	

		static void Task2_animals()
		{
			string voice=System.Console.ReadLine();
			if (voice=="мяу") 
				System.Console.WriteLine("Покорми кота.");
			else if (voice=="гав") 
				System.Console.WriteLine("Погуляй с собакой.");
			else
				System.Console.WriteLine("Не понятно.");
		}	

		static void Task3_seasons()
		{
			byte month=byte.Parse(System.Console.ReadLine());
			if (month==12 || month==1 || month==2) 
				System.Console.WriteLine("Зима");
			else if (month>=3 && month<=5) 
				System.Console.WriteLine("Весна");
			else if (month>=6 && month<=8) 
				System.Console.WriteLine("Лето");
			else if (month>=9 && month<=11) 
				System.Console.WriteLine("Осень");
			else
				System.Console.WriteLine("Не понятно.");
		}	

		static void Task4_goodorbad()
		{
			byte variable=byte.Parse(System.Console.ReadLine());
			System.Console.WriteLine(variable==0 ? "Плохо." : "Хорошо.");
		}

		static void Task5_dayofweek()
		{
			byte day=byte.Parse(System.Console.ReadLine());
			switch (day)
			{
				case 1:
					System.Console.WriteLine("Понедельник");
					break;
				case 2:
					System.Console.WriteLine("Вторник");
					break;
				case 3:
					System.Console.WriteLine("Среда");
					break;
				case 4:
					System.Console.WriteLine("Четверг");
					break;
				case 5:
					System.Console.WriteLine("Пятница");
					break;
				case 6:
					System.Console.WriteLine("Суббота");
					break;
				case 7:
					System.Console.WriteLine("Воскресенье");
					break;
				default:
					System.Console.WriteLine("Не понятно");
					break;
			}
		}

		static void Task6_taxi()
		{
			System.Console.WriteLine("Введите количество километров:");	
			uint km=uint.Parse(System.Console.ReadLine());
			System.Console.WriteLine("Введите количество минут простоя:");	
			uint min=uint.Parse(System.Console.ReadLine());
			if (km>5) km=100+(km-5)*3;
			else km*=5;
			uint result=km+min;
			System.Console.WriteLine("Всего к оплате: " + result + "грн");	
		}

		static void Task7_simple()
		{
			bool flag=true;
			uint variable = uint.Parse(System.Console.ReadLine());
			for(int i=2;i<System.Math.Sqrt(variable);i++)
				if(variable%i==0)flag=false;
			if(flag)System.Console.WriteLine("Число простое");	
			else System.Console.WriteLine("Число сложенное");
		}
	
		static void Task8_luckynumber()
		{	
			System.Random rnd=new System.Random();
			System.Console.WriteLine("Введите ставку:");	
			uint input=uint.Parse(System.Console.ReadLine());
			int number=rnd.Next(1,12);
			System.Console.WriteLine("Выпало число " + number);
			if(number<=5)System.Console.WriteLine("Вы проиграли");
			else if (number>=6 && number<=8)System.Console.WriteLine("Ваш приз = " + input);
			else if (number>=9 && number<=11)System.Console.WriteLine("Ваш приз = " + input*2);
			else System.Console.WriteLine("Ваш приз = " + input*10);
		}

		static void Task9_moneyconverter()
		{	
			System.Console.WriteLine("Введите сумму:");
			double summ=double.Parse(System.Console.ReadLine());
			System.Console.WriteLine("Сумму в какой валюте вы ввели?");
			System.Console.WriteLine("1.Гривны");
			System.Console.WriteLine("2.Доллары");
			System.Console.WriteLine("3.Евро");
			uint choose = uint.Parse(System.Console.ReadLine());
			switch (choose)
			{
				case 1:
					System.Console.WriteLine("Ваша сумма равна:");
					System.Console.WriteLine(summ/26.984 + " долларов");
					System.Console.WriteLine(summ/29.168 + " евро");
					break;
				case 2:
					System.Console.WriteLine("Ваша сумма равна:");
					System.Console.WriteLine(summ*26.984 + " гривен");
					System.Console.WriteLine(summ*0.913 + " евро");
					break;
				case 3:
					System.Console.WriteLine("Ваша сумма равна:");
					System.Console.WriteLine(summ*29.168 + " гривен");
					System.Console.WriteLine(summ/0.913 + " долларов");
					break;
				default:
					break;
			}
		}

		//блок 2

		static void Task1_multtable()
		{	
			double number=double.Parse(System.Console.ReadLine());
			for(int i=1;i<=20;i++)
				System.Console.WriteLine(number + " * " + i + " = " + number*i);
		}

		static void Task2_rozryady()
		{	
			uint number = uint.Parse(System.Console.ReadLine());
			uint count = 0;
			while (number!=0)
			{
				count++;
				number/=10;
			}
			System.Console.WriteLine("Количество разрядов в числе: " + count);
		}

		static void Task3_guess()
		{	
			System.Random rnd=new System.Random();
			int number=rnd.Next(1,146);
			int guess=0;
			while(guess!=number)
			{
				guess=int.Parse(System.Console.ReadLine());
				if(guess>number) System.Console.WriteLine("Меньше");
				else if (guess<number) System.Console.WriteLine("Больше");
			}
			System.Console.WriteLine("Вы победили! Было загаданно число " + number);
		}

		static void Task4_square()
		{	
			uint number=uint.Parse(System.Console.ReadLine());
			uint counter = 0;
			while((counter*counter)<number)
			{
				System.Console.WriteLine(counter + "^2 = " + counter*counter);
				counter++;
			}	
		}

		static void Task5_arifmet()
		{	
			double number,summ=0;
			for (int i=0;i<5;i++)
			{
				number=double.Parse(System.Console.ReadLine());
				summ+=number;
			}		
			System.Console.WriteLine("Среднее арифметическое = " + summ/5);	
		}

		static void Task6_randarifmet()
		{	
			System.Random rnd = new System.Random();		
			double summ=0,temp;
			for (int i=0;i<5;i++)
			{
				temp=rnd.Next(1,100);
				System.Console.WriteLine(i+1 + "е число = " + temp);
				summ+=temp;
			}		
			System.Console.WriteLine("Среднее арифметическое = " + summ/5);	
		}

		static void Task7_ducksandrabbits()
		{			
			System.Console.WriteLine("При условии,что у кроликов и гусей всего 64 лапы");	
			System.Console.WriteLine("Возможны следующие сочетания:");
			uint ducks,rabbits;
			for(uint i=0;i<=64;i++)
			{
				ducks=i;
				rabbits=64-i;
				if(ducks%2==0 && rabbits%4==0)
					System.Console.WriteLine(ducks/2 + " гусей и " + rabbits/4 + " кроликов");
			}
		}

		static void Task8_password()
		{			
			string true_pass="root";
			string pass="";
			do
			{   
				System.Console.WriteLine("Неверный пароль! Попробуйте снова:");
				pass=System.Console.ReadLine();
			}
			while(true_pass!=pass);
			System.Console.WriteLine("Вход выполнен.");
		}

	//дно класса
	}
//дно пространства имен
}
