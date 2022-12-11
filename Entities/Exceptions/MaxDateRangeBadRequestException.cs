using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class MaxDateRangeBadRequestException :BadRequestException
    {
        public MaxDateRangeBadRequestException():base("There is no transaction on this Date")
        {

        }
    }
}
