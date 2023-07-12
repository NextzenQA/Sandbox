Feature: Facebook

This feature is to validate all possible scenarios in facebook login

@tag1LoginWithValidCredentials
Scenario: [Login with valid credentials]
	Given I am in facebook login page
	When login with Lakshmi
	Then I should see Lakshmi home page

	@tag1LoginWithInvalidCredentials
Scenario: [Login With Invalid Credentials]
	Given I am in facebook login page
	When login with pavan
	Then I should see invalid credential error message


	@tag1LoginWithEmptyCredentials
Scenario: [Login With Empty Credentials]
	Given I am in facebook login page
	When login with Monika
	Then I should see username and password fields are required message


	