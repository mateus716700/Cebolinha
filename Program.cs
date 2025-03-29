Console.Clear();
string nomeDigitado;
string nomeLeet;
Console.WriteLine();
nomeDigitado = Console.ReadLine()!;
nomeLeet = nomeDigitado.Replace("R","L").
                        Replace("r","l");
Console.WriteLine($" {nomeLeet}!");