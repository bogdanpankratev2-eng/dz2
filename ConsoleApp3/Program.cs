Console.WriteLine("--Улучшенный калькулятор!--");
Console.WriteLine("Введите первое число!");
double firstNum  = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число!");
double twoNum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите оператор +,-,*,/");
string oper = Console.ReadLine();

switch (oper)
{
    case "+":
        Console.WriteLine($"Сложение:{firstNum} + {twoNum} = {firstNum + twoNum}");
        break;

    case "-":
        Console.WriteLine($"Вычетание:{firstNum} - {twoNum} = {firstNum - twoNum}");
        break;

    case "*":
        Console.WriteLine($"Умножение:{firstNum} * {twoNum} = {firstNum * twoNum}");
        break;

    case "/":
        Console.WriteLine($"Деление:{firstNum} / {twoNum} = {firstNum / twoNum}");
        break;

    default:
        Console.WriteLine("Вы ввели не правильное значение");
        break;
}





