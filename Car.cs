namespace MKcrud
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Trasmission { get; set; }
        public string Color { get; set; }
        public int NumbersDoor { get; set; }

        public Car() { }
        public Car(string model, string brand, string transmission, string color, int numbersDoor)
        {
            this.Model = model;
            this.Brand = brand;
            this.Trasmission = transmission;
            this.Color = color;
            this.NumbersDoor = numbersDoor;
        }
    }
}
