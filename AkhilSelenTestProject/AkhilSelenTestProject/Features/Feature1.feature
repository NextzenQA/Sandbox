Feature: Fillout Forms

A short summary of the feature


Scenario: Validating Contact Us funcitonality
	Given I am on fill out forms page of Ultimate QA application
	When I submit a message
	Then I should see 'Thanks for contacting us' message
