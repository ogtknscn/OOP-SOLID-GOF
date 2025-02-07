using Solutions.GOF.Behavioral.Memento;

/*Memento*/
//Intent: Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later.

/*var editor = new Editor();
var history = new History(editor);
history.BackUp();
editor.Title = "Test";
history.BackUp();
editor.Content = "Test Content";
history.BackUp();
editor.Title = "Test 2";

System.Console.WriteLine($"Current Title: {editor.Title}");
System.Console.WriteLine($"Current Content: {editor.Content}");

history.Undo();

System.Console.WriteLine($"Current Title: {editor.Title}");
System.Console.WriteLine($"Current Content: {editor.Content}");

history.ShowHistory();

history.Undo();

System.Console.WriteLine($"Current Title: {editor.Title}");
System.Console.WriteLine($"Current Content: {editor.Content}");

history.Undo();

System.Console.WriteLine($"Current Title: {editor.Title}");
System.Console.WriteLine($"Current Content: {editor.Content}");*/