using System;
using Stratis.SmartContracts;

[Deploy]

public class ShipXSmartContract : SmartContract {
        public struct data {

        };
        private const string AppName = "ShipX";


        public ShipXSmartContract(ISmartContractState smartContractState) : base(smartContractState) {
            
        };

        public void Main(string[] args) {
            // method logic
            Console.WriteLine("Hello World!");
        }
}