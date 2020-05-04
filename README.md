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

Operator | Function
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
`++` | increment - pre-increment by placing operator before variable; post-increment by placing operator after variable
`--` | decrement - pre-decrement by placing operator before variable; post-decrement by placing operator after variable
`Random()` | randomization

Chapter 4: Methods and Scope
----------------------------

**Methods** group instructions that are related by their function. **Methods** also enable code reuse and prevent code duplication since each method can be executed as many times as needed.

**Method Syntax**
* **Header** - also known as a method signature, is the first line of a method. It contains, at a minimum, the name of the method, a return type, and a parameter list

* **Name** - PascalCase, usually verb or word combination that describes its funcion

* **Return value** - uses the keyword `return` followed by a reference to the data terminates the method's execution and passes the data back to the calling instructions

* **Retun type** - declares the data type of the value returned by the method to the calling instructions

* **Void type** - if method does not return data, the method retur type is assigned the `void` type

* **Parameters** - variables declared inside the method header. When one or more method parameters exist, the calling instruction must either pass variable values or pass references to the method in the same sequence as their devclaration in the method header. Values that are passed to parameter declarations in the header are called **arguments**

* **Static modifier** - static methods can only call other static methods without an object reference

![Figure 4-1: Method structures](https://github.com/maryoohhh/CS131/blob/master/Images/Figure4-1.png)

*Figure 4-1: Method structures*

**Calling a Method**

> To call a method, you must type the method name and include rhe required arguments within parenthesis

```
using System;

namespace ConsoleApplication1 {
    class Program {
        // Console applications always start in the Main() method
        static void Main() {
            const float MILEAGE = 98.0f;
            float kilometers = ConvertToKM(MILEAGE); // calling instruction

            ShowDistance(MILEAGE, kilometers); // calling instruction
            Console.ReadLine();
        }

        // Display the mile to km conversion in a reader friendly format
        static float ConvertToKM(float miles) {
            const float KM_PER_MILE = 1.60934f;
            retunr miles * KM_PER_MILE; // retunrs a float
        }

        // Convert miles to km and show the result
        static void (float miles, float km) {
            Console.WriteLine(miles + " miles = " + km + " km.");
        }
    }
}
```

**Methods Overloads**

Methods overloading allows to create methods with identical names as long as each method has a unique arrangement of parameter types. Overloading can make your code more reader friendly when these methods perform similar routine.

```
using System;

namespace ConsoleApplication1 {
    class Program {
        static void Main() {
            // call overload with no fax
            DisplayContact("Banana Republic Women", "735 State St", "Santa Barbara", "CA", "93101");
            Console.WriteLine();

            // call overlaod with fax
            DisplayContact("Legal Aid Society", "1233 W 6th St", "Cleveland", "OH", "44113", "216-586-3220");
            Console.ReadLine();
        }

        // overload with no fax
        static void DisplayContact(string orgName, string street, string city, string state, string zip) {
            Console.WriteLine(orgName);
            Console.WriteLine(street);
            Console.WriteLine(city + ", " + state);
            Console.WriteLine(zip);
        }

        // overload with fax
        static void DisplayContact(string orgName, string street, string city, string state, string zip, string fax) {
            // use DisplayContact() overload with no fax
            DisplayContact(orgName, street, city, state, zip);
            Console.WriteLine("fax: " + fax); // show fax
        }
    }
}
```

**Passing arguments by value and by reference**

>Arguments can be passed to methods in two ways: by value ot by reference

**Passing by value**

When the parameter is passed to a method by value, a copy of the variable is made and any changes to the argument in the method have no effect on the original value in the calling instructions.

**Passing by reference**

When passing arguments by reference to a method, starting address for the data value is given to the method. Any changes made inside the method to the values referenced by this object are also applied to the object's values outsode the method. Variables with complex data types such as arrays or instances of a class are passed by reference.

```
using System;

namespace ConsoleApplication1 {
    class Program {

        const int FIRST_PRICE = 0;

        static void Main() {
            decimal[] prices = {9.99m};
            ShowPrices(prices);
            AddTax(prices[FIRST_PRICE]); // pass by value
            ShowPrices(prices); // pass by reference
            Inflate(prices); // pass by reference
            ShowPrices(prices); // pass by reference

            Console.ReadLine();
        }

        // receives argument by reference
        static void ShowPrices(decimal[] price) {
            Console.WriteLine("Value in calling method: " + price[FIRST_PRICE].ToString("C"));
        }

        // receives argument by value
        static void AddTax(decimal price) {
            const decimal TAX_RATE = 1.07m;
            price *= TAX_RATE;
            Console.WriteLine("After tax: " + price.ToString("C"));
        }

        // receives argument by reference
        static void ShowPrices(decimal[] price) {
            const decimal INFLATION_RATE = 1.01m;
            prices[FIRST_PRICE] *= INFLATION_RATE;
            Console.WriteLine("After inflation: " + price[FIRST_PRICE].ToString("C"));
        }
    }
}
```

**Passing arguments explicitly by reference**

A `ref` keyword is required before each argument that is explicitly passed by reference

```
using System;

namespace ConsoleApplication1 {
    class Program {
        static void Main() {
            float house = 200000.0f;
            float salary = 75000.0f;
            
            // explicitly pass variables by reference
            AdjustForInflation(ref house, ref salary);
            Console.WriteLine("**Values After Inflation Adjustment**");
            Console.WriteLine("Home: " + house);
            Console.WriteLine("Income: " + salary);
            Console.ReadLine();
        }

        // receive arguments explicitly by reference
        static void AdjustForInflation(ref float home, ref float income) {
            const float RATE = 1.03f;
            home *= RATE;
            income *= RATE;
        }
    }
}
```

**Passing uninitialized variable by reference**

When `out` keyword is included in a parameter declaration, an uninitialized variable can be passed to the method by reference

```
using System;

namespace ConsoleApplication1 {
    class Program {
        static void Main() {
            const double TOTAL_YEARS = 5;
            double accrualRate;
            
            // pass uninitialized rate explicitly by reference
            GetAccrualRate(out accrualRate, TOTAL_YEARS);
            Console.WriteLine("Accrual rate: " + accrualRate);
            Console.ReadLine();
        }

        // receive uninitialized interest rate explicitly by reference
        static void GetAccrualRate(out double interest, double years) {
            const double INTEREST_RATE = 1.05;
            interest = Math.Pow(INTEREST_RATE, years);
        }
    }
}
```

**Scope** - describes the region of the code where the variable can be accessed

**Class Scope** - defines the accessibility for variables and objects declared at the class level. Class-level declarations are convenient if several methods within the class must reference the item. However, class-level scope is more error prone than localized scope since class-level items can be modified anywhere in the class for as long as the class instance exists

**Method Scope** - variables and objects that are declared inside a method are accessible for edits and reads only within the method. Method-level items exist from the point they are declared in the method to the time the method exits.

**Block Scope** - even more refined level of scope than method scope. refers to the accessibility of a variable or object that is declared inside a conditional structure or loop

**Variable Precedence**

>Local variable always take precedence. As a result, whenever you reference a variable name that exists both locally and the class level, the locally declared variable is used.

Chapter 5: Conditional Structures and Loops
--------------------------------------------

Operator | Operation
--------- | --------
equals | ==
not equals | !=
less than | <
greater than | >
less than or equal | <=
greater than or equal | >=
logical AND | &&
logical OR | ||

**Conditional Structures**

**If-else** - a series of conditional expressions that are grouped together

`if` - contains the first conditional expression within the if-else statement

`else if` - optional and must follow the opening `if` statement

`else` - default selsction when no previous condition in the `if-else` series is true

**Ternary operators** - conditional operators that can be used to return different values based on the outcome of a simple conditional expression

**Switches** - conditional structure that provides a selection of `case` values to determine which code block to execute

**Loops**

* `for` loops - starts with a header which contains three instructions (initial value for a counter, conditional expression that is evaluated for every iteration, modifies the counter variable)

* `while` loops - repreats instructions in its block as long as specific condition is true

* `do while` loops - similar to `while` loops, however the `do while` loop is always executed at least once, because the conditional expression is evaluated at the end

* `foreach` loop - allows to iterate through a collection of a similarly typed objects (a declaration within the header creates a temporary variable to store an item from the collection, the temporary variable is followed by the keyword `in` and the collection reference)

`break` statements - force the program to exit the current loop when they are encountered

`continue` statemtent - allows you to bypass all remaining instructions in a loop block to return to the top of the loop
