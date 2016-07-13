# Design Pattern

## Command

1. [Class Diagrams](#diagram)
2. [Definition](#definition)
3. [Examples](#examples)

## Definition

the command pattern is a behavioral design pattern in which an object is used to encapsulate all information needed to perform an action or trigger an event at a later time. 

## Diagram
<img src="http://www.macoratti.net/13/03/net_cmd1.gif" width="60%" height="60%">

## Examples

  The following code is an implementation of Command pattern in Coffeescript

```coffeescript
# The Invoker function
class Switch
   _commands = []
   storeAndExecute: (command) ->
     _commands.push(command)
     command.execute()

#  The Receiver function
class Light
  turnOn: ->
    console.log ('turn on')
  turnOff: ->
    console.log ('turn off')

# The Command for turning on the light - ConcreteCommand #1 
class FlipUpCommand
 constructor: (@light) ->

 execute: ->
   @light.turnOn()

# The Command for turning off the light - ConcreteCommand #2
class FlipDownCommand
 constructor: (@light) ->

 execute: ->
   @light.turnOff()

light = new Light()
switchUp = new FlipUpCommand(light)
switchDown = new FlipDownCommand(light)
s = new Switch()

s.storeAndExecute(switchUp)
s.storeAndExecute(switchDown)
```

## Credits
- Name: [Yago Azedias](https://github.com/yagoazedias)
- Email: yagoazedias@gmail.com
