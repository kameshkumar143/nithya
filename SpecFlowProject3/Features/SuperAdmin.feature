Feature: SuperAdmin

Adding the company details with valid credentials

Background: 
      Given navigate to the  url
	  When user should enter the mail
	  When user should click on next
	  When user should enter the password
	  And user should click on signin button
	  Then user either selects yes or no
   


@tag1
Scenario:Adding a company admin
	When superadmin should enter valid name
	And superadmin should enter valid emailid
	And superadmin should select a companyname 
	Then superadmin should click on submit button

	Scenario:Adding a new company
	When super admin click on addcompany
	And superadmin should enter valid companyname
	Then superadmin should cilck on click to add button