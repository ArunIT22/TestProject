Feature: NewProduct
	Only employee and admin are going to add new product

@tag1
Scenario: Create a new product with all the mandatory fields
	#Given I have opened my application
	When I filled all the mandatory fields
	#DataTable
		| ProductName | UnitPrice | UnitsInStock |
		| Pencil      | 500.99    | 50           |
		| White Board | 3500.99   | 50           |
		| Table Light | 2600      | 50           |
	#And I pressed AddProduct Button
	#Then I should see the data updated to Database

@tag2
Scenario Outline: Create a new product with all the mandatory fields using Outline
	#Given I have opened my application
	When I filled all the mandatory fields <ProductName>, <UnitPrice> and <UnitsInStock>
	#And I pressed AddProduct Button
	#Then I should see the data updated to Database
Examples:
	| ProductName | UnitPrice | UnitsInStock |
	| Pencil      | 500.99    | 50           |
	| White Board | 3500.99   | 50           |
	| Table Light | 2600      | 50           |