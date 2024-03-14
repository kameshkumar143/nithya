Feature: SuperAdminTip

For the super admin adding tips


Background:navigate to superadmin login
      Given navigate to the superadmin url
      When user should a enter the mail
	  When user should  a click on next
	  When user should  a enter the password
	  And user should click  signin button
	 Then user either selects  a yes or no
    


@tag1
Scenario: Adding tips for Personal 
	When click on the addtip field
	And then click on category 
	And select on any category
	And then click on source 
	And select on any sources
	And after that enter a title
	And then enter a description
	Then click on submit

@tag2
Scenario:Adding tips for Department
     When click on the Department addtip field
	 And click on Department field 
	And then click on  Department category 
	And select on any  Department category
	And then click on  Department source 
	And select on any  Department sources
	And after that enter a  Department title
	And then enter a  Department description
	Then click on  Department submit


