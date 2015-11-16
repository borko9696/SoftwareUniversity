import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 06/11/2015.
 */
public class LittleJhon {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 4; i++) {
            String input = sc.nextLine();
            sb.append(input);
            sb.append(" ");
        }
        int countSmall = 0;
        int countMed = 0;
        int countLarge = 0;

        Pattern pat = Pattern.compile(">----->|>>----->|>>>----->>");
        Matcher match = pat.matcher(sb.toString());

        while (match.find()) {
            String arrow = match.group();
            if (arrow.equals(">----->")){
                countSmall++;
            } else if (arrow.equals(">>----->")) {
                countMed++;
            }else if (arrow.equals(">>>----->>")) {
                countLarge++;
            }
        }
       String num = new StringBuilder().append(countSmall).append(countMed).append(countLarge).toString();
        Integer numdec = Integer.parseInt(num);
        String binary = Integer.toBinaryString(numdec);
        String reversed = new StringBuilder().append(binary).reverse().toString();
        String readybin = new StringBuilder().append(binary).append(reversed).toString();
        int result = Integer.parseInt(readybin,2);
        System.out.println(result);

    }
}
