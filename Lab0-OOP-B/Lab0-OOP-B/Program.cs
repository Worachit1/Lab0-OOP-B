// See https://aka.ms/new-console-template for more information
using Lab0_OOP_B;

Student student1 = new Student();
student1.name ="Worachit Thonglert";
student1.weight = 82.5f;

Student student2 = new Student();
student2.name ="Pathipat Mattra";
student2.weight = 60.0f;

Student student3 = new Student();
student3.name ="Thanachok Suwan";
student3.weight = 75.0f;

Student student4 = new Student();
student4.name ="Worachot Thonglert";
student4.weight =78.9f;

Student student5 = new Student();
student5.name ="Naphat Suyoungkoi";
student5.weight = 104.0f;

double avgWeight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight)/5;
Console.WriteLine("avg Weight = {0} kg ", avgWeight);
Console.WriteLine("max Weight = name:{0} , weight: {1} kg", student5.name,student5.weight);
Console.WriteLine("min Weight = name:{0} , weight: {1} kg", student2.name, student2.weight);

Console.WriteLine("name = Worachit Thonglert");
Console.WriteLine("ID = 653450298-2");

