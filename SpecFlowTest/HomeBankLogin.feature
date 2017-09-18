Feature: Login Feature

	In order to check my ING card funds
	As a normal human being
	I want to login into ING HomeBank site

Scenario: Cannot Login unless the username and password are correct
	Given I am on the homepage of the site
		And I enter a username of MariaSiIon
		And I enter a password of Test
	When I click Login
	Then I should see an error message telling me that the username and/or password are incorrect

Scenario: Cannot Login unless the password field is filled
	Given I am on the homepage of the site
		And I enter a username of MariaSiIon
	When I click Login
	Then I should see an error message telling me that i need fill both username and password fields with values

Scenario: Cannot Login unless the username field is filled
	Given I am on the homepage of the site
		And I enter a password of Test
	When I click Login
	Then I should see an error message telling me that i need fill both username and password fields with values
