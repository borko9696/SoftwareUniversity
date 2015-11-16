import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class LegendaryFarming {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        boolean breakWhile = false;
        TreeMap<String, Integer> materials = new TreeMap<>();
        materials.put("fragments", 0);
        materials.put("motes", 0);
        materials.put("shards", 0);

        TreeMap<String, Integer> junks = new TreeMap<>();
        String input = Console.nextLine().toLowerCase();
        Pattern pat = Pattern.compile("(\\d+)\\s+([\\w-]+)");
        StringBuilder sb = new StringBuilder();

        while (true) {
            Matcher match = pat.matcher(input);
            while (match.find()) {
                int quantity = Integer.parseInt(match.group(1));
                String mats = match.group(2);

                if (mats.equals("fragments") || mats.equals("motes") || mats.equals("shards")) {
                    materials.put(mats, materials.get(mats) + quantity);
                    if (materials.get(mats) >= 250) {
                        materials.put(mats, materials.get(mats) - 250);
                        sb.append(mats);

                        breakWhile = true;
                        break;
                    }

                } else {
                    if (!junks.containsKey(mats)) {
                        junks.put(mats, quantity);

                    } else {
                        junks.put(mats, junks.get(mats) + quantity);
                    }
                }
            }
            if (breakWhile) {
                break;
            }
            input = Console.nextLine().toLowerCase();
        }

        String sbString = sb.toString();
        if (sbString.equals("motes")) {
            System.out.println("Dragonwrath obtained!");
        } else if (sbString.equals("fragments")) {
            System.out.println("Valanyr obtained!");
        } else {
            System.out.println("Shadowmourne obtained!");
        }

        materials.entrySet()
                .stream()
                .sorted((a, b) -> b.getValue().compareTo(a.getValue()))
                .forEach(e ->
                        System.out.println(e.getKey() + ": " + e.getValue()));
        junks.entrySet()
                .stream()
                .forEach(e ->
                        System.out.println(e.getKey() + ": " + e.getValue()));
    }
}
