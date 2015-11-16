import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 16/11/2015.
 */
public class SoftUniDefenseSystem {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        int sum = 0;
        while (!input.equals("OK KoftiShans")) {
            Pattern pat = Pattern.compile("([A-Z][a-z]+).*?([A-Z][a-z]*[A-Z]).*?(\\d+)L");
            Matcher match = pat.matcher(input);

            while (match.find()) {
                String name = match.group(1);
                String alchohol = match.group(2).toLowerCase();
                int litri = Integer.parseInt(match.group(3));
                sum += litri;
                System.out.printf("%s brought %d liters of %s!\n", name, litri, alchohol);
            }

            input = sc.nextLine();
        }

        String str = String.format("%03d",sum);

        StringBuilder sb = new StringBuilder();
        String result = "";
        if (str.length()<4) {
            sb.append("0");
            for (int i = -1; i < str.length(); i++) {
                if (i==-1){
                    sb.append(".");
                }else{
                    sb.append(str.charAt(i));
                }
                result = sb.toString();
            }
        }else {
            for (int i = 0; i < str.length(); i++) {
                sb.append(str.charAt(i));
            }
            result = sb.toString().substring(0,sb.length()-3 ) + "." + sb.substring(sb.length() - 3, sb.length());
        }
        System.out.println(result + " softuni liters");
    }
}
