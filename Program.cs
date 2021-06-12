using ConsoleApplication;
using System;
using System.Threading.Tasks;

namespace FaceBookBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var facebookClient = new FacebookClient();
            var facebookService = new FacebookService(facebookClient);
            var getAccountTask = facebookService.GetAccountAsync(FacebookSettings.AccessToken);
            Task.WaitAll(getAccountTask);
            var account = getAccountTask.Result;
            Console.WriteLine($"{account.Id} {account.Name}");


            var postOnWallTask = facebookService.PostOnWallAsync(FacebookSettings.AccessToken,
            "Hi \n this post from .NET Core app 😁");
            Task.WaitAll(postOnWallTask);
        }
    }
}
