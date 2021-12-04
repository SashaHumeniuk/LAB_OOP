interface IFigure
{
    string sizeFigure { get; }
    string Type();
    string Square();
    string Length();
}
interface IColoredFigure : IFigure
{
    string name { get; }
}
class Rectangle : IFigure
{
    protected double a { get; set; }
    protected double b { get; set; }
    public Rectangle(double A, double B)
    {
        this.a = A;
        this.b = B;
    }
    public string sizeFigure
    {
        get
        {
            return $"Розмiр фiгури: A = {a}, B = {b}";
        }
    }
    public string Length()
    {
        double d = Math.Round(Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2)), 2);
        return $"Довжина дiагоналi фiгури = {d}";
    }
    public string Square()
    {
        double s = Math.Round(a * b, 2);
        return $"Площа фiгури = {s}";
    }
    public string Type()
    {
        return "Тип: прямокутник";
    }
}
class ColoredRectangle : Rectangle, IColoredFigure
{
    protected string color { get; set; }
    public string name { get; set; }
    public ColoredRectangle(double A, double B, string C) : base(A, B)
    {
        this.color = C;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Rectangle[] rectangle = {
 new Rectangle (2.5, 1.5),
 new Rectangle (6.5, 3.5),
 new Rectangle (7.5, 5.5)
 };
        foreach (Rectangle str in rectangle)
        {

            Console.WriteLine($"{str.Type()}\n{str.sizeFigure}\n{str.Square()}\n{str.Length()}");
        }
    }
}