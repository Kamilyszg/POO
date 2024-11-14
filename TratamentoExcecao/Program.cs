int a = 10, b= 0;
try{
    int resultado = a/b;
    System.Console.WriteLine("Resultado " + resultado);
}catch (DivideByZeroException){
    System.Console.WriteLine("Erro - divisão por zero");
}
    System.Console.WriteLine("Término do programa");

/*
try
{
// Isto causará uma exceção
File.OpenRead("\\downloads\\ArquivoLeitura.txt");
}
catch (FileNotFoundException e)
{
    Console.WriteLine(e.ToString());
    System.Console.WriteLine("Arquivo não encontrado");

}
catch (DirectoryNotFoundException e){
    Console.WriteLine(e.ToString());
    System.Console.WriteLine("Pasta do arquivo não encontrada");
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}
finally{
    System.Console.WriteLine("Feche o arquivo"); //execução obrigatória
}
System.Console.WriteLine("Término do programa");
*/