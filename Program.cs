using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Vehicle
    {

    }

    //SRP states that every class should have a single responsibility, and that responsibility should be entirely encapsulated by the class. 
    //There should only be a single reason for making the change to a class.

    //It means that a class should not be loaded with multiple responsibilities and a single responsibility should not be scattered across 
    //multiple classes and mixed with other responsibilities.The reason is that the more changes requested in the future, the more changes 
    //the class needs to undergo.

    //Below is a code violating the SRP.In the sample code, SRP is violated by mixing the OpenGate and CloseGate responsibility
    //with the core vehicle service functionality.

    //1st example of SRP 
    //public class ServiceStation
    //{
    //    public void OpenGate()
    //    {
    //        //Open the gate if the time is later than 9 AM
    //    }

    //    public void DoService(Vehicle vehicle)
    //    {
    //        //Check if service station is opened and then
    //        //complete the vehicle service
    //    }

    //    public void CloseGate()
    //    {
    //        //Close the gate if the time has crossed 6PM
    //    }
    //}

    //The re-factored code sample is as follows.A new interface is created and the 
    //gate related utility methods are moved to a different class called ServiceStationUtility.

    //public class ServiceStation
    //{
    //    IGateUtility _gateUtility;

    //    public ServiceStation(IGateUtility gateUtility)
    //    {
    //        _gateUtility = gateUtility;
    //    }
    //    public void OpenForService()
    //    {
    //        _gateUtility.OpenGate();
    //    }

    //    public void DoService()
    //    {
    //        //Check if service station is opened and then
    //        //complete the vehicle service
    //    }

    //    public void CloseForDay()
    //    {
    //        _gateUtility.CloseGate();
    //    }
    //}

    //public class ServiceStationUtility : IGateUtility
    //{
    //    public void OpenGate()
    //    {
    //        //Open the shop if the time is later than 9 AM
    //        Console.WriteLine("Opened Today");
    //    }

    //    public void CloseGate()
    //    {
    //        Console.WriteLine("Closed Today");
    //        //Close the shop if the time has crossed 6PM
    //    }
    //}


    //public interface IGateUtility
    //{
    //    void OpenGate();
    //    void CloseGate();
    //}

    //Second Example of SRP

    public class Customer
    {

    }
    //public class EmailSender
    //{
    //    public void SendEmail(string customerID,
    //        string emailNotificationType)
    //    {
    //        //STEP1: load customer details
    //        //STEP2: get email content
    //        //STEP3: send email (using SmtpClient class)
    //    }

    //    public string GetEmailContent(Customer customer,
    //        string emailNotificationType)
    //    {
    //        // Build the email notification content
    //        return "Customer";
    //    }

    //The refactored code goes in here!
    public class CustomerRespository
    {
        public Customer GetCustomer(string id)
        {
            return new Customer();
            // logic load customer from Database
        }
    }

    public class EmailContentBuilder
    {
        public string getEmailContent
            (Customer customerDetails)
        {
            // logic to build email content
            return "new content";
        }
    }

    public class EmailSender
    {
        public void SendEmail(string emailaddress,
            string subject, string bodycontent)
        {
            //logic to send email out
        }
    }
}


class Program
    {
        static void Main(string[] args)
        {
        }
    }

