namespace Store.Domain.Entities
{
    public class Product : Entity
    {
        public Product(string title, decimal price, bool active)
        {
            Title = title;
            Price = price;
            Active = active;
        }

        public string Title {get; private set;}
        public decimal Price {get; private set;}
        public bool Active {get; private set;}

        /*
            Se quiser alterar as informações você deve criar um método

            Exemplo:

            public void ChangeInfo(string title, decimal price, bool active) 
            {
                Title = title;
                Price = price;
                Active = active;
            }
        */
    }
}