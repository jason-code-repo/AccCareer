namespace AccCareer.DAL.Utilities;

public static class BooleanExtensions
{

    public static bool ToBool(this int x)
    {
        return x switch
        {
            1 => true,
            0 => false,
            _ => throw new InvalidDataException("int must be either 1 or 0 to convert to bool")
        };
    }
    
    public static int ToInt(this bool x)
    {
        return x ? 1 : 0;
    }
    
}