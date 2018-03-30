# C# quick start for Pythonistas #
python                 | c#                   | notes
-----------------------|----------------------|----- 
`print "hello world"`  | `Console.WriteLine("hello world");` 
`import json`          | `using Newtonsoft.Json;`
`myname = 'Tyson'`     | `string myName = "Tyson";` <br>-or-<br> `var myName = "Tyson";` (implicit type)
`def do_thing(): `<br>&nbsp;&nbsp;`# do that thing`| `void doThing()`<br>` {` <br>&nbsp;&nbsp;`//do that thing`<br>`}` | "`void`" is the return type <br>for "returns nothing" <br>- if the function returned a <br>`string`, it would be <br>`string doThing()`
`# this is a comment` | `// this is a single-line comment`
`for i in range(0,10):`<br>&nbsp;&nbsp;`print i` | `for(int i=0; i<10; i++) `<br>`{`<br>&nbsp;&nbsp;`Console.WriteLine(i.ToString());`<br>`}`
`for dog in dogs:`<br>&nbsp;&nbsp;`pet(dog)` | `foreach(Dog dog in dogs) {`<br>&nbsp;&nbsp;`Pet(dog)`<br>`}`
`if test1:`<br>&nbsp;&nbsp;`#do thing`<br>`elif test2:`<br>&nbsp;&nbsp;`#do thing2`<br>`else test3:`<br>&nbsp;&nbsp;`#do thing3` | `if(test1) { `<br>&nbsp;&nbsp;`//do thing`<br>`} else if (test2) {`<br>&nbsp;&nbsp;`//do thing2`<br>`} else {`<br>&nbsp;&nbsp;`//do thing3`<br>`}`
`[dog for dog in dogs if dog.weight > 100]` | `dogs.Where(dog => dog.Weight > 100)`
`instance = MyCustomClass()` | `MyCustomClass instance = new MyCustomClass();` | (`var` works too)

## Big Differences: ##
### Whitespace don't matta! ###
C# is basically whitespace agnostic - format your lines and indentation however you damn well please. Instead, you'll see more `{}` brackets to enclose blocks and `;` to end statements. 

### Strong typing ###
C# is a statically typed language, whereas python is dynamically typed. This means a few things:
* types are checked at compile-time, rather than at run-time
* variables can be declared without being assigned a value
* variables cannot change type, so, whereas python will let you do this:
<br>`myvar = 'a kitten' `<br>`myvar = 45`<br>`myvar = {'bip': 'bop'} `<br>C# (generally) will not. 
* this also means you have explicitly convert objects from one type to another, often via casting or explicit methods (like `.ToString()`)
### Compiled ###
As a somewhat innacurate generalization, Python is an interpreted language whereas C# is a compiled language. (in reality it is more complicated than this and both languages are kind of both but ¯\\\_(ツ)_/¯ ) For our purposes we can just say that in order to run c#, you must always "Build" it into a `.dll` or `.exe`. 
### Collections ###
There are some differences between the way python + C# handle collections. Python lists look a lot like C# arrays, but behave like C# lists. C# arrays are fixed-size, so you can't initialize them as `[]` and then add items to them. For variable sized collections, you'll need C# `List`s (`System.Collections.Generic.List<T>`) which introduces another new topic - "Generics". Both lists and arrays in C# must know their type, and will not accept objects of a different type. Some general remarks:
* `List<T>` is slower than an array but much more flexible - usually it will be fine for your purposes.
* list + array access look just like python: `MyList[5]` will retun the 6th element in the collection. 
* Setting up a list can look a little funky if you're used to Python: <br>`List<string> namesOfStuff = new List<string>();`<br> initializes an empty list. You can also populate a list at initialization, like so:<br>`var namesOfStuff = new List<string>{"Rock", "Plant", "Sofa", "Cheeky Neon", "Fruit Water"};` (note the `{}` instead of `()`)
### Object-Orientation ###
Python lets you be as Object-oriented as you want - but it is possible to write python code that avoids object-orientation almost entirely. C# is much more opinionated about object-orientation, and has a lot of language features/architecture organized around OO practices. Python is much more flexible and free - it does less implicit hiding and protecting of class members, it's much easier to alter the behavior of code from modules borrowed from elsewhere. C# can be quite strict about what you're allowed to do, and good C# involves a lot of "encapsulation" which can feel foreign if you're used to python. 