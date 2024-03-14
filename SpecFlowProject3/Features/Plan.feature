Feature: Plan

Flow of plan 

Background: 
  Given user navigate to url
  When user enters all valid details

  

@tag1
Scenario: Adding a tip from plan flow
   Given user clicks on plan 
	When click on make new extra action
    When user selects category 
	When user selects sources
	And user adds the description 
	Then then user clicks on submit
	
 Scenario: Adding a plan and deadline 
    Given user clicks on  any plan 
 Then user selects a particular tip and clicks on plus icon
 When user then selects the person
 And user selects a dedaline 
 And user can eneble or disable the deadline notification
 Then user clicks on create measure

