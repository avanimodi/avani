

Feature: Skills

A short summary of the feature

@tag1
Scenario:3-1[Create new Skills for seller]
	Given I login to the mars website
	When I navigate skills in profile page 
	And I create credential in skill
	Then skill should be created  successfully

Scenario:3-2[Edit Skills ]
	Given I login to the  website
	When I navigate skills in the profile page 
	And I edit '<Skill>'credential in skills
	Then Skill should be edited successfully in '<Skill>'

	Examples: 
	
	| Skills|
	| aaa |



Scenario:3-3[Delete skills ]
	Given I login to website
	When I navigate skills in the profile  
	And I delete credential in skill
	Then skill should be deleted successfully


