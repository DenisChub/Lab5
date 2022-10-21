namespace ClassRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            ClassRoom classRoom = new ClassRoom(new ExcelentPupil(), new BadPupil(), new GoodPupil());
            classRoom.ShowPupils();
        }
    }
}
