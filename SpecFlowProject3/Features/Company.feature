Feature: Company

login with allvalid crendentials

Background: 
      Given navigate to url
     When company admin should enter username 
     And company admin  should enter password
     Then click on the sign in button


  Scenario:login with allvalid crendentials
 When navigate to add department button
  And enter new department
  Then click on the add department

 Scenario:navigate to our department list 
 When navigate to search department field 
 Then close the app

 Scenario:addind a new user to the department
When click on particular department
And click on add user
And then enter valid name 
And the enter valid mailid
Then click on to add user