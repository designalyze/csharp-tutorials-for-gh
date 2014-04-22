//Intro to C# scripting in Grasshopper Lesson:04
//http://designalyze.com/GH_Scripting_Intro_Part_04

List<Point3d> pts = new List<Point3d>();
for (int i = 0; i < 10; i++) {
Point3d tempPt = new Point3d(i, 0, 0);
pts.Add(tempPt);
}
A = pts;
