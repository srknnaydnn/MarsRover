
string s1 = "5 5";
string s2 = "1 2 N";
string s3 = "LMLMLMLMM";
string s4 = "3 3 E";
string s5 = "MMRMMRMRRM";


string [] str=s2.Split(" ");
int x =int.Parse(str[0]);
int y =int.Parse(str[1]);
string direction=str[2];

string[] str1 = s4.Split(" ");
int x1 = int.Parse(str1[0]);
int y1 = int.Parse(str1[1]);
string direction1 = str1[2];

Rover rover = new Rover(x, y, direction);
rover.MoveToRover(s3);

Rover rover1 = new Rover(x1, y1, direction1);
rover1.MoveToRover(s5);

Console.WriteLine($"{rover._x} {rover._y} {rover._direction}");

Console.WriteLine($"{rover1._x} {rover1._y} {rover1._direction}");


class Rover
{

    public int _x { get; set; }
    public int _y { get; set; }
    public string _direction { get; set; }

    public Rover(int x,int y,string direction)
    {
        _x = x;
        _y = y;
        _direction = direction;
    }

    public void TurnLeft()
    {

        switch (_direction)
        {
            case "N":
                _direction = "W";
                break;
            case "W":
                _direction = "S";
                break;
            case "S":
                _direction = "E";
                break;
            case "E":
                _direction = "N";
                break;
            default:
                break;
        }
    }
    public void TurnRight()
    {

        switch (_direction)
        {
            case "N":
                _direction = "E";
                break;
            case "E":
                _direction = "S";
                break;
            case "S":
                _direction = "W";
                break;
            case "W":
                _direction = "N";
                break;
            default:
                break;
        }
    }
    public void Move()
    {
        switch (_direction)
        {
            case "N":
                _y=_y+1;
                break;
            case "E":
                _x = _x + 1;
                break;
            case "S":
                _y = _y - 1;
                break;
            case "W":
                _x = _x - 1;
                break;
            default:
                break;
        }
    }
    public void MoveToRover(string message)
    {
        char[] messages = message.ToCharArray();
        for (int i = 0; i < messages.Length; i++)
        {
            switch (messages[i])
            {
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
                case 'M':
                    Move();
                    break;
                default:
                    break;
            }
        }
    }
}