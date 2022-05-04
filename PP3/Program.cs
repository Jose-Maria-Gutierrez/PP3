using PP3;

int dato;
double op1, op2;
op1 = op2 = 0;
Suma s = new Suma();
Resta r = new Resta();
Multiplicacion m = new Multiplicacion();
Division d = new Division();

do
{
    do
    {
        Console.WriteLine("1 para sumar\n2 para restar\n3 para multiplicar\n4 para dividir\n0 para salir");
    } while (!int.TryParse(Console.ReadLine(), out dato) || dato<0 || dato>4);

    if (dato!=0)
    {
        do
        {
            Console.WriteLine("ingrese el primer operando");
        } while (!double.TryParse(Console.ReadLine(), out op1));
        do
        {
            Console.WriteLine("ingrese el segundo operando");
        } while (!double.TryParse(Console.ReadLine(), out op2));
    }

    switch (dato)
    {
        case 1: 
            s.valor1 = op1;
            s.valor2 = op2;
            s.operar();
            Console.WriteLine(s.resultado);
            break;
        case 2:
            r.valor1 = op1;
            r.valor2 = op2;
            r.operar();
            Console.WriteLine(r.resultado);
            break;
        case 3:
            m.valor1 = op1;
            m.valor2 = op2;
            m.operar();
            Console.WriteLine(m.resultado);
            break;
        case 4:
            d.valor1 = op1;
            d.valor2 = op2;
            d.operar();
            Console.WriteLine(d.resultado);
            break;
        default:  break;
    }
    Console.ReadKey();
    Console.Clear();
} while (dato!=0);