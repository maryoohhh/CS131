# CS131: C#

Chapter 1: Introduction to C# Coding and Debugging
---------------------------------------------------

**Brief History**

<dl>
    <dt>C#</dt>
    <dd>is amultipurpose language that can be used to develop console. windows, web, and mobile applications</dd>
    <dd>was first introduced as part of the Microsoft .Net Framework, which was announced and demonstrated in July 2000 at Microsoft's Professional Developers Conference</dd>
</dl>

**Understanding Basic Code Terminology**

<dl>
    <dt>Variables</dt>
    <dd>user-defined named references to stored data</dd>
    <dd>usually nound that describe the items stored</dd>
    <dd>properly named variables help narrate code</dd>
    <dt>Methods</dt>
    <dd>groups of instructions that perform a routine</dd>
    <dd>names are usually verbs that describes the action they perform</dd>
    <dd>help reduce duplicate code by enabling code reuse in addition to making programs easier to read and debug</dd>
    <dt>Classes</dt>
    <dd>templates that provide a related grouping of meathods, data, and other constructs</dd>
    <dd>used to create object</dd>
    <dt>Namespace</dt>
    <dd>logical groupings of classes</dd>
    <dd>referencing namespaces (with 'using' statements) at the top of your code file lets you use their classes in that file</dd>
    <dd>prevent conflicts that occur when classes have identical names</dd>
    <dt>Comments</dt>
    <dd>narrate codes</dd>
    <dd>not included in the executable applications</dd>
    <dt> Single-line comments</dt>
    <dd>preceded by two forward slashes</dd>
    `// Comments about the code structure go here`
    <dt>Multiple-line comments</dt>
    <dd>begins with /* and end with */</dd>
    <dd>maybe used for narrative paragraphs</dd>
    `/* Information about the code structure belongs here */`
    <dt>XML tag comments</dt>
    <dd>precede by triple forward slashes</dd>
    <dd>enables auto-generation of HTML documentation that is enabled in VS</dd>
    <dd>enable tooltip hnts for describing code blocks</dd>
    <dd>9 main comment tags: remarks, summary, example, exception, param, permission, returns, seealso, and include</dd>
    `/// < summary >`
    <dt>Syntax</dt>
    <dd>set of rules for structural correctness of a programming language</dd>
    <dt>Indentation</dt>
    <dd>opening and closing curly braces are required to enclose structures such as classes, methods, and more</dd>
    <dd>for readability and by convection, it is essential to indent and left-align the code within each pair of curly braces, including structures inside structures</dd>
</dl>

Chapter 2: Variables, Constants, Arrays, and Enumerations
----------------------------------------------------------

<dl>
    <dt>Variables</dt>
    <dd>uniquely named references to store data</dd>
    <dd>values can change at run time</dd>
    <dt>Constants</dt>
    <dd>uniquely named references to values</dd>
    <dd>values cannot change after they are assigned when the constants are declared</dd>
    <dt>Arrays</dt>
    <dd>store multiple values of the same data type</dd>
    <dt>Enumerations</dt>
    <dd>sets of named constants called *enumerators*</dd>
    <dd>customizable type offers a reader-friendly reference to a group of constant values</dd>
</dl>

> C# is a stongly typed language.

This means that once a data structure s defined with a given data type, the structure is unable to hold a value of different type.

![Figure 2-1 Common Data Types](https://github.com/maryoohhh/CS131/blob/master/Images/Figure2-1.png)

*Figure 2-1: Common Data Types*

**Numeric Lieterals**

```
// Height in Meters
float cnTower = 553;                // Valid
float empireStateBuilding = 443.1;  // Causes error
float burjKalifa = 829.8f;          // Valid
```

Notice that fractional numeric values require a suffix of `f` to distinguish them as float type. Whole numbers can be assigned to float types because float is large enough to store any valid whole numbers.

```
// Net Worth in US Dollars
decimal amancioOrtega = 51700000000;        // Valid
decimal ingvatKamprad = 39900000000.79m;    // Valid
decimal leeShauKee = 22300000000.34;        // Causes error
```

Notice that whole number can be assigned to decimal variables because the decimal format is large enough to store any whole number. On the other hand, the format of a fraction value must be clarified with the numeriic literal `m` before the number can be assigned to a decimal variable.

**Variable Types**

<dl>
    <dt>Value Type</dt>
    <dd>store simple types that are predefined in the C# library, such as integer, float, and decimal types</dd>
    <dd>reference a location in memory that stores the data</dd>
    <dt>Reference Type</dt>
    <dd>reference custom objects made using classes or collections of data</dd>
    <dd>refer ti a location in memory that contains the starting address where the data is stored</dd>
</dl>

**Variable Syntax**

Variables can be declared separately and then initialized later:
```
int totalOutlets; // Declare the variable
totalOutlets = 4; // Initialize the variable
```

Variables can also be declared and initialized on the same line:
`int totalOutlets = 4;`

**Variable Names**

Variable names are written in *camelCase*, meaning the first letter of the name is lowercase and then, after the first word, each consecutive word in the variable name begins with an uppercase letter.

> **Note**
Most C# developers use camelCaase names when the variable's access level is private or protected. With this same standard, if the variable access level is public, the variable name is wirtten in *PascalCase*, meaning each word in the name starts with an uppercase letter while all other letters are lowercase.

**Constants**

Constants are different from variables, though, because constant values cannot change after they are intialized. Since constant values are fixed, the constant reference prevents unwanted data tampering throughout the program. In addition, the constant's name provides a reader-friendly reference for the data value.

**Constant Syntax**

Declaration is preceded with the keyword `const`

`const string FUN_FACT = "Facts about Venus";`

**Consant Names**

> Most C# developers write constant names entirely with uppercase letters.

**Explicit Variable Conversion (Casting)**

When working with nummeric values, if you need to assign a value from a variable with a type that has more storage space into a variable type with a similar format but less storage, you must perform a *cast*.

```
float distance = -386.8f;
int distanceInMiles = (int)distance; // Stores -386
```

**Implicit Variable Conversion**

When working with similar numeric data types, if you assign a value to a variable with a data type that has more storage space, then an implicit conversion occurs.

```
float distance = -67.7f;
double distanceInMiles = distance; // Convers to -67.6999969482422
```

**Arrays**

Arrays store multiple values of the same data type.

**Array Syntax**

Each value within the array is stored inside an *element* of the array. Elements of the array are referenced sequentially with an *index*.

`string[] island = new string [] {"Hawaii", "Maui", "Oahu", "Kauai", "Molokai", "Lanai", "Niihau", "Kahoolawe"};`

![Figure 2-2 Array address, indexes, and elements](https://github.com/maryoohhh/CS131/blob/master/Images/Figure2-2.png)

*Figure 2-2: Array address, indexes, and elements*

Three common ways to declare arrays are to state
* Type, name, and array size together

```
string[] name = new string[3];
name[0] = "Hawaii"; // first element referenced at index '0'
name[1] = "Maui"; // second element referenced at index '1'
name[2] = "Oahu"; // third element referenced at index '2'
```

* Type and name first and then size allocation later

```
string[] name;
    name = new string[3];
name[0] = "Hawaii"; // first element referenced at index '0'
name[1] = "Maui"; // second element referenced at index '1'
name[2] = "Oahu"; // third element referenced at index '2'
```

* Type, name, and size inferred while initializing element values when the aray is declared

`string[] island = new string [] {"Hawaii", "Maui", "Oahu", "Kauai", "Molokai", "Lanai", "Niihau", "Kahoolawe"};`

**Array Length**

Each array instance exposes a `Length` property to obtain the number of elements in the array.

 ```
 using System;

 namespace Starter {
     class Program {
         public static void Main() {
             string[] island = new string [] {"Hawaii", "Maui", "Oahu", "Kauai", "Molokai", "Lanai", "Niihau", "Kahoolawe"};
             Console.Write("The total main Islands of Hawaii is ");
             Console.WriteLine(island.Length);
             Console.ReadLine();
         }
     }
 }
 ```

 **Sorting Arrays**

 Single-dimensional arrays can be sorted with the `Sort()` method:

 `void Sort(arrayType[] array);`

 Example

  ```
 using System;

 namespace Starter {
     class Program {
         public static void Main() {
             string[] surfDestinations = new string [] {"Ehukai Beach Park", "Laniakea", "Backyards", "Hookipa", "Honolua"};
             Array.Sort(surfDestinations);
             Console.Write("Top 5 Hawaiian surf destinations in alphabetical order: ");
             Console.WriteLine(surfDestinations[0] + ", " + surfDestinations[1] + ", " + surfDestinations[2] + ", " + surfDestinations[3] + ", " + surfDestinations[4] + ".");
             Console.ReadLine();
         }
     }
 }
 ```

 **Multidimensional Arrays**

![Figure 2-3: Multidimensional array](https://github.com/maryoohhh/CS131/blob/master/Images/Figure2-3.png)

*Figure 2-3: Multidimensional array*

**Multidimensional Array Syntax**

`int[,] forecast = new int[NUM_DAYS, NUM_WEATHER_STATS];`

To assign values to elements

```
forecast[WED, LOW] = 69;
forecast[WED, HIGH] = 80;
```

**Multidimensional Array Length**

`int GetLength(int dimension);`

**Enumerations**

An enumeration type defines a list of related constant values.

**Enumerations Syntax**

Enumeration types are defined using the `enum` keyword.

`enum PlanetSize{Jupiter, Saturn, Uranus, Neptune, Earth, Venus, Mars, Mercury, Pluto};`

Enumerator values can be assigned manually too.

`enum PlanetDiameter { Jupiter=88800, Saturn=74900, Uranus=31763, Neptune=34500, Earth=7926, Venus=7500, Mercury=3030, Pluto=1480};`

When you need to obtain a value associated with the enumerated item, a cast is required:

`int JupiterSize = (int)PlanetDiameter.Jupiter;`

**Enumeration Naming**

Enumeration names are most commonly written using *PascalCase*.

**Enumeration Methods**

You can obtain the name of an enumerator with a cast using the enumeration type and the value of the enumerator.

`enum {Jupiter, Saturn, Uranus, Neptune, Earth, Venus, Mars, Mercury, Pluto};`

the enumerator name can be obtained using the enumerator's value:

```
Planet enumerator = (Planet)4;
string name = enumerator.ToString();
// Assign 'Earth'
```

**Determining the Enumerator Count**

`GetNames()` methos requires the enumeration type as a parameter.

`string[] planetNames = Enum.GetNames(typeof(Planet));`

Once the enumerator names are stored in a string array, you can obtain their count by checking the `Lenght` property of the array:

`int totalPlanet = planetNames.Length;`

Chapter 3: Numeric Operators and Routines
------------------------------------------

**Basic Calculations**

    | Function
--- | --------
`+` | addition
`+=` | compound operator, reassigns a variable on the left with its starting value plus the right operand value
`-` | subtraction
`-=` | reassigns a variable with its staring value minus the right operand
`*` | multiplication
`*=` | reassigns the variable on the left with its original valu multiplied by the right operand
`/` | division
`/=` | reassigns a variable at the left with its starting value divided by the right operand
`%` | used to calculate the remainder during division
`%=` | implement a self-assignment
`Math.Pow(base, exponent)` | exponential
`Math.Sqrt()` | square root

