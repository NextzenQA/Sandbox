Feature: NextzenPage

// This feature is to vaildate all the posiable ways of NextZen Registraion Form Funtionality

 @EnteredStudentDeatilsWithAllRequiredFeilds  @RegisterationTest
Scenario: [Validate the student can submit the information with all required feilds]
	Given I am on NextZen registration page
	When I submit student details with all required feilds
	Then I should see a success message



 @EnteredStudentDeatilsWithoutAllRequiredFeilds  @RegisterationTest
Scenario: [Validate the student can not submit the information with all required feilds]
	Given I am on NextZen registration page
	When I submit student details without all required feilds
	Then I should see a error message


	@SubmitedWithoutAllRequiredFeilds  @RegisterationTest
Scenario: [Validate the student submited without entering all required feilds]
	Given I am on NextZen registration page
	When I submit student details without all required feilds
	Then I should see a error message


