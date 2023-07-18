Feature: BackendValidations

A short summary of the feature

@tag1
Scenario: validate employee schedule nightly job
	Given I have an updated employee schedule
	When I run so amd so job
	Then my database table should be updated with so and so
