public class Line
{
    Point begin;
    Point end;
    public Line(int x1, int y1, int x2, int y2)
    {
    
    }
    public Line(Point begin, Point end)
    {
        this.begin=begin;
        this.end=end;
    }
    public Point GetBegin()=> this.begin;
    public void SetBegin(Point begin)=> this.begin=begin;
    public Point GetEnd()=> this.end;
    public void SetEnd(Point end)=> this.end=end;
    public int GetBeginX()=> begin.GetX();
    public void SetBeginX(int x)=> begin.SetX(x);
    public int GetBeginY()=> begin.GetY();
    public void SetBeginY(int y)=> begin.SetY(y);
    public int[] GetBeginXY()
    {
        int[] arr= new int[]{begin.GetX(), begin.GetY()};
        return arr;
    }
    public int GetEndX()=> end.GetX();
    public void SetEndX(int x)=> end.SetX(x);
    public int GetEndY()=> end.GetY();
    public void SetEndY(int y)=> end.SetY(y);
    public int[] GetEndXY()
    {
        int[] arr=new int[]{end.GetX(), end.GetY()};
        return arr;
    }
    public void SetEndXY(int x, int y)
    {
        end.SetX(x);
        end.SetY(y);
    }
    public string Tostring()=> $"Line [begin=({begin.GetX()}, {begin.GetY()}), end=({end.GetX()}, {end.GetY()})]";
    
}