Feature: Nextzen

A short summary of the feature

@tag1Loginwithvalidcredentials
Scenario: [Login with valid credentials]
	Given I am in Nextzen Registration page
	When I login with shumayla
	Then I should see Successful login and redirect to homepage

@tag1Loginwithinvalidcredentials
Scenario: [Login with invalid credentials]
	Given I am in Nextzen Registration page
	When I login with shumayla
	Then I should see an error message "Invalid Credentials"

@tag1Loginwithemptycredentials
Scenario: [Login with empty credentials]
	Given I am in Nextzen Registration page
	When I login with shumayla
	Then I should see an error message "First name and last name are required fields"
