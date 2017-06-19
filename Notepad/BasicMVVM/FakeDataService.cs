using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMVVM
{
    public class FakeDataService
    {
        public PersonModel GetPersonFromDatabase()
        {
            return new PersonModel
            {
                Id = Guid.NewGuid(),
                Name = "Jack",
                Birthday = new DateTime(2000, 12, 1)
            };
        }
    }
}
