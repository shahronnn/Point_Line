public class Point
{
    int x=0;
    int y=0;
    public Point(){}
    public Point(int x, int y)
    {
        this.x=x;
        this.y=y;
    }
    public int GetX()=> x;
    public void SetX(int x)=> this.x=x;
    public int GetY()=> y;
    public void SetY(int y)=> this.y=y;
    public string Tostring => $"({x},{y})";
    public int[] GetXY()
    {
        int[] arr=new int[]{x,y};
        return arr;
    }
    public void SetXY(int x, int y)
    {
        this.x=x;
        this.y=y;
    }
    public double Distance(int x, int y)=> x-y;
    
}