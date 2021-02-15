using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Boolean Compares
            // 1-) Sadelik ve okunabilirlik ön planda olmalı
            // 2-) Pozitif ol!
            // 3-) Use Ternary if ! (çok uzun ternary expression kullanma max 3 veya 4)
            // 4-) Use Strongly Type not Stringly Type!!! Avoid magic string with using enum or const, readonly
            // 5-) Başıboş ifadelerden kaçın (avoid stray expressions!)
            // 6-) Karmaşık ifadelerin sadeleştirilmesi(keep complex expression simple)
            #region 1.1-)
            bool done = true;
            if (done == true) { }

            //recommended it's simple
            if (done) { }
            #endregion 1.1-)

            #region 1.2-)

            int totalWeeklySpend = 200;
            bool hasQualifyCompany;
            if (totalWeeklySpend > 500)
            {
                hasQualifyCompany = true;
            }
            else
            {
                hasQualifyCompany = false;
            }

            hasQualifyCompany = totalWeeklySpend > 500; // more clean
            #endregion 1.2-)

            #region 2.1)

            bool isLogin = true;

            bool isNotLogin = false;//not recommended

            if (!isNotLogin) { }  //not recommended
            if (isLogin) { }

            #endregion 2.1)

            #region 2.2)
            /* 
                 public static bool IsValid()
                {
                    return !exception.Any();
                }
                public static bool IsValid()
                {
                    return exception.Count == 0;
                }
             
             */
            #endregion

            #region 3.1)

            int dailyMessageLimit;
            bool isFreeMember = true;
            if (isFreeMember)
            {
                dailyMessageLimit = 10;
            }
            else
            {
                dailyMessageLimit = 100;
            }
            dailyMessageLimit = isFreeMember ? (10) : (100);

            // avoid this kind of usage of too long ternary if
            int freeMember = 1;
            dailyMessageLimit = freeMember == 1 ? 1 : freeMember == 2 ? 2 : freeMember == 3 ? 3 : freeMember == 4 ? 4 : 500;
            #endregion 3.1)

            #region 4.1)

            string productionType="";
            if (productionType == "HOTEL"){}// not recommended

            const string productionTypeHotel = "HOTEL";
            if (productionType == productionTypeHotel) { } // more clean

            #endregion

            #region 5.1)
            int age = 20;
            if (age > 16) { }// 16 is stray expression!!!

            int ageLimit = 16;
            if (age > ageLimit) { }// more clean than above

            #endregion 5.1)


            #region 6.1)

            /* 
              if(DateTime.Now.Year - lastVisitDate.Year <= 2 && childCount>0 )
             {
                 //logic
             }

             bool acceptedPromotionGoal = (DateTime.Now.Year - lastVisitDate.Year) <= 2;
             if (acceptedPromotionGoal)
             {
                 // hasChild?
             }

             */
            #endregion 6.1)

            #region 6.2)
            int contractCount = 50;
            List<Contract> relatedContracts = new List<Contract>();
            relatedContracts = relatedContracts.CreateContractList(contractCount);
            foreach (var contract in relatedContracts)
            {
                if (contract.active &&
                    contract.Status == ContractStatus.Done &&
                    contract.Id >= 10)
                {
                    Console.WriteLine(contract.Id.ToString() + contract.Status);
                }
            }
           
             var filteredContract = relatedContracts.
              Where(c => c.Id >= 10 && c.Status == ContractStatus.Done && c.active);
               
            #endregion

            #endregion Boolean Compares

            Console.ReadKey();
        }


    }
}
