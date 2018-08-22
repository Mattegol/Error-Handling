# Error-Handling
Error Handling in C# with Exceptions

An exception is any error condition or unexpected behavior that is encountered by an executing program.

## Why Handle Errors?
Prevent the entire program from crashing.

Prevent unhappy users.

A chance to fix and retry.

Meaningful messages and graceful exit.

Opportunity to log errors.

Good error handling code helps future maintainers understand what possible error conditions may occur and how they can be handled.

## Why Exceptions
Don't need to know all error/success codes.

Don't need if/switch statements everywhere a method is called.

More readable, less clutter.

No magic numbers/constants.

Exceptions can bubble up.

Catch exceptions higher up/in one place.

Handle system errors.

Generate exceptions from constructors.

## What is an Exception
Object instances.

Inherits from System.Exception which is the base calss for all types of exceptions.

Generated with the throw statement.

Different exception classes represent different errors.

Can have additional error information.

Different exceptions can be handled differently.




