using MKcrud.Class;

namespace MKcrud
{
    class RentCar
    {
        public int Id { get; set; }
        public string RentDuration { get; set; }
        public Client RentClient { get; set; }
        public Car RentCars { get; set; }
        public string RentTimeIn { get; set; }
        public string RentTimeOut { get; set; }
        public RentCar() { }
    }
}
