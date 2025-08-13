using System.Text;

namespace PokeDexBackend.Core;

public class Pagination
{
    private const int Unset = -1;
    
    public int NumberOfRecords { get; set; } = Unset;
    public int Offset { get; set; } = Unset;

    public override string ToString()
    {
        var sb = new StringBuilder();
        if (NumberOfRecords is not Unset)
        {
            sb.Append($"limit={NumberOfRecords}");
        }

        if (Offset is not Unset)
        {
            if (sb.Length == 0)
            {
                sb.Append('&');
            }
            
            sb.Append($"offset={Offset}");
        }
        
        var result = sb.ToString();
        if (string.IsNullOrEmpty(result))
        {
            return string.Empty;
        }
        
        return $"?{result}";
    }
}