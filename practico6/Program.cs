// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

//EJERICIO 1

int intNum=0, aux=0, resto, invertido=0, ceros=0;
bool anda = false;
string? numString="";

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


//EJERCICIO 2

int intMenu=1, num1, num2;
string? auxMenuString = "";
bool menu = false;

while(intMenu != 0)
{
    while (!menu || intMenu < 1 || intMenu > 4)
    {
        Console.WriteLine("Que desea hacer?\n1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir");
        auxMenuString = Console.ReadLine();
        menu = int.TryParse(auxMenuString, out intMenu);
        if(!menu || intMenu < 1 || intMenu > 4)
        {
            Console.WriteLine("Valor ingresado invalido");
        }
    }

    Console.WriteLine("Num 1: ");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Num 2: ");
    num2 = int.Parse(Console.ReadLine());
    switch(intMenu)
    {
        case 1: num1 += num2;
                Console.WriteLine("La suma da: " + num1);
                break;
        case 2: num1 -= num2;
                Console.WriteLine("La resta da: " + num1);
                break;
        case 3: num1 *= num2;
                Console.WriteLine("La multiplicación da: " + num1);
                break;
        case 4: num1 /= num2;
                Console.WriteLine("La división da: " + num1);
                break;
    }

    Console.WriteLine("Desea ingresar otro número? (0: no, 1: si)");
    intMenu = int.Parse(Console.ReadLine());
}
