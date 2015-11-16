import com.sun.org.apache.xerces.internal.impl.xpath.regex.Match;
import jdk.nashorn.internal.ir.IfNode;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 12/11/2015.
 */
public class BiggestTableRow {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        List<Double> sumTest = new ArrayList<>();
        List<String[]> numbers = new ArrayList<>();
        numbers.add(new String[]{"0"});

        String input = sc.nextLine();
        while (!input.equals("</table>")) {
            double sum = 0;
            StringBuilder sb = new StringBuilder();
            Pattern patNum = Pattern.compile(">([-]*[.\\d]+)<");
            Matcher matcher = patNum.matcher(input);

            while (matcher.find()) {
                sum += Double.parseDouble(matcher.group(1));
                sumTest.add(sum);
                sb.append(matcher.group(1));
                sb.append(" ");
            }

            numbers.add(sb.toString().trim().split(" "));
            input = sc.nextLine();
        }
        if (sumTest.isEmpty()) {
            System.out.println("no data\n");
        } else {
            Collections.sort(sumTest);
            double sumMax = sumTest.get(sumTest.size() - 1);

            for (int i = 0; i < numbers.size(); ) {
                boolean test = false;
                double sum = 0;
                for (int j = 0; j < numbers.get(i).length; j++) {
                    if (!numbers.get(i)[j].equals("")) {
                        test = true;
                        sum += Double.parseDouble(numbers.get(i)[j]);
                    } else {
                        break;
                    }
                }
                if (sum != sumMax) {
                    numbers.remove(i);
                    test = false;
                }
                if (test) {
                    i++;
                }
            }


            StringBuilder sb = new StringBuilder();
            if (sumMax > (int) sumMax) {
                sb.append(sumMax);
            } else {
                int sumInt = (int) sumMax;
                sb.append(sumInt);
            }

            sb.append(" = ");
            for (int i = 0; i < numbers.get(0).length; i++) {
                if (i < numbers.get(0).length - 1) {
                    sb.append(numbers.get(0)[i]);
                    sb.append(" + ");
                } else {
                    sb.append(numbers.get(0)[i]);
                }
            }
            System.out.println(sb.toString());
        }
    }
}