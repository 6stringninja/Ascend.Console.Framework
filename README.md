Wasted a day in my life on an application not "good" enough for being worthy of employment at trek. Required to provide a sample that was rejected due to the lack of mind reading and their appetite for wasting peoples time. Please Review..but don't use :) as it "sucks". 

## Reasons I suck ##

1. Trek, expects you to bloat it with nuget packages (I lacked) and are incapable of NOT running "dotnet restore" (probably right click , check restore). Not that it was required for this as all the libs for this "Simple" app are standard framework. Which is not complicated enough for the simplicity trek is looking for.

2. The testing framework that ships with VS2017 (current at the time) is "obsolete", consult nostradomas for prefered third party. You have a choice of 2 standard, don't choose "unit tests" even though they say "unit tests" as they expect nunit to prove your mind reading abilities.

3. They expect EF framework as demonstrating anything that isn't generated is "legacy" apparently. 

4. Design pattern, architecture or clean code gets is optional. 


below is the requirements. Please Don't suck

# Ascend.Console.Framework - Requirements 
Example App NOT good enough to get hired at Trek Bikes. https://www.trekbikes.com
# WARNING (Don't waste more then 10 minutes on this app)
Ascend Development Exercise
Simple Application
Develop a simple console application that allows the user to enter and review sales information.
Functional Specifications
- Main prompt: The main application prompt allows the user to select:
o ‘S’ – Sale – allows the user to enter sales information
 Additional prompt for Sale Amount (add numeric currency validation)
 Additional prompt for State code
o ‘R’ – Report – outputs sale information to the console window
 Ordered by descending entry date time
 Output format – Entry Date, State Code, Sale Amount, Tax Amount, Sale Total
 Use currency formatting and date format (dd/mm/yyyy hh:mm), no need to
focus on lining up output columns at this point

o ‘Q’ – Quit – closes the application
- Sale entry flow:
o Data is collected as per the prompt above
o The tax rate for the entered state code is looked up, if the state code cannot be found
the ‘Default Tax Rate’ is used
o The record is stored in the database
 EnteryDate – is the date/time when entered
 StateCode – is set from the user input (actual state code validation not required,
but should only accept 2 characters
 SaleAmount – is the amount entered from the prompt
 TaxRate – is the rate looked up from the StateTaxRate table or the ‘Default Tax
Rate’ if not found
 TotalAmount – is the SaleAmount and the tax amount added together

Technical Specifications
- ‘Default Tax Rate’ should be configurable and should initially be 6%
- The Sale table TotalAmount value is a calculated column but is stored for faster reporting
- The TaxRate is stored at time of entry as historic sales should not change in value if tax rates
change at later dates
- Adhere to good programming design/practices and add unit tests where appropriate
- Use the Visual Studio SQL Database Project to document the table design (also makes
deployment very easy)
Table Design (SQL Express)
Sale
- ID (Big Int Primary Key)
- EntryDate (DateTime not null)
- StateCode (nvarchar(2) not null)

- SaleAmount (money not null)
- TaxRate (decimal not null)
- TotalAmount (decimal not null)
StateTaxRate
- Design as needed to support state code lookup of tax rates. Mock seed values are fine.
