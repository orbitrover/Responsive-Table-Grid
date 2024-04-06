using Core.Models;

namespace Core.Services
{
    public class PizzaServices : IPizzaServices
    {
        private readonly List<Pizza> _Pizza;
        private int _nextId;
        public PizzaServices()
        {
            _Pizza = new List<Pizza> {
                    new Pizza(){Id=1, ItemNumber="123001", PizzaName="Onion Pizza", Description="Onion with Mozerlla Cheez", ItemSize="Large"},
                    new Pizza() { Id=2, ItemNumber="123002", PizzaName="Onion Pizza", Description="Onion with Mozerlla Cheez", ItemSize="Medium"},
                    new Pizza() { Id=3, ItemNumber="123003", PizzaName="Onion Pizza", Description="Onion with Mozerlla Cheez", ItemSize="Small"},
                    new Pizza() { Id=4, ItemNumber="123004", PizzaName="Capiscum Pizza", Description="Capiscum, Onion with Mozerlla Cheez", ItemSize="Large"},
                    new Pizza() { Id=5, ItemNumber="123005", PizzaName="Capiscum Pizza", Description="Capiscum, Onion with Mozerlla Cheez", ItemSize="Medium"},
                    new Pizza() { Id=6, ItemNumber="123006", PizzaName="Capiscum Pizza", Description="Capiscum, Onion with Mozerlla Cheez", ItemSize="Small"}
            };
            _nextId = 7;
        }
        public List<Pizza> GetAll() => _Pizza;
        public Pizza Get(int id) => _Pizza[id];
        public List<Pizza> Add(Pizza pizza)
        {
            pizza.Id = _nextId++;
            _Pizza.Add(pizza);
            return _Pizza;
        }
        public List<Pizza> Update(Pizza pizza, int id)
        {
            var _pizza = _Pizza.FirstOrDefault(p => p.Id == id);
            var index = _Pizza.IndexOf(_pizza);
            if (index == -1) return _Pizza;
            _Pizza[index] = pizza;
            return _Pizza;
        }
        public List<Pizza> Delete(int id)
        {
            var _pizza = _Pizza.FirstOrDefault(p => p.Id == id);
            _Pizza.Remove(_pizza);
            return _Pizza;
        }
    }
}
