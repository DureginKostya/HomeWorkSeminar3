/*Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.Clear();
void GetUserValue(int[,] MatrizaPoints, int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Введите координаты точки № {i + 1}:");
        CreateArray(MatrizaPoints, i);
        Console.WriteLine();
    }
}
void CreateArray(int[,] Matriza, int Index)
{
    for (int i = 0; i < 3; i++)
    {
       switch (i)
       {
            case 0:
            {
                Console.Write("ось X: ");
                Matriza[Index, i] = int.Parse(Console.ReadLine()!);
                break;
            }
            case 1:
            {
                Console.Write("ось Y: ");
                Matriza[Index, i] = int.Parse(Console.ReadLine()!);
                break;                
            }
            case 2:
            {
                Console.Write("ось Z: ");
                Matriza[Index, i] = int.Parse(Console.ReadLine()!);
                break;
            }
       } 
    }
}
double CalculationDistance(int[,] CalculationMatriza)
{
    int Sum = 0;    
    int Diff = 0;
    for (int i = 0; i < 3; i++)
    {
        Diff =  CalculationMatriza[1, i] - CalculationMatriza[0, i];
        Sum = Sum + (int)Math.Pow(Diff, 2);
    }
    double Distance = Math.Sqrt(Sum);
    return Distance;
}
int[,] CoordinatesPoints = new int[2, 3];
GetUserValue(CoordinatesPoints, 2);
double DistancePoints = Math.Round(CalculationDistance(CoordinatesPoints), 2);
Console.WriteLine($"Расстояние между точкой № 1 (координаты: X={CoordinatesPoints[0, 0]}; Y={CoordinatesPoints[0, 1]}; Z={CoordinatesPoints[0, 2]}) и точкой № 2 (координаты: X={CoordinatesPoints[1, 0]}; Y={CoordinatesPoints[1, 1]}; Z={CoordinatesPoints[1, 2]}) равно {DistancePoints}");

