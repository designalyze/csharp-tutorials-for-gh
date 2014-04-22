//Intro to C# scripting in Grasshopper Lesson:09
//http://www.designalyze.com/GH_Scripting_Intro_Part_09

Point3d pt = new Point3d();
pt = x.PointAtNormalizedLength(t);
 
A = pt;

///////////////////////////////////////////////////

List<Point3d> pts = new List<Point3d>();
Point3d pt = new Point3d();
 
double spacing = 1.0 / numDivs;
double t;
 
for (int i = 0; i <= numDivs; i++) {
    t = i * spacing;
    pt = x.PointAtNormalizedLength(t);
    pts.Add(pt);
}
 
A = pts;
