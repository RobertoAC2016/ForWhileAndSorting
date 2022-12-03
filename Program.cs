// See https://aka.ms/new-console-template for more information
Console.WriteLine("Uso del ciclo for de forma acescente y de forma descendente");

////Ciclo for de forma acendente

int numeroDeCiclos = 10;

for (int x = 0; x < numeroDeCiclos; x++)
{
    Console.WriteLine($"For ASC, X es el valor de la posicion actual: {x}");
}


// Ciclo for de forma descendente

for (int x = numeroDeCiclos - 1; x >= 0; x--)
{
    Console.WriteLine($"For DESC, X es el valor de la posicion actual: {x}");
}


//  Ahora usaremos while como sentencia para realizar el ciclo

int idx = 0;
while (idx < numeroDeCiclos)
{
    Console.WriteLine($"While ASC, X es el valor de la posicion actual: {idx}");
    idx++;
}

//  Usando ciclo while descendente

idx = numeroDeCiclos - 1;
while (idx >= 0)
{
    Console.WriteLine($"While DESC, X es el valor de la posicion actual: {idx}");
    idx--;
}


//  Veamos como se ordena una lista de modo q tengamos los  numeros de forma ASC y dESC

List<int> nums = new List<int>
{
    34,54,1,2,98,9,5,6,7,8,10,4
};

//  Imprimimos los numeros de la lista previo la ordenacion

nums.ForEach(e => {
    Console.WriteLine("Valor: {0}",e);   
});

//Numeros de form ascendente

var nums_asc = nums.OrderBy(e=>e).ToList();


nums_asc.ForEach(e => {
    Console.WriteLine("Valor ASC: {0}", e);
});


//Numeros de forma descendente

var nums_desc = nums.OrderByDescending(e => e).ToList();


nums_desc.ForEach(e => {
    Console.WriteLine("Valor DESC: {0}", e);
});











