char[,] field = new char[20, 16];
int timer = 555;
int coordX = field.GetLength(1) / 2;
int coordY = 0;
char bgChar = '.';
char figuresChar = Convert.ToChar(9632);
char[,] figure;
char[,] line = new char[1, 4] { { figuresChar, figuresChar, figuresChar, figuresChar } };
char[,] square = new char[2, 2] { { figuresChar, figuresChar }, { figuresChar, figuresChar } };
char[,] angle_left = new char[3, 2] { { bgChar, figuresChar }, { bgChar, figuresChar }, { figuresChar, figuresChar } };
char[,] angle_right = new char[3, 2] { { figuresChar, bgChar }, { figuresChar, bgChar }, { figuresChar, figuresChar } };
char[,] sig_left = new char[3, 2] { { figuresChar, bgChar }, { figuresChar, figuresChar }, { bgChar, figuresChar } };
char[,] sig_right = new char[3, 2] { { bgChar, figuresChar }, { figuresChar, figuresChar }, { figuresChar, bgChar } };
char[,] snake_left = new char[3, 3] { { figuresChar, bgChar, bgChar }, { figuresChar, figuresChar, figuresChar }, { bgChar, bgChar, figuresChar } };
char[,] snake_right = new char[3, 3] { { bgChar, bgChar, figuresChar }, { figuresChar, figuresChar, figuresChar }, { figuresChar, bgChar, bgChar } };

bool collision = false;

List<char[,]> list_figures = new List<char[,]> { line, square, angle_left, angle_right, sig_left, sig_right };

char[,] FieldFill(char[,] field)
{
    for (int i = 0; i < field.GetLength(0); i++)
    {
        for (int j = 0; j < field.GetLength(1); j++)
        {
            field[i, j] = bgChar;
        }
    }
    return field;
}
field = FieldFill(field);



void Print(char[,] input)
{
    Console.Clear();
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);
        }
        Console.WriteLine();
    }
}
Print(field);

figure = list_figures[Random.Shared.Next(0, list_figures.Count)];

char[,] PlaceFigure(char[,] field, char[,] figure)
{
    for (int i = 0; i < figure.GetLength(0); i++)
    {
        for (int j = 0; j < figure.GetLength(1); j++)
        {
            field[i + coordY, j + coordX] = figure[i, j];
        }

    }
    return field;
}


bool Collision(char[,] field, char[,] figure)
{
    bool result = false;
    for (int i = 0; i < figure.GetLength(0); i++)
    {
        for (int j = 0; j < figure.GetLength(1); j++)
        {
            if (field[j + figure.GetLength(0) + 1, i + figure.GetLength(0)] != bgChar)
            {
                result = true;
                break;

            }
        }
        if (result) break;
    }
    return result;
}
collision = Collision(field, figure);

// Логика отрисовки
void FigureMovment(int timer)
{
    PlaceFigure(field, figure);
    Print(field);
    Thread.Sleep(timer);
    coordY++;
    field = FieldFill(field);

}


new Thread(() =>
{
    while (true)
    {
        FigureMovment(timer);
        if (coordY > 18)
        {
            coordX = field.GetLength(0) / 2 - 1;
            coordY = 1;
            figure = list_figures[Random.Shared.Next(0, list_figures.Count)];
            FigureMovment(timer);
            timer = 888;
        }
    }
}).Start();

// Логика проверки нажатия кнопок
while (true)
{
    var key = Console.ReadKey(true).Key;

    if (key == ConsoleKey.LeftArrow && coordX != 0)
    {
        coordX--;
        PlaceFigure(field, figure);
    }
    if (key == ConsoleKey.RightArrow && coordX != field.GetLength(1) - 2)
    {
        coordX++;
        PlaceFigure(field, figure);
    }
    if (key == ConsoleKey.DownArrow && coordY != field.GetLength(0) + 1)
    {
        timer = 50;
        FigureMovment(timer);
        PlaceFigure(field, figure);
    }
}

//field = PrintFigure(field, RandomFigure(random));
/*void RandomFigure(int number)
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
                for (int i = x - 1; i <= x - 1; i++)
                {
                    for (int j = y - 1; j <= y + 2; j++)
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
                for (int i = x - 1; i <= x - 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write("+");
                    }
                }
                for (int i = x - 1; i <= x - 1; i++)
                {
                    for (int j = y - 1; j <= y - 1; j++)
                    {
                        Console.SetCursorPosition(i + 1, j + 2);
                        Console.Write("+");
                    }
                }
                break;
            }
    }
}*/