 Feature: Feature3

checking the end to end flow of personal and department

Background: 
Given navigate to the energyapp url
When user enters his mail
And user enters his pasword
Then user clicks on signin


Scenario: Flow of scores in personal and department
When user click on personal button and score
When After that user checks the maandscore, average ,trend and branch
When user clicks on department button
And user clicks on scores
Then after users clicks on maandscore, average ,trend and branch

Scenario:Flow of analysis in department 
When userr click on department
Then user clicks on analysis button



Scenario:Flow of analysis in personal
When user click on personal
When user click on analysis button
When user select on Stressbronne,energyborn,kwetsbaarheden and hulpbronne
When click on sla op
Then click on ok button












	
