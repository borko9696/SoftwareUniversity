import com.sun.org.apache.xerces.internal.impl.xpath.regex.Match;
import javafx.collections.transformation.SortedList;


import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 04/11/2015.
 */
public class ShmoogleCounter {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);

        List<String> doubleVar = new ArrayList<>();
        List<String> intVar = new ArrayList<>();

        Pattern pat = Pattern.compile("(double|int)\\s([a-z][a-zA-Z]*)");
        String line = Console.nextLine();

        while (!line.equals("//END_OF_CODE")) {
            Matcher match = pat.matcher(line);
            while (match.find()) {
                if (match.group(1).equals("double")){
                    String doubleD = match.group(2);
                    doubleVar.add(doubleD);
                }else{
                    String intI = match.group(2);
                    intVar.add(intI);
                }
            }

            line = Console.nextLine();
        }
        Collections.sort(doubleVar);
        Collections.sort(intVar);

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < doubleVar.size() ; i++) {
            if (i<doubleVar.size()-1) {
                sb.append(doubleVar.get(i));
                sb.append(", ");
            }else{
                sb.append(doubleVar.get(i));
            }
        }
        String doubleResult = sb.toString();

        StringBuilder sb1 = new StringBuilder();
        for (int i = 0; i < intVar.size() ; i++) {
            if (i<intVar.size()-1) {
                sb1.append(intVar.get(i));
                sb1.append(", ");
            }else{
                sb1.append(intVar.get(i));
            }
        }
        String intResult = sb1.toString();

        if (doubleResult.isEmpty()  && intVar.isEmpty()){
            System.out.println("Doubles: None");
            System.out.println("Ints: None");
        }else if (intVar.isEmpty()) {
            System.out.println("Doubles: " + doubleResult);
            System.out.println("Ints: None");
        }else if (doubleVar.isEmpty()) {
            System.out.println("Doubles: None");
            System.out.println("Ints: " + intResult);
        }else{
            System.out.println("Doubles: " + doubleResult);
            System.out.println("Ints: " + intResult);
        }

    }
}
