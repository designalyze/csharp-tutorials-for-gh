//Intro to C# scripting in Grasshopper Lesson:08
//http://www.designalyze.com/GH_Scripting_Intro_Part_08

if (x == true) {
    A = "It's True!";
} else {
    A = "It's False";
}

///////////////////////////////////////////////////

List<Point3d> pts = new List<Point3d>();
 
for (int i = 0; i < 100; i++) {
    if (i%3 == 0 || i %5 == 0) {
        Point3d ptTemp = new Point3d(i, 0, 0);
        pts.Add(ptTemp);
    }
}
A = pts;
