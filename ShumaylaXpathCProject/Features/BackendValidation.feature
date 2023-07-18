Feature: BackendValidation

A short summary of the feature

@tag1
Scenario: Validate employee schedule nightly job
	Given I have an updated employee schedule
	When I run QA Engineer job
	Then My database table should be updated with QA Engineer
