Feature: Registration
	So that I can use the site
	I need to register
	

@mytag
Scenario: Valid Registration
	Given I navigate to site
	When I click on register link
	And I enter firstname
	And I enter last name
	And I enter email "test@giftrete.com"
	And I enter mobile number
	And I enter password 
	And I confirm password
	And I click on signup
	Then I should be registered


	Scenario: inValid Registration
	Given I navigate to site
	When I click on register link
	And I enter firstname
	And I enter last name
	And I enter email "test@giftrete.com"
	And I enter mobile number
	And I enter password 
	And I confirm password 
	And I click on signup
	Then the password is too short error is displayed
	And I should be registered
	
