Feature: Settings

To test the normal flow of settings

Background: 
Given user enters the url 
When user enters the valid credentials
And user click on signin 
Then user clicks on settings

@tag1
Scenario: Basic flow of messages
	Given click on notifications
	When then make  allow notifications to enable or disable
	And after that enable and disbale the notifications which u want

Scenario: Entering  the feedback
 Given click on feedback
Then enter the feed back

Scenario: delete and logout account
Given click on accounts
And select logout then main login page will appear
Then select delete account

Scenario: Changing the language
Given click on taal
Then select the language (english or dutch)

Scenario: Going through the Privacy declaration and Scientific basis
Given select the Privacy declaration
Then select the Scientific basis