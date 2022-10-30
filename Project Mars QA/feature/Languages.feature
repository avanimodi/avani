Feature: Languages

I want to add,update and delete skills to my profile details


@tag1
Scenario:2-1[Create new Skill for the seller]
   Given  I loggedin to the website 
	When I navigate Language in the profile page
	And  I create credential in the Language
	Then Language should be created successfully

Scenario:2-2[Edit Language]
	Given I loggedin to the Mars website
	When I navigate Language in profile page
	And I Edit '<Language>' credential in profile page
	Then Record should be edited successfully '<Language>' 
	
	Examples:

	|Language |	       
    | Hindi   |



Scenario:2-3[Delete Languege ]
	Given I login to localhost website
	When I navigate language in  profile  
	And I deleted credential in language
	Then language should be delete successfully







