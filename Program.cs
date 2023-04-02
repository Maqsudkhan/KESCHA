string password = "";
do{
    System.Console.Write("Enter password: ");
    password = Console.ReadLine();
} 
while(password != "Maqsudkhan");

System.Console.WriteLine("Password opened!!!\n");

System.Console.Write("Enter your name: ");
string name = Console.ReadLine();
System.Console.Write("Enter you age: ");
string ageString = Console.ReadLine();
System.Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageString);
System.Console.WriteLine($"Successfully converted! {age}");
int kescha = 3;

System.Console.WriteLine($"You are  older than KESCHA: {age > kescha}");
System.Console.WriteLine($"You are  older than or equal to KESCHA: {age >= kescha}");
System.Console.WriteLine($"You are younger than KESCHA: {age < kescha}");
System.Console.WriteLine($"You are younger than or equal to KESCHA: {age <=kescha}");
System.Console.WriteLine($"Your age  is equal to KESCHA's age: {age == kescha}");
System.Console.WriteLine($"Your age is not equal to KESCHA's age: {age != kescha}");
