using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class CustomerController
    {
        public ActionResult GetCustomer(int id)
        {
            if (id == 0)
                return new NotFound();

            return new Ok();
        }
    }

    public class ActionResult { }

    public class NotFound : ActionResult { }

    public class Ok : ActionResult { }
}
