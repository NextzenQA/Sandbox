Feature: Fillout Forms

A short summary of the feature

@tag1

Scenario: Validating contact us functionality
	Given I am on fill out form page of ultimate QA application
	When I submit a message
	Then I should see "Thanks for contacting us" message
