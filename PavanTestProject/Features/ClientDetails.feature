Feature: ClientDetails

This feature is to document the Nextzen clients details functionality

#This is one application begaviour
Scenario: Validate the Client can submit information with required fields
	Given I am on Nextzen client details page
	When I submit client details with all required fields
	Then I should see a successful submission message

#This is another application begaviour
Scenario: Validate the Client can not submit information without required fields
	#Context
	Given I am on Nextzen client details page
	#Trigger or action
	When I submit client details without all required fields
	#Outcome or Validation
	Then I should see an error message
