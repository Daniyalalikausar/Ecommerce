﻿using System.Configuration;
namespace FypStore.Models
{
    public class PayPalModel
    {
        public string cmd { get; set; }
        public string business { get; set; }
        public string no_shipping { get; set; }
        public string @return { get; set; }
        public string cancel_return { get; set; }
        public string notify_url { get; set; }
        public string currency_code { get; set; }
        public string item_name { get; set; }
        public string display { get; set; }
        public string itemcolor { get; set; }
        public string undefined_quantity { get; set; }
        public double? shipping { get; set; }
        public double amount { get; set; }
        public string actionURL { get; set; }
        
        public PayPalModel(bool useSandbox)
        {
            this.cmd = "_xclick";
            this.cancel_return = ConfigurationManager.AppSettings["cancel_return"];
            this.@return = ConfigurationManager.AppSettings["return"];
            if (useSandbox)
            {
                this.actionURL = ConfigurationManager.AppSettings["test_url"];
            }
            else
            {
                this.actionURL = ConfigurationManager.AppSettings["Prod_url"];
            }
            // We can add parameters here, for example OrderId, CustomerId, etc....
            
            
            this.notify_url = ConfigurationManager.AppSettings["notify_url"];
            // We can add parameters here, for example OrderId, CustomerId, etc....
            
            this.currency_code = ConfigurationManager.AppSettings["currency_code"];
        }
    }
}