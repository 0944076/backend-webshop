﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sessie_model;
using geregistreerdeklant_model;

namespace sessie_Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class sessieController : ControllerBase
    {
        private readonly kamerplantContext _context;

        public sessieController(kamerplantContext context)
        {
            _context = context;
        }

        // GET api/sessie
        [HttpGet]
        public List<sessie> Get()
        {
            return _context.sessie.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public sessie Get(int id)
        {
            return _context.sessie.Find(id);
        }

        // POST api/values
        //Bij login post een sessie

        public class inlogObject 
        {
            public string email { get; set; }
            public string wachtwoord { get; set; }

        }

        [HttpPost]
        public geregistreerdeklant Post([FromBody] inlogObject login)
        {
            //Gebruiker identificeren
            geregistreerdeklant gebruiker = _context.geregistreerdeklant.SingleOrDefault(geregistreerdeklant => geregistreerdeklant.email == login.email);
            return gebruiker;
        }

        // PUT api/values/5
//         [HttpPut]
//         public StatusCodeResult Put([FromBody] geregistreerdeklant changedCustomer)
//         {
//             try
//             {
//                 _context.klant.Update(changedCustomer);
//                 _context.SaveChanges();
//                 return Ok();
//             }
//             catch
//             {
//                 return BadRequest();
//             }
//         }

//         // DELETE api/values/5
//         [HttpDelete("{id}")]
//         public StatusCodeResult Delete(int id)
//         {
//             try
//             {
//                 geregistreerdeklant verwijder = _context.klant.Find(id);
//                 _context.klant.Remove(verwijder);
//                 _context.SaveChanges();
//                 return Ok();
//             }
//             catch
//             {
//                 return BadRequest();
//             }
//         }
     }
}