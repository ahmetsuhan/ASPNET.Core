using System;

namespace CleanCode2
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        /*ex1
         * Create object and give it as a func paramater
         * Obey the rule of Single-responsibility principle 
         static void SaveUser(string userName,string password,string mail,bool sendEmail, bool sendBill, bool printReport)
        {

        }

        prefer below 
         static void SaveUser(User user)
        {
            //logic
        }
        static void SendEmail(bool sendEmail)
        {
            //logic
        }
        static void SendBill(bool sendBill)
        {

        }
        static void PrintReport(bool printReport)
        {

        }
         
         */

        /* ex2
          static void DoWork()
         {
             //business
             if ()
             {
                 if ()
                 {
                     if ()
                     {
                         if ()
                         {
                             if ()
                             {

                             }
                         }
                     }
                 }
             }
         }
        
        To Do: 
            

         static void DoWork()
        {
            if ()
            {
                if ()
                {
                    DoWorkExtractMethod();
                }
            }
        }
        static void DoWorkExtractMethod()
        {
            if ()
            {
                if ()
                {
                    if ()
                    {

                    }
                }
            }
        }
         */

        /* ex3 
           static void Login( string userName,string password)
          {
              if (string.IsNullOrWhiteSpace(userName))
              {
                  if (!string.IsNullOrWhiteSpace(password))
                  {
                      //login
                  }
                  else
                  {
                      throw new ArgumentNullException("password must be entered");
                  }
                  //logic
              }
              else
              {
                  throw new ArgumentNullException("user cannot be an empty! ");
              }
          }

          static void LoginFailFast(string userName, string password)
          {
              //the method written by applied failfast first.
              if (string.IsNullOrWhiteSpace(userName))
              {
                  throw new ArgumentNullException("user cannot be an empty! ");
              }
              if (string.IsNullOrWhiteSpace(password))
              {
                  throw new ArgumentNullException("password must be entered!");
              }

              //login

          }


         */
    }
}
