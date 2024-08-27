namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            object myCar = new object();

            object myCar2 = new object();

            myCar2 = myCar;


            var obj = new
            {
                Name = "John",
                Age = 30
            };//Anonymous type


            Car car = new Car(1, "Toyota");
            System.Console.WriteLine(car.Model);
            Car car2 = new Car(2, "BMW");
            System.Console.WriteLine(car2.Model);
        }
    }

    class Car
    {
        public int Id;
        public string Model;
        public Car(int id, string model)
        {
            Id = id;
            Model = model;
        }
    }
}