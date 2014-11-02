using System; using System.Xml;
using System.IO; 
namespace ConsoleApplication3 
{ 
    class Program 
    { 
        static void Main(string[] args)
        {
            FileStream aFile = new FileStream(@"F:\TradingStrategy\MQ\data\futuretick\20120104\IF9999.tk", FileMode.Open);
            StreamReader sw = new StreamReader(aFile);
            string str=sw.ReadLine();
            BinaryReader sn = new BinaryReader(aFile);
            double d = sn.ReadDouble();
            char[] m = sn.ReadChars(10);
            string st=sn.ReadString();
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}