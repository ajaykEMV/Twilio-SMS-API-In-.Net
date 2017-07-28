using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Auth Token at twilio.com/console
            const string accountSid = "AC68cc85ef7287959939a7bf0da37f6e16";
            const string authToken = "Your_Auth_Token";
            TwilioClient.Init(accountSid, authToken);

            //var mediaUrl = new List<Uri>() {
            //new Uri( "https://c1.staticflickr.com/3/2899/14341091933_1e92e62d12_b.jpg" )
        //};
            var to = new PhoneNumber("+91**********");
            var message = MessageResource.Create(
                to,
                from: new PhoneNumber("+16195360830"),
                body: "This is Ajay from ProAdroit Advisors Pvt. Ltd. for test sms."
                //mediaUrl: mediaUrl
                );
            Console.WriteLine(message.Sid);
        }
    }
}
