string name = "Ewa";
string gender = "woman";
int age = 33;

if (age < 30 && gender == "woman")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 && gender != "woman")
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}