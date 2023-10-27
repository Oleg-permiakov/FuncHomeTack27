// Принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int namber = Convert.ToInt32(Console.ReadLine());
int res = 0;
int res1 = 0;

int CreateSum(int namber) {

while (namber > 10)
{
    res1 = namber % 10;
    res = res + res1;
    namber = namber / 10;
}
res = res + namber;
return res;

}
int result = CreateSum(namber);
Console.WriteLine("Сумма цифр будет - " + result);
