using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueRemit.Service;
using ValueRemit.Service.Quickteller;
using System.Xml.Linq;
using System.IO;
using ValueRemit.Model;
namespace ValueRemit.Service
{
    public class Services
    {
        QuickTellerServiceClient quickTeller = null;
         
        public Services()
        {
          
            //string getBiller = quickTeller.GetBillers("<SearchCriteria><TerminalId>3BPT0001</TerminalId></SearchCriteria>");
            //XDocument xDoc = new XDocument();
            //using (StringReader s = new StringReader(getBiller))
            //{
            //    xDoc = XDocument.Load(s);
            //}
            //var billerId = xDoc.Descendants().Elements("Id").ToList().FirstOrDefault().Value;
           
            //quickTeller.GetBillerPaymentItems("<SearchCriteria><BillerId>667</BillerId></SearchCriteria>");
        }

        public string GetBiller()
        {
            quickTeller = new QuickTellerServiceClient();
            return quickTeller.GetBillers("<SearchCriteria><TerminalId>3BPT0001</TerminalId></SearchCriteria>");
        }

        public string GetBillerPaymetItem()
        {
            quickTeller = new QuickTellerServiceClient();
            return quickTeller.GetBillerPaymentItems("<SearchCriteria><BillerId>667</BillerId></SearchCriteria>");
        }

        public string SendBillPaymentAdvice()
        {
            quickTeller = new QuickTellerServiceClient();
            return quickTeller.SendBillPaymentAdvice("<BillPaymentAdvice><Amount>450000</Amount><PaymentCode>687343</PaymentCode><CustomerMobile>08065186175</CustomerMobile><CustomerEmail>pdaniels@interswitchng.com</CustomerEmail><CustomerId>Deal0001</CustomerId><TerminalId>3pbl0001</TerminalId><RequestReference>12341033154260</RequestReference></BillPaymentAdvice>");
        }

        public string DoTransfer(TransferBankModel model)
        {
             quickTeller = new QuickTellerServiceClient();
            var param = ConstructRequestForDoTransfer(model);
            var response = quickTeller.DoTransfer(param);
            return "";
        }

        private string ConstructRequestForDoTransfer(TransferBankModel model)
        {
            throw new NotImplementedException();
        }

    }
}
