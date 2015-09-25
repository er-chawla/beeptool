using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ValueRemit.Model
{
  public  class TransferBankModel
    {
        public string ExchangeRate { get; set; }
        public string AccountBalance { get; set; }

        public int CountryId { get; set; }
        public int BankId { get; set; }
        public int BankType { get; set; }
        public string BenficeryName { get; set; }

        public string BeneficeryAccountNumber { get; set; }

        public int TransferAmount { get; set; }

        public int AccountTypeId { get; set; }

        public string BeneficeryEmail { get; set; }

        public string BeneficeryPhone { get; set; }

        public string PurposeOfTransfer { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

        public IEnumerable<SelectListItem> Banks { get; set; }

        public IEnumerable<SelectListItem> AccountTypes { get; set; }

        public int fee { get; set; }
    }
}
