using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PresentationLayerWebForm.ServiceReference1;

namespace PresentationLayerWebForm.BLL
{
    public class User
    {
        public string Insert(InsertUser user)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string output = client.Insert(user);
            return output;
        }

        public static string InsertUser(InsertUser user)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string output = client.Insert(user);
            return output;
        }
    }
}