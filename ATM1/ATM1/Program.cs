using System;

namespace atm_program
{
	class ab
	{
		static void Main(String[] args)
		{
			int amt = 0, dep, wit, pin = 09090, pin1;

			while (true)
			{
				Console.WriteLine("Enter the pin");
				pin1 = int.Parse(Console.ReadLine());

				if (pin1 == pin)
				{
					Console.WriteLine("1.To check balance");
					Console.WriteLine("2.To withdraw money");
					Console.WriteLine("3.To deposite Money");
					Console.WriteLine("4.To Cancel Transaction");
					Console.WriteLine("Enter your choice");
					int ch = int.Parse(Console.ReadLine());
					switch (ch)
					{
						case 1:
							Console.WriteLine("The current balance in your account is: {0}" + amt);
							break;

						case 2:
							Console.Clear();
							Console.WriteLine("Enter the withdrawal amount \n");


							wit = int.Parse(Console.ReadLine());
							if (wit % 100 != 0)
							{
								Console.Clear();
								Console.WriteLine("Invalid Amount! Must be a multiple of 100: \n");
								Console.WriteLine("Example: 100, 200, 500, 1000");
							}
							else if (wit > (amt - 0))
							{
								Console.WriteLine("Insufficient balance \n");
							}
							else
							{
								Console.Clear();
								amt = amt - wit;
								Console.WriteLine("You have withdrawn {0} \n", wit);
								Console.WriteLine("Your new balance is {0} \n", amt);
							}
							break;

						case 3:
							Console.Clear();
							Console.WriteLine("Enter the amount to deposit: \n");
							dep = int.Parse(Console.ReadLine());
							amt = amt + dep;
							Console.Clear();
							Console.WriteLine("Your balance is: {0} \n", amt);
							break;

						case 4:
							Console.Clear();
							Console.WriteLine("Transaction Cancelled \n");
							break;

					}
					if (ch == 4)
					{
						Console.WriteLine("Press enter to exit.");
						Console.ReadKey();
						break;
					}
				}
			}
		}

	}
}