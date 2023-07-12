Feature: Facebook

This is a feature to validate all facebook functionality scenario

@tag1
Scenario: Login with valid credentials
	Given I am on Facebook Login Page
	When I Login with 'Sai'
	Then I should see 'Sai' Home Page
	
Scenario: Login with invalid creditionals
	Given I am on Facebook Login Page
	When I Login with 'Sabi'
	Then I should see invalid credentials error message
	// enter the name 
Scenario: Login with empty creditionals
	Given I am on Facebook Login Page
	When I Login with 'Samy'
	Then I should see user name and password fields are required message