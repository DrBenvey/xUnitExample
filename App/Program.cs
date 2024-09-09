using BusinessLogic.Helpers;

try
{
    Console.WriteLine("Start");
    string pass = " привет ";
    if (!ValidationHelper.IfPasswordDontContainsCyrillic(pass))
        pass = RandomHelper.RandomLatinString(12);
    Console.WriteLine(pass);
    Console.WriteLine("End");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
finally
{
    Console.ReadLine();
}