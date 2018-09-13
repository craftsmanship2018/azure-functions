# Azure Functions

## Story

A business has a basic ecommerce website allowing customers to purchase products from its store, and make payments
through a third party provider.

The web server initially responded with web requests serving up HTML, CSS and JS. It also handled
the callback from the third party provider.

As the business has grown through the years, there needs to be a scalable solution, so that the one
web server is not responsible for everything and become monolithic.

The new requirements of the system now includes:

- Generating and sending order confirmations to customers via email
- Generating and sending software licence files to customers via email
- Scheduled reporting e.g. daily/weekly sales


## Tasks for participants to tackle (in order of difficulty)

Initial task will be to migrate email sending functionality to Azure Functions using either SMTP or Sendgrid
https://docs.microsoft.com/en-us/azure/azure-functions/functions-bindings-sendgrid

On completing that task, they can extend the email functionality by including, for example, an order confirmation.

Following that, they can also make use of blob storage to store software licence files and email those to customers

## Solution Components

### Craftathon.AzureFunctions

- Contains the Azure Functions that can be developed in Visual Studio and also published from Visual Studio.

Currently, it has 3 queues:
1) AddOrderToQueueWebhook

- This Function responds to an HTTP request to add an order to a queue to be processed.

2) AddOrderToBlobStorageQueueTrigger

- This function responds to items added to queue. The order information is used to generate the licence
  file and stored in blob storage.

3) EmailLicenceBlobTrigger

- This function responds to items added to blob storage. The licence file is retrieved from blob storage and
  emailed to the customer.

Craftathon.Models

- Contains data models

Craftathon.Services

- Contains business logic

Craftathon.WebUI

- Contains:

    - web interface which will be used to fire HTTP requests to Azure Functions.
    - resources and examples on various Azure Functions topics.
    - code to be able to send emails via SMTP and Sendgrid API.



## Running Craftathon.WebUI


1) In the Solution Explorer, right click on Craftathon.WebUI and Debug



## Publishing Craftathon.AzureFunctions to Azure

You must sign into Visual Studio before proceeding to the steps below.

1) In the Solution Explorer, right click on Craftathon.AzureFunctions and Publish
2) Select Create New, then click Create Profile
3) Fill the required fields, then Create
4) Log in to https://portal.azure.com/ and click on Function Apps in the left panel to see your deployment