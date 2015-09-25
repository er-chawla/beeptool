using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ValueRemit.Model;
using System.Web.Mvc;

namespace ValueRemit.Dal
{
    public class MySqlDal
    {
        public IEnumerable<Country> GetCountries()
        { 
            return new List<Country>{
            new Country(){CountryCode="AU",CountryId=1,CountryName="Australia"},
            new Country(){CountryName="NiGeria",CountryId=2,CountryCode="NG"}
        };
        }

        public IEnumerable<Bank> GetBanks()
        {
            return new List<Bank>{
            new Bank(){BankId=1,BankName="USA Bank"},
            new Bank(){BankId=2,BankName="SA Bank"}
        };
        }

        public IEnumerable<AccountType> GetAccounts()
        {
            return new List<AccountType>{
            new AccountType(){AccountTypeId=1,AccountTypeName="Saving Account"},
            new AccountType(){AccountTypeId=2,AccountTypeName="Current Account"}
        };
        }

        public IEnumerable<SelectListItem> SelectMockCountryData()
        {
            return GetCountries().Select(x => new SelectListItem { Value = x.CountryId.ToString(), Text = x.CountryName }).ToList();
        }

        public IEnumerable<SelectListItem> SelectMockBankData()
        {
            return GetBanks().Select(x => new SelectListItem { Value = x.BankId.ToString(), Text = x.BankName }).ToList();
        }

        public IEnumerable<SelectListItem> SelectMockAccountTypeData()
        {
            return GetAccounts().Select(x => new SelectListItem { Value = x.AccountTypeId.ToString(), Text = x.AccountTypeName }).ToList();
        }


        public void SelectCountryData()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Customers"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                         
                        }
                    }
                }
            }
        }


        public void SelectBankData()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM banks"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                        }
                    }
                }
            }
        }



        public void GetExchangeRate()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM banks"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                        }
                    }
                }
            }
        }

        public void GetAccountBalance()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM banks"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                        }
                    }
                }
            }
        }



        public void GetAccounteeName()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM banks"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                        }
                    }
                }
            }
        }


        public string GetClientId(long clientId)
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            string id_client = "";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT id_client FROM api.clients where api.login =@clientId"+clientId))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@clientId", clientId);
                    con.Open();
                    object o = cmd.ExecuteScalar();
                    if (o != null)
                    {
                        id_client = o.ToString();
                    }
                }
            }
            return id_client;
        }


        public void GetClientProfile()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM banks"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);

                        }
                    }
                }
            }
        }



    }
}
