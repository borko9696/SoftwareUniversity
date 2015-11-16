import sun.reflect.generics.tree.Tree;

import java.util.*;

/**
 * Created by Borislav on 13/11/2015.
 */
public class Weightlifting {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        TreeMap<String, TreeMap<String,Long>> map = new TreeMap<>();

        int n = Integer.parseInt(sc.nextLine());
        for (int i = 0; i < n; i++) {
            String[] input = sc.nextLine().split(" ");
            String player = input[0];
            String exercise = input[1];
            long kg = Long.parseLong(input[2]);

            if (!map.containsKey(player)) {
                map.put(player, new TreeMap<>());
            }
            if (!map.get(player).containsKey(exercise)){
                map.get(player).put(exercise, 0L);
            }
            long sum = map.get(player).get(exercise)+kg;
            map.get(player).put(exercise,sum);

        }

        //StringBuilder sb = new StringBuilder();
        List<String> output = new ArrayList<>();
        map.entrySet()
                .stream()
                .forEach(entry -> {
                    StringBuilder sb = new StringBuilder();
                    sb.append(entry.getKey());
                    sb.append(" : ");
                    //System.out.printf("%s :", entry.getKey());

                    entry.getValue()
                            .entrySet()
                            .stream()
                            .forEach(a ->
                                            sb.append(a.getKey() + " - " + a.getValue() + " kg, ")
                                    //System.out.printf(" %s - %d kg", a.getKey(), a.getValue())
                            );
                    output.add(sb.toString());
                    //System.out.println();
                });
        for (int i = 0; i < output.size(); i++) {
            String result = output.get(i).substring(0,output.get(i).length()-2);
            System.out.println(result);
        }
    }
}
