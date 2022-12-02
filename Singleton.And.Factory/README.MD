# Singleton design pattern

## Concept

The singleton pattern is one of the simplest design patterns. Sometimes we need to have only one instance of our class for example 
a single DB connection shared by multiple objects as creating a separate DB connection for every object may be costly. Similarly, there can be a 
single configuration manager or error manager in an application that handles all problems instead of creating multiple managers.

## Definition

The singleton pattern is a design pattern that restricts the instantiation of a class to one object. 
Let’s see various design options for implementing such a class. If you have a good handle on static class variables and access modifiers this 
should not be a difficult task.

# Factory design pattern

## Concept

This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.
In Factory pattern, we create object without exposing the creation logic to the client and refer to newly created object using a common interface.