namespace Bibliotekarz.Model
{
    public class Customer : EntityBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public override void Test()
        {
            throw new System.NotImplementedException();
        }
    }
}