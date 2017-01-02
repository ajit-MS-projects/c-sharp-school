# Functional constructs in C# and higher order functions in C#

## Action - side effect function with void return type and 1..16 inputs
## Predicate - bool return type
## Func - 1..16 inputs and T return type
## Tuple - 1..7, TRest where trest is again tzpe of tuple to create nested tuples
### A tuple is just list of comma seperated values.
### use cases
1. To represent a single set of data. For example, a tuple can represent a database record, and its components can represent individual fields of the record.
2. To return multiple values from a method without using out parameters (in C#) or ByRef parameters (in Visual Basic).
3. To pass multiple values to a method through a single parameter. For example, the Thread.Start(Object) method has a single parameter that lets you supply one value to the method that the thread executes at startup time. If you supply a Tuple<T1, T2, T3> object as the  method argument, you can supply the thread’s startup routine with three items of data.
