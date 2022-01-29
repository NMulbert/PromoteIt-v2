# PromoteIt - Alpha
A project for promoting social campaigns through Twitter based on Azure Functions and CosmosDB.

## Description
The system works by onboarding business organizations that donate products, onboarding non-profit organizations that want to promote campaigns, and onboarding social activists – users of Twitter that can promote those campaigns.
## Getting Started

### Dependencies
* Windows 10/11
* CosmosDB Emulator/Account.
* Database named - "PromoteIt".

### Executing Program
* Create a Database with the name "PromoteIt" before starting the program.
* In order for the system to work properly you'll need to make sure that all Azure Functions are up and running before starting using the system.

## Help
* GetBalance - all functions for handling balance accounts.
* Login_SignIn - all of the UI elements.
* NPRCreateCampaign - functions for handling campaigns and functions for handling products.
* NPR_registration - functions for user creation/verification + admin functions for user data.
* OrderApp - functions for creating/updating orders.
* TimeTrigerUpadteTweetsAndBalance - a time trigger function for the Twitter API.
* TwitterAPI - all functions for the Twitter API (searching/creating/updating).

## Roadmap
* Adding a retweet count for the system so that social activists will get payed on each additional retweet they get.
* Adding a feature where social activists can choose to donate a product they have bought to a campaign of their choosing.

## Authors
* [Netanel Mülbert](https://github.com/NMulbert)
* [Vlad Probst](https://github.com/VladlenPro)

## License
This project is licensed under the MIT License - see the LICENSE.md file for details
