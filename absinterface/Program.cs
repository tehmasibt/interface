namespace absinterface
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            #region task-1
            //int say = -1;
            //while (say != 0)
            //{
            //    Console.WriteLine("Asagidakilardan birini sec");
            //    Console.WriteLine("1. Square");
            //    Console.WriteLine("2. Rectangular");
            //    Console.WriteLine("0.hesablama bitdi");
            //    if (!int.TryParse(Console.ReadLine(), out say))
            //    {
            //        Console.WriteLine("Herif daxil edile bilmez");
            //        continue;
            //    }
            //    switch (say)
            //    {
            //        case 1:
            //            Square square = new Square(20);
            //            square.CalcArea();
            //            break;
            //        case 2:
            //            Rectangular rectangular = new Rectangular(10, 4);
            //            rectangular.CalcArea();
            //            break;
            //        case 0:
            //            Console.WriteLine("hesablama bitdi");
            //            break;
            //        default:
            //            Console.WriteLine("dogru ededi daxil edin");
            //            break;
            //    }
            //}
            #endregion

            User user = new("Tagiyev1829","tagi29@example.com");
            Console.WriteLine($"Pre-assigned Id: {user.Id}");
            user.ShowInfo();
           

        }
    }
}
