using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Abstract;

namespace WebApi.Database.Dtos
{
    public class HeadMasterDto:Person
    {
        public decimal BankAccountMoney { get; set; }
        public string Bank { get; set; }
        public int IBAN { get; set; }
        public string Company { get; set; }
        public bool Maried { get; set; }
       

    }
}
