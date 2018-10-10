# Azure Functions (C#/JS)

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

Your initial goal is to follow the HTTP Trigger demo documented within the web app. This will guide you through setting up a basic Azure Function.

After that, you can choose to extend that functionality, or look to creating a continuous integration and deployment pipeline using Azure DevOps, again, this is documented within the web app.

Some ideas for extending the Azure Function:
- Sending email confirmations to users who use the contact us form
- Generating and sending order confirmations to customers via email
- Generating and sending software licence files to customers via email
- Scheduled reporting e.g. daily/weekly sales
