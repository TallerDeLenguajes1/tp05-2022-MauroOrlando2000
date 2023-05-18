// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//EJERICIO 1

int intNum=0, aux=0, resto, invertido=0;
bool anda = false;
string? numString="";
int ceros=0;

while (!anda)
{
    Console.WriteLine("Ingrese un numero entero válido y mayor a 0");
    numString = Console.ReadLine();
    anda = int.TryParse(numString, out intNum);
    if(!anda)
    {
        Console.WriteLine(numString + " no es un numero valido");
    }
    if(intNum < 0)
    {
        Console.WriteLine(intNum + " es un numero menor a 0");
        anda = false;
    }
}

for(int i=0; i<2; i++)
{
    aux = intNum;
    while (anda)
    {
        resto = aux % 10;
        aux /= 10;
        if(i==0)
        {
            ceros++;
        }
        else
        {
            for(int j=0; j<ceros; j++)
            {
                resto *= 10;
            }
            invertido += resto;
            ceros--;
        }
        if(aux == 0)
        {
            anda = false;
        }
    }
    anda = true;
    ceros--;
}

Console.WriteLine("El numero inicial es: " + intNum);
Console.WriteLine("El numero invertido es: " + invertido);