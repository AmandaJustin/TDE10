Retangulo R1 = new Retangulo();
Retangulo R2 = new Retangulo(5);
Retangulo R3 = new Retangulo(4, 6);

Console.WriteLine($"A area do retangulo R1 = {R1.CalculaArea()}");
Console.WriteLine($"O perimetro do retangulo R1 = {R1.CalcularPerimetro()}");

Console.WriteLine($"A area do retangulo R2 = {R2.CalculaArea()}");
Console.WriteLine($"O perimetro do retangulo R2 = {R2.CalcularPerimetro()}");

Console.WriteLine($"A area do retangulo R3 = {R3.CalculaArea()}");
Console.WriteLine($"O perimetro do retangulo R3 = {R3.CalcularPerimetro()}");

R3.Redimensionar(2);
Console.WriteLine($"A area do retangulo R3 = {R3.CalculaArea()}");
Console.WriteLine($"O perimetro do retangulo R3 = {R3.CalcularPerimetro()}");

R2.Redimensionar(10, 15);
Console.WriteLine($"A area do retangulo R2 = {R2.CalculaArea()}");
Console.WriteLine($"O perimetro do retangulo R2 = {R2.CalcularPerimetro()}");
