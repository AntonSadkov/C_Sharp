namespace MyCarsEnum
{
    /*
     * Программа которая выводит автомобили, которые были у меня во владении.
     */
    public class MyCarsEnum
    {
        enum MyCars
        {
            Vaz_2110 = 1,
            Opel_Astra_Body_H,
            Mazda3_Body_BK,
            Volkswagen_Golf_GTI_Body_MK6
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите от 1, до 4, чтобы узнать какие машины у меня были:");

            int numberCars = int.Parse(Console.ReadLine());

            if(numberCars <= 4)
            {
                MyCars myCars = (MyCars)numberCars;
                Console.WriteLine(myCars.ToString());
            }
            else
            {
                Console.WriteLine("Введенно некорректное значение");
            }           
        }
    }
}
