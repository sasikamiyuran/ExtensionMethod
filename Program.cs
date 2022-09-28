using Implementation;

string test = "HelloWorld";
string leftMost = test.Substring(0, 5);

//this 'RightSubstring' is the extension method
string rightMost = test.RightSubstring(5);

Console.WriteLine(leftMost + ' ' + rightMost);
