<img src="./assets/shipx__banner.png" width="760px" />

### ShipX: blockchain logistics monitoring for the USPS

True traceability and blockchain-enhanced monitoring will help streamline the technological processes behind the USPS, the big government behemoth awaiting innovation and change through Stratis.

###### Folder Tree:

- `./assets`

- `./pkg`

    React.js UI to integrate with the testnet node api and smart contract. utilizes the `bitcore-lib` package as well as `web3`. Login w/ your wallet name and wallet password.

- `./src`

    C# smart contract built for the Stratis platform, integrated w/ the USPS API

    * xunit, moq for testing

- `./net`

    Docker environment bash script and testnet endpoint for the smart contract UI to interface with.

- `./app`

    This is a Svelte.js app currently in progress in the `app` dir. Download the "NativeScript Playground" app in your respective app store (iOS, Google Play) and scan the QR Code to demo it.

---

This project is **MIT** licensed. 

The USPS web tools API portal was used for the logistic service component of the smart contract: https://www.usps.com/business/web-tools-apis/. More documentation can be read at: https://www.usps.com/business/web-tools-apis/address-information-api.htm
