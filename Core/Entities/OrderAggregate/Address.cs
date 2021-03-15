namespace Core.Entities.OrderAggregate
{
    public class Address
    {
        public Address() 
        {    
        }
        public Address(string name, string street, string ward, string district, string city, string zipcode) 
        {
            this.Name = name;
            this.Street = street;
            this.Ward = ward;
            this.District = district;
            this.City = city;
            this.Zipcode = zipcode;
        }

        public string Name { get; set; }
        public string Street { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
    }
}