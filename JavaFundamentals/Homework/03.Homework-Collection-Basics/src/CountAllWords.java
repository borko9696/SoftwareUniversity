import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 22/10/2015.
 */
public class CountAllWords {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        String line=Console.nextLine();

        Pattern pattern= Pattern.compile("\\w+");
        Matcher matcher=pattern.matcher(line);

        int count=0;
        while (matcher.find()){
            count++;
        }
        System.out.println(count);
    }
}
