# Eng104_Week2

## Errors

##### Logic error



##### Syntax error



##### Other error types 

For example:

```c#
var text = File.ReadAllText("HelloWorld.txt");
```

This line is perfectly fine by it's self and logically & syntax wise is correct, however is missing the file directory.

To catch the error and return a meaning full message try:

``` C#
        string text;
        string fileName = "HelloWorld.txt";

		try
        {
            text = File.ReadAllText(fileName);
            Console.WriteLine(text);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Sorry I can't find " + fileName);
        }
```

Using

``` c# 
        finally
        {
            Console.WriteLine("I'm always running whatvever happnes ");
        }
```

Will run regardless if error is caught or program run as intended, it is important to run a meaningful message like: File x has been read.

there are different type of exception if we run the first code block with string an empty `fileName` we get a `FileNotFoundException` error.



###### Exception types

Exception types The C# library exceptions are all subclasses of  SystemException, which is a subclass of Exception

> `SystemException `
>
> > `Arithmetic Exception`
> >
> >  `DivideBy ZeroException`
> >
> >  `OverflowException`

> `ArgumentException` 
>
> >`ArgumentNullException`
> >
> > `ArgumentoutofRangeException` 
> >
> >`ArrayTypeMismatchException`

> `InvalidCastException` 
>
>`IndexOutofRangeException`
>
> `Null reference exception`
>
> `OutOfMemoryException` 
>
>See the msdn C# Exceptions page for descriptions  and more examples

