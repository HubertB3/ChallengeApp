using System.ComponentModel.Design;

string name = "Ewa";
string sex = "kobieta";
int age = 33;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33 && sex == "kobieta")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex != "kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (name == "Ewa" &&  sex == "kobieta" && age > 18)
{
    Console.WriteLine("Ewa pełnoletnia kobieta");
}