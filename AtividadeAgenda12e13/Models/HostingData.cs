using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgenda12e13.Models
{
    public class HostingData
    {
        public string Description { get; }
        public string Adults { get; }
        public string Childrens { get; }
        public string CheckinDate { get; }
        public string CheckoutDate { get; }
        public string Stay { get; }
        public string StringData { get; }
        public string Price { get; }
        public string DateHire { get; }

        public HostingData(string stringData)
        {
            StringData = stringData;
            string[] data = stringData.Split(";");
            Description = data[0];
            Adults = data[1];
            Childrens = data[2];
            CheckinDate = data[3];
            CheckoutDate = data[4];
            Stay = data[5];
            Price = data[6];
            DateHire = data[7];

        }

        public HostingData(
        string description,
        string adults,
        string childrens,
        string checkinDate,
        string checkoutDate,
        string stay,
        string price
          )
        {
            Description = description;
            Adults = adults;
            Childrens = childrens;
            CheckinDate = checkinDate;
            CheckoutDate = checkoutDate;
            Stay = stay;
            Price = price;
            DateHire = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            StringData = $"{Description};{Adults};{Childrens};{CheckinDate};{CheckoutDate};{Stay};{Price};{DateHire}";
            
    }

    }
}
