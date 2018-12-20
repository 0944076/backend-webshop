//product[] producten = _context.product.ToArray();

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using product_model;


namespace beschrijving_Controller
{
 [Route("api/beschrijving")]
    [ApiController]
    public class beschrijvingController : ControllerBase
    {
        private readonly kamerplantContext _context;

        public beschrijvingController(kamerplantContext context)
        {
            _context = context;
        }

        [HttpPut]
        public StatusCodeResult Put()
        {
            try
            {
                
                product[] producten = _context.product.ToArray();
                Random rnd = new Random();

                for (int i = 0; i != (producten.Length); i++ )
                {
                    int randomizer = rnd.Next(1,10);
                    switch(randomizer){
                        case (1):
                            producten[i].beschrijving = "Deze mooie " + producten[i].naam + " is de leukste en lekkerst ruikenede toevoeging tot je woonkamer, nu voor slechts €" + producten[i].prijs.ToString() + "!";
                            break;
                        case (2):
                            producten[i].beschrijving = producten[i].naam + " is de essentiele plant waar een huishouden om draait, geen " + producten[i].naam + ", geen lente. Investeer daarom snel in een warme zomer! Dat is zeker voor de prijs van: €" + producten[i].prijs + " geen geld.";
                            break;
                        case (3):
                            producten[i].beschrijving = "Sommigen geven hun ouders een oudejaarslot cadeau, maar wat moeten ze daarmee als je ook een " + producten[i].naam + " kan krijgen. En alleen bij kamerplant.me he! KOOP DAN, voor slechts: €" + producten[i].prijs;
                            break;
                        case (4):
                            Console.WriteLine('4');
                            break;
                        case (5):
                            Console.WriteLine('5');
                            break;
                        case (6):
                            Console.WriteLine('6');
                            break;
                        case (7):
                            Console.WriteLine('7');
                            break;
                        case (8):
                            Console.WriteLine('8');
                            break;
                        case (9):
                            Console.WriteLine('9');
                            break;
                        case (10):
                            producten[i].beschrijving = "Deze " + producten[i].naam + " is de aller laatste die we uit China konden trekken, hierna sterft ie uit! Kopen nu het nog kan dus, zeker voor een prijsje van slechts: €" + producten[i].prijs + "!";
                            break;
                        default: //Komt eigenlijk niet voor, daarom dubbel met case 10:
                            producten[i].beschrijving = "Deze " + producten[i].naam + " is de aller laatste die we uit China konden trekken, hierna sterft ie uit! Kopen nu het nog kan dus, zeker voor een prijsje van slechts: €" + producten[i].prijs + "!";
                            break; 
                    } 
                    _context.SaveChanges();     

                }
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }

}