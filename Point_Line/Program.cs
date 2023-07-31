var point=new Point();
point.SetXY(50, 100);
System.Console.WriteLine(point.GetXY()[0]+" "+point.GetXY()[1]);
int[] arr=point.GetXY();
foreach (var i in arr)
{
    System.Console.Write(i+" ");
}
System.Console.WriteLine();
point.SetXY(200, 300);
int[] arr1=point.GetXY();
foreach (var item in arr1)
{
    System.Console.Write(item+" ");
}