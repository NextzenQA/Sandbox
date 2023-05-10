Feature: Amazon Search


Scenario: Validate amazon search within a department - Mens
Given I am amazon search
When I search for 'shoes' in 'search-alias=fashion-mens's department
Then I should the shoes in "Men's Fashion" in results

Scenario: Validate amazon search within a department - Women
Given I am amazon search
When I search for 'belts' in 'search-alias=fashion-womens's department
Then I should the shoes in "Women's Fashion" in results


#Men, shoes - test data
#Women, belts - test data

# should not be more than 5 lines . 3 - good, 4 -ok 5 limit
#B - Business Language - do not use words like click, enter
#R - Real Data - do not use test specific data
#I - Intention Revealing - DO NOT DO THIS - decribing application mechanics - How to , what are you expecting from the sye
#E - Essential Information
#F - Focus
