using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode
{
    public class Contract
    {
        public readonly bool active;
        public int Id { get; set; }
        public ContractStatus Status { get; set; }
        public Contract(bool isActive)
        {
           this.active= isActive; 
        }
        
        
    }


    public static class ContractExtension
    {
        public static bool IsActive(this Contract contract)
        {
            if (contract.active)
            {
                return true;
            }
            return false;
        }

        static Random random = new Random();

        private static bool GenerateRandomTrueFalse()
        {
            return random.Next(0, 3) < 1;
        }
        public static List<Contract> CreateContractList(this List<Contract> contracts,int count)
        {
            for(int i = 0; i < count; i++)
            {
                bool trueOrFalse = GenerateRandomTrueFalse();
                contracts.Add(new Contract(trueOrFalse) { 
                Id=i,
                Status=SetContractStatus()
                });
            }
            return contracts;
        }
    
        private static ContractStatus SetContractStatus()
        {
            ContractStatus status;
            if (GenerateRandomTrueFalse())
            {
                status = ContractStatus.Done;
            }
            else
            {
                status = ContractStatus.None;
            }
            return status;
        }
    }

    public enum ContractStatus
    {
        None,
        Done  
    }
}


