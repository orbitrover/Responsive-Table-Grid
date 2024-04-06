using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IPizzaServices
    {
        public List<Pizza> GetAll();
        public Pizza Get(int id);
        public List<Pizza> Add(Pizza pizza);
        public List<Pizza> Update(Pizza pizza, int id);
        public List<Pizza> Delete(int id);
    }
}
