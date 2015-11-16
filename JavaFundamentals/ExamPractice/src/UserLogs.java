import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Borislav on 03/11/2015.
 */
public class UserLogs {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        Pattern pat = Pattern.compile("IP=([\\w.:]+)\\s+message='.*'\\s+user=(\\w+)");

        TreeMap<String , LinkedHashMap<String,Integer>> userLogs = new TreeMap<>();

        String line = Console.nextLine();
        while (!line.equals("end")){
            Matcher match = pat.matcher(line);
            if (match.find()) {
                String ip = match.group(1);
                String user = match.group(2);
                if (!userLogs.containsKey(user)){
                    userLogs.put(user,new LinkedHashMap<>());
                }
                if (!userLogs.get(user).containsKey(ip)){
                    userLogs.get(user).put(ip,0);
                }
                int counter = userLogs.get(user).get(ip);
                userLogs.get(user).put(ip,counter+1);
            }

            line = Console.nextLine();
        }
        for (Map.Entry<String, LinkedHashMap<String, Integer>> userInfo : userLogs.entrySet()) {
            System.out.println(userInfo.getKey() + ":");
            StringBuilder sb = new StringBuilder();
            for (Map.Entry<String, Integer> inerPair : userInfo.getValue().entrySet()) {
                sb.append(inerPair.getKey());
                sb.append(" => ");
                sb.append(inerPair.getValue());
                sb.append(", ");
            }
            String output= sb.toString();
            output=output.substring(0,output.length()-2);
            System.out.println(output+ ".");
        }
    }
}
