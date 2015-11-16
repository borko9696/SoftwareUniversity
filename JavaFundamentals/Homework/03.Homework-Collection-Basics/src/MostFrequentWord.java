import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

/**
 * Created by Borislav on 27/10/2015.
 */

public class MostFrequentWord {
    public static void main(String[] args) {
        Scanner Console = new Scanner(System.in);
        String[] line = Console.nextLine().toLowerCase().split("\\W+");
        List<String> word = new ArrayList<>();
        List<Integer> count = new ArrayList<>();

        for (int i = 0; i < line.length; i++) {
            int counter = 1;
            for (int j = i + 1; j < line.length; j++) {
                if (line[i].contains(line[j])) {
                    counter++;
                }
            }
            word.add(line[i]);
            count.add(counter);
        }
        List<String> wordResult = new ArrayList<>();
        List<Integer> countResult = new ArrayList<>();

        int curent = count.get(0);

        for (int i = 1; i < count.size(); i++) {
            if (curent < count.get(i)) {
                curent   = count.get(i);
            }
        }

        for (int i = 0; i < count.size(); i++) {
            if (curent == count.get(i)) {
                wordResult.add(word.get(i));
                countResult.add(count.get(i));
            }
        }

        Collections.sort(wordResult);

        for (int i = 0; i < wordResult.size(); i++) {
            System.out.println(wordResult.get(i) + " -> " + countResult.get(i) + " times");
        }
    }
}
