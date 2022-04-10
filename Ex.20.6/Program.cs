// See https://aka.ms/new-console-template for more information
using Ex._20._6;

//Age is in months
Animal[] animals = {new Cat()           { Name = "catty", Age = 40},
                    new TomCat()        { Name = "tommy", Age = 31},
                    new Frog()          { Name = "froggy", Age = 14},
                    new Kitten()        { Name = "kit", Age = 21},
                    new Dog()           { Name = "flash", Age = 9}
};


int length = animals.Length;
for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Name: {animals[i].Name}");
    Console.WriteLine($"Age: {animals[i].Age} months");
    Console.Write("Sound: ");
    animals[i].MakeSound();
    Console.WriteLine();
}