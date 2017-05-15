Feature: Conversation

@CoreRegression
@Messaging
Scenario: Start a conversation
	Given Another user exists
	When I start a conversation with another user
	Then A conversation is started