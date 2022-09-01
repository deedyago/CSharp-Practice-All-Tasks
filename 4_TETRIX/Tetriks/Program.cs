

char[,] field = new char[20, 16];
char[,] bgField = new char[20, 16];
int timer = 555;
int coordX = field.GetLength(1) / 2;
int coordY = 0;
char bgChar = '.';
char figuresChar = '+';


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

char[,] FieldFill(char[,] input)
{
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            input[i, j] = bgChar;
        }
    }
    return input;
}
field = FieldFill(field);
bgField = FieldFill(bgField);

char[,] FieldHold(char[,] field)
{
    int k = 0;
    int c = 0;
    for (int i = (coordY+1) - figure.GetLength(0); i < coordY; i++)
    {
        for (int j = coordX + 1; j < coordX + figure.GetLength(1); j++)
        {
            field[i, j] = figure[k, c];
            c++;
        }
        k++;
    }
    return field;
}

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
    if(collision == false)
    {
        for (int i = 0; i < figure.GetLength(0); i++)
        {
            for (int j = 0; j < figure.GetLength(1); j++)
            {
                if(coordY >= 20 - figure.GetLength(0))
                {
                    coordY = 0;
                    coordX = field.GetLength(1)/2;
                }
                field[i + coordY, j + coordX] = figure[i, j];
            }
        }
    }
    else
    {
        Console.WriteLine("GAMEOVER!");
    }
    return field;
}


char[,] RotateFigure(char[,] input)
{
    int inputM = input.GetLength(0);
    int inputN = input.GetLength(1);
    char[,] bufferFigure = new char[inputN, inputM];
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            bufferFigure[j,i] = input[i,j];
        }
    }
    return bufferFigure;
}

bool Collision(char[,] field, char[,] figure)
{
    bool result = true;
    for (int i = 0; i < figure.GetLength(1); i++)
    {
        for (int j = 0; j < figure.GetLength(0); j++)
        {
            if (field[i + figure.GetLength(0) + coordY + 1, j + figure.GetLength(1) + coordX ] == bgChar || coordY != field.GetLength(0) - 3)
            {
                result = false;

            }
        }
    }
    return result;
}
collision = Collision(field, figure);


// Логика отрисовки
void FigureMovment(int timer)
{
    timer = 555;
    PlaceFigure(field, figure);
    Print(field);
    coordY++;
    Thread.Sleep(timer);
    field = FieldFill(field);
    
}


new Thread(() =>
{
    while (true)
    {
        
        if (collision == true)
        {
            field = FieldHold(field);
            coordY = 0;
            coordX = (field.GetLength(0) / 2) - 1;
            timer = 555;
            figure = list_figures[Random.Shared.Next(0, list_figures.Count)];
            FigureMovment(timer);
            PlaceFigure(field, figure);

        }
        else
        {
            FigureMovment(timer);
            PlaceFigure(field, figure);
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
        FigureMovment(timer);
        PlaceFigure(field, figure);
    }
    if (key == ConsoleKey.RightArrow && coordX != field.GetLength(1) - 2)
    {
        coordX++;
        FigureMovment(timer);
        PlaceFigure(field, figure);
    }
    if (key == ConsoleKey.DownArrow && coordY < field.GetLength(0) - 1)
    {
        timer = 50;
        FigureMovment(timer);
        PlaceFigure(field, figure);

    }
    if (key == ConsoleKey.UpArrow)
    {
        figure = RotateFigure(figure);
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