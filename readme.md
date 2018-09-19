# Azure Functions

In a nutshell: Azure Functions = Events + Code

Azure Functions is a serverless compute service that enables you to run code on-demand without having to explicitly provision or manage infrastructure.
  - Rapid prototyping, write only the code to respond to the event
  - No need to write boilerplate code
  - No server maintainence
  - Automatic scaling

### Usage examples

  - Run a scheduled task e.g. generating a daily/weekly report
  - Process messages in a queue or items added to blob storage e.g. sending an order confirmation email to a customer when an order has be placed
  - Respond to a HTTP request or webhook e.g. handle the callback from a third party payment provider

### What's my goal?

Your goal is to decompose the web application into Azure Function microservices.

Imagine a startup company has a basic e-commerce website allowing customers to purchase products from its store, and make payments through a third party provider.

As the business has grown through the years, there needs to be a scalable solution, so it doesn't become monolithic.

The new requirements of the system now includes:
- Sending email confirmations to users who use the contact us form
- Generating and sending order confirmations to customers via email
- Generating and sending software licence files to customers via email
- Scheduled reporting e.g. daily/weekly sales

### Solution Components

Craftathon.AzureFunctions
- Contains the Azure Functions that can be developed in Visual Studio and also published from Visual Studio.

1) AddOrderToQueueWebhook - This Function responds to an HTTP request to add an order to a queue to be processed.

2) AddOrderToBlobStorageQueueTrigger - This function responds to items added to queue. The order information is used to generate the licence
  file and stored in blob storage.

3) EmailLicenceBlobTrigger - This function responds to items added to blob storage. The licence file is retrieved from blob storage and emailed to the customer.

Craftathon.Models
- Contains data models

Craftathon.Services
- Contains business logic

Craftathon.WebUI
- Contains:
    - web interface which will be used to fire HTTP requests to Azure Functions.
    - resources and examples on various Azure Functions topics.
    - code to be able to send emails via SMTP and Sendgrid API.

### Running Craftathon.WebUI

1) In the Solution Explorer, right click on Craftathon.WebUI and Debug

### Publishing Craftathon.AzureFunctions to Azure

You must sign into Visual Studio before proceeding to the steps below.

1) In the Solution Explorer, right click on Craftathon.AzureFunctions and Publish
2) Select Create New, then click Create Profile
3) Fill the required fields, then Create
4) Log in to https://portal.azure.com/ and click on Function Apps in the left panel to see your deployment
