namespace Test_Area
{
    public static class OutputManager
    {
        //для примера добавил статичный класс который будет выводить периметр фигуры в консоль
        //также при условии расширения проекта можно избавиться от жесткой зависимости класса Console
        //через определение делегата и события OnMessege
        public static void PrintShapeArea(ShapeAbstract shape)
        {
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}
