using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValueRemit.Service.Quickteller;

namespace ValueRemit.Controllers
{
    public class PayBillController : Controller
    {
        //
        // GET: /PayBill/

        public ActionResult Index()
        {
            ValueRemit.Service.Services S = new ValueRemit.Service.Services();
            string biller = S.GetBiller();
           //string X= S.GetBillerPaymetItem();
            return View();
        }

    }
}
