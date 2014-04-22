//Intro to C# scripting in Grasshopper Lesson:03
//http://designalyze.com/GH_Scripting_Intro_Part_03

//Define a new List called numbers of type int
List<int> numbers = new List<int>();
 
// for (initialization-clause; condition-clause; iteration-clause) { statement-block; }
for (int i = 0; i < 10; i++) {
numbers.Add(i);
} 
 
A = numbers;
