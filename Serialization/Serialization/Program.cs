using Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;

class Program
{
     public static void Main(string[]args)
    {
        string path = @"D:\\s-s\sample.txt";
        Employee emp =new  Employee(241,"subha");
        FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(stream, emp);
        stream.Close();
        Console.WriteLine("File Created Successfully->" + path);
        Console.ReadLine();

    }

}