using DeleteLib;

namespace tuples
{
	class Program
	{
		static void Main(string[] args)
		{
			bool operationResult = false;
			string enter = "";

			(string name, string surname, byte age, string login, byte loginLength, bool havingPet, string[] favColors)[] User = new (string, string, byte, string, byte, bool, string[])[3];
			for (int j = 0; j < User.Length; j++)
			{
				Console.WriteLine($"Анкета юзера #{j}:");
				Console.Write("Введите имя: ");
				User[j].name = Console.ReadLine();
				Console.Write("Введите фамилию: ");
				User[j].surname = Console.ReadLine();
                Console.Write("Введите возраст: ");
                User[j].age = byte.Parse(Console.ReadLine());
                Console.Write("Введите логин: ");
				User[j].login = Console.ReadLine();
				User[j].loginLength = (byte)User[j].login.Length;
				Console.WriteLine("Есть ли у Вас животные? Да или Нет");
				User[j].havingPet = (string.Compare(Console.ReadLine(), "Да", true) == 0) ? true : false;

				User[j].favColors = new string[3];
				Console.WriteLine("Введите три Ваших любимых цвета(по английски с большой буквы):");
				for (int i = 0; i < User[j].favColors.Length; i++)
				{
					Console.Write($"Цвет #{i}: ");
					DltSmthg._setCursorPosition(out int x, out int y);
					do
					{
						enter = Console.ReadLine();
						if (Enum.IsDefined(typeof(ConsoleColor), enter))
						{
							User[j].favColors[i] = enter;
							operationResult = true;
						}
						else
						{
							DltSmthg.deleteWrongEnter(x, y, enter);
							operationResult = false;
						}
					} while (!operationResult);
				}
				Console.WriteLine("/*********************************************************/");
			}
		}
	}
}