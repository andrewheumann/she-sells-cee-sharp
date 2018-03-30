# C# quick start for Pythonistas #
python                 | c#                   | notes
-----------------------|----------------------|----- 
`print "hello world"`  | `Console.WriteLine("hello world");` 
`import json`          | `using Newtonsoft.Json;`
`myname = 'Tyson'`     | `string myName = "Tyson";` <br>-or-<br> `var myName = "Tyson";` (implicit type)
<code>def do_thing(): <br>&nbsp;&nbsp;# do that thing</code> | <code>void doThing()<br> { <br>&nbsp;&nbsp;//do that thing<br>}</code> | "`void`" is the return type <br>for "returns nothing" <br>- if the function returned a <br>`string`, it would be <br><code>string doThing()</code>
`# this is a comment` | `// this is a single-line comment`
<code>for i in range(0,10):<br>&nbsp;&nbsp;print i</code> | <code>for(int i=0; i<10; i++) <br>{<br>&nbsp;&nbsp;Console.WriteLine(i.ToString());<br>}</code>
<code>for dog in dogs:<br>&nbsp;&nbsp;pet(dog)</code> | <code>foreach(Dog dog in dogs) {<br>&nbsp;&nbsp;Pet(dog)<br>}</code>
`[dog for dog in dogs if dog.weight > 100]` | `dogs.Where(dog => dog.Weight > 100)`

## Big Differences: ##
### Whitespace don't matta! ###
C# is basically whitespace agnostic - format your lines and indentation however you damn well please. Instead, you'll see more `{}` brackets to enclose blocks and `;` to end statements. 

### Strong typing ###
C# is a statically typed language, whereas python is dynamically typed. This means a few things:
* types are checked at compile-time, rather than at run-time
* variables can be declared without being assigned a value
* variables cannot change type, so, whereas python will let you do this:
<br><code>myvar = 'a kitten' <br>myvar = 45<br>myvar = {'bip': 'bop'} </code><br>C# (generally) will not. 
* this also means you have explicitly convert objects from one type to another, often via casting or explicit methods 
### Compiled ###
As a somewhat innacurate generalization, Python is an interpreted language whereas C# is a compiled language. (in reality it is more complicated than this and both languages are kind of both but ¯\\\_(ツ)_/¯ ) For our purposes we can just say that in order to run c#, you must always "Build" it into a `.dll` or `.exe`. 