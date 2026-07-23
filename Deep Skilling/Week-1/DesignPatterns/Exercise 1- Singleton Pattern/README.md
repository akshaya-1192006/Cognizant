# Exercise 1: Implementing the Singleton Pattern

## Scenario
 
A logging utility is used throughout an application to record important events. Since all log messages should be handled by the same logger, only one instance of the Logger class should exist during the application's execution.

---

## Objective

The objective of this exercise is to implement the **Singleton Design Pattern** by ensuring that only one object of the Logger class is created and shared throughout the application.

---

## About the Concept

The Singleton Pattern is one of the creational design patterns. It is used when only one instance of a class is required. Instead of creating multiple objects, the same object is returned whenever it is requested.

This pattern is commonly used for logging, configuration settings, caching, and database connections.

---

## How the Program Works

- A `Logger` class is created.
- The constructor is declared as `private` to prevent object creation from outside the class.
- A private static instance of the Logger class is created.
- The `GetInstance()` method returns the same Logger object whenever it is called.
- The program verifies that only one Logger object is created.

---

## Advantages

- Ensures only one object exists.
- Saves memory by avoiding unnecessary object creation.
- Provides a single access point to the Logger object.

---

## Output

https://github.com/akshaya-1192006/Cognizant/blob/main/Deep%20Skilling/Week-1/DesignPatterns/Exercise%201-%20Singleton%20Pattern/imge.jpeg?raw=true

---

## What I Learned

- I understood how the Singleton Design Pattern works.
- I learned why the constructor is declared as private.
- I learned how a single object can be shared throughout an application.
