class Presentation
{
    public int Width { get; set; }
    public int Height { get; set; }
    public void Copy()
    {
        System.Console.WriteLine("Obj copied");
    }
    public void Duplicate()
    {
        System.Console.WriteLine("Obj duplicated");
    }
}