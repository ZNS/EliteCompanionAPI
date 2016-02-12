using System;
using System.Threading.Tasks;
using ZNS.EliteCompanionAPI;

namespace ZNS.EliteCompanionCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
        }

        static async Task MainAsync()
        {
            var profileExists = EliteCompanion.Instance.LoadProfile("test@email.com");
            if (!profileExists)
            {
                EliteCompanion.Instance.CreateProfile("test@email.com", "password");
            }
            var response = await EliteCompanion.Instance.GetProfileData();
            var json = "";
            if (response.LoginStatus == EliteCompanionAPI.Models.LoginStatus.PendingVerification)
            {
                Console.WriteLine("Enter verification code sent as email:");
                string code = Console.ReadLine();
                var verificationResponse = await EliteCompanion.Instance.SubmitVerification(code);
                if (verificationResponse.Success)
                {
                    response = await EliteCompanion.Instance.GetProfileData();
                    json = response.Json ?? "";
                }
            }
            Console.Write(response.Json);
            Console.ReadLine();
        }
    }
}
