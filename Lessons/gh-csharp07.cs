//Intro to C# scripting in Grasshopper Lesson:07
//http://www.designalyze.com/GH_Scripting_Intro_Part_07

List<Point3d> pts = new List<Point3d>();
 
if (x == null) {
    x = new Point3d(0,0,0);
}
 
double spacingX = xSize / numDivsX;
double spacingY = ySize / numDivsY;
 
Point3d tempPt = x;
 
for (int i = 0; i < numDivsX; i++) {
    tempPt.X = x.X + (spacingX * i);
 
    for (int j = 0; j < numDivsY; j++) {
        tempPt.Y = x.Y + (spacingY * j);
        pts.Add(tempPt);
    }
}
 
A = pts;
