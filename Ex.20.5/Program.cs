// See https://aka.ms/new-console-template for more information
using Ex._20._5;

Shapes[] shapes = new Shapes[] {

new Triangle()    {Width = 2.8f, Height = 3},
new Rectangle() {Width = 2, Height = 3},
new Circle()    {Radius = 3.5},
};

foreach (Shapes shape in shapes)
{
    Console.WriteLine("Shape = {0} surface area = {1:F2}", shape.GetType().Name.PadRight(9, ' '), shape.CalculateSurface());
}