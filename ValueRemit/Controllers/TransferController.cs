using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValueRemit.Model;
using ValueRemit.Dal;
using ValueRemit.Service;

namespace ValueRemit.Controllers
{
    public class TransferController : Controller
    {
        //
        // GET: /Transfer/

        public ActionResult Index(string I)
        {
            MySqlDal dal=new MySqlDal();
            TransferBankModel model = new TransferBankModel();
            model.Countries = dal.SelectMockCountryData();
            model.Banks = dal.SelectMockBankData();
            model.AccountTypes = dal.SelectMockAccountTypeData();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(TransferBankModel model)
        {
            Services s = new Services();
            s.DoTransfer(model);
            return View();
        }

    }
}
