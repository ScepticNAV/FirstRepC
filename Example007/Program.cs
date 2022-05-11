// Рисунок с точками, являющимися серединами отрезков
Console.Clear();

//Console.SetCursorPosition(10, 4); //10 - отступ столбцов от левого края экрана, 4 - отступ строк от верхнего края экрана, нумерация с 0
//Console.WriteLine("*") - отображает символ * на экране;

//Определяем вершины треугольника (координаты вершин)

int xa = 40; //отступ от левого края первой точки (вершины1)
int ya = 1; //отступ от верхнего края первой точки (вершины1)

int xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

int x = xa, y = ya;

int count = 0;

while(count < 10000)
{
    int randNum = new Random().Next(0, 3); // (0,1,2)

    if(randNum == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

     if(randNum == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(randNum == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count++; //count = count + 1

} 