Feature: IngHomeBankFeature
	In order to check my ING card funds
	As a normal human being
	I want to login into ING HomeBank site

Scenario: Login Completed Unsuccessfully
	Given I am on the homepage of the site
		And I enter a username of "Test"
		And I enter a password of "Test"
	When I click Login
	Then I should see the "Codul de Utilizator/Codul introduse nu sunt corecte!" error



