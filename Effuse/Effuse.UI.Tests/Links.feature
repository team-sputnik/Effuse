Feature: Links

Given i am in a conversation

@mytag
Scenario: Http addresses are hyperlinks

       When I send a message with a HTTP address
       Then The message is sent
       And the HTTP address is marked as a hyperlink

 Sce