// See https://aka.ms/new-console-template for more information
Console.WriteLine("Numeros Amistosos");
Console.WriteLine("Ingrese el rango maximo para calcular numeros amistosos");
int rango = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
List<int> SumaDivisores = new();
SumaDivisores.Add(0);
SumaDivisores.Add(1);
int NInicio = 0; int NRebote = 0; int medio = 0;
int Contador = 3; int Sumatoria = 0;
while (Contador <= rango)
{
    medio = Contador/2;
    for (int i = 1; i < Contador; i++)
    {
        if(i > medio)
        {
            break;
        }
        if (Contador % i == 0)
        {
            Sumatoria += i;
        }

    }
    SumaDivisores.Add(Sumatoria);
    //Console.WriteLine(Sumatoria);
    Sumatoria = 0;
    Contador += 1;
}
/* Console.WriteLine("Salimos priemer ciclo");
Console.WriteLine(SumaDivisores.Count);
Console.WriteLine(SumaDivisores[19]); */
for (int i = 1; i < SumaDivisores.Count-1; i++)
{
    NInicio = SumaDivisores[i];
    if (NInicio < i + 1)
    {
        NRebote = SumaDivisores[NInicio - 1];
        if (NRebote == i + 1  )
        {
            Console.WriteLine("Si coincidio "+NRebote+" "+NInicio);
        }else
        {
            //Console.WriteLine("NO coincidio");
        }
    }

}
