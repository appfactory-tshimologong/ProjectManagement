namespace ProjectManagement.Data
{
    public partial class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
       public Province Province { get; set; }
       public string PostalCode { get; set; }

    }
}
