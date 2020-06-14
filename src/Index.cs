using Stratis.SmartContracts;

/// <summary>
/// A base, starter smart contract for the ShipX dApp
/// </summary>

[Deploy]

public class ShipXSmartContract : SmartContract {
        public struct data {

        };
        private const string AppName = "ShipX";
        private string Region {get;set; // get{return}
        }
        public string GetRegion() {
            return this.Region;
        }

        public ShipXSmartContract(ISmartContractState smartContractState) : base(smartContractState) {
            this.Region = "any";
        }
}