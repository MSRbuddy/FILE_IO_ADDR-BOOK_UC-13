class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string PhNo { get; set; }
    public string Mail { get; set; }

    public Person(string firstName, string lastName, string address, string city, string state, string zip, string phno, string mailid)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Address = address;
        this.City = city;
        this.State = state;
        this.Zip = zip;
        this.PhNo = phno;
        this.Mail = mailid;
    }
}
