Feature: Login

A short summary of the feature

@tag1

Scenario: Login to website
	Given I login to the mars website
	When I navigate to profile page 
	And I  update First Name in Profile Page 
	Then First Name should be updated successfully 

	Scenario: Update Last Name in Profile Page 
	Given I login to the website
	When I navigate to profile page 
	And I  update First Name in Profile Page 
	Then Last Name should be updated successfully

	
	
Scenario:Person Hours
	Given I login to the website
	When I navigate hours in profile page 
	And I  update credential in Hours
	Then Hours should be updated  successfully   

Scenario:Earn Target
	Given I login to the website
	When I navigate Earn Target  in profile page 
	And I  update credential in Earn Target
	Then Earn Target should be updated  successfully  

Scenario:Description
	Given I login to the website
	When I navigate Description in profile page 
	And I  update credential in Description
	Then Description should be updated  successfully

Scenario:Certification 
	Given I login to the website
	When I navigate Certification in profile page 
	And I create credential in Certification
	Then Certification should be created  successfully

	Given I login to the website
	When I navigate Certification in profile page 
	And I edit credential in Certification
	Then Certification should be edited successfully

	Given I login to the website
	When I navigate Certification in profile page 
	And I delete credential in Certification
	Then Certification should be deleted successfully

	Scenario:Eduction  
	Given I login to the website
	When I navigate eduction in profile page 
	And I create credential in eduction
	Then eduction should be created  successfully

	Given I login to the website
	When I navigate eduction in profile page 
	And I edit credential in eduction
	Then eduction should be edited successfully

	Given I login to the website
	When I navigate eduction in profile page 
	And I delete credential in eduction
	Then eduction should be deleted successfully

