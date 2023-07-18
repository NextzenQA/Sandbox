Feature: WebApplication

A short summary of the feature

@tag1
Scenario: Validate Amazon Search Functionality
	Given I am on amazon search page
	When I search for cosmatics
	Then I should see results for cosmatics
