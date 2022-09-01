int x = 10;
int y = 1;


int[,] field = new int[20,16];
int coordX = field.GetLength(1)/2;
int coordY = 0;

List<char[,]> figures = new List<char>()
{
    char[,] field      =new char[16,16];
char[,] fill_field =new char[16,16];
char[,] figure;
char[,] line       =new char[1,4] {{_1,_1,_1,_1}};
char[,] square     =new char[2,2] {{_1,_1},{_1,_1}};
char[,] angle_left =new char[3,2] {{_0,_1},{_0,_1},{_1,_1}};
char[,] angle_right=new char[3,2] {{_1,_0},{_1,_0},{_1,_1}};
char[,] sig_left   =new char[3,2] {{_1,_0},{_1,_1},{_0,_1}};
char[,] sig_right  =new char[3,2] {{_0,_1},{_1,_1},{_1,_0}};
char[,] triangle   =new char[2,3] {{_0,_1,_0},{_1,_1,_1}};
char[,] star       =new char[3,3] {{_0,_1,_0},{_1,_1,_1},{_0,_1,_0}};
char[,] snake_left =new char[3,3] {{_1,_0,_0},{_1,_1,_1},{_0,_0,_1}};
char[,] snake_right=new char[3,3] {{_0,_0,_1},{_1,_1,_1},{_1,_0,_0}};
};

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

