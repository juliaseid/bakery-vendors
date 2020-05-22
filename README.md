# _Bakery Retailer Management_

#### _Epicodus Project May 22, 2020_

#### By _**Julia Seidman**_


## Description

_A project to introduce the C# language and the .NET Core framework with ASP.NET CORE MVC and MSBuild through a mock website for a bakery to manage weekly orders and invoices. This lesson serves as a reference for configuring, building, and launching web applications in C#. Dynamic sites using forms and views are explored with a web utility allowing users to add new retailers and orders to the bakery's book of business._

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. Run the commands dotnet restore, dotnet build, and dotnet run to download dependencies, build the configuration, and run the program in your local browser.

## Known Bugs

There are no known bugs at the time of this update.

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue] here on GitHub._

## Technologies Used

* C#
* .NET Core
* ASP.NET Core MVC
* MSBuild
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **Form allows user to view all retailers with accounts** | User Input: "View Vendors" | Output: "Your Vendors: Sam's, Sammy's, Sampson's" |
| **Form allows user to create a new retailer account** | User Input: "Sandy's", "425-222-5555 | Output: Vendor List: ...Sandy's...|
| **Form allows user create daily order for retailer** | User Input:"Tuesday", 10, 50 | Output: "Sandy's Tuesday Order: 10 loaves of bread, 50 pastries"|
| **Form calculates invoice total for each order** | User Input: 5 loaves bread, 5 pastries | Output: "Invoice Total: $29" |
| **Form shows list of daily orders for each retailer** | User Input: "See orders" | "Sandy's 1. Tuesday 2. Friday" |





### License
This software is licensed under the MIT license.

Copyright (c) 2020 **_Julia Seidman_**