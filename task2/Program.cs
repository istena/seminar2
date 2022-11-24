Console.Clear();
Console.WriteLine("Введите последовательность чисел ");
int [] a= new int[100];
a[0]= Convert.ToInt32(Console.ReadLine());
int i=0;
do{
    i++;
    a[i]= Convert.ToInt32(Console.ReadLine()); 
}
while(a[i]!=0);
int firstmax,secondmax;
if (a[0]>a[1]){
    firstmax=a[0];
    secondmax=a[1];
}
else{
     firstmax=a[1];
    secondmax=a[0];
}
for (int j=2;j<i;j++){
    if (a[j]>=firstmax)
    {
        secondmax=firstmax;
        firstmax=a[j];
    }
    else if(a[j]>secondmax)
        secondmax=a[j];
}


Console.WriteLine($"Второе максимальное число {secondmax} ");
