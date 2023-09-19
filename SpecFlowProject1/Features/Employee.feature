Feature: Employee
	Create a new employee details

@tag1
Scenario: Create Employee with all details
	Given I have connected to the EmployeeService class
	When I enter Id, Name and MobileNo
	| Id | Name   | MobileNo   |
	| 1  | Sanjay | 7788995566 |
	#Then It store the employee details in the List