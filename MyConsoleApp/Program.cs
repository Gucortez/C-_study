// using MyConsoleApp.Math;
// using MyConsoleApp.People;
// using MyConsoleApp.Classes;
// using MyConsoleApp.ConditionalStatements;
// using MyConsoleApp.IterationStatements;
// using MyConsoleApp.Time;
// using MyConsoleApp.Strings;


// var john = new Person();
//             john.FirstName = "John";
//             john.LastName = "Smith";
//             john.Introduce();

// var result = Calculator.Add(1, 2);
// Console.WriteLine(result);

// // declaring arrays
// // int[] numbers = new int[3] {1, 2, 3};
// // values in {}
// string name = "Mosh";
// char firstChar = name[0];
// Console.WriteLine(firstChar);

// var stringsLesson = StringTest.Names();
// Console.WriteLine(stringsLesson);

// // instead of using multiple const you can use enum
// /* 
// const int RegularAirMail = 1,
// const int RegisteredAirMail = 2,
// const int Express = 3;
// public enum Shipping method
// {
//     RegularAirMail = 1,
//     RegisteredAirMail = 2,
//     Express = 3;
// }
// */
// var methodId = 3;
// Console.WriteLine((EnumTest.ShippingMethod)methodId); // output = Express

// var method = EnumTest.ShippingMethod.Express; // call the enum that you want
// Console.WriteLine((int)method);

// Console.WriteLine(method.ToString()); // convert enum to string, output = Express

// var methodName = "Express";
// var shippingMethod = (EnumTest.ShippingMethod)Enum.Parse(typeof(EnumTest.ShippingMethod),methodName); // string to enum, parse and cast
// Console.WriteLine(shippingMethod);

// var classText = ClassTests.ClassText();
// Console.WriteLine(classText);

// var numb = 1;
// Person.Increment(numb);
// Console.WriteLine(numb); // the method takes a copy of the numb, making the original numb unchanged, because only the copy was altered. output = 1

// var person = new Person() {Age = 20};
// Person.MakeOld(person);
// Console.WriteLine(person.Age); // method takes the reference to the same memory location, so the object is altered. output = 30

// /* 
// Summary:
// Value Types: Changes are made on a copy, so the original value remains unchanged (e.g., int, bool, char, struct).
// Reference Types: Changes are made on the original object since the method operates on a reference to the same object (e.g., class, array, delegate).*/

// IfElseLesson.IfElse(1);
// IfElseLesson.Customer(true);

// Switch.switchSeasons((Season)2);

// Exercise.NumberValidation();
// int maxNumber = Exercise.MaxNumber();
// Console.WriteLine(maxNumber);
// Exercise.LandscapeOrPortrait();
// Exercise.SpeedTest();

// ForLoops.ForLoopsTests(1);
// ForeachLoops.ForeachLoopsTests("Jonh Smith");
// ForeachLoops.ForeachLoopsArray([1,2,3,4,5,6,7,8]);

// WhileLoops.EcoProgram();
// RandomClass.RandomTests();
// InterationExercises.CountNumbers();
// InterationExercises.NumberFactorial();
// InterationExercises.OkExercise();
// InterationExercises.SeriesOfNumbers();
// InterationExercises.RandomNumber();
// ArrayTest.Arrays();
// ListsTests.Lists();
// ArrayListsExercises.Exercise5();
// DateTimeTests.DateTimeMethods();
// TimeSpanTests.TimeSpanMethods();
// StringsTests.Strings();
// Exercises.LiveCoding();
// StringBuilderTests.StringBuilder();
// Exercises.Exercise1();