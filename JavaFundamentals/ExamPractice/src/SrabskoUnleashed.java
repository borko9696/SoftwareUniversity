import com.sun.org.apache.xerces.internal.impl.xpath.regex.Match;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 04/11/2015.
 */
public class SrabskoUnleashed {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        LinkedHashMap<String,LinkedHashMap<String,Integer>> map = new LinkedHashMap<>();
        String input = Console.nextLine();

        Pattern pat = Pattern.compile("([\\D]+)\\s@([\\D]+)\\s([\\d]+)\\s([\\d]+)");

        while (!input.equals("End")){
            Matcher match = pat.matcher(input);
            if (match.find()) {
                String singer = match.group(1);
                String place = match.group(2);
                int money =Integer.parseInt(match.group(3)) * Integer.parseInt(match.group(4));

                if (!map.containsKey(place)){
                    map.put(place, new LinkedHashMap<>());
                }
                if  (!map.get(place).containsKey(singer)){
                    map.get(place).put(singer,0);
                }
                int sum = map.get(place).get(singer);
                map.get(place).put(singer, sum + money);
            }
            input = Console.nextLine();
        }

        for (Map.Entry<String, LinkedHashMap<String, Integer>> pair : map.entrySet()) {
            System.out.println(pair.getKey());

            pair.getValue().entrySet().stream().sorted((a,b) -> b.getValue().compareTo(a.getValue())).forEach(a -> System.out.println("#  " + a.getKey() + " -> " + a.getValue()));

        }
    }
}
