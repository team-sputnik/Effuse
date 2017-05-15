Feature: Links

Background: 
	Given I am in a conversation

@Conversation
@WebLinks
Scenario: Http addresses are hyperlinks
    When I send a message with a HTTP address
    Then The message is sent
    And the HTTP address is marked as a hyperlink

@Conversation
@WebLinks
@ReminderTab
Scenario: Received Http links are automatically placed in the links tab
	When I receive a messate with a HTTP address
	Then the http address is stored in the reminder tab

@Conversation
@WebLinks	
Scenario: Visited Http addresses are marked as visited
	When I receive a messate with a HTTP address
	And i click the address
	Then The address is marked as visited