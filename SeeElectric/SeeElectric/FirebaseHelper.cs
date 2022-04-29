using System;
using System.Collections.Generic;
using System.Text;
using Firebase;
using Firebase.Database;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;



namespace SeeElectric
{
    public class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://seeelectricm-default-rtdb.asia-southeast1.firebasedatabase.app/");

        public async Task AddRecord(string dt, double c, double p, string a, double t)
        {
            await firebase
                .Child("AnnualReport")
                .PostAsync(new ElectricRecord() { DateRecorded = dt, Current = c, Price = p, App = a, AppTime = t });
        }

        public async Task<List<ElectricRecord>> GetAllElectricRecord()
        {
            return (await firebase
                .Child("AnnualReport")
                .OnceAsync<ElectricRecord>()).Select(item => new ElectricRecord
                {
                    DateRecorded = item.Object.DateRecorded,
                    Current = item.Object.Current,
                    Price = item.Object.Price,
                    App = item.Object.App,
                    AppTime = item.Object.AppTime,
                }).ToList();
        }
    }
}
