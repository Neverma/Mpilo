using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;
using System.Xml.Linq;


namespace BusinessLogic
{
    public class BusinessLogic
    {
        public static bool SaveClient(string xmlfile, Models.Client client)
        {
            //Client client = new Client();
            try
            {
                var xdoc = XDocument.Load(xmlfile);

                xdoc.Descendants("Surname").FirstOrDefault().Value=client.Surname ;
                 xdoc.Descendants("FirstName").FirstOrDefault().Value=client.Firstname ;
                xdoc.Descendants("IdentityType").FirstOrDefault().Value= client.IdentityType;
                xdoc.Descendants("IdentityNumber").FirstOrDefault().Value= client.IdentityNumber;
                xdoc.Descendants("DateOfBirth").FirstOrDefault().Value= client.DateofBirth;

                xdoc.Save(xmlfile);
            }
            catch (Exception ex)
            {
                throw;
            }
            return true;
        }

        public static Client GetCLient(string xmlfile)
        {
            Client client = new Client();
            try
            {
                var xdoc = XDocument.Load(xmlfile);

                client.Surname = xdoc.Descendants("Surname").FirstOrDefault().Value;
                client.Firstname = xdoc.Descendants("FirstName").FirstOrDefault().Value;
                client.IdentityType = xdoc.Descendants("IdentityType").FirstOrDefault().Value;
                client.IdentityNumber = xdoc.Descendants("IdentityNumber").FirstOrDefault().Value;
                client.DateofBirth = xdoc.Descendants("DateOfBirth").FirstOrDefault().Value;
            }
            catch (Exception ex)
            {
                throw;
            }
            return client;
        }
    }
}
