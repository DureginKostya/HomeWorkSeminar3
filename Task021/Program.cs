/*Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.*/
Console.Clear();
void GetUserValue(int[,] MatrixPoints, int Count)
{
    for (int i = 0; i < Count; i++)
    {
        Console.WriteLine($"Введите координаты точки № {i + 1}:");
        CreateMatrix(MatrixPoints, i);
        Console.WriteLine();
    }
}
void CreateMatrix(int[,] Matrix, int Index)
{
    for (int i = 0; i < 3; i++)
    {
       switch (i)
       {
            case 0:
            {
                Console.Write("ось X: ");
                Matrix[Index, i] = int.Parse(Console.ReadLine()!);
                break;
            }
            case 1:
            {
                Console.Write("ось Y: ");
                Matrix[Index, i] = int.Parse(Console.ReadLine()!);
                break;                
            }
            case 2:
            {
                Console.Write("ось Z: ");
                Matrix[Index, i] = int.Parse(Console.ReadLine()!);
                break;
            }
       } 
    }
}
double Distance(int[,] MatrixCoordinates)
{
    int Sum = 0;    
    int Diff = 0;
    for (int i = 0; i < 3; i++)
    {
        Diff =  MatrixCoordinates[1, i] - MatrixCoordinates[0, i];
        Sum = Sum + (int)Math.Pow(Diff, 2);
    }
    double Spacing = Math.Sqrt(Sum);
    return Spacing;
}
int[,] TwoPoints = new int[2, 3];
GetUserValue(TwoPoints, 2);
double DistancePoints = Math.Round(Distance(TwoPoints), 3);
Console.WriteLine($"Расстояние между точкой № 1 (координаты: X={TwoPoints[0, 0]}; Y={TwoPoints[0, 1]}; Z={TwoPoints[0, 2]}) и точкой № 2 (координаты: X={TwoPoints[1, 0]}; Y={TwoPoints[1, 1]}; Z={TwoPoints[1, 2]}) равно {DistancePoints}");