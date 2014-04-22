//Intermediate C# scripting in Grasshopper Lesson:01
//http://www.designalyze.com/intermediate-scripting-01-inch-precision

int wholeNumber = (int) x;
 
double inchPart = Math.Round((x-wholeNumber) * inchPrecision);
if (inchPart == inchPrecision) {
    inchPart = 0;
    wholeNumber = wholeNumber + 1;
}
//The following line is not necessary I just used it as a check
B = wholeNumber + (inchPart / inchPrecision);
 
string answer = String.Format("{0} {1}/{2}", wholeNumber, inchPart, inchPrecision);
 
A = answer;
