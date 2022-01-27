**Interfaces** allow for code to be more maintainable, easier to extend (rather than break), and easier to test.

<br/><br/><br/>

By definition, an **`interface`** contains definitions for a group of related functionalities that a non-abstract `class` or `struct` must implement.

Think of an `interface` as a contract in which any class that "agrees" to the contract affirms that they have the **functions** listed in the contract and these **functions** may include **properties, methods, events,** and/or **indexers**.


<br/><br/><br/>

Interfaces can be a good way to allow your application to receive data from multiple sources. These sources include:

1. **Web Service** that gives data formatted in `JSON`.
2. **CSV Text Files** that give data in comma-separated values.
3. **SQL** or **NoSQL** database.
4. **Cloud Services** such as `AWS`.
5. **Azure Functions**

Interfaces can be formatted in the **REPOSITORY PATTERN** which *mediates between the domain and data mapping layers using a collection-like interface for accessing domain objects.* This helps separate our C# application from the data storage technology, our #C application doesn't need to know how to open a file on the file system or make HTTP calls.

<br/>

You can program a **service repository** which will know how to make HTTP calls to a **web service**, a **CSV repository**, or a **SQL repository**. Essentially, the interface will hold the methods that interact with our data from one (or more) of these data sources.

<br/>

**Important Note:** If our client code contains only *read* methods in line with the **CRUD** [C.reate, R.ead, U.pdate, D.elete] operations scheme, then our interface should only contain methods used by the client.

<br/><br/><br/>

A common method used with handling data is a **factory method** known as a **Data Reader Factory**. A factory method is responsible for getting us an instance of an object. The factory in this case will get us an object that implements an interface, an example:

```
public IPersonReader GetReader(string readerType)
{
	switch(readerType)
	{
		case "Service": return new ServiceReader();
		case "CSV": return new CSVReader();
		case "SQL": return new SQLReader();
		default: throw new ArgumentException();
	};
}
```