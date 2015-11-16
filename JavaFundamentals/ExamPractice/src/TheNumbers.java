import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 10/11/2015.
 */
public class TheNumbers {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        String input = Console.nextLine();

        Pattern pat = Pattern.compile("\\d+");
        Matcher match = pat.matcher(input);
        StringBuilder sb = new StringBuilder();

        while (match.find()){
            int num = Integer.parseInt(match.group());
            String hex = Integer.toHexString(num).toUpperCase();
            sb.append("0x");
            if (hex.length()<4){
                for (int i = 0; i < 4-hex.length(); i++) {
                    sb.append("0");
                }
            }
            sb.append(hex);
            sb.append("-");
        }
        String result = sb.substring(0, sb.length()-1);
        System.out.println(result);
    }
}
