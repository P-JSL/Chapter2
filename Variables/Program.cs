using System.Xml;

// See https://aka.ms/new-console-template for more information
object height = 1.88;
object name = "Amir";
Console.WriteLine($"{name} is {height} meters tall");

//int length = name.Length();
int length2 = ((string)name).Length;

Console.WriteLine($"{name} has {length2} characters");

//var 사용의 좋은 예
var xml1 = new XmlDocument();

//xml  불필요하에 반복함
XmlDocument xml2 = new XmlDocument();

//var 사용의 나쁜 예
var file1 = File.CreateText(@"C:\someting.txt");

//var 사용의 좋은 예
StreamWriter file2 = File.CreateText(@"C:\someting.txt");

//대상으로 형식화된 new
XmlDocument xml3 = new();

//설정해야하는 필드나 속성이 있는 형식은 다음처럼 형식을 유추 가능
class Persion
{
    public DateTime birthDate;

    Persion kim = new();

    void m()
    {
        kim.birthDate = new(1967, 12, 26);
    }
}