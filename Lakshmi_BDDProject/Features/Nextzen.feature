Feature: Nextzen

A short summary of the feature

@UserEnteredValidCredentials
Scenario: submit with valid credentials
	Given registration form is there with empty fields.
	When user filled the data with all the required fields such as firstname, lastname, mobile number, email and university.
	Then  user submit the registration form successfully.

@UserEnteredEmptyCredentials
Scenario: submit with empty credentials
	Given registration form is there with empty fields.
	When user left some fields empty and trying to submit
	Then displayed “please fill out this form” on required field

@UserEnteredInValidCredentials
Scenario: submit with invalid credentials
	Given registration form is there with empty fields.
	When User entered invalid credentials
	Then displayed "invalid credentials