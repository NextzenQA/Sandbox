Feature: Amazon Search


Scenario: Validate amazon search within a department - Mens
Given I am amazon search
When I search for 'shoes' in '   Men's department
Then I should the shoes in "Men's Fashion" in results

Scenario: Validate amazon search within a department - Women
Given I am amazon search
When I search for 'belts' in '   Women's department
Then I should the shoes in "Women's Fashion" in results

