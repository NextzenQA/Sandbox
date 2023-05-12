Feature: Alerts

A short summary of the feature

@tag1
Scenario: Accepting Alerts on Cher Cher 
	Given I am on cher cher practice popups page
	When I bring an alert
	Then I should be able to accept the alert

Scenario: Accept Confirmation on Cher Cher 
	Given I am on cher cher practice popups page
	When I bring a confirmation
	Then I should be able to accept the confirmation

Scenario: Decline Confirmation on Cher Cher 
	Given I am on cher cher practice popups page
	When I bring a confirmation
	Then I should be able to decline the confirmation

Scenario: Accept a prompt with a message on Cher Cher 
	Given I am on cher cher practice popups page
	When I bring a prompt
	Then I should be able to accept the prompt with a message

Scenario: Decline a prompt with a message on Cher Cher 
	Given I am on cher cher practice popups page
	When I bring a prompt
	Then I should be able to decline the prompt with a message


	#var saiAlert = Driver.SwithTo().Alert();
	#saiAlert.Accept();
	#saiAlert.Dismiss();
	#saiAlert.Text
	#saiAlert.SendKeys("This is my text")