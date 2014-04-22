//Intro to C# scripting in Grasshopper Lesson:10
//http://www.designalyze.com/GH_Scripting_Intro_Part_10

//Example 1
//Create an empty list of lines
List<Line> lines = new List<Line>();
    //Initialize a new instance of the Random class called random
    Random random = new Random();
    //start a loop
    for(int i = start; i <= end; i = i+2){
        //Create a new integer called randint from the Next method of the random class        
        int randint = random.Next(0, 100);
        //Create a line from 6 input values in the form of (x1, y1, z1, x2, y2, z2)
        Line ln = new Line(i, 10, 0, randint, 50, 0);
        //Add our new line to the list of lines
        lines.Add(ln);
    }
A = lines;

///////////////////////////////////////////////////

//Example 2
//Create empty points, planes, and rectangle lists
List<Point3d> pts = new List<Point3d>();
List<Plane> plns = new List<Plane>();
List<Rectangle3d> rects = new List<Rectangle3d>();
 
//Initialize a new instance of the Random class called random
Random random = new Random();
//Create a new unitZ vector
Vector3d unitZ = new Vector3d(0,0,1);
 
//Start a loop
for(int i = start; i <= end; i = i + 2) {
    //Create random values
    int randint = random.Next(0,100);
    int randint2 = random.Next(0,10);
    int randint3 = random.Next(0,5);
 
    //Create new points, planes, and rectangles based on these random values
    Point3d pt = new Point3d(i, randint, randint2);
    Plane pln = new Plane(pt, unitZ);
    Rectangle3d rect = new Rectangle3d(pln, randint3, randint3);
 
    //Add all of these to the appropriate lists (Actually, since we are only using the rects you don't need the others FYI) 
    pts.Add(pt);
    plns.Add(pln);
    rects.Add(rect);
}
 
A = rects;
