using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCategory : iGameCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                    {
                    new Category { categoryname = "Стратегії", description = "Ігри, в яких запорукою до перемоги є  планування і стратегічне мисення людини" },
                    new Category { categoryname = "3D-Action", description = "Ігри, в яких успіх кравця залежить від його швидкості, реакції та вміння прийняти вірне рішення" },
                    new Category { categoryname = "Симулятри", description = "Ігри, де граваць асоціюється з конкретним персонажем, або лідером команди" },
                    new Category { categoryname = "Пригодницькі", description = "Ігри, у яких керований гравцем герой просувається по сюжету і взаємодіє з ігровим світом." }
                    };
            }
        }
    }
}
