# Azure Functions
## Story

A startup e-commerce company has a website allowing customers to purchase products from its online store. As the business has increased over the years, the company want to track engagement metrics for marketing emails it sends to customers, to improve customer engagement and increase sales. They need a scalable solution with a continuous integration and deployment pipeline.

## Technology

The company wishes to continue using their .NET Core web application as is, but do not want implement their own solution to gather email engagement metrics, knowing there are effective existing solutions. They have chosen Azure Web Apps to host the application as it should port easily, while offering reduced maintenance and cost-effective scalability.

## Getting Started

1. Clone or download this repository
1. Open `src/Craftathon.sln` in Visual Studio
1. Restore NuGet packages
1. Build the solution and start a new instance of `Craftathon.WebUI`

## Goal

1. Follow the HTTP Trigger demo documented within the web app. This will guide you through setting up a basic Azure Function.
1. Modify the HTTP trigger function, you could...
    - Send emails to users (this would be the marketing emails, but keep it simple without worry about the email contents)
    - Generate and send order confirmations to customers via email
    - Generate and send software licence files to customers via email
1. Build a continuous integration and deployment pipeline using Azure DevOps, that will build, test and deploy the application in a safe and repeatable way. The pipleline should...
    - Be triggered by source control
    - Execute all unit tests
    - Publish the solution to a production environment
