using System;

public static class Identifier
{
     public static string Clean(string identifier)
    {
        bool isNextUpper = false;
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < identifier.Length; i++) {
            char c = identifier[i];
            if(char.IsControl(c)) {
                sb.Append("CTRL");
            } else if(char.IsWhiteSpace(c)) {
                sb.Append('_');
            } else if(c == '-') {
                isNextUpper = true;
            } else if(c >= 'α' && c <= 'ω') {
                continue;
            } else if(char.IsLetter(c)) { 
                sb.Append(isNextUpper ? char.ToUpper(c) : c);
                isNextUpper = false;
            }
        }
        return sb.ToString();
    }
}
