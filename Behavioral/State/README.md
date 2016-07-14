# State

#### Check list
1 - Identify an existing class, or create a new class, that will serve as the "state machine" from the client's perspective. That class is the "wrapper" class.

2 - Create a State base class that replicates the methods of the state machine interface. Each method takes one additional parameter: an instance of the wrapper class. The State base class specifies any useful "default" behavior.

3 - Create a State derived class for each domain state. These derived classes only override the methods they need to override.

4 - The wrapper class maintains a "current" State object.

5 - All client requests to the wrapper class are simply delegated to the current State object, and the wrapper object's this pointer is passed.

6 - The State methods change the "current" state in the wrapper object as appropriate..

#### Definition
The State pattern allows an object to change its behavior when its internal state changes.

<img src="https://sourcemaking.com/files/v2/content/patterns/State1-2x.png" width="70%" height="60%">

# Credits

### [Emanuel Umbelino] (https://github.com/EmanuelUmbelino)

### [Lucas Miiller] (https://github.com/Lucasmiiller01)
