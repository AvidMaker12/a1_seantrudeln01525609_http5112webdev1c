using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace a1_seantrudeln01525609_http5112webdev1c.Controllers
{
    public class HostingCostController : ApiController
    {
        // <summary>
        // Output 3 strings which describe the total hosting cost.
        // </summary>
        // Assignment1 Questions 5   sean trudel
        // Context: the client is being charged $5.50 / FN (FN = fortnight) for web hosting and maintenance, plus an additional 13% HST.
        // The input {id} represents the number of days which has elapsed since the beginning of the hosting.
        // Request1: GET localhost/HostingCost/0 should return 3 strings:   "1 fortnight(s) at $5.50/FN = $5.50 CAD", "HST 13% = $0.72 CAD", "Total = $6.22 CAD"
        // Request2: GET localhost/HostingCost/14 should return 3 strings:  "2 fortnight(s) at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
        // Request3: GET localhost/HostingCost/15 should return 3 strings:  "2 fortnight(s) at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
        // Request4: GET localhost/HostingCost/21 should return 3 strings:  "2 fortnight(s) at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
        // Request5: GET localhost/HostingCost/28 should return 3 strings:  "3 fortnight(s) at $5.50/FN = $16.50 CAD", "HST 13% = $2.14 CAD", "Total = $18.64 CAD"
        public IEnumerable<string> Get(int id)    // requests multiple strings
        {
            // declare variables:
            decimal days = id;                                                                              // make it clear that 'int id' number represents number of days
            decimal fortnights = days / 14;                                                                 // converts number of days into number of fortnights
            decimal fortnightPrice = Decimal.Multiply( fortnights, 550 ) / 100;                             // calculates set price per fortnight
                //Decimal.Round(fortnightPrice, 2);                                                                  // round answer to 2 decimal places
                //Decimal.ToString(fortnightPrice);
                //string.Format("{0:0.00}", fortnightPrice);
            decimal tax = decimal.Multiply( fortnightPrice, 13 ) / 100;                                     // calculates 13% Harmonized Sales Tax (HST)
                //Decimal.Round(tax, 2);                                                                             // round answer to 2 decimal places
                //string.Format("{0:0.00}", tax);
            decimal total = fortnightPrice + tax;                                                           // calculates total price, tax included
                                                                                                            //Decimal.Round(total, 2);                                                                           // round answer to 2 decimal places
                                                                                                            //string.Format("{0:0.00}", total);


            // concatenated string variables:
            string fortnightTotal = fortnights + " fortnight(s) at $5.50/FN = $" + fortnightPrice + " CAD"; // string1 text: display fortnight price
            string taxTotal = "HST 13% = $" + tax + " CAD";                                                 // string2 text: display tax
            string priceTotal = "Total = $" + total + " CAD";                                               // string3 text: display total price

            // if 'int days' is less than 1 then set 'int days' to 1 to charge minimum hosting price.
            if ( days < 1 )
            {
                days = 1;
            }

            // returns multiple strings:
            return new string[] { fortnightTotal, taxTotal, priceTotal };
        }
    }
}
