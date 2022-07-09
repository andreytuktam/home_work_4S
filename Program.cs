

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

double step(double A, double B){
    double result = 0;
    result = Math.Pow(A, B);
    Console.WriteLine(result);
    return result;
}
//step(3, 5);

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


double sum(double A){
    string B = A.ToString();
    double result = 0;
    double S = 0;
    Console.WriteLine(A);
    for (double i = 1; i <= B.Length; i++){
        result = A / Math.Pow(10, (B.Length - i)) % 10;
        result = Math.Floor(result);
        Console.WriteLine(result);
        S = result + S;
    }
    Console.WriteLine("Сумма цифр в числе " + A + " = " + S);
    return S;
}
//sum(9012);


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


void mass(){
    int lenght = 8;
    int[] eight = new int[lenght];
    Random rnd = new Random();
    int result = 0;
    for (int i = 0; i <= lenght - 1; i++){
        eight[i] = rnd.Next(-10, 10);
        Console.WriteLine(eight[i]);
    }
}
//mass();



