//Intro to C# scripting in Grasshopper Lesson:06
//http://www.designalyze.com/GH_Scripting_Intro_Part_06


List<int> numbers = new List<int>();
 
int i = 0;
while (i < count) {
    numbers.Add((i*step) + start);
    i++;
}
A = numbers;
