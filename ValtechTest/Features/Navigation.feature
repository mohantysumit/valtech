Feature: Navigation

Background:
	Given I am on the valtech homepage

Scenario Outline: Navigating to the toolbar pages
	When I navigate to the <page> page
	Then I should see the <page> header

	Examples:
	| page     |
	| About    |
	| Services |
	| Work     |
