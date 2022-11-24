Console.Clear();
Console.WriteLine("Введите  число");
int a= Convert.ToInt32(Console.ReadLine());
int size=1;
int b=a/10;
while (b!=0){
    b=b/10;
    size++;
}
if (size>=3){
    while(size>3){
    a=a/10;
    size=size-1;
    }
    int x =a%10;
    Console.WriteLine($"Третья цифра {x}");
}
else
    Console.WriteLine("Третьей цифры нет");
