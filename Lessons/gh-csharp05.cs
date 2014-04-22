//Intro to C# scripting in Grasshopper Lesson:05
//http://designalyze.com/GH_Scripting_Intro_Part_05

List<double> xpos = new List<double>();
foreach(Point3d pt in pts) {
    xpos.Add(pt.X);
}
A = xpos;


///////////////////////////////////////////////////

List<Circle> circles = new List<Circle>();
foreach(Point3d pt in pts) {
    Circle tempCircle = new Circle(pt, 1.0);
    circles.Add(tempCircle);
}
A = circles;
