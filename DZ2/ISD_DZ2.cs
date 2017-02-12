namespace Fight
{
	class Fighter
	{
		private int healthPoints;
		private int blockValue;

		public Fighter()
		{
			healthPoints = 20;		
		}
		
		public void HeadPunch()
		{
			if(healthPoints < 10)
				healthPoints=0;
			else
				healthPoints-=10;
		}		

		public void BodyPunch()
		{
			if(healthPoints < 7)
				healthPoints=0;
			else
				healthPoints-=7;
		}

		public void LegsPunch()
		{
			if(healthPoints < 5)
				healthPoints=0;
			else
				healthPoints-=5;
		}

		public int getHealth()
		{
			return healthPoints;
		}
		
		public int getBlock()
		{
			return blockValue;
		}

		public void setBlock(int bv)
		{
			blockValue=bv;
		}
		
	}

	class MainClass
	{
		static int Main(string[] args)
		{
			Fighter player=new Fighter();
			Fighter enemy=new Fighter();
			System.Random rnd = new System.Random();
			int move=rnd.Next(1,2);
			if(move==1)
				System.Console.WriteLine("Боги рандома решили, что вы будете ходить первым!");
			else
				System.Console.WriteLine("Боги рандома решили, что первым будет ходить компьютер!");
			do
			{
				if(move==1)
				{	
					System.Console.WriteLine("");
					uint punch;
					System.Console.WriteLine("Выберите,куда ударить!");
					punch=uint.Parse(System.Console.ReadLine());
					int block=rnd.Next(1,3);					
					enemy.setBlock(block);
					if(enemy.getBlock()==punch)
						System.Console.WriteLine("Противник заблокировал удар!");
					else
					{
						System.Console.WriteLine("Вы попали по противнику!");
						switch (punch)
						{
							case 1:
							enemy.HeadPunch();
							break;

							case 2:
							enemy.BodyPunch();
							break;

							case 3:
							enemy.LegsPunch();
							break;
						}
					}
					System.Console.WriteLine("Ваше здоровье:" + player.getHealth());
					System.Console.WriteLine("Здоровье противника:" + enemy.getHealth());
					move=2;
				}
				else
				{
					System.Console.WriteLine("");
					int punch=rnd.Next(1,3);
					System.Console.WriteLine("Выберите,какую часть тела заблокировать:");
					player.setBlock(int.Parse(System.Console.ReadLine()));
					if(player.getBlock()==punch)
						System.Console.WriteLine("Вы заблокировали удар!");
					else
					{
						System.Console.WriteLine("Противник ударил вас!");
						switch (punch)
						{
							case 1:
							player.HeadPunch();
							break;

							case 2:
							player.BodyPunch();
							break;

							case 3:
							player.LegsPunch();
							break;
						}
					}
					System.Console.WriteLine("Ваше здоровье:" + player.getHealth());
					System.Console.WriteLine("Здоровье противника:" + enemy.getHealth());
					move=1;
				}
			}
			while(player.getHealth()!=0 && enemy.getHealth()!=0);

			if(enemy.getHealth()==0)
				System.Console.WriteLine("Поздравляем! Вы одолели противника!");
			else
				System.Console.WriteLine("Вы проиграли. Противник одолел вас :-(");
			return 0;
		}
	}	
}
