 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderPOS.Models
{
    public class BartenderRepo

    {
        private static List<DrinkOrder> responses = new List<DrinkOrder>();
        public static IEnumerable<DrinkOrder> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(DrinkOrder response)
        {
            responses.Add(response);
        }
    }
}
