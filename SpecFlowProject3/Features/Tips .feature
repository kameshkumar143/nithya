Feature: Tips 

End to End flow of tips for users

Background: 
      Given navigate to ene url
     When user  enters her/his  name 
     And user  should enters password
     Then user should click on  sign in button


@tag1
Scenario: user selects his favourite tips 
    When user clicks on personal
	When user selects the tips option
	When then user selcts a source
    Then user favourite his/her tip

	
