using System.Diagnostics;

var numerosSequencia = 10000;
var execucoes = 10000;
var stopWatch = new Stopwatch();

stopWatch.Start();
for (int i = 0; i < execucoes; i++)
{
    Fibonacci(0, 1, 1, numerosSequencia);
}
stopWatch.Stop();
Console.WriteLine($"Execuções: {execucoes} - Tempo Total: {stopWatch.ElapsedMilliseconds} ms");
Console.ReadLine();

static void Fibonacci(int first, int second, int processed, int numberSeq)
{
    if (processed < numberSeq)
    {
        Fibonacci(second, first + second, processed + 1, numberSeq);
    }
}
