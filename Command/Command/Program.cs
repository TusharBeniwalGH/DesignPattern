using Command;

// Receiver object 
Document doc = new Document();

// command
ICommand openCommand=new OpenCommand(doc);
ICommand saveCommand=new SaveCommand(doc);
ICommand closeCommand=new CloseCommand(doc);

// Invoker instance
MenuOptions options=new MenuOptions(openCommand,saveCommand,closeCommand);

options.ClickOpen();
options.ClickSave();
options.ClickClose();

Console.ReadLine();