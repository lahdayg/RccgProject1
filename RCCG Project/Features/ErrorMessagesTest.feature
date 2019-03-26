Feature: ErrorMessagesTest
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: inValid Registration
	Given I navigate to site
	When I click on register link
	And I enter firstname
	And I enter last name
	And I enter email "test@giftrete.com"
	And I enter mobile number
	And I enter password "MyNewPassword"
	And I confirm password "No"
	Then the error message "<message>"is displayed for "<test>"
	
	Examples:
	| test             |message                                                 |                                             
	| PasswordTooShort | Your Password Must Be AT Least 5 Character Long        |
	|Invalidemail      | Please Enter A Valid Email Address                     |
	| MobileTooshort   | Your Mobile Number Must Be At Least 10 Characters Long |

	
	