int x = 10;
int y = 1;

int Randomizer()
{
    int random = new Random().Next(1,4);
    return random;
}

int random = Randomizer();

void RandomFigure(int number)
{
    switch (number)
    {
        case 1://FigureCube
            {
                   Console.Clear();
                   for (int i = x - 1; i <= x; i++)
                   {
                       for (int j = y - 1; j <= y; j++)
                       {
                            Console.SetCursorPosition(i, j);
                            Console.Write("+");
                       }
                   }
                   break;
            }
        case 2://FigureLine
            {
                   Console.Clear();
                   for (int i = x - 1; i <= x-1; i++)
                   {
                       for (int j = y - 1; j <= y+2; j++)
                       {
                            Console.SetCursorPosition(i, j);
                            Console.Write("+");
                       }
                   }
                   break;
            }
        case 3:// FigureL
            {
                   Console.Clear();
                   for (int i = x - 1; i <= x-1; i++)
                   {
                       for (int j = y - 1; j <= y+1; j++)
                       {
                            Console.SetCursorPosition(i, j);
                            Console.Write("+");
                       }
                   }
                   for (int i = x - 1; i <= x-1; i++)
                   {
                        for (int j = y - 1; j <= y-1; j++)
                        {
                            Console.SetCursorPosition(i+1, j+2);
                            Console.Write("+");
                        }
                   }
                   break;
            }     
    }
}
// Логика отрисовки всего

void FigureMovment(int timer)
{
    RandomFigure(random);
    Thread.Sleep(timer);
    y++;
}

int timer = 888;
new Thread(() =>
{
  while (true)
  {
    FigureMovment(timer);
   if (y > 15)
        {
            x = 10;
            y = 1;
            random = Randomizer();
            FigureMovment(timer);
            timer = 888;
        }     
  }
}).Start();



// Логика проверки нажатия кнопок
while (true)
{
  var key = Console.ReadKey(true).Key;

  if (key == ConsoleKey.LeftArrow && x != 1)
  {
        x--;
        RandomFigure(random);
  }
  if (key == ConsoleKey.RightArrow && x != 19)
  {
        x++;
        RandomFigure(random);
  }
  if (key == ConsoleKey.DownArrow && y != 1)
  {
        timer = 50;
        FigureMovment(timer);
        RandomFigure(random);
  }
}

