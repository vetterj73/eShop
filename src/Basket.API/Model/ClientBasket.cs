namespace Basket.API.Model
{
    public class ClientBasket
    {
        public string ClientId { get; set; }

        public List<BasketItem> Items { get; set; } = [];

        public ClientBasket() { }

        public ClientBasket(string customerId)
        {
            ClientId = customerId;
        }
    }
}
