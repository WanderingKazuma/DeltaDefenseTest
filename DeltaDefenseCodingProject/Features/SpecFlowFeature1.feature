Feature: USCCA - Website Test
	This feature file contains some of the basic tests
	that are expected to be run for the automation coding exercise
	for USCCA. 

@SDET
Scenario: Open a Browser to USCCA page and navigate to the login and signup page.
	Given I have a browser pointed at "https://www.usconcealedcarry.com/"
	When I click on the Log In Header Link
	And I click on the Sign Up Today Button
	Then I should see the sign up Form
	And I should close the browser

@SDET
Scenario: Create an email on Putsbox, and signup on USCCA website as free account.
	Given I have a browser pointed at "http://www.putsbox.com"
	When I enter in "jy-DDTest-002" into the email textfield
	And I click Create Inbox
	When I navigate to "https://www.usconcealedcarry.com/"
	And I click on the Log In Header Link
	And I click on the Sign Up Today Button
	And I enter "Jason" for the First Name Field
	And I enter "Yang" for the Last Name Field
	And I enter "jyDDTest-002@putsbox.com" for the Email Field
	And I enter "tes541pvq3r45" for the Password and Password Confirmation Fields
	And I click Create Account
	#Then I should receive an email confirming registration.								##At the time of writing this automation, emails are taking ~10 minutes or longer to be received. Not realistic for CI/CD env where test results expected in less than 30 minutes. Different solution needed here...
	Then I should close the browser

@SDET
Scenario: Signup on USCCA website as already used account.
	Given I have a browser pointed at "https://www.usconcealedcarry.com/"
	When I click on the Log In Header Link
	And I click on the Sign Up Today Button
	And I enter "Jason" for the First Name Field
	And I enter "Yang" for the Last Name Field
	And I enter "jyDDTest-002@putsbox.com" for the Email Field
	And I enter "tes541pvq3r45" for the Password and Password Confirmation Fields
	And I click Create Account
	Then I should see a Used Email Error
	And I should close the browser

@SDET
Scenario: Login and Change Password
	Given I have a browser pointed at "https://www.usconcealedcarry.com/"
	When I click on the Log In Header Link
	And I enter "jyDDTest-002@putsbox.com" for the Email Login Field
	And I click on the Continue Button
	And I enter "tes541pvq3r45" for the Password Login Field
	And I click on the Log In Now Button
	And I click Account Details LinkGroup
	And I click on Contact Information
	And I click on Edit Password Link
	And I enter new Password "tes541pvq3r46" and select Update
	And I click Log Out in the Header
	When I click on the Log In Header Link
	And I enter "jyDDTest-002@putsbox.com" for the Email Login Field
	And I click on the Continue Button
	And I enter "tes541pvq3r46" for the Password Login Field
	And I click on the Log In Now Button

@SDET
Scenario: Video Exploration and Excel Output
	When I click on Education and Training
	Then I should see the available videos
	And I can export these headers into an excel file

@SDET
Scenario: Search for 7 reasons to join
	When I search for "7 reasons to Join"
	And I click on the first link
	Then I should see 3 of the reasons to join
