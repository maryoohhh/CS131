# CS131: C#

## Chapter 1: Introduction to C# Coding and Debugging
_____________________________________________________

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

## Chapter 2: Variables, Constants, Arrays, and Enumerations
____________________________________________________________

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

![Figure 2-1 Common Data Types](https://github.com/maryoohhh/CS131/blob/master/Figure2-1.png)
Figure 2-1 Common Data Types

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

