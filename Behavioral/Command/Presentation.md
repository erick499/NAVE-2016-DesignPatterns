# Design Pattern

## Command

1. [Diagrama de classes](#diagram)
2. [Definição](#definition)
3. [Exemplos](#examples)

## Definição

O padrão de projeto (Design Pattern) Command é um padrão comportamental  cuja intenção é encapsular uma solicitação como um objeto e desta forma permitir que você parametrize clientes com diferentes solicitações, enfileire ou registre(log) solicitações e suporte operações que podem ser desfeitas.(GoF)

### Sinônimos
Em alguns códigos é possível ver alguns sinôimos que substituem a palavra command. Ex: Action, Transaction

### Necessidade
É necessário em momentos onde deve-se emitir informações ou requerimentos para o objeto sem nada sabe sobre a operação que está sendo solicitada ou mesmo sobre seu receptor. 
## Diagrama
<img src="http://www.macoratti.net/13/03/net_cmd1.gif" width="60%" height="60%">

- **Command**: Declara uma interface para a execução de uma operação.
- **ConcreteCommand**: Define uma vinculação entre um objeto, um Receiver e uma ação. E também implementa “execute” através da invocação da operação correspondente no Receiver.
- **Client**: Cria um objeto ConcreteCommand e estabelece o seu receptor.
- **Invoker**: Solicita ao Command a execução da solicitação
- **Receiver**: Sabe como executar as operações associadas a uma solicitação. Qualquer classe pode funcionar como um Receiver.

## Exemplos

  O código a seguir é uma implementação do padrão do command em Java

```java
  public class portao {
      public final static void int ABERTO = 0;
      public final static void int FECHADO = 1;
      
      private int estado;
      
      public void getEstado(int estado) {
          return estado;
      }
      
      public void setEstado(int estado) {
          this.estado = estado;
      }
      
      public void abrir() {
          this.estado = ABERTO;
      }
      
      public void fechar(){
          this.estado = FECHADO;
      }
  }
```

```java
  public interface Command {
      public void execute();
      public void undo();
  }
```

```java
  public class AbrirCommand inplements Command{
      private Portao portao;
      
      public AbrirCommand (Portao portao) {
          this.portao = portao;
      }
      
      public void execute() {
          portao.abrir();
      }
      
      public void undo() {
          portao.fechar();
      }
  }
```

```java
  public class Controle {
      private Command[] commands;
      private Command ultimoCommand;
      
      public Controle(Command abrirCommand, Command fecharCommand) {
          this.commands = new Command[2];
          commands[0] = abrirCommand;
          commands[1] = fecharCommand;
      }
      
      public void abrirPortão() {
          commands[0].execute();
          ultimoCommand = commands[0];
      }
      
      public void fecharPortão() {
          commands[1].execute();
          ultimoCommand = commands[0];
      }
      
      public void desfazer() {
          ultimoCommand.undo();
      }
  }
```

  O código a seguir é uma implementação do padrão do command em Coffeescript
  
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

## Créditos
- Name: [Yago Azedias](https://github.com/yagoazedias)
- Email: yagoazedias@gmail.com
- Referência: http://www.csi.uneb.br/padroes_de_projetos/command_2.html
